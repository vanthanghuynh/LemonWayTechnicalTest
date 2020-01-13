using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemonWay.WinForm
{
    public partial class BusyForm : Form
    {
        private Task _task;

        public BusyForm(Task task)
        {
            _task = task ?? throw new ArgumentNullException();

            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _task.ContinueWith(t =>
            {
                this.Close();
            }
            , TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
