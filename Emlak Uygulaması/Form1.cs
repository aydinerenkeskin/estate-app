using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Emlak_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void estateSave_Click(object sender, EventArgs e)
        {
            EstateScreen estateScreen = new EstateScreen();
            estateScreen.Show();

        }

        private void custumerSave_Click(object sender, EventArgs e)
        {
            CustomerScreen customerScreen = new CustomerScreen();
            customerScreen.Show();

        }

        private void workingPlaceAdd_Click(object sender, EventArgs e)
        {
            WorkPlace workPlace = new WorkPlace();
            workPlace.Show();
        }

        private void newSave_Click(object sender, EventArgs e)
        {
            newRecordScreen newRecordScreen = new newRecordScreen();
            newRecordScreen.Show();
        }

    }
}
