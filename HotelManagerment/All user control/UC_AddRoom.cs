using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagerment.All_user_control
{
    public partial class UC_AddRoom : UserControl
    {
        Db_connect db = new Db_connect();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = db.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtRoomNo.Text))
            {
                lblErrorNumber.Visible = true;
                return;
            }
            else
                lblErrorNumber.Visible = false;
            if (String.IsNullOrEmpty(txtType.Text))
            {
                lblErrorType.Visible = true;
                return;
            }
            else
                lblErrorType.Visible = false;
            if (String.IsNullOrEmpty(txtBed.Text))
            {
                lblErrorBed.Visible = true;
                return;
            }
            else
                lblErrorBed.Visible = false;
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                lblErrorPrice.Visible = true;
                return;
            }


            else
                lblErrorPrice.Visible = false;
            String room_no = txtRoomNo.Text;
            String type = txtType.Text;
            String bed = txtBed.Text;
            Int64 price = Convert.ToInt64(txtPrice.Text);

            query = "Insert into rooms ( roomNo, roomType, bed, price ) values ( '" + room_no + "' , '" + type + "' , '" + bed + "', '" + price + "' )";
            db.setData(query, "Add successfully");


            UC_AddRoom_Load(this, null);
            clearAll();
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho phép các ký tự điều khiển như backspace và các ký tự số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtRoomNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void clearAll()
        {
            txtRoomNo.Clear();
            txtType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }
}
