using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.KupriyanovEA.Sprint7.Project.V15.Lib;

namespace Tyuiu.KupriyanovEA.Sprint7.Project.V15
{
    public partial class FormWriteText : Form
    {
        public FormWriteText()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonOK_KUE_Click(object sender, EventArgs e)
        {

            DataService.Text = textBoxInputLabelColumn_KUE.Text;
            this.Close();
        }
    }
}
