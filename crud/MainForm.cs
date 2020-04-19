using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;


namespace crud
{
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = academi; Uid= root");
        MySqlCommand mycommand = new MySqlCommand();
        MySqlDataAdapter myadapter = new MySqlDataAdapter();

		public MainForm()
		{
			InitializeComponent();
		}
		
		public bool dbOpen(){
            try{
                co.Open();

            }
            catch{
                MessageBox.Show("Tidak Terhubung");
                return false;
            }

            return true;
		}
		
		void tampildata(){
			try{
                mycommand.Connection=co;
                myadapter.SelectCommand=mycommand;
                mycommand.CommandText="select * from pesan";
                DataSet ds = new DataSet();    
                if (myadapter.Fill(ds,"dftpesan")>0){
                	dataGridView.DataSource = ds;
                    dataGridView.DataMember = "dftpesan";
                }
                co.Close();              
            }            
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
            }
        }    
		
		void BtnTambahClick(object sender, EventArgs e){
			try{
            	co.Open();
            	mycommand.Connection= co;
            	mycommand.CommandText= "insert into pesan values('"+id.Text+"','"+nama.Text+"', '"+pesanan.Text+"','"+harga.Text+"','"+waktu.Text+"','"+tanggal.Text+"')";
            	myadapter.SelectCommand = mycommand;
            	if(mycommand.ExecuteNonQuery()==1){
                	MessageBox.Show("Data berhasil dimasukkan","Informasi", MessageBoxButtons.OK,MessageBoxIcon.Information);
                	tampildata();
				}        
            	co.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }                
		}
		
		void BtnUbahClick(object sender, EventArgs e){
			try {
                co.Open();
                mycommand.CommandText="update pesan set id='"+id.Text+"', nama ='"+nama.Text+"', pesanan='"+pesanan.Text+"', harga='"+harga.Text+"', waktu='"+waktu.Text+"',tanggal='"+tanggal.Text+"' where id='"+id.Text+"'";
                myadapter.SelectCommand=mycommand;
                mycommand.ExecuteNonQuery();
                tampildata();
                co.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
		}
		
		
		void BtnHapusClick(object sender, EventArgs e){
            try{
                co.Open();
                mycommand.CommandText="delete from pesan where id = '"+id.Text+"'";
                myadapter.SelectCommand = mycommand;
                mycommand.ExecuteNonQuery();
                tampildata();
                co.Close();
            }
            catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
		}
		
		
		void BtnKoneksiClick(object sender, EventArgs e)
		{
			if(dbOpen()){
			MessageBox.Show("Terhubung");
			co.Close();
			}
		}
		
		
		void DataGridViewCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = dataGridView.Rows[e.RowIndex];
			id.Text = row.Cells[0].Value.ToString();
			nama.Text = row.Cells[1].Value.ToString();
			pesanan.Text = row.Cells[2].Value.ToString();
			harga.Text=row.Cells[3].Value.ToString();
			waktu.Text=row.Cells[4].Value.ToString();
			tanggal.Text=row.Cells[5].Value.ToString();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			tampildata();			
		}
	}
}
