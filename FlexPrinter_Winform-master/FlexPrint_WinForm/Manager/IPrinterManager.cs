using FlexPrint_Console.Model;
using FlexPrint_WinForm.Model;

namespace FlexPrint_Console.Manager
{
	public interface IPrinterManager
	{
		
		/// <summary>
		/// Метод, який завантажує дані про принтери з бази даних.
		/// </summary>
		void LoadDataFromDatabase();

		/// <summary>
		/// Метод для додавання нового принтера до бази даних та внутрішнього списку.
		/// </summary>
		/// <typeparam name="T">Тип принтера, який додається.</typeparam>
		/// <param name="printer">Об'єкт принтера, який додається.</param>
		void AddPrinter<T>(T printer) where T : Printer;

		/// <summary>
		/// Метод для видалення принтера з бази даних та внутрішнього списку за його унікальним кодом.
		/// </summary>
		/// <param name="productCode">Унікальний код продукту, який ідентифікує принтер.</param>
		void RemovePrinter(string productCode);

		/// <summary>
		/// Метод для редагування даних про принтер в базі даних та внутрішньому списку.
		/// </summary>
		/// <typeparam name="T">Тип принтера, який редагується.</typeparam>
		/// <param name="productCode">Унікальний код продукту, який ідентифікує принтер.</param>
		/// <param name="newPrinterData">Нові дані про принтер для заміни.</param>
		void EditPrinter<T>(string productCode, T newPrinterData) where T : Printer;

		/// <summary>
		/// Метод для сортування принтерів за ціною в порядку зростання.
		/// </summary>
		LinkedList<Printer> SortPrintersByPrice(LinkedList<Printer> allPrinters);


		/// <summary>
		/// Метод для получення всіч принтерів
		/// </summary>
		LinkedList<Printer> GetPrinters();



		/// <summary>
		/// Метод для отримання списку лазерних принтерів з бази даних.
		/// </summary>
		/// <returns>Список лазерних принтерів.</returns>
		LinkedList<Printer> GetLaserPrinters(LinkedList<Printer> allPrinters);

		/// <summary>
		/// Метод для отримання списку струменевих принтерів з бази даних.
		/// </summary>
		/// <returns>Список струменевих принтерів.</returns>
		LinkedList<Printer> GetInkjetPrinters(LinkedList<Printer> allPrinters);

		/// <summary>
		/// Метод для отримання списку принтерів виробника за його назвою.
		/// </summary>
		/// <param name="manufacturer">Назва виробника принтерів.</param>
		/// <returns>Список принтерів виробника.</returns>
		LinkedList<Printer> GetPrintersByManufacturer(string manufacturer, LinkedList<Printer> allPrinters);

		/// <summary>
		/// Метод для отримання списку принтерів для дому.
		/// </summary>
		/// <returns>Список принтерів для дому.</returns>
		LinkedList<Printer> GetHomePrinters(LinkedList<Printer> allPrinters);

		/// <summary>
		/// Метод для отримання списку принтерів для офісу.
		/// </summary>
		/// <returns>Список принтерів для офісу.</returns>
		LinkedList<Printer> GetOfficePrinters(LinkedList<Printer> allPrinters);
		/// <summary>
		/// Метод для отримання принтера за його кодом.
		/// </summary>
		/// <returns>Принтер з відповідним кодом</returns>
		Printer GetPrinterByProductCode(string productCode);
	}


}
