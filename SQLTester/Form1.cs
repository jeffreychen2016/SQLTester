using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace SQLTester
{
    public partial class frmTester : Form
    {
        OdbcConnection conn;

        public frmTester()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var connString = String.Format("Dsn={0};Uid={1};Pwd={2}", txtODBCDSN_DSN.Text, txtODBCDSN_Username.Text, txtDDBCDSN_Password.Text);
            conn = new OdbcConnection(connString);
            conn.Open();

            OdbcCommand command = null;
            OdbcDataAdapter adapter = new OdbcDataAdapter();
            DataTable table = new DataTable();

            try
            {
                command = new OdbcCommand(txtCommand.Text, conn);
                adapter.SelectCommand = command;
                adapter.Fill(table);

                // binding data
                grdRecord.DataSource = table;
                lblCount.Text = table.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In SQL Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            command.Dispose();
            adapter.Dispose();
            table.Dispose();
            conn.Close();
            conn.Dispose();
        }

        private void frmFormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void ManageCheckGroupBox(CheckBox chk, GroupBox grp)
        {
            // Make sure the CheckBox isn't in the GroupBox.
            // This will only happen the first time.
            if (chk.Parent == grp)
            {
                // Reparent the CheckBox so it's not in the GroupBox.
                grp.Parent.Controls.Add(chk);

                // Adjust the CheckBox's location.
                chk.Location = new Point(
                    chk.Left + grp.Left,
                    chk.Top + grp.Top);

                // Move the CheckBox to the top of the stacking order.
                chk.BringToFront();
            }

            // Enable or disable the GroupBox.
            grp.Enabled = chk.Checked;
        }

        private void chkODBC_CheckedChanged(object sender, EventArgs e)
        {
            ManageCheckGroupBox(chkODBCDSN, grpODBCDSNConfig);
        }

        private void grpODBCConfig_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtODBCDSN_DSN.Clear();
            txtODBCDSN_Username.Clear();
            txtDDBCDSN_Password.Clear();
        }

        private void txtODBCDSN_DSN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNextTab_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[tabControl1.TabPages.Count - 1];
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
