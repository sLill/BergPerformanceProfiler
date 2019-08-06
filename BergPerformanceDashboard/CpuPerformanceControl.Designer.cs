﻿namespace BergPerformanceDashboard
{
    partial class CpuPerformanceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCPU = new System.Windows.Forms.GroupBox();
            this.chartCpu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbFilterUser = new System.Windows.Forms.ComboBox();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelCpuDetails = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalCpu = new System.Windows.Forms.Label();
            this.lblLogicalProcessors = new System.Windows.Forms.Label();
            this.lblCores = new System.Windows.Forms.Label();
            this.lblThreads = new System.Windows.Forms.Label();
            this.lblTotalCpuUser = new System.Windows.Forms.Label();
            this.toolTipLabel4 = new BergPerformanceDashboard.ToolTipLabel();
            this.toolTipLabel5 = new BergPerformanceDashboard.ToolTipLabel();
            this.toolTipLabel6 = new BergPerformanceDashboard.ToolTipLabel();
            this.toolTipLabel7 = new BergPerformanceDashboard.ToolTipLabel();
            this.toolTipLabel8 = new BergPerformanceDashboard.ToolTipLabel();
            this.groupBoxCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCpu)).BeginInit();
            this.tableLayoutPanelCpuDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCPU
            // 
            this.groupBoxCPU.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxCPU.Controls.Add(this.chartCpu);
            this.groupBoxCPU.Controls.Add(this.cbFilterUser);
            this.groupBoxCPU.Controls.Add(this.cbStyle);
            this.groupBoxCPU.Controls.Add(this.tableLayoutPanelCpuDetails);
            this.groupBoxCPU.Location = new System.Drawing.Point(2, 3);
            this.groupBoxCPU.Name = "groupBoxCPU";
            this.groupBoxCPU.Size = new System.Drawing.Size(912, 461);
            this.groupBoxCPU.TabIndex = 9;
            this.groupBoxCPU.TabStop = false;
            this.groupBoxCPU.Text = "CPU";
            // 
            // chartCpu
            // 
            this.chartCpu.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "%";
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY2.LabelStyle.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorTickMark.Enabled = false;
            chartArea1.Name = "OverallCpu";
            this.chartCpu.ChartAreas.Add(chartArea1);
            this.chartCpu.Location = new System.Drawing.Point(27, 57);
            this.chartCpu.Margin = new System.Windows.Forms.Padding(0);
            this.chartCpu.Name = "chartCpu";
            this.chartCpu.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartCpu.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))))};
            series1.BorderWidth = 2;
            series1.ChartArea = "OverallCpu";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.chartCpu.Series.Add(series1);
            this.chartCpu.Size = new System.Drawing.Size(543, 196);
            this.chartCpu.TabIndex = 15;
            this.chartCpu.Text = "chart1";
            // 
            // cbFilterUser
            // 
            this.cbFilterUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterUser.FormattingEnabled = true;
            this.cbFilterUser.Items.AddRange(new object[] {
            "Total",
            "Current User"});
            this.cbFilterUser.Location = new System.Drawing.Point(131, 33);
            this.cbFilterUser.Margin = new System.Windows.Forms.Padding(3, 3, 17, 3);
            this.cbFilterUser.Name = "cbFilterUser";
            this.cbFilterUser.Size = new System.Drawing.Size(121, 21);
            this.cbFilterUser.TabIndex = 17;
            // 
            // cbStyle
            // 
            this.cbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Items.AddRange(new object[] {
            "Overall",
            "Virtual Cores"});
            this.cbStyle.Location = new System.Drawing.Point(252, 33);
            this.cbStyle.Margin = new System.Windows.Forms.Padding(3, 3, 17, 3);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(121, 21);
            this.cbStyle.TabIndex = 16;
            this.cbStyle.SelectedIndexChanged += new System.EventHandler(this.CbStyle_SelectedIndexChanged);
            // 
            // tableLayoutPanelCpuDetails
            // 
            this.tableLayoutPanelCpuDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelCpuDetails.ColumnCount = 6;
            this.tableLayoutPanelCpuDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanelCpuDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanelCpuDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanelCpuDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanelCpuDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanelCpuDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCpuDetails.Controls.Add(this.toolTipLabel4, 0, 1);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.lblTotalCpu, 3, 0);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.toolTipLabel5, 0, 0);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.lblLogicalProcessors, 1, 1);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.lblCores, 1, 0);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.lblThreads, 5, 0);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.toolTipLabel6, 2, 0);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.toolTipLabel7, 2, 1);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.toolTipLabel8, 4, 0);
            this.tableLayoutPanelCpuDetails.Controls.Add(this.lblTotalCpuUser, 3, 1);
            this.tableLayoutPanelCpuDetails.Location = new System.Drawing.Point(27, 269);
            this.tableLayoutPanelCpuDetails.Name = "tableLayoutPanelCpuDetails";
            this.tableLayoutPanelCpuDetails.RowCount = 3;
            this.tableLayoutPanelCpuDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCpuDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelCpuDetails.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelCpuDetails.Size = new System.Drawing.Size(470, 47);
            this.tableLayoutPanelCpuDetails.TabIndex = 18;
            // 
            // lblTotalCpu
            // 
            this.lblTotalCpu.AutoSize = true;
            this.lblTotalCpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCpu.Location = new System.Drawing.Point(292, 0);
            this.lblTotalCpu.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCpu.Name = "lblTotalCpu";
            this.lblTotalCpu.Size = new System.Drawing.Size(68, 20);
            this.lblTotalCpu.TabIndex = 7;
            this.lblTotalCpu.Text = "-";
            this.lblTotalCpu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLogicalProcessors
            // 
            this.lblLogicalProcessors.AutoSize = true;
            this.lblLogicalProcessors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogicalProcessors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogicalProcessors.Location = new System.Drawing.Point(111, 20);
            this.lblLogicalProcessors.Name = "lblLogicalProcessors";
            this.lblLogicalProcessors.Size = new System.Drawing.Size(46, 20);
            this.lblLogicalProcessors.TabIndex = 4;
            this.lblLogicalProcessors.Text = "-";
            this.lblLogicalProcessors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCores
            // 
            this.lblCores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCores.Location = new System.Drawing.Point(111, 0);
            this.lblCores.Name = "lblCores";
            this.lblCores.Size = new System.Drawing.Size(46, 20);
            this.lblCores.TabIndex = 3;
            this.lblCores.Text = "-";
            this.lblCores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThreads
            // 
            this.lblThreads.AutoSize = true;
            this.lblThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreads.Location = new System.Drawing.Point(416, 0);
            this.lblThreads.Margin = new System.Windows.Forms.Padding(0);
            this.lblThreads.Name = "lblThreads";
            this.lblThreads.Size = new System.Drawing.Size(54, 20);
            this.lblThreads.TabIndex = 8;
            this.lblThreads.Text = "-";
            this.lblThreads.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTotalCpuUser
            // 
            this.lblTotalCpuUser.AutoSize = true;
            this.lblTotalCpuUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCpuUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCpuUser.Location = new System.Drawing.Point(292, 20);
            this.lblTotalCpuUser.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCpuUser.Name = "lblTotalCpuUser";
            this.lblTotalCpuUser.Size = new System.Drawing.Size(68, 20);
            this.lblTotalCpuUser.TabIndex = 13;
            this.lblTotalCpuUser.Text = "-";
            this.lblTotalCpuUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTipLabel4
            // 
            this.toolTipLabel4.AutoSize = true;
            this.toolTipLabel4.BackColor = System.Drawing.Color.Transparent;
            this.toolTipLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel4.Location = new System.Drawing.Point(3, 23);
            this.toolTipLabel4.Name = "toolTipLabel4";
            this.toolTipLabel4.Size = new System.Drawing.Size(102, 13);
            this.toolTipLabel4.TabIndex = 9;
            this.toolTipLabel4.Text = "Logical Processors:";
            this.toolTipLabel4.ToolTipEnabled = true;
            this.toolTipLabel4.ToolTipText = "Equal to 2x the number of physical cpu cores when hyperthreading is enabled";
            // 
            // toolTipLabel5
            // 
            this.toolTipLabel5.AutoSize = true;
            this.toolTipLabel5.BackColor = System.Drawing.Color.Transparent;
            this.toolTipLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel5.Location = new System.Drawing.Point(3, 3);
            this.toolTipLabel5.Name = "toolTipLabel5";
            this.toolTipLabel5.Size = new System.Drawing.Size(43, 13);
            this.toolTipLabel5.TabIndex = 1;
            this.toolTipLabel5.Text = "Cores:";
            this.toolTipLabel5.ToolTipEnabled = false;
            this.toolTipLabel5.ToolTipText = "things and stuff";
            // 
            // toolTipLabel6
            // 
            this.toolTipLabel6.AutoSize = true;
            this.toolTipLabel6.BackColor = System.Drawing.Color.Transparent;
            this.toolTipLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolTipLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel6.Location = new System.Drawing.Point(163, 3);
            this.toolTipLabel6.Name = "toolTipLabel6";
            this.toolTipLabel6.Size = new System.Drawing.Size(126, 14);
            this.toolTipLabel6.TabIndex = 10;
            this.toolTipLabel6.Text = "Total CPU Usage";
            this.toolTipLabel6.ToolTipEnabled = true;
            this.toolTipLabel6.ToolTipText = "The number";
            // 
            // toolTipLabel7
            // 
            this.toolTipLabel7.AutoSize = true;
            this.toolTipLabel7.BackColor = System.Drawing.Color.Transparent;
            this.toolTipLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolTipLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel7.Location = new System.Drawing.Point(163, 23);
            this.toolTipLabel7.Name = "toolTipLabel7";
            this.toolTipLabel7.Size = new System.Drawing.Size(126, 14);
            this.toolTipLabel7.TabIndex = 11;
            this.toolTipLabel7.Text = "Total CPU Usage (User):";
            this.toolTipLabel7.ToolTipEnabled = true;
            this.toolTipLabel7.ToolTipText = "The number";
            // 
            // toolTipLabel8
            // 
            this.toolTipLabel8.AutoSize = true;
            this.toolTipLabel8.BackColor = System.Drawing.Color.Transparent;
            this.toolTipLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.toolTipLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolTipLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLabel8.Location = new System.Drawing.Point(363, 3);
            this.toolTipLabel8.Name = "toolTipLabel8";
            this.toolTipLabel8.Size = new System.Drawing.Size(50, 14);
            this.toolTipLabel8.TabIndex = 12;
            this.toolTipLabel8.Text = "Threads:";
            this.toolTipLabel8.ToolTipEnabled = false;
            this.toolTipLabel8.ToolTipText = "The number";
            // 
            // CpuPerformanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBoxCPU);
            this.Name = "CpuPerformanceControl";
            this.Size = new System.Drawing.Size(917, 467);
            this.groupBoxCPU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCpu)).EndInit();
            this.tableLayoutPanelCpuDetails.ResumeLayout(false);
            this.tableLayoutPanelCpuDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxCPU;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCpu;
        private System.Windows.Forms.ComboBox cbFilterUser;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCpuDetails;
        private ToolTipLabel toolTipLabel4;
        private System.Windows.Forms.Label lblTotalCpu;
        private ToolTipLabel toolTipLabel5;
        private System.Windows.Forms.Label lblLogicalProcessors;
        private System.Windows.Forms.Label lblCores;
        private System.Windows.Forms.Label lblThreads;
        private ToolTipLabel toolTipLabel6;
        private ToolTipLabel toolTipLabel7;
        private ToolTipLabel toolTipLabel8;
        private System.Windows.Forms.Label lblTotalCpuUser;
    }
}