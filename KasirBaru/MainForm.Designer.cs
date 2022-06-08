/*
 * Created by SharpDevelop.
 * User: Belintawati Zelda
 * Date: 24/05/2022
 * Time: 14:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace KasirBaru
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
			this.KodeBarang = new System.Windows.Forms.Label();
			this.NamaBarang = new System.Windows.Forms.Label();
			this.HargaJual = new System.Windows.Forms.Label();
			this.HargaBeli = new System.Windows.Forms.Label();
			this.JumlahBarang = new System.Windows.Forms.Label();
			this.SatuanBarang = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// KodeBarang
			// 
			this.KodeBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.KodeBarang.Location = new System.Drawing.Point(11, 56);
			this.KodeBarang.Name = "KodeBarang";
			this.KodeBarang.Size = new System.Drawing.Size(118, 18);
			this.KodeBarang.TabIndex = 0;
			this.KodeBarang.Text = "Kode Barang";
			// 
			// NamaBarang
			// 
			this.NamaBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NamaBarang.Location = new System.Drawing.Point(11, 99);
			this.NamaBarang.Name = "NamaBarang";
			this.NamaBarang.Size = new System.Drawing.Size(118, 18);
			this.NamaBarang.TabIndex = 1;
			this.NamaBarang.Text = "Nama Barang";
			// 
			// HargaJual
			// 
			this.HargaJual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.HargaJual.Location = new System.Drawing.Point(11, 146);
			this.HargaJual.Name = "HargaJual";
			this.HargaJual.Size = new System.Drawing.Size(118, 18);
			this.HargaJual.TabIndex = 2;
			this.HargaJual.Text = "Harga Jual";
			// 
			// HargaBeli
			// 
			this.HargaBeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.HargaBeli.Location = new System.Drawing.Point(11, 190);
			this.HargaBeli.Name = "HargaBeli";
			this.HargaBeli.Size = new System.Drawing.Size(118, 18);
			this.HargaBeli.TabIndex = 3;
			this.HargaBeli.Text = "Harga Beli";
			// 
			// JumlahBarang
			// 
			this.JumlahBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.JumlahBarang.Location = new System.Drawing.Point(11, 239);
			this.JumlahBarang.Name = "JumlahBarang";
			this.JumlahBarang.Size = new System.Drawing.Size(118, 18);
			this.JumlahBarang.TabIndex = 4;
			this.JumlahBarang.Text = "Jumlah";
			// 
			// SatuanBarang
			// 
			this.SatuanBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.SatuanBarang.Location = new System.Drawing.Point(11, 290);
			this.SatuanBarang.Name = "SatuanBarang";
			this.SatuanBarang.Size = new System.Drawing.Size(118, 18);
			this.SatuanBarang.TabIndex = 5;
			this.SatuanBarang.Text = "Satuan";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(152, 54);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(262, 22);
			this.textBox1.TabIndex = 6;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.White;
			this.textBox2.Location = new System.Drawing.Point(152, 97);
			this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(262, 22);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.White;
			this.textBox3.Location = new System.Drawing.Point(152, 143);
			this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(262, 22);
			this.textBox3.TabIndex = 8;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3KeyPress);
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.White;
			this.textBox4.Location = new System.Drawing.Point(152, 188);
			this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(262, 22);
			this.textBox4.TabIndex = 9;
			this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4KeyPress);
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.White;
			this.textBox5.Location = new System.Drawing.Point(152, 237);
			this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(262, 22);
			this.textBox5.TabIndex = 10;
			this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5KeyPress);
			// 
			// comboBox1
			// 
			this.comboBox1.BackColor = System.Drawing.Color.White;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(152, 286);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(262, 24);
			this.comboBox1.TabIndex = 11;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Location = new System.Drawing.Point(483, 179);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.groupBox1.Size = new System.Drawing.Size(440, 54);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pencarian Barang";
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.White;
			this.textBox6.Location = new System.Drawing.Point(5, 20);
			this.textBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(430, 22);
			this.textBox6.TabIndex = 0;
			this.textBox6.TextChanged += new System.EventHandler(this.TextBox6TextChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button1.Location = new System.Drawing.Point(483, 262);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 30);
			this.button1.TabIndex = 13;
			this.button1.Text = "Simpan";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button2.Location = new System.Drawing.Point(596, 262);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(95, 30);
			this.button2.TabIndex = 14;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button3.Location = new System.Drawing.Point(710, 262);
			this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(95, 30);
			this.button3.TabIndex = 15;
			this.button3.Text = "Hapus";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.button4.Location = new System.Drawing.Point(828, 262);
			this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(95, 30);
			this.button4.TabIndex = 16;
			this.button4.Text = "Refresh";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(11, 330);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.Size = new System.Drawing.Size(968, 210);
			this.dataGridView1.TabIndex = 17;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(989, 550);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.SatuanBarang);
			this.Controls.Add(this.JumlahBarang);
			this.Controls.Add(this.HargaBeli);
			this.Controls.Add(this.HargaJual);
			this.Controls.Add(this.NamaBarang);
			this.Controls.Add(this.KodeBarang);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.Text = "KasirBaru";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label SatuanBarang;
		private System.Windows.Forms.Label JumlahBarang;
		private System.Windows.Forms.Label HargaBeli;
		private System.Windows.Forms.Label HargaJual;
		private System.Windows.Forms.Label NamaBarang;
		private System.Windows.Forms.Label KodeBarang;
	}
}
