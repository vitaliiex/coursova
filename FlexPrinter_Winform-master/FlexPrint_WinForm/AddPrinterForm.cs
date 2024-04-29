using FlexPrint_Console.Enum;
using FlexPrint_Console.Model;
using FlexPrint_WinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexPrint_WinForm
{
	public partial class AddPrinterForm : Form
	{
		public AddPrinterForm()
		{
			InitializeComponent();
		}

		private void TypePrinter_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Отримуємо вибраний тип принтера
			string selectedType = TypePrinter.SelectedItem.ToString();

			// Перевіряємо, чи вибраний тип - Laser
			if (selectedType == "Laser")
			{
				// Показуємо поле LaserType
				LaserType.Visible = true;
				LaserTypeT.Visible = true;
				Duplex.Visible = false;
				DuplexT.Visible = false;
			}
			if (selectedType == "Inkject")
			{
				Duplex.Visible = true;
				DuplexT.Visible = true;
				LaserType.Visible = false;
				LaserTypeT.Visible = false;

			}
		}


		public Printer GetPrinterData()
		{
			string model = EnterName.Text;
			string manufacturer = Manufacturer.Text;
		
			decimal price ;
			decimal.TryParse(Price.Text, out price);
		

			MaxPrinterSize printerSize;
			Enum.TryParse(PrinterSize.SelectedItem.ToString(), out printerSize);
			
			PrinterPurpose purpose;
			Enum.TryParse(Purpose.SelectedItem.ToString(), out purpose);
			

			if (TypePrinter.SelectedItem.ToString() == "Laser")
			{
				string selectedLaserType = LaserType.SelectedItem.ToString();

				LaserPrinterType laserPrinterType;
				Enum.TryParse(selectedLaserType, out laserPrinterType);
				

				return new LaserPrinter
				{
					Model = model,
					Manufacturer = manufacturer,
					Price = price,
					PrinterSize = printerSize,
					Purpose = purpose,
					LaserType = laserPrinterType
				};
			}

			if (TypePrinter.SelectedItem.ToString() == "Inkject")
			{
				bool duplex = false;

			
				if (Duplex.SelectedItem != null && Duplex.SelectedItem.ToString() == "Yes")
				{
					duplex = true;
				}
				return new InkjetPrinter
				{
					Model = model,
					Manufacturer = manufacturer,
					Price = price,
					PrinterSize = printerSize,
					Purpose = purpose,
					Duplex = duplex
				};
			}

			//Це в нас заглушка для майбутнього можливо будемо ще додавати принтери різних типів
			return new Printer
			{
				Model = model,
				Manufacturer = manufacturer,
				Price = price,
				PrinterSize = printerSize,
				Purpose = purpose
			};
		}

		private void AddPrinter_Click(object sender, EventArgs e)
		{
			
			if (string.IsNullOrWhiteSpace(EnterName.Text) ||
				string.IsNullOrWhiteSpace(Manufacturer.Text) ||
				string.IsNullOrWhiteSpace(Price.Text) ||
				string.IsNullOrWhiteSpace(PrinterSize.Text))
			{
				MessageBox.Show("Please fill in all fields.");
				return;
			}
			
			if (!decimal.TryParse(Price.Text, out decimal price))
			{
				MessageBox.Show("Please enter a valid price.");
				return;
			}
			
			if(PrinterSize.SelectedItem == null)
			{
				MessageBox.Show("Please select a valid printer size.");
				return;
			}
			if (TypePrinter.SelectedItem == null)
			{
				MessageBox.Show("Please select a printer type.");
				return;
			}
			if (Purpose.SelectedItem==null)
			{
				MessageBox.Show("Please select a valid purpose.");
				return;
			}

			if (TypePrinter.SelectedItem.ToString() == "Inkject")
			{
				
				if (Duplex.SelectedItem == null)
				{
					MessageBox.Show("Please select a duplex");
					return;
				}
			}
			if (TypePrinter.SelectedItem.ToString() == "Laser")
			{

				if (LaserType.SelectedItem == null)
				{
					MessageBox.Show("Please select a LaserType");
					return;
				}
			}

			DialogResult = DialogResult.OK;
		}

		private void Cancel_button_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
