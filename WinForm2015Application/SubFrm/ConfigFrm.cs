using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm2015Application.SubFrm
{
    public partial class ConfigFrm : Form
    {
        public ConfigFrm()
        {
            InitializeComponent();
        }



        //private void UpdateConfigDisplay()
        //{
        //    grdConfig.AllowUserToAddRows = false;

        //    lblDescription.Text = m_ConfigMode.ToString();
        //    string query = "";
        //    switch (m_ConfigMode)
        //    {
        //        case EConfigMode.AlarmCode:
        //            grdConfig.AllowUserToAddRows = true;
        //            query = "SELECT alarm_id, alarm_code, eq_id, unit_id, alarm_text FROM alarm_info ";
        //            break;
        //        case EConfigMode.CancelCode:
        //            grdConfig.AllowUserToAddRows = true;
        //            query = "SELECT code, description FROM cancel_code ";
        //            break;
        //        case EConfigMode.PMCode:
        //            grdConfig.AllowUserToAddRows = true;
        //            query = "SELECT pm_code, description, note FROM pm_info ";
        //            break;
        //        case EConfigMode.EqLayerModel:
        //            query = "SELECT module_id, layer, parent_module_id, description FROM module_info ";
        //            break;
        //        case EConfigMode.EqStateModel:
        //            break;
        //        case EConfigMode.ProcStateModel:
        //            break;
        //        case EConfigMode.HostIF:
        //            query = "SELECT cfg_file FROM host_info ";
        //            break;
        //        case EConfigMode.EqIF:
        //            query = "SELECT eq_id, ip, port, connection_mode, app_path, app_argument FROM eq_info ";
        //            break;
        //        case EConfigMode.LabellerIF:
        //            break;
        //        case EConfigMode.StateVariable:
        //            grdConfig.AllowUserToAddRows = true;
        //            query = "SELECT svid, svname, unit_id, description FROM sv ";
        //            break;
        //        case EConfigMode.EqConstant:
        //            grdConfig.AllowUserToAddRows = true;
        //            query = "SELECT ecid, ec_name, ecdef, ecsll, ecsul, ecwll, ecwul, unit_id FROM ec ";
        //            break;
        //        case EConfigMode.EqOnlineParam:
        //            query = "SELECT eoid, eomd, eov, unit_id FROM eo_info ORDER BY unit_id ";
        //            break;
        //        case EConfigMode.UserInfo:
        //            query = "SELECT user_id, password, user_group FROM user_info ";
        //            break;
        //        case EConfigMode.PortInfo:
        //            query = "SELECT port_id, port_type, port_mode, sort_type, cst_demand, area_type FROM port_info ";
        //            break;

        //        case EConfigMode.UseEq:
        //            grdConfig.AllowUserToAddRows = true;
        //            query = "SELECT type, eq_id FROM use_eq";
        //            break;

        //        case EConfigMode.WorkAlias:
        //            grdConfig.AllowUserToAddRows = true;
        //            query = "SELECT work_id, alias FROM alias_info WHERE alias_type=N'" + m_ConfigMode + "'";
        //            break;
        //        case EConfigMode.WorkerAlias:
        //            grdConfig.AllowUserToAddRows = true;
        //            query = "SELECT work_id, worker_id, alias FROM alias_info WHERE alias_type=N'" + m_ConfigMode + "'";
        //            break;
        //        case EConfigMode.FlowAlias:
        //            grdConfig.AllowUserToAddRows = true;
        //            query = "SELECT flow_id, alias FROM alias_info WHERE alias_type=N'" + m_ConfigMode + "'";
        //            break;

        //        case EConfigMode.SamplingDataAlias:
        //        case EConfigMode.JudgementFlowAlias:
        //        case EConfigMode.ManualDispatchRuleAlias:
        //            grdConfig.AllowUserToAddRows = true;
        //            query = "SELECT eq_id, unit_id, alias FROM alias_info WHERE alias_type=N'" + m_ConfigMode + "'";
        //            break;

        //        case EConfigMode.RecipeBodyAlias:
        //        case EConfigMode.DBRRecipeAlias:
        //        case EConfigMode.SubEqStateAlias:
        //        case EConfigMode.PairEqAlias:
        //            grdConfig.AllowUserToAddRows = true;
        //            query = "SELECT unit_id, alias FROM alias_info WHERE alias_type=N'" + m_ConfigMode + "'";
        //            break;

        //        case EConfigMode.EqOnlineParameterAlias:
        //            grdConfig.AllowUserToAddRows = true;
        //            query = "SELECT eq_id, alias FROM alias_info WHERE alias_type=N'" + m_ConfigMode + "'";
        //            break;

        //        default:
        //            break;
        //    }

        //    if (!string.IsNullOrEmpty(query))
        //    {
        //        grdConfig.DataSource = null; //반드시 null뒤에 정의해줄것
        //        grdConfig.DataSource = m_LCMain.m_Data.GetDataSet("cfg", query);
        //        grdConfig.DataMember = "cfg";
        //    }
        //    else
        //    {
        //        grdConfig.DataSource = null;
        //        grdConfig.DataMember = null;
        //    }
        //}
    }
}
