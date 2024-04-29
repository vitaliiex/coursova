using FlexPrint_Console.DB;
using Microsoft.Extensions.Configuration;

namespace FlexPrint_WinForm
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var configuration = new ConfigurationBuilder()
		.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
		.AddJsonFile("appsettings.json")
		.Build();
			using (var dbContext = new PrinterDbContext(configuration))
			{
				if (!dbContext.Database.CanConnect())
				{
					dbContext.Database.EnsureCreated();
				}
			}


			ApplicationConfiguration.Initialize();
			 Application.Run(new MainWindow(configuration));
		}
	}
}