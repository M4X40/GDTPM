using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using GDPackLibrary.Properties;
using System.Text.RegularExpressions;

namespace GDPackLibrary
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			LoadingAnim();
		}

		private int amount = 0;
		
		private void Timer_Tick(object sender, EventArgs e)
		{
			if (amount == 0 || amount == 4)
			{
				label2.Text = "Loading.";
			}
			else if (amount == 1 || amount == 5)
			{
				label2.Text = "Loading..";
			}
			else if (amount == 2 || amount == 6)
			{
				label2.Text = "Loading...";
			}
			else if (amount == 3 || amount == 7)
			{
				label2.Text = "Loading";
			}
			else if (amount == 8)
			{
				LoadingTimer.Interval = 50;
			}
			else if (amount == 9)
			{
				label2.Text = "oadin";
			}
			else if (amount == 10)
			{
				label2.Text = "adi";
			}
			else if (amount == 11)
			{
				label2.Text = "d";
			}
			else if (amount == 12)
			{
				label2.Text = "";
				LoadingTimer.Interval = 100;
			}
			else if (amount == 13)
			{
				label2.Text = "d";
				LoadingTimer.Interval = 100;
			}
			else if (amount == 14)
			{
				label2.Text = "do";
			}
			else if (amount == 15)
			{
				label2.Text = "don";
			}
			else if (amount == 16)
			{
				label2.Text = "done";
			}
			else if (amount == 17)
			{
				label2.Text = "done!";
				LoadingTimer.Interval = 750;
			}
			else if (amount == 18)
			{
				LoadingTimer.Interval = 50;
			}
			else if (amount == 19)
			{
				label2.Text = "one";
			}
			else if (amount == 20)
			{
				label2.Text = "n";
			}
			else if (amount == 21)
			{
				label2.Text = "";
				label2.Visible = false;
				LoadingTimer.Stop();
			}
			amount += 1;
			if (amount <= 20)
			{
				this.Text = "GD Pack Library | " + (label2.Text);
			} else
			{
				this.Text = "GD Pack Library";
			}
			label2.Location = new Point((this.Width / 2) - (label2.Width / 2), (this.Height / 2) - (label2.Height / 2) - 27);

		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void Form1_ResizeEnd(object sender, EventArgs e)
		{
			label2.Location = new Point((this.Width / 2) - (label2.Width / 2), (this.Height / 2) - (label2.Height / 2) - 27);
		}
	}
}
