namespace WinForms_Course
{
	partial class Form1
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
			label1 = new Label();
			kodBox = new TextBox();
			kodBtn = new Button();
			addBtn = new Button();
			productListBox = new ListBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			groupBox1 = new GroupBox();
			button1 = new Button();
			btn0 = new Button();
			btn9 = new Button();
			btn8 = new Button();
			btn7 = new Button();
			btnNoqte = new Button();
			btn6 = new Button();
			btn5 = new Button();
			btn4 = new Button();
			btnEnter = new Button();
			btn3 = new Button();
			btn2 = new Button();
			btn1 = new Button();
			odenisBox = new TextBox();
			umumiMeb = new Label();
			odenilenMeb = new Label();
			qaytarilanMeb = new Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(91, 57);
			label1.Name = "label1";
			label1.Size = new Size(182, 37);
			label1.TabIndex = 0;
			label1.Text = "Məhsul kodu";
			// 
			// kodBox
			// 
			kodBox.Location = new Point(91, 130);
			kodBox.Name = "kodBox";
			kodBox.Size = new Size(220, 43);
			kodBox.TabIndex = 1;
			// 
			// kodBtn
			// 
			kodBtn.Location = new Point(327, 46);
			kodBtn.Name = "kodBtn";
			kodBtn.Size = new Size(250, 58);
			kodBtn.TabIndex = 2;
			kodBtn.Text = "Kod siyahısı";
			kodBtn.UseVisualStyleBackColor = true;
			kodBtn.Click += button1_Click;
			// 
			// addBtn
			// 
			addBtn.Location = new Point(327, 115);
			addBtn.Name = "addBtn";
			addBtn.Size = new Size(250, 58);
			addBtn.TabIndex = 3;
			addBtn.Text = "Əlavə et";
			addBtn.UseVisualStyleBackColor = true;
			addBtn.Click += addBtn_Click;
			// 
			// productListBox
			// 
			productListBox.FormattingEnabled = true;
			productListBox.ItemHeight = 37;
			productListBox.Location = new Point(91, 265);
			productListBox.Name = "productListBox";
			productListBox.Size = new Size(501, 374);
			productListBox.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(821, 57);
			label2.Name = "label2";
			label2.Size = new Size(215, 37);
			label2.TabIndex = 5;
			label2.Text = "Ümumi məbləğ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(800, 115);
			label3.Name = "label3";
			label3.Size = new Size(236, 37);
			label3.TabIndex = 6;
			label3.Text = "Ödənilən məbləğ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(781, 181);
			label4.Name = "label4";
			label4.Size = new Size(255, 37);
			label4.TabIndex = 7;
			label4.Text = "Qaytarılan məbləğ";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(btn0);
			groupBox1.Controls.Add(btn9);
			groupBox1.Controls.Add(btn8);
			groupBox1.Controls.Add(btn7);
			groupBox1.Controls.Add(btnNoqte);
			groupBox1.Controls.Add(btn6);
			groupBox1.Controls.Add(btn5);
			groupBox1.Controls.Add(btn4);
			groupBox1.Controls.Add(btnEnter);
			groupBox1.Controls.Add(btn3);
			groupBox1.Controls.Add(btn2);
			groupBox1.Controls.Add(btn1);
			groupBox1.Controls.Add(odenisBox);
			groupBox1.Location = new Point(692, 265);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(537, 374);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			groupBox1.Text = "Ödənişi edin";
			// 
			// button1
			// 
			button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			button1.Location = new Point(404, 42);
			button1.Name = "button1";
			button1.Size = new Size(90, 43);
			button1.TabIndex = 13;
			button1.Text = "X";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_1;
			// 
			// btn0
			// 
			btn0.Location = new Point(404, 284);
			btn0.Name = "btn0";
			btn0.Size = new Size(90, 72);
			btn0.TabIndex = 12;
			btn0.Text = "0";
			btn0.UseVisualStyleBackColor = true;
			btn0.Click += btn0_Click;
			// 
			// btn9
			// 
			btn9.Location = new Point(279, 284);
			btn9.Name = "btn9";
			btn9.Size = new Size(90, 72);
			btn9.TabIndex = 11;
			btn9.Text = "9";
			btn9.UseVisualStyleBackColor = true;
			btn9.Click += btn9_Click;
			// 
			// btn8
			// 
			btn8.Location = new Point(159, 284);
			btn8.Name = "btn8";
			btn8.Size = new Size(90, 72);
			btn8.TabIndex = 10;
			btn8.Text = "8";
			btn8.UseVisualStyleBackColor = true;
			btn8.Click += btn8_Click;
			// 
			// btn7
			// 
			btn7.Location = new Point(35, 284);
			btn7.Name = "btn7";
			btn7.Size = new Size(90, 72);
			btn7.TabIndex = 9;
			btn7.Text = "7";
			btn7.UseVisualStyleBackColor = true;
			btn7.Click += btn7_Click;
			// 
			// btnNoqte
			// 
			btnNoqte.Location = new Point(404, 197);
			btnNoqte.Name = "btnNoqte";
			btnNoqte.Size = new Size(90, 72);
			btnNoqte.TabIndex = 8;
			btnNoqte.Text = ".";
			btnNoqte.UseVisualStyleBackColor = true;
			btnNoqte.Click += btnNoqte_Click;
			// 
			// btn6
			// 
			btn6.Location = new Point(279, 197);
			btn6.Name = "btn6";
			btn6.Size = new Size(90, 72);
			btn6.TabIndex = 7;
			btn6.Text = "6";
			btn6.UseVisualStyleBackColor = true;
			btn6.Click += btn6_Click;
			// 
			// btn5
			// 
			btn5.Location = new Point(159, 197);
			btn5.Name = "btn5";
			btn5.Size = new Size(90, 72);
			btn5.TabIndex = 6;
			btn5.Text = "5";
			btn5.UseVisualStyleBackColor = true;
			btn5.Click += btn5_Click;
			// 
			// btn4
			// 
			btn4.Location = new Point(35, 197);
			btn4.Name = "btn4";
			btn4.Size = new Size(90, 72);
			btn4.TabIndex = 5;
			btn4.Text = "4";
			btn4.UseVisualStyleBackColor = true;
			btn4.Click += btn4_Click;
			// 
			// btnEnter
			// 
			btnEnter.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
			btnEnter.Location = new Point(404, 109);
			btnEnter.Name = "btnEnter";
			btnEnter.Size = new Size(90, 72);
			btnEnter.TabIndex = 4;
			btnEnter.Text = "Enter";
			btnEnter.UseVisualStyleBackColor = true;
			btnEnter.Click += btnEnter_Click;
			// 
			// btn3
			// 
			btn3.Location = new Point(279, 109);
			btn3.Name = "btn3";
			btn3.Size = new Size(90, 72);
			btn3.TabIndex = 3;
			btn3.Text = "3";
			btn3.UseVisualStyleBackColor = true;
			btn3.Click += btn3_Click;
			// 
			// btn2
			// 
			btn2.Location = new Point(159, 109);
			btn2.Name = "btn2";
			btn2.Size = new Size(90, 72);
			btn2.TabIndex = 2;
			btn2.Text = "2";
			btn2.UseVisualStyleBackColor = true;
			btn2.Click += btn2_Click;
			// 
			// btn1
			// 
			btn1.Location = new Point(35, 109);
			btn1.Name = "btn1";
			btn1.Size = new Size(90, 72);
			btn1.TabIndex = 1;
			btn1.Text = "1";
			btn1.UseVisualStyleBackColor = true;
			btn1.Click += btn1_Click;
			// 
			// odenisBox
			// 
			odenisBox.Location = new Point(35, 42);
			odenisBox.Name = "odenisBox";
			odenisBox.Size = new Size(334, 43);
			odenisBox.TabIndex = 0;
			// 
			// umumiMeb
			// 
			umumiMeb.AutoSize = true;
			umumiMeb.Location = new Point(1078, 57);
			umumiMeb.Name = "umumiMeb";
			umumiMeb.Size = new Size(72, 37);
			umumiMeb.TabIndex = 9;
			umumiMeb.Text = "0.00";
			// 
			// odenilenMeb
			// 
			odenilenMeb.AutoSize = true;
			odenilenMeb.Location = new Point(1078, 115);
			odenilenMeb.Name = "odenilenMeb";
			odenilenMeb.Size = new Size(72, 37);
			odenilenMeb.TabIndex = 10;
			odenilenMeb.Text = "0.00";
			// 
			// qaytarilanMeb
			// 
			qaytarilanMeb.AutoSize = true;
			qaytarilanMeb.Location = new Point(1078, 181);
			qaytarilanMeb.Name = "qaytarilanMeb";
			qaytarilanMeb.Size = new Size(72, 37);
			qaytarilanMeb.TabIndex = 11;
			qaytarilanMeb.Text = "0.00";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(16F, 37F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Silver;
			ClientSize = new Size(1341, 693);
			Controls.Add(qaytarilanMeb);
			Controls.Add(odenilenMeb);
			Controls.Add(umumiMeb);
			Controls.Add(groupBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(productListBox);
			Controls.Add(addBtn);
			Controls.Add(kodBtn);
			Controls.Add(kodBox);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
			Margin = new Padding(7);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox kodBox;
		private Button kodBtn;
		private Button addBtn;
		private ListBox productListBox;
		private Label label2;
		private Label label3;
		private Label label4;
		private GroupBox groupBox1;
		private Label umumiMeb;
		private Label odenilenMeb;
		private Label qaytarilanMeb;
		private Button btn0;
		private Button btn9;
		private Button btn8;
		private Button btn7;
		private Button btnNoqte;
		private Button btn6;
		private Button btn5;
		private Button btn4;
		private Button btnEnter;
		private Button btn3;
		private Button btn2;
		private Button btn1;
		private TextBox odenisBox;
		private Button button1;
	}
}