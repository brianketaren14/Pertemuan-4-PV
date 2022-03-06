/*
 * Created by SharpDevelop.
 * User: User
 * Date: 06/03/2022
 * Time: 20:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace pertemuan4
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtNama = new System.Windows.Forms.TextBox();
			this.txtKelas = new System.Windows.Forms.TextBox();
			this.txtNIM = new System.Windows.Forms.TextBox();
			this.txtMatkul = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(41, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nama";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(41, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "NIM";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(41, 115);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Kelas";
			this.label3.Click += new System.EventHandler(this.Label3Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(41, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Mata Kuliah";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(137, 179);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// txtNama
			// 
			this.txtNama.Location = new System.Drawing.Point(137, 43);
			this.txtNama.Name = "txtNama";
			this.txtNama.Size = new System.Drawing.Size(234, 20);
			this.txtNama.TabIndex = 5;
			// 
			// txtKelas
			// 
			this.txtKelas.Location = new System.Drawing.Point(137, 115);
			this.txtKelas.Name = "txtKelas";
			this.txtKelas.Size = new System.Drawing.Size(234, 20);
			this.txtKelas.TabIndex = 6;
			// 
			// txtNIM
			// 
			this.txtNIM.Location = new System.Drawing.Point(137, 76);
			this.txtNIM.Name = "txtNIM";
			this.txtNIM.Size = new System.Drawing.Size(234, 20);
			this.txtNIM.TabIndex = 7;
			// 
			// txtMatkul
			// 
			this.txtMatkul.Location = new System.Drawing.Point(137, 150);
			this.txtMatkul.Name = "txtMatkul";
			this.txtMatkul.Size = new System.Drawing.Size(234, 20);
			this.txtMatkul.TabIndex = 8;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 263);
			this.Controls.Add(this.txtMatkul);
			this.Controls.Add(this.txtNIM);
			this.Controls.Add(this.txtKelas);
			this.Controls.Add(this.txtNama);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "pertemuan4";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtMatkul;
		private System.Windows.Forms.TextBox txtNIM;
		private System.Windows.Forms.TextBox txtKelas;
		private System.Windows.Forms.TextBox txtNama;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
