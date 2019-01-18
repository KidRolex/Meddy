/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 11/12/2018
 * Time: 5:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Meddy
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int loopStart;
			int loopEnd;
			int multiplyBy;
			int answer;
 
			loopStart = int.Parse(textBox1.Text);
			loopEnd = int.Parse(textBox2.Text);
			multiplyBy = int.Parse(textBox3.Text);
			
			for (int i = loopStart; i <= loopEnd; i++)
			{
				answer = multiplyBy * i;
				
				listBox1.Items.Add(i + "times" + multiplyBy + "=" + answer.ToString() );
			}
		}			
		
		
		void Button2Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
		}
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		Form1 secondForm = new Form1();
		
		void Button4Click(object sender, EventArgs e)
		{
			Form1 secondForm = new Form1();
			secondForm.Show();
		}
		}
	}

