/*
 * Created by SharpDevelop.
 * User: User
 * Date: 06/03/2022
 * Time: 20:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pertemuan4
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
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			MessageBox.Show("Nama\t\t: " + this.txtNama.Text + "\nNIM\t\t: " + this.txtNIM.Text + "\nKelas\t\t: " + this.txtKelas.Text + "\nMata Kuliah\t: " + this.txtMatkul.Text);
		}
	}
}
