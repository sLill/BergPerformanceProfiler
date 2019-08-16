﻿using BergCommon;
using BergPerformanceServices;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BergUI
{
    public partial class CpuPerformanceControl : UserControl, IBergPerformanceControl
    {
        #region Member Variables..
        BergCpuMonitor _BergCpuMonitor { get; set; }
        private CpuViewMode _CpuViewMode = CpuViewMode.OverallUtilization;
        #endregion Member Variables..

        #region Properties..
        #region ChartAreas
        public ChartAreaCollection ChartAreas
        {
            get { return chartCpu.ChartAreas; }
        }
        #endregion ChartAreas

        #region Cores
        [Browsable(false)]
        public string Cores
        {
            get { return lblCores.Text; }
            set { lblCores.Text = value; }
        }
        #endregion Cores

        #region LogicalProcessors
        [Browsable(false)]
        public string LogicalProcessors
        {
            get { return lblLogicalProcessors.Text; }
            set { lblLogicalProcessors.Text = value; }
        }
        #endregion LogicalProcessors

        #region Series
        public SeriesCollection Series
        {
            get { return chartCpu.Series; }
        }
        #endregion Series

        #region TotalCpu
        [Browsable(false)]
        public string TotalCpu
        {
            get { return lblTotalCpu.Text; }
            set { lblTotalCpu.Text = value; }
        }
        #endregion TotalCpu

        #region TotalCpuUser
        [Browsable(false)]
        public string TotalCpuUser
        {
            get { return lblTotalCpuUser.Text; }
            set { lblTotalCpuUser.Text = value; }
        }
        #endregion TotalCpuUser

        #region Threads
        [Browsable(false)]
        public string Threads
        {
            get { return lblThreads.Text; }
            set { lblThreads.Text = value; }
        }
        #endregion Threads

        #region UseLocalDataSource
        [DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description(@"""True"" uses the current system this control is running on as the datasource. ""False"" uses a remote application or executable running the BergDataServices dll as the datasource"), Category("DataSource")]
        public bool UseLocalDataSource { get; set; }
        #endregion UseLocalDataSource

        #region UpdateInterval
        [DefaultValue(1000)]
        [Description(@"Frequency at which performance data is refreshed. Default - 1000ms"), Category("DataSource")]
        public int UpdateInterval { get; set; }
        #endregion UpdateInterval
        #endregion Properties..

        #region Delegates/Events
        public delegate void OnDataUpdated();
        #endregion Delegates/Events

        #region Enums..
        private enum CpuViewMode
        {
            OverallUtilization,
            LogicalProcessors
        }
        #endregion Enums..

        #region Constructors..
        #region CpuPerformanceControl
        public CpuPerformanceControl()
             : base()
        {
            InitializeComponent();
            InitializeControls();

            // Prevent the control from running in VS Designer
            if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
            {
                UpdateInterval = 1000;
                UseLocalDataSource = true;

                _BergCpuMonitor = new BergCpuMonitor(UpdateInterval, true, UseLocalDataSource);
                _BergCpuMonitor.DataUpdated += OnPerformanceDataUpdated;
            }
        }
        #endregion CpuPerformanceControl
        #endregion Constructors..

        #region Methods..
        #region Events..
        #region tsCpuViewMode_DropDownItemClicked
        private void tsCpuViewMode_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripMenuItem item in tsCpuViewMode.DropDownItems)
            {
                item.Checked = item.Name == e.ClickedItem.Name;
            }

            foreach (var chartArea in chartCpu.ChartAreas)
            {
                chartArea.Visible = (CpuViewMode)e.ClickedItem.Tag == (CpuViewMode)chartArea.Tag;
            }
        }
        #endregion tsCpuViewMode_DropDownItemClicked
        #endregion Events..

        #region AddLogicalProcessorChartArea
        private ChartArea AddLogicalProcessorChartArea(string name)
        {
            ChartArea ChartArea = new ChartArea(name);
            ChartArea.Tag = CpuViewMode.LogicalProcessors;

            bool ShowLogicalProcessors = _CpuViewMode == CpuViewMode.LogicalProcessors;
            ChartArea.Visible = ShowLogicalProcessors;

            ChartArea.AxisX2.Enabled = AxisEnabled.True;
            ChartArea.AxisX2.MajorGrid.Enabled = false;
            ChartArea.AxisX2.MinorGrid.Enabled = false;
            ChartArea.AxisX2.MajorTickMark.Enabled = false;
            ChartArea.AxisX2.MinorTickMark.Enabled = false;
            ChartArea.AxisX2.LabelStyle.Enabled = false;

            ChartArea.AxisY2.Enabled = AxisEnabled.True;
            ChartArea.AxisY2.MajorGrid.Enabled = false;
            ChartArea.AxisY2.MinorGrid.Enabled = false;
            ChartArea.AxisY2.MajorTickMark.Enabled = false;
            ChartArea.AxisY2.MinorTickMark.Enabled = false;
            ChartArea.AxisY2.LabelStyle.Enabled = false;

            ChartArea.AxisY.MajorGrid.Enabled = false;
            ChartArea.AxisY.MajorTickMark.Enabled = false;
            ChartArea.AxisY.LabelStyle.Enabled = false;
            //ChartArea.AxisY.Title = "%";

            ChartArea.AxisX.MajorGrid.Enabled = false;
            ChartArea.AxisX.MajorTickMark.Enabled = false;
            ChartArea.AxisX.LabelStyle.Enabled = false;

            return ChartArea;
        }
        #endregion AddLogicalProcessorChartArea

        #region AddLogicalProcessorSeries
        private Series AddLogicalProcessorSeries(string name)
        {
            Series Series = new Series(name);
            Series.ChartType = SeriesChartType.Line;

            return Series;
        }
        #endregion AddLogicalProcessorSeries

        #region InitializeControls
        public void InitializeControls()
        {
            InitializeGridLayout();
        }
        #endregion InitializeControls

        #region InitializeGridLayout
        private void InitializeGridLayout()
        {
            chartCpu.ChartAreas["OverallCpu"].Tag = CpuViewMode.OverallUtilization;

            ToolStripMenuItem CpuViewModeMenuItem = chartCpu.ContextMenuStrip.Items["tsCpuViewMode"] as ToolStripMenuItem;
            CpuViewModeMenuItem.DropDownItems["tsOverallUtilization"].Tag = CpuViewMode.OverallUtilization;
            CpuViewModeMenuItem.DropDownItems["tsLogicalProcessors"].Tag = CpuViewMode.LogicalProcessors;

            for (int i = 0; i < Environment.ProcessorCount; i++)
            {
                // ChartArea
                string ChartAreaName = $"LogicalProcessorChartArea_{i}";
                ChartArea LogicalProcessorChartArea = AddLogicalProcessorChartArea(ChartAreaName);
                LogicalProcessorChartArea.Name = $"LogicalProcessorChartArea_{i}";
                chartCpu.ChartAreas.Add(LogicalProcessorChartArea);

                // Series
                string SeriesName = $"LogicalProcessorSeries_{i}";
                Series LogicalProcessorSeries = AddLogicalProcessorSeries(SeriesName);
                LogicalProcessorSeries.ChartArea = LogicalProcessorChartArea.Name;
                chartCpu.Series.Add(LogicalProcessorSeries);
            }
        }
        #endregion InitializeGridLayout

        #region OnPerformanceDataUpdated
        public void OnPerformanceDataUpdated(object sender, EventArgs e)
        {
            CpuPerformanceData CpuPerformanceData = sender as CpuPerformanceData;
            Invoke(new OnDataUpdated(() =>
            {
                Cores = CpuPerformanceData.CoreCount;
                LogicalProcessors = CpuPerformanceData.LogicalProcessorsCount;
                TotalCpu = CpuPerformanceData.TotalCPU;
                TotalCpuUser = CpuPerformanceData.TotalUserCPU;

                this.Series[0].Points.Add(Convert.ToDouble(CpuPerformanceData.TotalCPU));

                foreach (var logicalCore in CpuPerformanceData.LogicalCores)
                {
                    string SeriesName = $"LogicalProcessorSeries_{logicalCore.CoreId}";
                    this.Series[SeriesName].Points.Add(Convert.ToDouble(logicalCore.PercentProcessorTime));
                }
            }), null);
        }
        #endregion OnPerformanceDataUpdated
        #endregion Methods..
    }
}
