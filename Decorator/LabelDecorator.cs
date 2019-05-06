using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public class LabelDecorator : IDisposable
    {
        private Label _label;

        public LabelDecorator(Label label)
        {
            _label = label;
            AddHandlers();
        }

        private void AddHandlers()
        {
            _label.Click += new System.EventHandler(OnLabelClick);
            _label.Click += MousePosition;
        }

        private void MousePosition(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            MouseEventArgs args = (MouseEventArgs)e;
            label.Text = $"{ args.X }--{ args.Y}";
        }

        private void RemoveHandlers()
        {
            _label.Click -= OnLabelClick;
            _label.Click -= MousePosition;
        }

        private void OnLabelClick(object sender, EventArgs e)
        {
            _label.BackColor = Color.Aqua;
        }


        public void Dispose()
        {
            RemoveHandlers();
        }

    }
}
