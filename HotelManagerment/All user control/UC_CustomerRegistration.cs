using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

namespace HotelManagerment.All_user_control
{
    public partial class UC_CustomerRegistration : UserControl
    {
        Db_connect db = new Db_connect();
        String query;

        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }
        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = db.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void txtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Items.Clear();
            txtRoomNo.Items.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "' and roomType = ' " + txtRoom.Text + " ' and booked = 'NO' ";
            setComboBox(query, txtRoomNo);
        }
        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Items.Clear();
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();

        }
        int rid;

        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = " Select price, roomid from rooms where roomNo = '" + txtRoomNo.Text + " ' ";
            DataSet ds = db.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();

        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        { }


        private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnAlloteRoom_Click_1(object sender, EventArgs e)
        {
            string text = txtName.Text;
            if (!string.IsNullOrEmpty(text) &&
                !string.IsNullOrEmpty(txtContact.Text) &&
                !string.IsNullOrEmpty(txtNationality.Text) &&
                !string.IsNullOrEmpty(txtGender.Text) &&
                !string.IsNullOrEmpty(txtDob.Text) &&
                !string.IsNullOrEmpty(txtIdProof.Text) &&
                !string.IsNullOrEmpty(txtAddress.Text) &&
                !string.IsNullOrEmpty(txtCheckIn.Text) &&
                !string.IsNullOrEmpty(txtPrice.Text))
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String national = txtNationality.Text;
                String gender = txtGender.Text;
                String dob = txtDob.Text;
                String idproof = txtIdProof.Text;
                String address = txtAddress.Text;
                String checkin = txtCheckIn.Text;

                query = "insert into customer (cname, mobile, nationality, gender, dob, idproof, address, checkin, roomid) values ('" + name + "'," + mobile + ",'" + national + "','" + gender + "','" + dob + "','" + idproof + "','" + address + "','" + checkin + "'," + rid + "); update rooms set booked= 'Yes' where roomNo = '" + txtRoomNo.Text + "'";
                db.setData(query, "Room No " + txtRoomNo.Text + " Allocation Successful.");
                clearAll();
            }
            else
            {
                MessageBox.Show("All fields are mandatory.", "Information !!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.Value = DateTime.Now;
            txtIdProof.Clear();
            txtAddress.Clear();
            txtCheckIn.Value = DateTime.Now;
            txtBed.Items.Clear();
            txtRoom.Items.Clear();
            txtRoomNo.Items.Clear();
            txtPrice.Items.Clear();
        }

        private void UC_CustomerRegistration_Load(object sender, EventArgs e)
        {

        }
    }

   
}


