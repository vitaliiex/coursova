namespace FlexPrint_WinForm
{
	partial class MainWindow
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
			dataGridView1 = new DataGridView();
			ProductCode = new DataGridViewTextBoxColumn();
			Model = new DataGridViewTextBoxColumn();
			Manufacturer = new DataGridViewTextBoxColumn();
			Price = new DataGridViewTextBoxColumn();
			PrinterSize = new DataGridViewTextBoxColumn();
			Purpose = new DataGridViewTextBoxColumn();
			LaserType = new DataGridViewTextBoxColumn();
			Duplex = new DataGridViewTextBoxColumn();
			editButtonColumn = new DataGridViewButtonColumn();
			buyButtonColumn = new DataGridViewButtonColumn();
			Remove = new Button();
			Add = new Button();
			SortingMethod = new ComboBox();
			GetPrintersCombobox = new ComboBox();
			FindTextbox = new TextBox();
			Findbutton = new Button();
			Load_Data = new Button();
			Sort_by = new Button();
			GetPrinter = new Button();
			InfoButton = new Button();
			FromTheEndB = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ProductCode, Model, Manufacturer, Price, PrinterSize, Purpose, LaserType, Duplex, editButtonColumn, buyButtonColumn });
			
			dataGridView1.Location = new Point(3, 117);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 70;
			dataGridView1.RowTemplate.Height = 40;
			dataGridView1.Size = new Size(1045, 274);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellContentClick += DataGridView1_CellContentClick;
			// 
			// ProductCode
			// 
			ProductCode.HeaderText = "ProductCode";
			ProductCode.MinimumWidth = 6;
			ProductCode.Name = "ProductCode";
			// 
			// Model
			// 
			Model.HeaderText = "Model";
			Model.MinimumWidth = 6;
			Model.Name = "Model";
			// 
			// Manufacturer
			// 
			Manufacturer.HeaderText = "Manufacturer";
			Manufacturer.MinimumWidth = 6;
			Manufacturer.Name = "Manufacturer";
			// 
			// Price
			// 
			Price.HeaderText = "Price";
			Price.MinimumWidth = 6;
			Price.Name = "Price";
			// 
			// PrinterSize
			// 
			PrinterSize.HeaderText = "PrinterSize";
			PrinterSize.MinimumWidth = 6;
			PrinterSize.Name = "PrinterSize";
			// 
			// Purpose
			// 
			Purpose.HeaderText = "Purpose";
			Purpose.MinimumWidth = 6;
			Purpose.Name = "Purpose";
			// 
			// LaserType
			// 
			LaserType.HeaderText = "LaserType";
			LaserType.MinimumWidth = 6;
			LaserType.Name = "LaserType";
			// 
			// Duplex
			// 
			Duplex.HeaderText = "Duplex";
			Duplex.MinimumWidth = 6;
			Duplex.Name = "Duplex";
			// 
			// editButtonColumn
			// 
			editButtonColumn.HeaderText = "Edit";
			editButtonColumn.MinimumWidth = 6;
			editButtonColumn.Name = "editButtonColumn";
			editButtonColumn.Text = "Edit";
			editButtonColumn.UseColumnTextForButtonValue = true;
			// 
			// buyButtonColumn
			// 
			buyButtonColumn.HeaderText = "Buy";
			buyButtonColumn.MinimumWidth = 6;
			buyButtonColumn.Name = "buyButtonColumn";
			buyButtonColumn.Text = "Buy";
			buyButtonColumn.UseColumnTextForButtonValue = true;
			// 
			// Remove
			// 
			Remove.Location = new Point(12, 59);
			Remove.Name = "Remove";
			Remove.Size = new Size(113, 41);
			Remove.TabIndex = 1;
			Remove.Text = "Remove";
			Remove.UseVisualStyleBackColor = true;
			Remove.Click += Remove_Click;
			// 
			// Add
			// 
			Add.Location = new Point(131, 59);
			Add.Name = "Add";
			Add.Size = new Size(115, 41);
			Add.TabIndex = 2;
			Add.Text = "Add";
			Add.UseVisualStyleBackColor = true;
			Add.Click += Add_Click;
			// 
			// SortingMethod
			// 
			SortingMethod.DropDownStyle = ComboBoxStyle.DropDownList;
			SortingMethod.FormattingEnabled = true;
			SortingMethod.Items.AddRange(new object[] { "Price" });
			SortingMethod.SelectedIndex = 0;
			SortingMethod.Location = new Point(355, 66);
			SortingMethod.Name = "SortingMethod";
			SortingMethod.Size = new Size(151, 28);
			SortingMethod.TabIndex = 3;
			// 
			// GetPrintersCombobox
			// 
			GetPrintersCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
			GetPrintersCombobox.FormattingEnabled = true;
			GetPrintersCombobox.Items.AddRange(new object[] { "Office", "Home", "Laser Printer", "Inkject Printer" });
			GetPrintersCombobox.Location = new Point(578, 65);
			GetPrintersCombobox.Name = "GetPrintersCombobox";
			GetPrintersCombobox.Size = new Size(156, 28);
			GetPrintersCombobox.SelectedIndex = 0;
			GetPrintersCombobox.TabIndex = 4;
			// 
			// FindTextbox
			// 
			FindTextbox.Location = new Point(805, 67);
			FindTextbox.Name = "FindTextbox";
			FindTextbox.Size = new Size(125, 27);
			FindTextbox.TabIndex = 5;
			// 
			// Findbutton
			// 
			Findbutton.Location = new Point(939, 65);
			Findbutton.Name = "Findbutton";
			Findbutton.Size = new Size(94, 29);
			Findbutton.TabIndex = 6;
			Findbutton.Text = "Find";
			Findbutton.UseVisualStyleBackColor = true;
			Findbutton.Click += Findbutton_Click;
			// 
			// Load_Data
			// 
			Load_Data.Location = new Point(12, 12);
			Load_Data.Name = "Load_Data";
			Load_Data.Size = new Size(113, 41);
			Load_Data.TabIndex = 7;
			Load_Data.Text = "All Printers";
			Load_Data.UseVisualStyleBackColor = true;
			Load_Data.Click += Load_Data_Click;
			// 
			// Sort_by
			// 
			Sort_by.Location = new Point(282, 65);
			Sort_by.Name = "Sort_by";
			Sort_by.Size = new Size(67, 29);
			Sort_by.TabIndex = 8;
			Sort_by.Text = "Sort by";
			Sort_by.UseVisualStyleBackColor = true;
			Sort_by.Click += Sort_by_Click;
			// 
			// GetPrinter
			// 
			GetPrinter.Location = new Point(525, 65);
			GetPrinter.Name = "GetPrinter";
			GetPrinter.Size = new Size(47, 29);
			GetPrinter.TabIndex = 9;
			GetPrinter.Text = "Get";
			GetPrinter.UseVisualStyleBackColor = true;
			GetPrinter.Click += GetPrinter_Click;
			// 
			// InfoButton
			// 
			InfoButton.Location = new Point(131, 12);
			InfoButton.Name = "InfoButton";
			InfoButton.Size = new Size(115, 41);
			InfoButton.TabIndex = 10;
			InfoButton.Text = "Info";
			InfoButton.UseVisualStyleBackColor = true;
			InfoButton.Click += InfoButton_Click;
			// 
			// FromTheEndB
			// 
			FromTheEndB.Location = new Point(282, 12);
			FromTheEndB.Name = "FromTheEndB";
			FromTheEndB.Size = new Size(118, 29);
			FromTheEndB.TabIndex = 11;
			FromTheEndB.Text = "From the end";
			FromTheEndB.UseVisualStyleBackColor = true;
			FromTheEndB.Click += FromTheEndB_Click;
			// 
			// MainWindow
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(1051, 403);
			Controls.Add(FromTheEndB);
			Controls.Add(InfoButton);
			Controls.Add(GetPrinter);
			Controls.Add(Sort_by);
			Controls.Add(Load_Data);
			Controls.Add(Findbutton);
			Controls.Add(FindTextbox);
			Controls.Add(GetPrintersCombobox);
			Controls.Add(SortingMethod);
			Controls.Add(Add);
			Controls.Add(Remove);
			Controls.Add(dataGridView1);
			Name = "MainWindow";
			Text = "FlexPrint";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Button Remove;
		private Button Add;
		private ComboBox SortingMethod;
		private ComboBox GetPrintersCombobox;
		private TextBox FindTextbox;
		private Button Findbutton;
		private Button Load_Data;
		private Button Sort_by;
		private Button GetPrinter;
		private Button InfoButton;
		private DataGridViewTextBoxColumn ProductCode;
		private DataGridViewTextBoxColumn Model;
		private DataGridViewTextBoxColumn Manufacturer;
		private DataGridViewTextBoxColumn Price;
		private DataGridViewTextBoxColumn PrinterSize;
		private DataGridViewTextBoxColumn Purpose;
		private DataGridViewTextBoxColumn LaserType;
		private DataGridViewTextBoxColumn Duplex;
		private DataGridViewButtonColumn editButtonColumn;
		private DataGridViewButtonColumn buyButtonColumn;
		private Button FromTheEndB;
	}
}