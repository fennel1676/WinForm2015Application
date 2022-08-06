using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DHL.Util;
using System.Runtime.InteropServices;
using System.Threading;
using WinForm2015Application.SubFrm;

namespace WinForm2015Application
{

    struct t_Test
    {
        public int iTmp2;
        public string strTmp;
        public double dbTmp;
        public float ftTmp;


    }

    delegate int Calcu(int a, int b);


    public partial class MainFrm : Form
    {
        DockingFrm _dockFrm = null;

        Thread _thread;
        bool _isThread = false;

        t_Test tt = new t_Test();
        byte[] bTmp;

        public MainFrm()
        {
            InitializeComponent();




            _dockFrm = new DockingFrm();

            //테스트 값 대입...
            tt.dbTmp = 0.12321312313;
            tt.iTmp2 = 123123;
            tt.strTmp = "테스트1";
            tt.ftTmp = 0.123213f;

            
           // InitializeUI();

        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            string sResult = "";
            //byte[] bytes = new byte[] { 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47, 0x48 };
            //sResult = ConvertUtil.ByteArray2String(bytes, bytes.Length, 8);


            //bTmp = ConvertUtil.Object2Byte2(tt);
            //t_Test tTmp = ConvertUtil.Byte2Struct<t_Test>(bTmp);
            Calcu ca = delegate (int a, int b)
            {
                
                return a+ b;
            };

            Calcu cb = (int a, int b) => a + b;


            //int aa = 0;
            //int bb = 20;
            //int cc = 30;
            //Test1(ref aa, bb, cc);
            //int aa;
            //int bb = 20;
            //int cc = 30;
            //Test2(out aa, bb, cc);
            //Console.WriteLine("{0}", aa);

        }


        private void InitializeUI()
        {

        }


        private void Test1(ref int a , int b , int c)
        {

            a = b + c;
        }


        private void Test2(out int a, int b, int c)
        {

            a = b + c;
        }

        private void WorkThreads()
        {
            int i = 0;
            while(_isThread)
            {
                Console.WriteLine("{0}", i++);
                Thread.Sleep(100);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _isThread = false;
            _thread.Join();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            _isThread = true;
            _thread = new Thread(delegate ()
            {

                int i = 0;
                while (_isThread)
                {
                    Console.WriteLine("{0}", i++);
                    Thread.Sleep(100);
                }

                //Console.WriteLine("start");





            });
            _thread.Start();
        }

        private void btnViewer_Click(object sender, EventArgs e)
        {
           _dockFrm.ShowDialog();
        }
    }
}
