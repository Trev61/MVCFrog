using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCFrog
{
    public partial class FrogView : Form
    {

        FrogController frogController = new FrogController();
        public FrogView()
        {
            InitializeComponent();
        }

        private void btnGrowFrog_Click(object sender, EventArgs e)
        {
            frogController.growFrog();
            updateFrogSizeTextView();
        }

        private void btnShrinkFrog_Click(object sender, EventArgs e)
        {
            frogController.shrinkFrog();
            updateFrogSizeTextView();
        }

        private void updateFrogSizeTextView()
        {
            txtFrogSize.Text = frogController.getFrogSize().ToString();
            updateFrogSizeGraphicalView();
            if (frogController.getFrogSize() > 50)
            {
                txtFrogSize.Text = "Splat!";
            }
        }

        private void updateFrogSizeGraphicalView()
        {

            if (frogController.getFrogSize() < 50)
            {
                Size size = picFrog.Size;
                size.Height = frogController.getFrogSize();
                size.Width = frogController.getFrogSize();
                picFrog.Size = size;
            }
        
        else
            {
                //frog explodes
                picFrog.Image = Image.FromFile("C:\\Users\\MC03286\\OneDrive - Middlesbrough College\\Pictures\\splat.jfif");
            }
            
        }
    }
}
