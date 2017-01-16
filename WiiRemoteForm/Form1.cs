using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WiimoteLib;

namespace WiiRemoteForm
{
    public partial class Form1 : Form
    {
        Wiimote wm = new Wiimote();
        static public DateTime dt = DateTime.Now;
        static string pathDoc = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        StreamWriter sw;
        int frame = 0;

        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            Init();
            wm.WiimoteChanged += wm_WiimoteChanged;
            wm.SetReportType(InputReport.ButtonsAccel, true);
            wm.Connect();
        }
        public void Init()
        {
            //ファイル書き込み用のdirectoryを用意
            string date = dt.Year+digits(dt.Month)+digits(dt.Day)+digits(dt.Hour)+digits(dt.Minute);
            string path = pathDoc + "/HoeData/" + date;
            Directory.CreateDirectory(path);
            //ファイルを用意
            sw = new StreamWriter(path + "/Wii.csv", false);
        }

        private void wm_WiimoteChanged(object sender, WiimoteChangedEventArgs e)
        {
            WiimoteState ws = e.WiimoteState;
            WriteFile(ws);
            DrawForms(ws);
            frame++;
        }

        public void WriteFile(WiimoteState ws)
        {
            if (wiiRec.Checked)
                sw.WriteLine(frame+","+ws.AccelState.Values.X+","+ ws.AccelState.Values.Y+","+ ws.AccelState.Values.Z);
        }

        public void DrawForms(WiimoteState ws)
        {
            if (wiiRec.Checked)
            {
                ax.Text = "x軸:" + ws.AccelState.Values.X;
                ay.Text = "y軸:" + ws.AccelState.Values.Y;
                az.Text = "z軸:" + ws.AccelState.Values.Z;
            }
        }

        public String digits(int date)
        {
            if (date / 10 == 0) return "0" + date;
            else return date.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sw.Close();
        }
    }
}
