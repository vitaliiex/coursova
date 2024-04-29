using FlexPrint_Console.Enum;
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
	public partial class EditPrinterForm : Form
	{
		public string PrinterCode { get; set; }
		public string Model { get; set; }
		public string Manufacturer { get; set; }
		public decimal Price { get; set; }
		public MaxPrinterSize PrinterSize { get; set; }
		public PrinterPurpose Purpose { get; set; }
		public string? LaserType { get; set; }
		public bool? Duplex { get; set; }

		public EditPrinterForm(string printerCode, string model, string manufacturer, decimal price, MaxPrinterSize printerSize, PrinterPurpose purpose, string laserType, bool? duplex)
		{
			InitializeComponent();

			ProductCodeView.Text = printerCode;


			ModelView.Text = model;
			ManufactureView.Text = manufacturer;
			PriceView.Text = price.ToString();


			PurposeCombobox.SelectedItem = purpose.ToString();
			PrintSizeCombobox.SelectedItem = printerSize.ToString();


			if (laserType != null)
			{
				LaserTypeCombobox.SelectedItem = laserType;
				LaserTypeCombobox.Visible = true;
				LaserTypeT.Visible = true;
			}
			else if (duplex != null)
			{
				if (duplex == true)
				{
					DuplexCombobox.SelectedIndex = 0;

				}
				else
				{
					DuplexCombobox.SelectedIndex = 1;
				}

				DuplexCombobox.Visible = true;
				DuplexT.Visible = true;

			}
		}

		private void EditPrinterB_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(ModelView.Text))
			{
				MessageBox.Show("Please enter a valid model.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; 
			}
			Model = ModelView.Text;

			if (string.IsNullOrWhiteSpace(ManufactureView.Text))
			{
				MessageBox.Show("Please enter a valid manufacturer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return; 
			}
			Manufacturer = ManufactureView.Text;

			decimal price;
			if (!decimal.TryParse(PriceView.Text, out price))
			{
				MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Price = price;


			MaxPrinterSize printerSize;
			Enum.TryParse(PrintSizeCombobox.SelectedItem.ToString(), out printerSize);
			PrinterSize = printerSize;

			PrinterPurpose purpose;
			Enum.TryParse(PurposeCombobox.SelectedItem.ToString(), out purpose);
			Purpose = purpose;

			LaserType = LaserTypeCombobox.SelectedItem?.ToString();
			bool? duplexValue = null;
			string duplexString = DuplexCombobox.SelectedItem?.ToString();
			if (duplexString == "Yes")
			{
				duplexValue = true;
			}
			else if (duplexString == "No")
			{
				duplexValue = false;
			}
			Duplex = duplexValue;

			DialogResult = DialogResult.OK;
		}

		private void CanselB_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
