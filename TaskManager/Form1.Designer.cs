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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PullDataTimer = new System.Windows.Forms.Timer(this.components);
            this.MainList = new System.Windows.Forms.ListBox();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CpuBar = new System.Windows.Forms.ProgressBar();
            this.RamBar = new System.Windows.Forms.ProgressBar();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.CPUcheck = new System.Windows.Forms.CheckBox();
            this.RAMcheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
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
            this.MainList.Location = new System.Drawing.Point(632, 12);
            this.MainList.Name = "MainList";
            this.MainList.Size = new System.Drawing.Size(293, 342);
            this.MainList.TabIndex = 1;
            // 
            // MainChart
            // 
            chartArea5.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.MainChart.Legends.Add(legend5);
            this.MainChart.Location = new System.Drawing.Point(12, 12);
            this.MainChart.Name = "MainChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.MainChart.Series.Add(series5);
            this.MainChart.Size = new System.Drawing.Size(559, 342);
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
            this.CPUcheck.Location = new System.Drawing.Point(578, 13);
            this.CPUcheck.Name = "CPUcheck";
            this.CPUcheck.Size = new System.Drawing.Size(48, 17);
            this.CPUcheck.TabIndex = 5;
            this.CPUcheck.Text = "CPU";
            this.CPUcheck.UseVisualStyleBackColor = true;
            // 
            // RAMcheck
            // 
            this.RAMcheck.AutoSize = true;
            this.RAMcheck.Location = new System.Drawing.Point(578, 37);
            this.RAMcheck.Name = "RAMcheck";
            this.RAMcheck.Size = new System.Drawing.Size(50, 17);
            this.RAMcheck.TabIndex = 6;
            this.RAMcheck.Text = "RAM";
            this.RAMcheck.UseVisualStyleBackColor = true;
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.RAMcheck);
            this.Controls.Add(this.CPUcheck);
            this.Controls.Add(this.RamBar);
            this.Controls.Add(this.CpuBar);
            this.Controls.Add(this.MainChart);
            this.Controls.Add(this.MainList);
            this.Name = "TaskManager";
            this.Text = "TaskManager";
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

