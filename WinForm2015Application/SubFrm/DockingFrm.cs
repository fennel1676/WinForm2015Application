using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI;
using WeifenLuo.WinFormsUI.Docking;


namespace WinForm2015Application.SubFrm
{
    public partial class DockingFrm : Form
    {

        private LogFrm _logFrm = null;
        private MenuFrm _menuFrm = null;
        private ViewFrm _viewFrm = null;



        public DockingFrm()
        {
            InitializeComponent();
            InitializeUI();

        }


       



        private void DockingFrm_Load(object sender, EventArgs e)
        {
           // InitializeUI();


        }


        private void InitializeUI()
        {


            dockPanel1.Theme = new VS2015LightTheme();
            _menuFrm = new MenuFrm();
            _menuFrm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockLeft);
           // _menuFrm.Show(this.dockPanel1);
           //  _menuFrm.DockTo(this.dockPanel1, DockStyle.Left);
       



            _viewFrm = new ViewFrm();
            _viewFrm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.Document);



            _logFrm = new LogFrm();
            _logFrm.Show(dockPanel1, WeifenLuo.WinFormsUI.Docking.DockState.DockBottom);


            _menuFrm.TabText = "Main";
            _viewFrm.TabText = "View";
            _logFrm.TabText = "Alarm";
        }
    }
}
