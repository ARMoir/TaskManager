namespace TaskManager
{
    partial class TaskManager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainList = new System.Windows.Forms.ListBox();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CpuBar = new System.Windows.Forms.ProgressBar();
            this.RamBar = new System.Windows.Forms.ProgressBar();
            this.CPUcheck = new System.Windows.Forms.CheckBox();
            this.RAMcheck = new System.Windows.Forms.CheckBox();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.PerformancePage = new System.Windows.Forms.TabPage();
            this.ProcessesPage = new System.Windows.Forms.TabPage();
            this.ProcessGridView = new System.Windows.Forms.DataGridView();
            this.ProMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Services = new System.Windows.Forms.TabPage();
            this.ServiceGridView = new System.Windows.Forms.DataGridView();
            this.SerMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.PerformanceTimer = new System.Windows.Forms.Timer(this.components);
            this.BarTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.MainTabControl.SuspendLayout();
            this.PerformancePage.SuspendLayout();
            this.ProcessesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).BeginInit();
            this.ProMenuStrip.SuspendLayout();
            this.Services.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).BeginInit();
            this.SerMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainList
            // 
            this.MainList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainList.FormattingEnabled = true;
            this.MainList.Location = new System.Drawing.Point(653, 6);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(265, 316);
            this.MainList.TabIndex = 1;
            // 
            // MainChart
            // 
            this.MainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.MainChart.Legends.Add(legend1);
            this.MainChart.Location = new System.Drawing.Point(6, 0);
            this.MainChart.Name = "MainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.MainChart.Series.Add(series1);
            this.MainChart.Size = new System.Drawing.Size(587, 319);
            this.MainChart.TabIndex = 2;
            this.MainChart.Text = "chart1";
            // 
            // CpuBar
            // 
            this.CpuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CpuBar.Location = new System.Drawing.Point(12, 360);
            this.CpuBar.Name = "CpuBar";
            this.CpuBar.Size = new System.Drawing.Size(913, 23);
            this.CpuBar.TabIndex = 3;
            // 
            // RamBar
            // 
            this.RamBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RamBar.Location = new System.Drawing.Point(13, 390);
            this.RamBar.Name = "RamBar";
            this.RamBar.Size = new System.Drawing.Size(912, 23);
            this.RamBar.TabIndex = 4;
            // 
            // CPUcheck
            // 
            this.CPUcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUcheck.AutoSize = true;
            this.CPUcheck.Checked = true;
            this.CPUcheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CPUcheck.Location = new System.Drawing.Point(599, 6);
            this.CPUcheck.Name = "CPUcheck";
            this.CPUcheck.Size = new System.Drawing.Size(48, 17);
            this.CPUcheck.TabIndex = 5;
            this.CPUcheck.Text = "CPU";
            this.CPUcheck.UseVisualStyleBackColor = true;
            // 
            // RAMcheck
            // 
            this.RAMcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RAMcheck.AutoSize = true;
            this.RAMcheck.Location = new System.Drawing.Point(599, 26);
            this.RAMcheck.Name = "RAMcheck";
            this.RAMcheck.Size = new System.Drawing.Size(50, 17);
            this.RAMcheck.TabIndex = 6;
            this.RAMcheck.Text = "RAM";
            this.RAMcheck.UseVisualStyleBackColor = true;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.PerformancePage);
            this.MainTabControl.Controls.Add(this.ProcessesPage);
            this.MainTabControl.Controls.Add(this.Services);
            this.MainTabControl.Location = new System.Drawing.Point(3, 3);
            this.MainTabControl.Multiline = true;
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(934, 351);
            this.MainTabControl.TabIndex = 7;
            // 
            // PerformancePage
            // 
            this.PerformancePage.Controls.Add(this.MainChart);
            this.PerformancePage.Controls.Add(this.RAMcheck);
            this.PerformancePage.Controls.Add(this.CPUcheck);
            this.PerformancePage.Controls.Add(this.MainList);
            this.PerformancePage.Location = new System.Drawing.Point(4, 22);
            this.PerformancePage.Name = "PerformancePage";
            this.PerformancePage.Padding = new System.Windows.Forms.Padding(3);
            this.PerformancePage.Size = new System.Drawing.Size(926, 325);
            this.PerformancePage.TabIndex = 0;
            this.PerformancePage.Text = "Performance";
            this.PerformancePage.UseVisualStyleBackColor = true;
            // 
            // ProcessesPage
            // 
            this.ProcessesPage.Controls.Add(this.ProcessGridView);
            this.ProcessesPage.Location = new System.Drawing.Point(4, 22);
            this.ProcessesPage.Name = "ProcessesPage";
            this.ProcessesPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProcessesPage.Size = new System.Drawing.Size(926, 325);
            this.ProcessesPage.TabIndex = 1;
            this.ProcessesPage.Text = "Processes";
            this.ProcessesPage.UseVisualStyleBackColor = true;
            // 
            // ProcessGridView
            // 
            this.ProcessGridView.AllowUserToAddRows = false;
            this.ProcessGridView.AllowUserToDeleteRows = false;
            this.ProcessGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProcessGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProcessGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProcessGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProcessGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessGridView.ContextMenuStrip = this.ProMenuStrip;
            this.ProcessGridView.Location = new System.Drawing.Point(3, 3);
            this.ProcessGridView.Name = "ProcessGridView";
            this.ProcessGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProcessGridView.Size = new System.Drawing.Size(920, 319);
            this.ProcessGridView.TabIndex = 0;
            // 
            // ProMenuStrip
            // 
            this.ProMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killToolStripMenuItem,
            this.locationToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.ProMenuStrip.Name = "ProMenuStrip";
            this.ProMenuStrip.Size = new System.Drawing.Size(128, 70);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.killToolStripMenuItem.Text = "Kill";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.killToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // Services
            // 
            this.Services.Controls.Add(this.ServiceGridView);
            this.Services.Location = new System.Drawing.Point(4, 22);
            this.Services.Name = "Services";
            this.Services.Padding = new System.Windows.Forms.Padding(3);
            this.Services.Size = new System.Drawing.Size(926, 325);
            this.Services.TabIndex = 2;
            this.Services.Text = "Services";
            this.Services.UseVisualStyleBackColor = true;
            // 
            // ServiceGridView
            // 
            this.ServiceGridView.AllowUserToAddRows = false;
            this.ServiceGridView.AllowUserToDeleteRows = false;
            this.ServiceGridView.AllowUserToOrderColumns = true;
            this.ServiceGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ServiceGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ServiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceGridView.ContextMenuStrip = this.SerMenuStrip;
            this.ServiceGridView.Location = new System.Drawing.Point(5, 3);
            this.ServiceGridView.Name = "ServiceGridView";
            this.ServiceGridView.ReadOnly = true;
            this.ServiceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceGridView.Size = new System.Drawing.Size(918, 319);
            this.ServiceGridView.TabIndex = 0;
            // 
            // SerMenuStrip
            // 
            this.SerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.startToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.SerMenuStrip.Name = "SerMenuStrip";
            this.SerMenuStrip.Size = new System.Drawing.Size(114, 70);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // ProcessTimer
            // 
            this.ProcessTimer.Enabled = true;
            this.ProcessTimer.Interval = 5000;
            this.ProcessTimer.Tick += new System.EventHandler(this.ProcessTimer_Tick);
            // 
            // PerformanceTimer
            // 
            this.PerformanceTimer.Enabled = true;
            this.PerformanceTimer.Interval = 1000;
            this.PerformanceTimer.Tick += new System.EventHandler(this.PerformanceTimer_Tick);
            // 
            // BarTimer
            // 
            this.BarTimer.Enabled = true;
            this.BarTimer.Interval = 10;
            this.BarTimer.Tick += new System.EventHandler(this.BarTimer_Tick);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.RamBar);
            this.Controls.Add(this.CpuBar);
            this.Name = "TaskManager";
            this.Text = "TaskManager";
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.MainTabControl.ResumeLayout(false);
            this.PerformancePage.ResumeLayout(false);
            this.PerformancePage.PerformLayout();
            this.ProcessesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).EndInit();
            this.ProMenuStrip.ResumeLayout(false);
            this.Services.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).EndInit();
            this.SerMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.ProgressBar CpuBar;
        private System.Windows.Forms.ProgressBar RamBar;
        private System.Windows.Forms.CheckBox CPUcheck;
        private System.Windows.Forms.CheckBox RAMcheck;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage PerformancePage;
        private System.Windows.Forms.TabPage ProcessesPage;
        private System.Windows.Forms.ContextMenuStrip ProMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.TabPage Services;
        private System.Windows.Forms.ContextMenuStrip SerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Timer ProcessTimer;
        private System.Windows.Forms.Timer PerformanceTimer;
        private System.Windows.Forms.Timer BarTimer;
        public System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        public System.Windows.Forms.DataGridView ProcessGridView;
        public System.Windows.Forms.DataGridView ServiceGridView;
    }
}

