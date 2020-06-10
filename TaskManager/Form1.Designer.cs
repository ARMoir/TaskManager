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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PullDataTimer = new System.Windows.Forms.Timer(this.components);
            this.MainList = new System.Windows.Forms.ListBox();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CpuBar = new System.Windows.Forms.ProgressBar();
            this.RamBar = new System.Windows.Forms.ProgressBar();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.CPUcheck = new System.Windows.Forms.CheckBox();
            this.RAMcheck = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PerformancePage = new System.Windows.Forms.TabPage();
            this.ProcessesPage = new System.Windows.Forms.TabPage();
            this.ProcessGridView = new System.Windows.Forms.DataGridView();
            this.ProMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.PerformancePage.SuspendLayout();
            this.ProcessesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).BeginInit();
            this.ProMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PullDataTimer
            // 
            this.PullDataTimer.Enabled = true;
            this.PullDataTimer.Interval = 1000;
            this.PullDataTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainList
            // 
            this.MainList.FormattingEnabled = true;
            this.MainList.Location = new System.Drawing.Point(653, 6);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(265, 316);
            this.MainList.TabIndex = 1;
            // 
            // MainChart
            // 
            chartArea2.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.MainChart.Legends.Add(legend2);
            this.MainChart.Location = new System.Drawing.Point(6, 0);
            this.MainChart.Name = "MainChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.MainChart.Series.Add(series2);
            this.MainChart.Size = new System.Drawing.Size(587, 319);
            this.MainChart.TabIndex = 2;
            this.MainChart.Text = "chart1";
            // 
            // CpuBar
            // 
            this.CpuBar.Location = new System.Drawing.Point(12, 360);
            this.CpuBar.Name = "CpuBar";
            this.CpuBar.Size = new System.Drawing.Size(649, 23);
            this.CpuBar.TabIndex = 3;
            // 
            // RamBar
            // 
            this.RamBar.Location = new System.Drawing.Point(13, 390);
            this.RamBar.Name = "RamBar";
            this.RamBar.Size = new System.Drawing.Size(648, 23);
            this.RamBar.TabIndex = 4;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 10;
            this.RefreshTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // CPUcheck
            // 
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
            this.RAMcheck.AutoSize = true;
            this.RAMcheck.Location = new System.Drawing.Point(599, 26);
            this.RAMcheck.Name = "RAMcheck";
            this.RAMcheck.Size = new System.Drawing.Size(50, 17);
            this.RAMcheck.TabIndex = 6;
            this.RAMcheck.Text = "RAM";
            this.RAMcheck.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PerformancePage);
            this.tabControl1.Controls.Add(this.ProcessesPage);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(934, 351);
            this.tabControl1.TabIndex = 7;
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
            this.ProcessesPage.Controls.Add(this.pictureBox1);
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
            this.ProcessGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessGridView.ContextMenuStrip = this.ProMenuStrip;
            this.ProcessGridView.Location = new System.Drawing.Point(3, 6);
            this.ProcessGridView.Name = "ProcessGridView";
            this.ProcessGridView.Size = new System.Drawing.Size(837, 313);
            this.ProcessGridView.TabIndex = 0;
            // 
            // ProMenuStrip
            // 
            this.ProMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killToolStripMenuItem,
            this.locationToolStripMenuItem});
            this.ProMenuStrip.Name = "ProMenuStrip";
            this.ProMenuStrip.Size = new System.Drawing.Size(121, 48);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.killToolStripMenuItem.Text = "Kill";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.killToolStripMenuItem_Click);
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.locationToolStripMenuItem.Text = "Location";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(846, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.RamBar);
            this.Controls.Add(this.CpuBar);
            this.Name = "TaskManager";
            this.Text = "TaskManager";
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.PerformancePage.ResumeLayout(false);
            this.PerformancePage.PerformLayout();
            this.ProcessesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessGridView)).EndInit();
            this.ProMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer PullDataTimer;
        private System.Windows.Forms.ListBox MainList;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.ProgressBar CpuBar;
        private System.Windows.Forms.ProgressBar RamBar;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.CheckBox CPUcheck;
        private System.Windows.Forms.CheckBox RAMcheck;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PerformancePage;
        private System.Windows.Forms.TabPage ProcessesPage;
        private System.Windows.Forms.DataGridView ProcessGridView;
        private System.Windows.Forms.ContextMenuStrip ProMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

