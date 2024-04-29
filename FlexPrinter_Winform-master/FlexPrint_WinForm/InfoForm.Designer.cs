using System.Drawing.Printing;

namespace FlexPrint_WinForm
{
	partial class InfoForm
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
			Indotextbox = new RichTextBox();
			HeaderInfo = new TextBox();
			fontsizeCombobox = new ComboBox();
			ChangeFontsize = new Button();
			SuspendLayout();
			// 
			// Indotextbox
			// 
			Indotextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			Indotextbox.BackColor = SystemColors.ActiveCaption;
			Indotextbox.BorderStyle = BorderStyle.None;
			Indotextbox.Location = new Point(12, 84);
			Indotextbox.Name = "Indotextbox";
			Indotextbox.Size = new Size(776, 367);
			Indotextbox.TabIndex = 0;
			Indotextbox.Text = "";
			// 
			// HeaderInfo
			// 
			HeaderInfo.BackColor = SystemColors.ActiveCaption;
			HeaderInfo.BorderStyle = BorderStyle.None;
			HeaderInfo.Location = new Point(369, 12);
			HeaderInfo.Name = "HeaderInfo";
			HeaderInfo.Size = new Size(68, 20);
			HeaderInfo.TabIndex = 1;
			HeaderInfo.Text = "FlexPrint";
			// 
			// fontsizeCombobox
			// 
			fontsizeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
			fontsizeCombobox.FormattingEnabled = true;
			fontsizeCombobox.Items.AddRange(new object[] { "9","12","16", "20", "32" });
			fontsizeCombobox.SelectedIndex = 0;
			fontsizeCombobox.Location = new Point(12, 12);
			fontsizeCombobox.Name = "fontsizeCombobox";
			fontsizeCombobox.Size = new Size(82, 28);
			fontsizeCombobox.TabIndex = 3;
			// 
			// ChangeFontsize
			// 
			ChangeFontsize.Location = new Point(100, 11);
			ChangeFontsize.Name = "ChangeFontsize";
			ChangeFontsize.Size = new Size(73, 29);
			ChangeFontsize.TabIndex = 4;
			ChangeFontsize.Text = "Ok";
			ChangeFontsize.UseVisualStyleBackColor = true;
			ChangeFontsize.Click += ChangeFontsize_Click;
			// 
			// InfoForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(800, 450);
			Controls.Add(ChangeFontsize);
			Controls.Add(fontsizeCombobox);
			Controls.Add(HeaderInfo);
			Controls.Add(Indotextbox);
			Name = "InfoForm";
			Text = "InfoForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private RichTextBox Indotextbox;
		private TextBox HeaderInfo;
		private ComboBox fontsizeCombobox;
		private Button ChangeFontsize;
	}
}