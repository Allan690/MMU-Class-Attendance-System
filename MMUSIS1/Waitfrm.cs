using System;
using System.Threading.Tasks;

namespace MMUSIS1
{
    public partial class Waitfrm : MetroFramework.Forms.MetroForm
    {
        public Action Worker { get; set; }
        public Waitfrm(Action worker)
        {
            InitializeComponent();
            if (worker == null)
                throw new ArgumentNullException();
            Worker = worker;
        }

      
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());

        }
    }
}
