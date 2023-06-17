using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Course
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Product p = new Product();
		decimal total = 0;

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("122: Lays; \n 233: Coca-Cola; \n 544: Kurassan;");
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			odenisBox.Text += btn.Text;
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			odenisBox.Text += btn.Text;
		}

		private void btn3_Click(object sender, EventArgs e)
		{

			Button btn = (Button)sender;
			odenisBox.Text += btn.Text;
		}

		private void btn4_Click(object sender, EventArgs e)
		{

			Button btn = (Button)sender;
			odenisBox.Text += btn.Text;
		}

		private void btn5_Click(object sender, EventArgs e)
		{

			Button btn = (Button)sender;
			odenisBox.Text += btn.Text;
		}

		private void btn6_Click(object sender, EventArgs e)
		{

			Button btn = (Button)sender;
			odenisBox.Text += btn.Text;
		}

		private void btn7_Click(object sender, EventArgs e)
		{

			Button btn = (Button)sender;
			odenisBox.Text += btn.Text;
		}

		private void btn8_Click(object sender, EventArgs e)
		{

			Button btn = (Button)sender;
			odenisBox.Text += btn.Text;
		}

		private void btn9_Click(object sender, EventArgs e)
		{

			Button btn = (Button)sender;
			odenisBox.Text += btn.Text;
		}

		private void btnNoqte_Click(object sender, EventArgs e)
		{

			Button btn = (Button)sender;
			odenisBox.Text += btn.Text;
		}

		private void btn0_Click(object sender, EventArgs e)
		{

			Button btn = (Button)sender;
			odenisBox.Text += btn.Text;
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			odenisBox.Clear();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			if (kodBox.Text == "122")
			{
				object[] list = { p.Name = "Lays", p.Price = 2.56M };

				foreach (var item in list)
				{
					productListBox.Items.Add(item);
				}

				total = total + p.Price;
			}
			else if (kodBox.Text == "233")
			{
				object[] list = { p.Name = "Coca-Cola", p.Price = 1.90M };

				foreach (var item in list)
				{
					productListBox.Items.Add(item);
				}
				total = total + p.Price;
			}

			else if (kodBox.Text == "544")
			{
				object[] list = { p.Name = "Kurassan", p.Price = 1.00M };

				foreach (var item in list)
				{
					productListBox.Items.Add(item);
				}
				total = total + p.Price;
			}
			else
			{
				MessageBox.Show("Bu məhsul anbarda mövcud deyil!");
			}

			umumiMeb.Text = total.ToString() + " " + "manat";
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			decimal money = Convert.ToDecimal(odenisBox.Text);

			if (money<total)
			{
				MessageBox.Show("Odəniləcək məbləğ ümumi məbləğdən az ola bilməz!");
				odenilenMeb.ForeColor = Color.Red;
				odenilenMeb.Text=money.ToString()+" " + "manat";
			}
			else
			{
				decimal res = money - total;
				qaytarilanMeb.Text = res.ToString() + " " + "manat";
				odenilenMeb.ForeColor = Color.Black;
				odenilenMeb.Text=money.ToString() + " " + "manat";

			}
		}
	}
}
