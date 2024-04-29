namespace FlexPrint_WinForm
{
	partial class EditPrinterForm
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
			EditPrinterB = new Button();
			CanselB = new Button();
			ProductCodeT = new TextBox();
			ModelT = new TextBox();
			PurposeT = new TextBox();
			PrintSizeT = new TextBox();
			LaserTypeT = new TextBox();
			ManufacturerT = new TextBox();
			PriceT = new TextBox();
			ProductCodeView = new TextBox();
			ModelView = new TextBox();
			ManufactureView = new TextBox();
			PriceView = new TextBox();
			PurposeCombobox = new ComboBox();
			PrintSizeCombobox = new ComboBox();
			LaserTypeCombobox = new ComboBox();
			DuplexCombobox = new ComboBox();
			DuplexT = new TextBox();
			SuspendLayout();
			// 
			// EditPrinterB
			// 
			EditPrinterB.Location = new Point(400, 371);
			EditPrinterB.Name = "EditPrinterB";
			EditPrinterB.Size = new Size(115, 48);
			EditPrinterB.TabIndex = 0;
			EditPrinterB.Text = "Edit Printer";
			EditPrinterB.UseVisualStyleBackColor = true;
			EditPrinterB.Click += EditPrinterB_Click;
			// 
			// CanselB
			// 
			CanselB.Location = new Point(125, 371);
			CanselB.Name = "CanselB";
			CanselB.Size = new Size(115, 48);
			CanselB.TabIndex = 1;
			CanselB.Text = "Cancel";
			CanselB.UseVisualStyleBackColor = true;
			CanselB.Click += CanselB_Click;
			// 
			// ProductCodeT
			// 
			ProductCodeT.BackColor = SystemColors.ActiveCaption;
			ProductCodeT.BorderStyle = BorderStyle.None;
			ProductCodeT.Location = new Point(161, 45);
			ProductCodeT.Name = "ProductCodeT";
			ProductCodeT.Size = new Size(98, 20);
			ProductCodeT.TabIndex = 2;
			ProductCodeT.Text = "ProductCode";
			// 
			// ModelT
			// 
			ModelT.BackColor = SystemColors.ActiveCaption;
			ModelT.BorderStyle = BorderStyle.None;
			ModelT.Location = new Point(206, 82);
			ModelT.Name = "ModelT";
			ModelT.Size = new Size(53, 20);
			ModelT.TabIndex = 3;
			ModelT.Text = "Model";
			// 
			// PurposeT
			// 
			PurposeT.BackColor = SystemColors.ActiveCaption;
			PurposeT.BorderStyle = BorderStyle.None;
			PurposeT.Location = new Point(195, 200);
			PurposeT.Name = "PurposeT";
			PurposeT.Size = new Size(64, 20);
			PurposeT.TabIndex = 4;
			PurposeT.Text = "Purpose";
			// 
			// PrintSizeT
			// 
			PrintSizeT.BackColor = SystemColors.ActiveCaption;
			PrintSizeT.BorderStyle = BorderStyle.None;
			PrintSizeT.Location = new Point(196, 245);
			PrintSizeT.Name = "PrintSizeT";
			PrintSizeT.Size = new Size(63, 20);
			PrintSizeT.TabIndex = 5;
			PrintSizeT.Text = "PrintSize";
			// 
			// LaserTypeT
			// 
			LaserTypeT.BackColor = SystemColors.ActiveCaption;
			LaserTypeT.BorderStyle = BorderStyle.None;
			LaserTypeT.Location = new Point(194, 292);
			LaserTypeT.Name = "LaserTypeT";
			LaserTypeT.Size = new Size(65, 20);
			LaserTypeT.TabIndex = 6;
			LaserTypeT.Text = "LaserType";
			LaserTypeT.Visible = false;
			// 
			// ManufacturerT
			// 
			ManufacturerT.BackColor = SystemColors.ActiveCaption;
			ManufacturerT.BorderStyle = BorderStyle.None;
			ManufacturerT.Location = new Point(161, 118);
			ManufacturerT.Name = "ManufacturerT";
			ManufacturerT.Size = new Size(98, 20);
			ManufacturerT.TabIndex = 7;
			ManufacturerT.Text = "Manufacturer";
			// 
			// PriceT
			// 
			PriceT.BackColor = SystemColors.ActiveCaption;
			PriceT.BorderStyle = BorderStyle.None;
			PriceT.Location = new Point(215, 153);
			PriceT.Name = "PriceT";
			PriceT.Size = new Size(44, 20);
			PriceT.TabIndex = 8;
			PriceT.Text = "Price";
			// 
			// ProductCodeView
			// 
			ProductCodeView.Location = new Point(265, 42);
			ProductCodeView.Name = "ProductCodeView";
			ProductCodeView.ReadOnly = true;
			ProductCodeView.Size = new Size(125, 27);
			ProductCodeView.TabIndex = 9;
			// 
			// ModelView
			// 
			ModelView.Location = new Point(265, 82);
			ModelView.Name = "ModelView";
			ModelView.Size = new Size(125, 27);
			ModelView.TabIndex = 10;
			// 
			// ManufactureView
			// 
			ManufactureView.Location = new Point(265, 115);
			ManufactureView.Name = "ManufactureView";
			ManufactureView.Size = new Size(125, 27);
			ManufactureView.TabIndex = 11;
			// 
			// PriceView
			// 
			PriceView.Location = new Point(265, 153);
			PriceView.Name = "PriceView";
			PriceView.Size = new Size(125, 27);
			PriceView.TabIndex = 12;
			// 
			// PurposeCombobox
			// 
			PurposeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
			PurposeCombobox.FormattingEnabled = true;
			PurposeCombobox.Items.AddRange(new object[] { "Home", "Office", "Other" });
			PurposeCombobox.Location = new Point(265, 197);
			PurposeCombobox.Name = "PurposeCombobox";
			PurposeCombobox.Size = new Size(151, 28);
			PurposeCombobox.TabIndex = 13;
			// 
			// PrintSizeCombobox
			// 
			PrintSizeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
			PrintSizeCombobox.FormattingEnabled = true;
			PrintSizeCombobox.Items.AddRange(new object[] { "A4", "A5" });
			PrintSizeCombobox.Location = new Point(265, 242);
			PrintSizeCombobox.Name = "PrintSizeCombobox";
			PrintSizeCombobox.Size = new Size(151, 28);
			PrintSizeCombobox.TabIndex = 14;
			// 
			// LaserTypeCombobox
			// 
			LaserTypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
			LaserTypeCombobox.FormattingEnabled = true;
			LaserTypeCombobox.Items.AddRange(new object[] { "SolidState", "Gas", "Dye", "Fiber" });
			LaserTypeCombobox.Location = new Point(265, 289);
			LaserTypeCombobox.Name = "LaserTypeCombobox";
			LaserTypeCombobox.Size = new Size(151, 28);
			LaserTypeCombobox.TabIndex = 15;
			LaserTypeCombobox.Visible = false;
			// 
			// DuplexCombobox
			// 
			DuplexCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
			DuplexCombobox.FormattingEnabled = true;
			DuplexCombobox.Items.AddRange(new object[] { "Yes", "No" });
			DuplexCombobox.Location = new Point(265, 289);
			DuplexCombobox.Name = "DuplexCombobox";
			DuplexCombobox.Size = new Size(151, 28);
			DuplexCombobox.TabIndex = 16;
			DuplexCombobox.Visible = false;
			// 
			// DuplexT
			// 
			DuplexT.BackColor = SystemColors.ActiveCaption;
			DuplexT.BorderStyle = BorderStyle.None;
			DuplexT.Location = new Point(198, 292);
			DuplexT.Name = "DuplexT";
			DuplexT.Size = new Size(61, 20);
			DuplexT.TabIndex = 17;
			DuplexT.Text = "Duplex";
			DuplexT.Visible = false;
			// 
			// EditPrinterForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(679, 450);
			Controls.Add(DuplexT);
			Controls.Add(DuplexCombobox);
			Controls.Add(LaserTypeCombobox);
			Controls.Add(PrintSizeCombobox);
			Controls.Add(PurposeCombobox);
			Controls.Add(PriceView);
			Controls.Add(ManufactureView);
			Controls.Add(ModelView);
			Controls.Add(ProductCodeView);
			Controls.Add(PriceT);
			Controls.Add(ManufacturerT);
			Controls.Add(LaserTypeT);
			Controls.Add(PrintSizeT);
			Controls.Add(PurposeT);
			Controls.Add(ModelT);
			Controls.Add(ProductCodeT);
			Controls.Add(CanselB);
			Controls.Add(EditPrinterB);
			Name = "EditPrinterForm";
			Text = "EditPrinterForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button EditPrinterB;
		private Button CanselB;
		private TextBox ProductCodeT;
		private TextBox ModelT;
		private TextBox PurposeT;
		private TextBox PrintSizeT;
		private TextBox LaserTypeT;
		private TextBox ManufacturerT;
		private TextBox PriceT;
		private TextBox ProductCodeView;
		private TextBox ModelView;
		private TextBox ManufactureView;
		private TextBox PriceView;
		private ComboBox PurposeCombobox;
		private ComboBox PrintSizeCombobox;
		private ComboBox LaserTypeCombobox;
		private ComboBox DuplexCombobox;
		private TextBox DuplexT;
	}
}