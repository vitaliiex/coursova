namespace FlexPrint_WinForm
{
	partial class AddPrinterForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Cancel_button = new Button();
			AddPrinter = new Button();
			EnterModelT = new TextBox();
			EnterName = new TextBox();
			TypePrinterT = new TextBox();
			TypePrinter = new ComboBox();
			PriceT = new TextBox();
			Price = new TextBox();
			ManufacturerT = new TextBox();
			Manufacturer = new TextBox();
			PurposeT = new TextBox();
			Purpose = new ComboBox();
			PrinterSize = new ComboBox();
			PrinterSizeT = new TextBox();
			LaserTypeT = new TextBox();
			LaserType = new ComboBox();
			DuplexT = new TextBox();
			Duplex = new ComboBox();
			SuspendLayout();
			// 
			// Cancel_button
			// 
			Cancel_button.Location = new Point(52, 311);
			Cancel_button.Name = "Cancel_button";
			Cancel_button.Size = new Size(129, 45);
			Cancel_button.TabIndex = 0;
			Cancel_button.Text = "Cancel";
			Cancel_button.UseVisualStyleBackColor = true;
			Cancel_button.Click += Cancel_button_Click;
			// 
			// AddPrinter
			// 
			AddPrinter.Location = new Point(351, 311);
			AddPrinter.Name = "AddPrinter";
			AddPrinter.Size = new Size(120, 45);
			AddPrinter.TabIndex = 1;
			AddPrinter.Text = "Add Printer";
			AddPrinter.UseVisualStyleBackColor = true;
			AddPrinter.Click += AddPrinter_Click;
			// 
			// EnterModelT
			// 
			EnterModelT.BackColor = SystemColors.ActiveCaption;
			EnterModelT.BorderStyle = BorderStyle.None;
			EnterModelT.Location = new Point(94, 38);
			EnterModelT.Name = "EnterModelT";
			EnterModelT.Size = new Size(104, 20);
			EnterModelT.TabIndex = 2;
			EnterModelT.Text = "Enter Model";
			// 
			// EnterName
			// 
			EnterName.Location = new Point(204, 35);
			EnterName.Name = "EnterName";
			EnterName.Size = new Size(151, 27);
			EnterName.TabIndex = 3;
			// 
			// TypePrinterT
			// 
			TypePrinterT.BackColor = SystemColors.ActiveCaption;
			TypePrinterT.BorderStyle = BorderStyle.None;
			TypePrinterT.Location = new Point(62, 74);
			TypePrinterT.Name = "TypePrinterT";
			TypePrinterT.Size = new Size(136, 20);
			TypePrinterT.TabIndex = 4;
			TypePrinterT.Text = "Change Type Printer";
			// 
			// TypePrinter
			// 
			TypePrinter.DropDownStyle = ComboBoxStyle.DropDownList;
			TypePrinter.FormattingEnabled = true;
			TypePrinter.Items.AddRange(new object[] { "Laser", "Inkject" });
			TypePrinter.Location = new Point(204, 71);
			TypePrinter.Name = "TypePrinter";
			TypePrinter.Size = new Size(151, 28);
			TypePrinter.TabIndex = 5;
			TypePrinter.SelectedIndexChanged += TypePrinter_SelectedIndexChanged;
			// 
			// PriceT
			// 
			PriceT.BackColor = SystemColors.ActiveCaption;
			PriceT.BorderStyle = BorderStyle.None;
			PriceT.Location = new Point(148, 115);
			PriceT.Name = "PriceT";
			PriceT.Size = new Size(50, 20);
			PriceT.TabIndex = 6;
			PriceT.Text = "Price";
			// 
			// Price
			// 
			Price.Location = new Point(204, 112);
			Price.Name = "Price";
			Price.Size = new Size(151, 27);
			Price.TabIndex = 7;
			// 
			// ManufacturerT
			// 
			ManufacturerT.BackColor = SystemColors.ActiveCaption;
			ManufacturerT.BorderStyle = BorderStyle.None;
			ManufacturerT.Location = new Point(105, 150);
			ManufacturerT.Name = "ManufacturerT";
			ManufacturerT.Size = new Size(93, 20);
			ManufacturerT.TabIndex = 8;
			ManufacturerT.Text = "Manufacturer";
			// 
			// Manufacturer
			// 
			Manufacturer.Location = new Point(204, 148);
			Manufacturer.Name = "Manufacturer";
			Manufacturer.Size = new Size(151, 27);
			Manufacturer.TabIndex = 9;
			// 
			// PurposeT
			// 
			PurposeT.BackColor = SystemColors.ActiveCaption;
			PurposeT.BorderStyle = BorderStyle.None;
			PurposeT.Location = new Point(131, 195);
			PurposeT.Name = "PurposeT";
			PurposeT.Size = new Size(67, 20);
			PurposeT.TabIndex = 10;
			PurposeT.Text = "Purpose";
			// 
			// Purpose
			// 
			Purpose.DropDownStyle = ComboBoxStyle.DropDownList;
			Purpose.FormattingEnabled = true;
			Purpose.Items.AddRange(new object[] { "Home", "Office", "Other" });
			Purpose.Location = new Point(204, 187);
			Purpose.Name = "Purpose";
			Purpose.Size = new Size(151, 28);
			Purpose.TabIndex = 11;
			// 
			// PrinterSize
			// 
			PrinterSize.DropDownStyle = ComboBoxStyle.DropDownList;
			PrinterSize.FormattingEnabled = true;
			PrinterSize.Items.AddRange(new object[] { "A4", "A5" });
			PrinterSize.Location = new Point(204, 231);
			PrinterSize.Name = "PrinterSize";
			PrinterSize.Size = new Size(151, 28);
			PrinterSize.TabIndex = 12;
			// 
			// PrinterSizeT
			// 
			PrinterSizeT.BackColor = SystemColors.ActiveCaption;
			PrinterSizeT.BorderStyle = BorderStyle.None;
			PrinterSizeT.Location = new Point(113, 235);
			PrinterSizeT.Name = "PrinterSizeT";
			PrinterSizeT.Size = new Size(85, 20);
			PrinterSizeT.TabIndex = 13;
			PrinterSizeT.Text = "PrinterSize";
			// 
			// LaserTypeT
			// 
			LaserTypeT.BackColor = SystemColors.ActiveCaption;
			LaserTypeT.BorderStyle = BorderStyle.None;
			LaserTypeT.Location = new Point(113, 270);
			LaserTypeT.Name = "LaserTypeT";
			LaserTypeT.Size = new Size(85, 20);
			LaserTypeT.TabIndex = 14;
			LaserTypeT.Text = "LaserType";
			LaserTypeT.Visible = false;
			// 
			// LaserType
			// 
			LaserType.DropDownStyle = ComboBoxStyle.DropDownList;
			LaserType.FormattingEnabled = true;
			LaserType.Items.AddRange(new object[] { "SolidState", "Gas", "Dye", "Fiber" });
			LaserType.Location = new Point(204, 267);
			LaserType.Name = "LaserType";
			LaserType.Size = new Size(151, 28);
			LaserType.TabIndex = 15;
			LaserType.Visible = false;
			// 
			// DuplexT
			// 
			DuplexT.BackColor = SystemColors.ActiveCaption;
			DuplexT.BorderStyle = BorderStyle.None;
			DuplexT.Location = new Point(138, 270);
			DuplexT.Name = "DuplexT";
			DuplexT.Size = new Size(60, 20);
			DuplexT.TabIndex = 16;
			DuplexT.Text = "Duplex";
			DuplexT.Visible = false;
			// 
			// Duplex
			// 
			Duplex.DropDownStyle = ComboBoxStyle.DropDownList;
			Duplex.FormattingEnabled = true;
			Duplex.Items.AddRange(new object[] { "Yes", "No" });
			Duplex.Location = new Point(204, 267);
			Duplex.Name = "Duplex";
			Duplex.Size = new Size(151, 28);
			Duplex.TabIndex = 17;
			Duplex.Visible = false;
			// 
			// AddPrinterForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(506, 391);
			Controls.Add(Duplex);
			Controls.Add(DuplexT);
			Controls.Add(LaserType);
			Controls.Add(LaserTypeT);
			Controls.Add(PrinterSizeT);
			Controls.Add(PrinterSize);
			Controls.Add(Purpose);
			Controls.Add(PurposeT);
			Controls.Add(Manufacturer);
			Controls.Add(ManufacturerT);
			Controls.Add(Price);
			Controls.Add(PriceT);
			Controls.Add(TypePrinter);
			Controls.Add(TypePrinterT);
			Controls.Add(EnterName);
			Controls.Add(EnterModelT);
			Controls.Add(AddPrinter);
			Controls.Add(Cancel_button);
			Name = "AddPrinterForm";
			Text = "AddPrinterForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button Cancel_button;
		private Button AddPrinter;
		private TextBox EnterModelT;
		private TextBox EnterName;
		private TextBox TypePrinterT;
		private ComboBox TypePrinter;
		private TextBox PriceT;
		private TextBox Price;
		private TextBox ManufacturerT;
		private TextBox Manufacturer;
		private TextBox PurposeT;
		private ComboBox Purpose;
		private ComboBox PrinterSize;
		private TextBox PrinterSizeT;
		private TextBox LaserTypeT;
		private ComboBox LaserType;
		private TextBox DuplexT;
		private ComboBox Duplex;
	}
}