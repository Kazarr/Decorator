using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Form1 : Form
    {
        LabelDecorator _labelDecorator1;
        LabelDecorator _labelDecorator2;
        LabelDecorator _labelDecorator3;
        public Form1()
        {
            InitializeComponent();
            _labelDecorator1 = new LabelDecorator(label1);
            _labelDecorator2 = new LabelDecorator(label2);
            _labelDecorator3 = new LabelDecorator(label3);
        }

        private void Done()
        {
            _labelDecorator1.Dispose();
            _labelDecorator2.Dispose();
            _labelDecorator3.Dispose();
        }

        private void label3_Leave(object sender, EventArgs e)
        {

        }
    }
}
