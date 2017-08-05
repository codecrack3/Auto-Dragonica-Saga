using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using WindowsInput;
using System.IO;

namespace auto_final
{
    public partial class Form1 : Form
    {
        private bool _stopLoop;
        

        public Form1()
        {
            InitializeComponent();
           // get_info();

        }
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);




        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool ReadProcessMemory(IntPtr process, IntPtr baseAddress, [Out] byte[] buffer, int size,
            out IntPtr bytesRead);

        public static long ReadInt64(IntPtr process, IntPtr baseAddress)
        {
            var buffer = new byte[8];
            IntPtr bytesRead;
            ReadProcessMemory(process, baseAddress, buffer, 4, out bytesRead);
            return BitConverter.ToInt64(buffer, 0);
        }

        private static ProcessModule GetProcessModule(Process process, string moduleName)
        {
            foreach (ProcessModule module in process.Modules)
            {
                if (module.ModuleName == moduleName)
                {
                    return module;
                }
            }
            return null;
        }

        public static long GetRealAddress(IntPtr process, IntPtr baseAddress, int[] offsets)
        {
            var address = baseAddress.ToInt64();
            foreach (var offset in offsets)
            {
                address = ReadInt64(process, (IntPtr)address) + offset;

            }
            return address;
        }
       
        public void get_info()
        {
            // Console.WriteLine(Environment.Is64BitProcess);

            // Get the first Chrome process that contains a module named "pepflashplayer.dll".
            var chromeProcess =
                Process.GetProcessesByName("dragonsaga")
                    .FirstOrDefault();

            if (chromeProcess != null)
            {
                var buffer = new byte[8];
                var buffer2 = new byte[8];
                IntPtr lpsize;
                var flashPlayerModule = GetProcessModule(chromeProcess, "dragonsaga.exe");
                var baseAddress = flashPlayerModule.BaseAddress.ToInt64() + 0x0140C9D4;
                var offsets = new[] { 0x58, 0xc, 0x0, 0x4, 0x10 };
                var realAddress = GetRealAddress(chromeProcess.Handle, (IntPtr)baseAddress, offsets);

                var baseAddress2 = flashPlayerModule.BaseAddress.ToInt64() + 0x0140C9D8;
                var offsets2 = new[] { 0xC, 0x0, 0x4, 0x8, 0x10 };
                var realAddress2 = GetRealAddress(chromeProcess.Handle, (IntPtr)baseAddress2, offsets2);

                //Console.WriteLine(realAddress.ToString("X"));
               // while (true)
                //{
                    var value = ReadProcessMemory(chromeProcess.Handle, (IntPtr)realAddress, buffer, 4, out lpsize);
                    var heahlt = BitConverter.ToInt32(buffer, 0);
                    var value2 = ReadProcessMemory(chromeProcess.Handle, (IntPtr)realAddress2, buffer2, 4, out lpsize);
                    var mana = BitConverter.ToInt32(buffer2, 0);
                    //Console.WriteLine("Health: {0}", heahlt.ToString());
                    hpl.Text = heahlt.ToString();
                    mpl.Text = mana.ToString();
                    if(int.Parse(hpl.Text) <= int.Parse(dnhp.Text))
                {
                    anmau("hp");
                }
                if (int.Parse(mpl.Text) <= int.Parse(dnmp.Text))
                {
                    anmau("mp");
                }
                //Console.WriteLine("Mana: {0}", mana.ToString());

                //Thread.Sleep(1000);
                // Console.Clear();

                // }

                //Console.ReadLine();

            }
    }
        public void anmau(string k)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "services_heath.exe";
            startInfo.Arguments = "/"+k;
            process.StartInfo = startInfo;
            process.Start();
        }
        public void send_key()
        {
            string className = "Gamebryo Application";
            string windowName = "Dragon Saga (Patch Ver : 0.5.79 - Game Ver : 10.2.0.4) ";
            IntPtr IE = FindWindow(className, windowName);
            if (IE == IntPtr.Zero)
            {
                return;
            }
            SetForegroundWindow(IE);
            keybd_event((byte)Keys.X, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
            Thread.Sleep(200);
            //releases the key  
            keybd_event((byte)Keys.X, 0, 2, 0);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if(File.Exists(@"D:\config.ini") == true)
            {
                
                INIFile inif = new INIFile("D:\\config.ini");
                dnhp.Text = inif.Read("config_auto", "dnhp");
                key_dnhp.Text = inif.Read("config_auto", "key_dnhp");
                dnmp.Text = inif.Read("config_auto", "dnmp");
                key_dnmp.Text = inif.Read("config_auto", "key_dnmp");
                dl1.Text = inif.Read("config_auto", "dl1");
                key1.Text = inif.Read("config_auto", "key1");
                dl2.Text = inif.Read("config_auto", "dl2");
                key2.Text = inif.Read("config_auto", "key2");
                dl3.Text = inif.Read("config_auto", "dl3");
                key3.Text = inif.Read("config_auto", "key3");
                text_x.Text = inif.Read("config_auto", "d_x");
                text_y.Text = inif.Read("config_auto", "d_y");
                if (inif.Read("config_auto", "stand_only") == "1")
                {
                    standonl.Checked = true;
                }
                else
                {
                    standonl.Checked = false;
                }
                if (inif.Read("config_auto", "not_attack") == "1")
                {
                    notx.Checked = true;
                }
                else
                {
                    notx.Checked = false;
                }
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(write_ini())
            {
                _stopLoop = false;
                button2.Enabled = true;
                button1.Enabled = false;
                Process.Start("auto_services");
                while (_stopLoop == false)
                {
                    await Task.Run(() => get_info());

                }
            }
            else
            {
                MessageBox.Show("Bạn phải config cho đúng LOL !!!!!!");
            }
          
                
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button1.Enabled != true)
            {
                _stopLoop = true;
                button2.Enabled = false;
                button1.Enabled = true;
                foreach (var process in Process.GetProcessesByName("auto_services"))
                {
                    process.Kill();
                }
            }
            else
            {
                MessageBox.Show("LOL ! Start not start :v ");
            }
            
        }
        public bool write_ini()
        {
            INIFile inif = new INIFile("D:\\config.ini");
            if (dnhp.Text != "" && key_dnhp.Text != "" && dnmp.Text != "" && key_dnmp.Text != "")
                {
                inif.Write("config_auto", "dnhp", dnhp.Text);
                inif.Write("config_auto", "key_dnhp", key_dnhp.Text);
                inif.Write("config_auto", "dnmp", dnmp.Text);
                inif.Write("config_auto", "key_dnmp", key_dnmp.Text);
                inif.Write("config_auto", "dl1", dl1.Text);
                inif.Write("config_auto", "key1", key1.Text);
                inif.Write("config_auto", "dl2", dl2.Text);
                inif.Write("config_auto", "key2", key2.Text);
                inif.Write("config_auto", "dl3", dl3.Text);
                inif.Write("config_auto", "key3", key3.Text);
               
                if(standonl.Checked == true)
                {
                    inif.Write("config_auto", "stand_only", "1");
                    inif.Write("config_auto", "d_x", "");
                    inif.Write("config_auto", "d_y", "");
                }
                else
                {
                    inif.Write("config_auto", "d_x", text_x.Text);
                    inif.Write("config_auto", "d_y", text_y.Text);
                    inif.Write("config_auto", "stand_only", "0");
                }
                if (notx.Checked == true)
                {
                    inif.Write("config_auto", "not_attack", "1");
                   
                }
                else
                {
                   
                    inif.Write("config_auto", "not_attack", "0");
                }
                return true;
            }
            else
            {
                MessageBox.Show("Bạn không được bỏ trống ở trường HP và MP !");
                return false;
            }
            

   
               
               
            
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (standonl.Checked == true)
            {

                this.text_x.Enabled = false;
                this.text_y.Enabled = false;
            }
            else
            {
                this.text_x.Enabled = true;
                this.text_y.Enabled = true;
            }
        }

        private void notx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dnhp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void dnmp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void dl1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void dl2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void dl3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void text_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void text_y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
