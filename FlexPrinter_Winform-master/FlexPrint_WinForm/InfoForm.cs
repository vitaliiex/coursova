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
	public partial class InfoForm : Form
	{
		public InfoForm()
		{
			InitializeComponent();
			Load += new System.EventHandler(this.InfoForm_Load);
			Resize += new System.EventHandler(this.InfoForm_Resize);
			MinimumSize = new Size(600, 300);
		}
		private void InfoForm_Load(object sender, EventArgs e)
		{
			HeaderInfo.Text = "FlexPrint";
	

			Indotextbox.Text = "Good afternoon,below are brief instructions on how to interact with the program\nFunctionality:\r\nAdding printers: Users can add new records about printers, specifying the model, manufacturer, price, size, purpose, type of laser and availability of two-sided printing (duplex).\r\nView Printers: Users can view the list of available printers in the form of a table, which displays the main characteristics of each printer.\nEditing Printers: Users can edit existing printer records by changing any parameters such as model, manufacturer, price, etc.\r\nDelete Printers: Users can delete printer entries that are no longer needed.\r\nSort: You can sort printers by price\r\nSearch for printers: you can search for printers by their type, whether they belong to physical or home printers, you can also find a printer of a specific manufacturer\r\nPurchases and bonuses: Certain discounts or bonuses are available for the purchase of a printer\r\n\r\nUser interface:\r\nThe program has an intuitive and easy-to-use interface. On the main user window there is a list of printers in the form of a table with the possibility of editing and deleting entries. The buttons allow you to add new entries and open the user manual.";
		}
		private void InfoForm_Resize(object sender, EventArgs e)
		{
			int headerX = (this.ClientSize.Width - HeaderInfo.GetPreferredSize(Size.Empty).Width) / 2;
			HeaderInfo.Location = new Point(headerX, 10);

			// Визначення положення і розміру для параграфу
			int paragraphX = (this.ClientSize.Width - HeaderInfo.GetPreferredSize(Size.Empty).Width) / 2;
			int paragraphY = HeaderInfo.Bottom + 40;
		

			int textBoxY = HeaderInfo.Bottom + 30;
			Indotextbox.Location = new Point(10, textBoxY);
		}

		
			}

		}
	}
}
