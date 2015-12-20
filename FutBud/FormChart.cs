using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MetroFramework.Forms;
using UltimateTeam.Toolkit.Models;

namespace FutBud
{
    public partial class FormChart : MetroForm
    {

        private readonly List<string[]> _creditsHistoryList;
        public FormChart(List<string[]> creditsHistoryList)
        {
            InitializeComponent();
            this._creditsHistoryList = creditsHistoryList;
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            var creditsSeries = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Credits",
                BorderWidth = 3,
                Color = System.Drawing.Color.CornflowerBlue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };
            try
            {
                foreach (var value in _creditsHistoryList)
                {
                    creditsSeries.Points.AddXY(value[0], value[1]);
                }
                chart.Series.Add(creditsSeries);
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private void chart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
