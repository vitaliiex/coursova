using FlexPrint_Console.Enum;
using FlexPrint_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlexPrint_Console.Model
{
	public class LaserPrinter : Printer
	{

		public LaserPrinterType LaserType { get; set; }

		public override decimal CalculatePurchaseCost()
		{
			decimal discountedPrice = base.CalculatePurchaseCost();
			if (Price > 5000)
			{

				discountedPrice *= 0.95m;
				MessageBox.Show($"Congratulations, your purchase of a laser printer was more than 5000 and you are given a 5% discount and payable : {discountedPrice} UAH");

			}
			else
			{
				MessageBox.Show($"Your laser printer costs less than 5000, so the 5% discount is not applicable");
			}
			return discountedPrice;
		}
	
	}

}
