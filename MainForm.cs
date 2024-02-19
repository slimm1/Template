using StandardTemplate.utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardTemplate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
    }

    /*public void LoadChart() {
        RapperChart.Series.Clear();
        RapperChart.Titles.Clear();
        RapperChart.BackColor = Color.Transparent;
        RapperChart.Titles.Add("Rappers by Subgenre");
        RapperChart.Titles[0].Font = fontManager.TitleFont();
        string[] subgenres = AppConstants.comboItems;
        int[] points = DbLoader._instance.rappers.GetCountsBySubGenre();
        Series subgenre = new Series();
        subgenre.Name = "Subgenres";
        subgenre.ChartType = SeriesChartType.Bar;
        subgenre.Palette = ChartColorPalette.Pastel;
        subgenre.IsVisibleInLegend = false;
        RapperChart.Series.Add(subgenre);
        for (int i = 0; i < AppConstants.comboItems.Length; i++)
        {
            RapperChart.Series["Subgenres"].Points.AddXY(subgenres[i], points[i]);
        }*
    }*/

}
