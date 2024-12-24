using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.SafonovRV.Sprint7.Project.V15.Lib;

namespace Tyuiu.SafonovRV.Sprint7.Project.V15
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }


        private void FormChart_Load(object sender, EventArgs e)
        {
            string[] arrayname = DataService.ArrayName;
            double[] arraydata = DataService.ArrayData;

            this.chartDiagremma_KUE.Series[0].Points.DataBindXY(arrayname, arraydata);
        }
    }
}
