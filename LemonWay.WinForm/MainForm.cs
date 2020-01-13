using Autofac;
using LemonWay.WebServiceConnector;
using LemonWay.WebServiceConnector.FibonacciWSRef;
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
    public partial class MainForm : Form
    {
        public ILemonWayWSConnector _lemonWayWSConnector;

        public MainForm()
        {
            _lemonWayWSConnector = Program._container.Resolve<ILemonWayWSConnector>();

            InitializeComponent();
        }

        private async void ComputeFibonacci_ClickAsync(object sender, EventArgs e)
        {
            var computeFibonancciTask = ComputeFibonancciAsync();

            using (var busyFrm = new BusyForm(computeFibonancciTask))
            {
                busyFrm.ShowDialog();
            }

            var result = await computeFibonancciTask;
            MessageBox.Show(result.Result.ToString());
        }

        public async Task<WebServiceReponseOfInt32> ComputeFibonancciAsync()
        {
            return await _lemonWayWSConnector.ComputeFibonnaciAsync(10);
        }
    }
}
