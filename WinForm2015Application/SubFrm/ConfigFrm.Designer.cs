namespace WinForm2015Application.SubFrm
{
    partial class ConfigFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigFrm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("EQ. Layer Modeling");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Eq. State Modeling");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Proc. State Modeling");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Equipment Modeling", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Host I/F");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("EQ. I/F");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Label I/F");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Interface", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("EQ. Constant");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("EQ. Online Parameter");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("State Variable");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("EQ. Parameter", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Port");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Alarm Code");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("PM Code");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Cancel Code");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("User Info");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Work Alias");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Worker Alias");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Flow Alias");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("SamplingData Alias");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("JudgementFlow Alias");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("ManualDispatchRule Alias");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("RecipeBody Alias");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("DBR Recipe Alias");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("SubEqState Alias");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("PairEq Alias");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("EqOnlineParameter Alias");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Alias", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Use Eq");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.treeMenu = new System.Windows.Forms.TreeView();
            this.lblDescription = new System.Windows.Forms.Label();
            this.grdConfig = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grdConfig);
            this.splitContainer1.Panel2.Controls.Add(this.lblDescription);
            this.splitContainer1.Size = new System.Drawing.Size(590, 450);
            this.splitContainer1.SplitterDistance = 121;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Configuration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // treeMenu
            // 
            this.treeMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeMenu.Location = new System.Drawing.Point(0, 6);
            this.treeMenu.Name = "treeMenu";
            treeNode1.Name = "nodeEqLayer";
            treeNode1.Text = "EQ. Layer Modeling";
            treeNode2.Name = "nodeEqState";
            treeNode2.Text = "Eq. State Modeling";
            treeNode3.Name = "nodeProcState";
            treeNode3.Text = "Proc. State Modeling";
            treeNode4.Name = "nodeEqModeling";
            treeNode4.Text = "Equipment Modeling";
            treeNode5.Name = "nodeHostIF";
            treeNode5.Text = "Host I/F";
            treeNode6.Name = "nodeEqIF";
            treeNode6.Text = "EQ. I/F";
            treeNode7.Name = "nodeLabelerIF";
            treeNode7.Text = "Label I/F";
            treeNode8.Name = "nodeInterface";
            treeNode8.Text = "Interface";
            treeNode9.Name = "nodeEC";
            treeNode9.Text = "EQ. Constant";
            treeNode10.Name = "nodeEO";
            treeNode10.Text = "EQ. Online Parameter";
            treeNode11.Name = "nodeSV";
            treeNode11.Text = "State Variable";
            treeNode12.Name = "nodeEqParam";
            treeNode12.Text = "EQ. Parameter";
            treeNode13.Name = "nodePortInfo";
            treeNode13.Text = "Port";
            treeNode14.Name = "nodeAlarmCode";
            treeNode14.Text = "Alarm Code";
            treeNode15.Name = "nodePMCode";
            treeNode15.Text = "PM Code";
            treeNode16.Name = "nodeCancelCode";
            treeNode16.Text = "Cancel Code";
            treeNode17.Name = "nodeUserInfo";
            treeNode17.Text = "User Info";
            treeNode18.Name = "nodeWorkAlias";
            treeNode18.Text = "Work Alias";
            treeNode19.Name = "nodeWorkerAlias";
            treeNode19.Text = "Worker Alias";
            treeNode20.Name = "nodeFlowAlias";
            treeNode20.Text = "Flow Alias";
            treeNode21.Name = "nodeSamplingDataAlias";
            treeNode21.Text = "SamplingData Alias";
            treeNode22.Name = "nodeJudgementFlowAlias";
            treeNode22.Text = "JudgementFlow Alias";
            treeNode23.Name = "nodeManualDispatchRuleAlias";
            treeNode23.Text = "ManualDispatchRule Alias";
            treeNode24.Name = "nodeRecipeBodyAlias";
            treeNode24.Text = "RecipeBody Alias";
            treeNode25.Name = "nodeDBRRecipeAlias";
            treeNode25.Text = "DBR Recipe Alias";
            treeNode26.Name = "nodeSubEqStateAlias";
            treeNode26.Text = "SubEqState Alias";
            treeNode27.Name = "nodePairEqAlias";
            treeNode27.Text = "PairEq Alias";
            treeNode28.Name = "nodeEqOnlineParameterAlias";
            treeNode28.Text = "EqOnlineParameter Alias";
            treeNode29.Name = "nodeAlias";
            treeNode29.Text = "Alias";
            treeNode30.Name = "nodeUseEq";
            treeNode30.Text = "Use Eq";
            this.treeMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode29,
            treeNode30});
            this.treeMenu.Size = new System.Drawing.Size(115, 441);
            this.treeMenu.TabIndex = 12;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescription.Location = new System.Drawing.Point(12, 6);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(440, 73);
            this.lblDescription.TabIndex = 6;
            // 
            // grdConfig
            // 
            this.grdConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConfig.Location = new System.Drawing.Point(12, 82);
            this.grdConfig.Name = "grdConfig";
            this.grdConfig.RowTemplate.Height = 23;
            this.grdConfig.Size = new System.Drawing.Size(440, 357);
            this.grdConfig.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(527, 527);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // ConfigFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 568);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ConfigFrm";
            this.Text = "ConfigFrm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConfig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeMenu;
        private System.Windows.Forms.DataGridView grdConfig;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
    }
}