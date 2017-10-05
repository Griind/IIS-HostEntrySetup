using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace NewFulfillmentClientSetup
{
    public partial class FGS_iis_main : Form
    {
        public FGS_iis_main()
        {
            InitializeComponent();
            Load += new EventHandler(FGS_iis_main_Load);
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }
        private void FGS_iis_main_Load(object sender, System.EventArgs e)
        {
            if (!IsAdministrator())
            {
                
                Message_label.Visible = true;
                Message_label.Text = "You are not in admin mode".ToUpper();
                Message_label.ForeColor = System.Drawing.Color.Red;
                Message_label.Font = new Font("Tahoma", 15, FontStyle.Regular);
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Host_label.Text = "Host: " + Main_text_box.Text.Trim() + ".fulfillment.local";
            Path_label.Text = "Path:C:\\DEV\\TeamProject\\Fulfillment\\" + Main_text_box.Text.Trim() + "\\Development\\Source\\Fulfillment.Web";
        }
        private void TextBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

        }
        

            private void Button1_Click(object sender, EventArgs e)
        {
            if (Main_text_box.Text.Length == 0)
            {
                Message_label.ForeColor = Color.Red;
                Message_label.Text = "Text box is empty!";
                Message_label.Visible = true;
                return;
            }
            else if (!IsAdministrator())
            {
                Message_label.Visible = true;
                Message_label.Text = "App is not in admin mode".ToUpper();
                Message_label.ForeColor = System.Drawing.Color.Red;
                Message_label.Font = new Font("Tahoma", 16, FontStyle.Regular);
                return;
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure you want to proceed with " + Main_text_box.Text + "?",
                                        "Set Up IIS",
                                        MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (setupIIS(Main_text_box.Text))
                    {
                        Message_label.ForeColor = Color.ForestGreen;
                        Message_label.Text = "Success";
                        Message_label.Visible = true;
                    }
                    else
                    {
                        Message_label.ForeColor = Color.Red;
                        Message_label.Text = "Error";
                        Message_label.Visible = true;
                    }
                }
            }
        }
        private bool setupIIS(string text)
        {
            try
            {
                var host = Main_text_box.Text.Trim() + ".fulfillment.local"; ;
                var path = @"C:\DEV\TeamProject\Fulfillment\" + Main_text_box.Text.Trim() + @"\Development\Source\Fulfillment.Web";
                CreateIISSite(host, path);
                AddHostsEntry(host);
                return true;
            }
            catch (Exception e)
            {
                File.WriteAllText("C:\\", e.Message + "exception from setup IIS");
            }
            return false;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to exit?",
                                     "Exit!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) System.Windows.Forms.Application.Exit();

            Message_label.Visible = false;
        }

        private static void CreateIISSite(string host, string path)
        {
            ServerManager serverManager = new ServerManager();
            var applicationPool = serverManager.ApplicationPools.FirstOrDefault(p => p.Name == host);
            if (applicationPool == null)
            {
                applicationPool = serverManager.ApplicationPools.Add(host);
                applicationPool.ManagedPipelineMode = ManagedPipelineMode.Integrated;
                applicationPool.ProcessModel.IdentityType = ProcessModelIdentityType.SpecificUser;
                applicationPool.ProcessModel.UserName = @"***\*****";
                applicationPool.ProcessModel.Password = "******";//needs to be updated.
                applicationPool.ManagedRuntimeVersion = "v4.0";
            }

            var site = serverManager.Sites.FirstOrDefault(s => s.Name == host);
            if (site == null)
            {
                var bindingInfo = string.Format(@"{0}:{1}:{2}", "*", "80", host);
                site = serverManager.Sites.Add(host, "http", bindingInfo, path);
                site.ApplicationDefaults.ApplicationPoolName = applicationPool.Name;
            }
            serverManager.CommitChanges();
        }
        private static void AddHostsEntry(string host)
        {
            var hostsFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts");
            var exists = File.ReadAllLines(hostsFile).Any(x => !x.Trim().StartsWith("#") && x.ToLower().Contains(host.ToLower()));
            if (!exists)
            {
                File.AppendAllLines(hostsFile, new[] { string.Format("127.0.0.1		{0}", host) });
            }
        }
        public static bool IsAdministrator()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
