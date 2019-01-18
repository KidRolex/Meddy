/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 11/12/2018
 * Time: 5:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Meddy
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(233, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "MEDDY";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(60, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "START :";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(117, 53);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(58, 20);
			this.textBox1.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(192, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "END :";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(265, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(61, 20);
			this.textBox2.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(371, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(152, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "NUMBER TO MULTIPLY :";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(516, 47);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(53, 20);
			this.textBox3.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Yellow;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(91, 93);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 28);
			this.button1.TabIndex = 7;
			this.button1.Text = "GET TABLE";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Yellow;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(477, 104);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 28);
			this.button2.TabIndex = 8;
			this.button2.Text = "RESET";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(213, 119);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(174, 238);
			this.listBox1.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.label5.Location = new System.Drawing.Point(233, 93);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(141, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "MULTIPLICATION TABLE";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label6.Location = new System.Drawing.Point(213, 360);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(184, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "CREATED BY AHMED BANKOLE";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Yellow;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(91, 254);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(84, 30);
			this.button3.TabIndex = 12;
			this.button3.Text = "EXIT";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Yellow;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(477, 254);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(90, 30);
			this.button4.TabIndex = 13;
			this.button4.Text = "ABOUT";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(579, 383);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Meddy";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
