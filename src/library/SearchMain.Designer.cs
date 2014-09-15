namespace SoftwareSearch.Library
{
    partial class SearchMain
    {
        /// <summary>필수 디자이너 변수입니다.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>사용 중인 모든 리소스를 정리합니다.</summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchMain));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lvSoftwareList = new System.Windows.Forms.ListView();
            this.clmnName = new System.Windows.Forms.ColumnHeader();
            this.clmnSpcName = new System.Windows.Forms.ColumnHeader();
            this.clmnLicense = new System.Windows.Forms.ColumnHeader();
            this.toolStrip.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSearch,
            this.tsbtnSave});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(640, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearch.Image")));
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(49, 22);
            this.tsbtnSearch.Text = "검색";
            this.tsbtnSearch.Click += new System.EventHandler(this.OnSearchButtonClick);
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(49, 22);
            this.tsbtnSave.Text = "저장";
            this.tsbtnSave.Click += new System.EventHandler(this.OnSaveButtonClick);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lvSoftwareList);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(3);
            this.panelMain.Size = new System.Drawing.Size(640, 455);
            this.panelMain.TabIndex = 1;
            // 
            // lvSoftwareList
            // 
            this.lvSoftwareList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvSoftwareList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSoftwareList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnName,
            this.clmnSpcName,
            this.clmnLicense});
            this.lvSoftwareList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSoftwareList.FullRowSelect = true;
            this.lvSoftwareList.HideSelection = false;
            this.lvSoftwareList.Location = new System.Drawing.Point(3, 3);
            this.lvSoftwareList.MultiSelect = false;
            this.lvSoftwareList.Name = "lvSoftwareList";
            this.lvSoftwareList.Size = new System.Drawing.Size(634, 449);
            this.lvSoftwareList.TabIndex = 0;
            this.lvSoftwareList.UseCompatibleStateImageBehavior = false;
            this.lvSoftwareList.View = System.Windows.Forms.View.Details;
            // 
            // clmnName
            // 
            this.clmnName.Text = "소프트웨어 명칭";
            this.clmnName.Width = 250;
            // 
            // clmnSpcName
            // 
            this.clmnSpcName.Text = "SPC 명칭";
            this.clmnSpcName.Width = 250;
            // 
            // clmnLicense
            // 
            this.clmnLicense.Text = "라이센스 여부";
            this.clmnLicense.Width = 100;
            // 
            // SearchMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.toolStrip);
            this.Name = "SearchMain";
            this.Size = new System.Drawing.Size(640, 480);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.ListView lvSoftwareList;
        private System.Windows.Forms.ColumnHeader clmnName;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ColumnHeader clmnSpcName;
        private System.Windows.Forms.ColumnHeader clmnLicense;
    }
}