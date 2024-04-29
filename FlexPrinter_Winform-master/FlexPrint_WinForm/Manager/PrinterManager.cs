using FlexPrint_Console.DB;
using FlexPrint_Console.Enum;
using FlexPrint_Console.Model;
using FlexPrint_WinForm.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlexPrint_Console.Manager
{
	public class PrinterManager : IPrinterManager
	{
		private LinkedList<LaserPrinter> laserPrintersList = new LinkedList<LaserPrinter>();
		private LinkedList<InkjetPrinter> inkjetPrintersList = new LinkedList<InkjetPrinter>();

		private IConfiguration _configuration;

		public PrinterManager(IConfiguration configuration)
		{
			_configuration = configuration;
			LoadDataFromDatabase();
		}
		public LinkedList<Printer> GetPrinters()
		{
			var printers = new LinkedList<Printer>();
			foreach (var printer in inkjetPrintersList)
			{

				printers.AddLast(printer);
				
			}
			foreach (var printer in laserPrintersList)
			{
				printers.AddLast(printer);
			}

			return printers;
			
		}
		public void LoadDataFromDatabase()
		{
			using (var context = new PrinterDbContext(_configuration))
			{
				laserPrintersList = new LinkedList<LaserPrinter>(context.LaserPrinters.ToList());
				inkjetPrintersList = new LinkedList<InkjetPrinter>(context.InkjetPrinters.ToList());
			}
		}

		public void AddPrinter<T>(T printer) where T : Printer
		{
			try
			{
				using (var context = new PrinterDbContext(_configuration))
				{
					if (printer is LaserPrinter)
					{
						printer.ProductCode = GenerateProductCode();
						laserPrintersList.AddLast((LaserPrinter)(object)printer);
						context.LaserPrinters.Add((LaserPrinter)(object)printer);
					}
					else if (printer is InkjetPrinter)
					{
						printer.ProductCode = GenerateProductCode();
						inkjetPrintersList.AddLast((InkjetPrinter)(object)printer);
						context.InkjetPrinters.Add((InkjetPrinter)(object)printer);
					}
					context.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error with Add Printer: {ex.Message}");
			}
		}

		private string GenerateProductCode()
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			Random random = new Random();
			string productCode;

			do
			{
				productCode = new string(Enumerable.Repeat(chars, 6)
				  .Select(s => s[random.Next(s.Length)]).ToArray());
			} while (laserPrintersList.Any(p => p.ProductCode == productCode) || inkjetPrintersList.Any(p => p.ProductCode == productCode));

			return productCode;
		}

		public void EditPrinter<T>(string productCode, T newPrinterData) where T : Printer
		{
			try
			{
				using (var context = new PrinterDbContext(_configuration))
				{
					
					if (newPrinterData is LaserPrinter)
					{
						var existingLaserPrinter = context.LaserPrinters.FirstOrDefault(p => p.ProductCode == productCode);
						if (existingLaserPrinter != null)
						{
							existingLaserPrinter.Model = newPrinterData.Model;
							existingLaserPrinter.Manufacturer = newPrinterData.Manufacturer;
							existingLaserPrinter.Price = newPrinterData.Price;
							existingLaserPrinter.Purpose = newPrinterData.Purpose;
							existingLaserPrinter.PrinterSize = newPrinterData.PrinterSize;
							existingLaserPrinter.LaserType = ((LaserPrinter)(object)newPrinterData).LaserType;
						}
					}
					else if (newPrinterData is InkjetPrinter)
					{
						var existingInkjetPrinter = context.InkjetPrinters.FirstOrDefault(p => p.ProductCode == productCode);
						if (existingInkjetPrinter != null)
						{
							existingInkjetPrinter.Model = newPrinterData.Model;
							existingInkjetPrinter.Manufacturer = newPrinterData.Manufacturer;
							existingInkjetPrinter.Price = newPrinterData.Price;
							existingInkjetPrinter.Purpose = newPrinterData.Purpose;
							existingInkjetPrinter.PrinterSize = newPrinterData.PrinterSize;
							existingInkjetPrinter.Duplex = ((InkjetPrinter)(object)newPrinterData).Duplex;
						}
					}
					context.SaveChanges(); 
					LoadDataFromDatabase();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error with Edit Printer: {ex.Message}");
			}
		}

		public void RemovePrinter(string productCode)
		{
			using (var context = new PrinterDbContext(_configuration))
			{
				var laserPrinterToRemove = laserPrintersList.FirstOrDefault(p => p.ProductCode == productCode);
				if (laserPrinterToRemove != null)
				{
					laserPrintersList.Remove(laserPrinterToRemove);
					context.LaserPrinters.Remove(laserPrinterToRemove);
				}

				var inkjetPrinterToRemove = inkjetPrintersList.FirstOrDefault(p => p.ProductCode == productCode);
				if (inkjetPrinterToRemove != null)
				{
					inkjetPrintersList.Remove(inkjetPrinterToRemove);
					context.InkjetPrinters.Remove(inkjetPrinterToRemove);
				}

				context.SaveChanges();
			}
		}

		public LinkedList<Printer> SortPrintersByPrice(LinkedList<Printer> allPrinters)
		{
			var sortedPrinters = new LinkedList<Printer>(allPrinters.OrderBy(p => p.Price));
			return sortedPrinters;
		}

		public LinkedList<Printer> GetLaserPrinters(LinkedList<Printer> allPrinters)
		{
			var laserPrinters = new LinkedList<Printer>();

			foreach (var printer in allPrinters)
			{
				if (printer is LaserPrinter)
				{
					laserPrinters.AddLast(printer);
				}
			}
			return laserPrinters;
		}
		public LinkedList<Printer> GetInkjetPrinters(LinkedList<Printer> allPrinters)
		{
			var inkjetPrinters = new LinkedList<Printer>();

			foreach (var printer in allPrinters)
			{
				if (printer is InkjetPrinter)
				{
					inkjetPrinters.AddLast(printer);
				}
			}
			return inkjetPrinters;
		}

		public LinkedList<Printer> GetPrintersByManufacturer(string manufacturer,LinkedList<Printer> allPrinters)
		{
			var printersByManufacturer = new LinkedList<Printer>();

			foreach (var printer in allPrinters)
			{
				if (printer.Manufacturer == manufacturer)
				{
					printersByManufacturer.AddLast(printer);
				}
			}

			return printersByManufacturer;
		}

		public LinkedList<Printer> GetHomePrinters(LinkedList<Printer> allPrinters)
		{
			var homePrinters = new LinkedList<Printer>();

			foreach (var printer in allPrinters)
			{
				if (printer.Purpose == PrinterPurpose.Home)
				{
					homePrinters.AddLast(printer);
				}
			}

			return homePrinters;
		}

		public LinkedList<Printer> GetOfficePrinters(LinkedList<Printer> allPrinters)
		{
			var officePrinters = new LinkedList<Printer>();

			foreach (var printer in allPrinters)
			{
				if (printer.Purpose == PrinterPurpose.Office)
				{
					officePrinters.AddLast(printer);
				}
			}

			return officePrinters;
		}

		public Printer GetPrinterByProductCode(string productCode)
		{
			var laserPrinter = laserPrintersList.FirstOrDefault(p => p.ProductCode == productCode);
			if (laserPrinter != null)
			{
				return laserPrinter;
			}

			var inkjetPrinter = inkjetPrintersList.FirstOrDefault(p => p.ProductCode == productCode);
			if (inkjetPrinter != null)
			{
				return inkjetPrinter;
			}

			return null;
		}
	}
}
