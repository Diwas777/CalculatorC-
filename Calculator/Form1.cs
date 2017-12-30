using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{ 
	public partial class Form1 : Form
	{
		Double result = 0;
		string operationPerformed = "";
		bool isoperationPerformed = false;
		public Form1() 
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			MessageBox.Show("hello");
			
		}

		private void button_click(object sender, EventArgs e)
		{
			if (textBox1.Text == "0" || isoperationPerformed)
				textBox1.Text = "";
			isoperationPerformed = false;
			Button button=(Button)sender;
			if(button.Text==".")
			{
				if (!textBox1.Text.Contains("."))
				{
					textBox1.Text += button.Text;
	
				}
			}
			else
			textBox1.Text += button.Text;
	
			
		}

		

		private void button5_Click(object sender, EventArgs e)
		{ //for CE
			textBox1.Text = "0";
		}

		private void button10_Click(object sender, EventArgs e)
		{//for C
			textBox1.Text = "0";
			result = 0;
		}

		private void equal_click(object sender, EventArgs e)
		{

			switch(operationPerformed)
			{
				case "+":
					textBox1.Text = (result + Double.Parse(textBox1.Text)).ToString();
					break;
				case "-":
					textBox1.Text = (result - Double.Parse(textBox1.Text)).ToString();
					break;
				case "/":
					textBox1.Text = (result / Double.Parse(textBox1.Text)).ToString();
					break;
				case "*":
					textBox1.Text = (result * Double.Parse(textBox1.Text)).ToString();
					break;
				default:
					break;
				
			}
			result = Double.Parse(textBox1.Text);
			current_operation.Text = "";
		}

		private void operator_click(object sender, EventArgs e)
		{
			

			Button button = (Button)sender;
			

			if (result!=0)
			{
				button20.PerformClick();
				operationPerformed = button.Text;
			current_operation.Text = result + " " + operationPerformed;
				isoperationPerformed = true;
			}
			else
			{
				operationPerformed = button.Text;
				result = Double.Parse(textBox1.Text);
				current_operation.Text = result + " " + operationPerformed;
				isoperationPerformed = true;
			}

		}
	}
}
