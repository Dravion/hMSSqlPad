using System;
using System.Windows.Forms;

namespace hMSSql
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_connect_Click(object sender, EventArgs e)
        {
            var oApp = new hMailServer.Application();

            if (oApp.Authenticate(ed_usr.Text, ed_pwd.Text) == null) {
                MessageBox.Show(@"Username / Password Wrong", @"Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            } else {

                try

                {
                    var i = oApp.Database.ExecuteSQLWithReturn(sql_pad.Text);

                    if (i != 0) return;
                    lb_status.Text = @"Query excuted without Errors [OK]";
                    lb_status.Visible = true;
                }
                catch (Exception err)
                {
                    lb_status.Text = @"Warning: Query caused a Problem [ERROR]";
                    lb_status.Visible = true;

                    MessageBox.Show(err.ToString(), @"SQL-Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            lb_status.Visible = false;
        }

        private void lb_status_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            OpenFileDialog openFile1 = new OpenFileDialog {Filter = @"SQL-Script Files|*.sql"};
            
            if (openFile1.ShowDialog() == DialogResult.OK)
                sql_pad.LoadFile(openFile1.FileName,
                    RichTextBoxStreamType.PlainText);

        }
    }
}
