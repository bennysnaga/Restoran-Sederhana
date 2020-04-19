/*
 * Created by SharpDevelop.
 * User: LENOVO
 * Date: 07/12/2018
 * Time: 08.37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace crud
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.TextBox();
			this.nama = new System.Windows.Forms.TextBox();
			this.btnTambah = new System.Windows.Forms.Button();
			this.btnUbah = new System.Windows.Forms.Button();
			this.btnHapus = new System.Windows.Forms.Button();
			this.btnKoneksi = new System.Windows.Forms.Button();
			this.txt = new System.Windows.Forms.Label();
			this.txt2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pesanan = new System.Windows.Forms.TextBox();
			this.harga = new System.Windows.Forms.TextBox();
			this.waktu = new System.Windows.Forms.TextBox();
			this.tanggal = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(328, 78);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(939, 462);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellContentClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(34, 122);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 28);
			this.label1.TabIndex = 1;
			this.label1.Text = "ID";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(34, 156);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 28);
			this.label2.TabIndex = 2;
			this.label2.Text = "nama";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(33, 188);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 28);
			this.label3.TabIndex = 3;
			this.label3.Text = "Jumlah Pesanan";
			// 
			// id
			// 
			this.id.Location = new System.Drawing.Point(148, 118);
			this.id.Margin = new System.Windows.Forms.Padding(4);
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(125, 22);
			this.id.TabIndex = 4;
			// 
			// nama
			// 
			this.nama.Location = new System.Drawing.Point(148, 153);
			this.nama.Margin = new System.Windows.Forms.Padding(4);
			this.nama.Name = "nama";
			this.nama.Size = new System.Drawing.Size(125, 22);
			this.nama.TabIndex = 5;
			// 
			// btnTambah
			// 
			this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnTambah.Location = new System.Drawing.Point(34, 321);
			this.btnTambah.Margin = new System.Windows.Forms.Padding(4);
			this.btnTambah.Name = "btnTambah";
			this.btnTambah.Size = new System.Drawing.Size(100, 28);
			this.btnTambah.TabIndex = 7;
			this.btnTambah.Text = "Add";
			this.btnTambah.UseVisualStyleBackColor = false;
			this.btnTambah.Click += new System.EventHandler(this.BtnTambahClick);
			// 
			// btnUbah
			// 
			this.btnUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnUbah.Location = new System.Drawing.Point(34, 380);
			this.btnUbah.Margin = new System.Windows.Forms.Padding(4);
			this.btnUbah.Name = "btnUbah";
			this.btnUbah.Size = new System.Drawing.Size(100, 28);
			this.btnUbah.TabIndex = 8;
			this.btnUbah.Text = "Update";
			this.btnUbah.UseVisualStyleBackColor = false;
			this.btnUbah.Click += new System.EventHandler(this.BtnUbahClick);
			// 
			// btnHapus
			// 
			this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnHapus.Location = new System.Drawing.Point(173, 321);
			this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
			this.btnHapus.Name = "btnHapus";
			this.btnHapus.Size = new System.Drawing.Size(100, 28);
			this.btnHapus.TabIndex = 9;
			this.btnHapus.Text = "Delete";
			this.btnHapus.UseVisualStyleBackColor = false;
			this.btnHapus.Click += new System.EventHandler(this.BtnHapusClick);
			// 
			// btnKoneksi
			// 
			this.btnKoneksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnKoneksi.Location = new System.Drawing.Point(173, 380);
			this.btnKoneksi.Margin = new System.Windows.Forms.Padding(4);
			this.btnKoneksi.Name = "btnKoneksi";
			this.btnKoneksi.Size = new System.Drawing.Size(100, 28);
			this.btnKoneksi.TabIndex = 10;
			this.btnKoneksi.Text = "Connect";
			this.btnKoneksi.UseVisualStyleBackColor = false;
			this.btnKoneksi.Click += new System.EventHandler(this.BtnKoneksiClick);
			// 
			// txt
			// 
			this.txt.Location = new System.Drawing.Point(33, 217);
			this.txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.txt.Name = "txt";
			this.txt.Size = new System.Drawing.Size(73, 28);
			this.txt.TabIndex = 11;
			this.txt.Text = "harga";
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(33, 256);
			this.txt2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(69, 28);
			this.txt2.TabIndex = 13;
			this.txt2.Text = "waktu";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new System.Drawing.Point(217, 19);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(462, 55);
			this.label4.TabIndex = 17;
			this.label4.Text = "Restoran tempat makan";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(34, 288);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 18;
			this.label5.Text = "tanggal";
			// 
			// pesanan
			// 
			this.pesanan.Location = new System.Drawing.Point(148, 188);
			this.pesanan.Name = "pesanan";
			this.pesanan.Size = new System.Drawing.Size(125, 22);
			this.pesanan.TabIndex = 19;
			// 
			// harga
			// 
			this.harga.Location = new System.Drawing.Point(148, 220);
			this.harga.Name = "harga";
			this.harga.Size = new System.Drawing.Size(125, 22);
			this.harga.TabIndex = 20;
			// 
			// waktu
			// 
			this.waktu.Location = new System.Drawing.Point(148, 253);
			this.waktu.Name = "waktu";
			this.waktu.Size = new System.Drawing.Size(125, 22);
			this.waktu.TabIndex = 21;
			// 
			// tanggal
			// 
			this.tanggal.Location = new System.Drawing.Point(148, 285);
			this.tanggal.Name = "tanggal";
			this.tanggal.Size = new System.Drawing.Size(125, 22);
			this.tanggal.TabIndex = 22;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.HotTrack;
			this.ClientSize = new System.Drawing.Size(1293, 674);
			this.Controls.Add(this.tanggal);
			this.Controls.Add(this.waktu);
			this.Controls.Add(this.harga);
			this.Controls.Add(this.pesanan);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt);
			this.Controls.Add(this.btnKoneksi);
			this.Controls.Add(this.btnHapus);
			this.Controls.Add(this.btnUbah);
			this.Controls.Add(this.btnTambah);
			this.Controls.Add(this.nama);
			this.Controls.Add(this.id);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "crud";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox tanggal;
		private System.Windows.Forms.TextBox waktu;
		private System.Windows.Forms.TextBox harga;
		private System.Windows.Forms.TextBox pesanan;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label txt2;
		private System.Windows.Forms.Label txt;
		private System.Windows.Forms.Button btnKoneksi;
		private System.Windows.Forms.Button btnHapus;
		private System.Windows.Forms.Button btnUbah;
		private System.Windows.Forms.Button btnTambah;
		private System.Windows.Forms.TextBox nama;
		private System.Windows.Forms.TextBox id;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}
