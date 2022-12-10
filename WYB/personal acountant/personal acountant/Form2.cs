using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Data.SqlClient;
using personal_acountant.Properties;

namespace personal_acountant
{
    public partial class Main : KryptonForm
    {
        private bool iscollapsed;
        public Main()
        {
            InitializeComponent();
        }

       

       

        

       
        private void maintimer_Tick(object sender, EventArgs e)
        {
            if (iscollapsed)
            {
                button10.Image = Resources.Collapse_Arrow_20px;
                maindrop.Height += 10;
                if (maindrop.Size == admindrop.MaximumSize)
                {
                    maintimer.Stop();
                    iscollapsed = false;
                }
            }
            else
            {
                button10.Image = Resources.Expand_Arrow_20px;
                maindrop.Height -= 10;
                if (maindrop.Size == admindrop.MinimumSize)
                {
                    maintimer.Stop();
                    iscollapsed = true;
                }
            }

        }
       

   

        private void button14_Click(object sender, EventArgs e)
        {
            settingtimer.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            maintimer.Start();
        }

        private void settingtimer_Tick(object sender, EventArgs e)
        {
            if (iscollapsed)
            {
                button14.Image = Resources.Collapse_Arrow_20px;
                settingdrop.Height += 10;
                if (settingdrop.Size == settingdrop.MaximumSize)
                {
                    settingtimer.Stop();
                    iscollapsed = false;
                }
            }
            else
            {
                button14.Image = Resources.Expand_Arrow_20px;
                settingdrop.Height -= 10;
                if (settingdrop.Size == settingdrop.MinimumSize)
                {
                    settingtimer.Stop();
                    iscollapsed = true;
                }
            }

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void admintimer_Tick(object sender, EventArgs e)
        {
            if (iscollapsed)
            {
                button1.Image = Resources.Collapse_Arrow_20px;
                admindrop.Height += 10;
                if (admindrop.Size == admindrop.MaximumSize)
                {
                    admintimer.Stop();
                    iscollapsed = false;
                }
            }
            else
            {
                button1.Image = Resources.Expand_Arrow_20px;
                admindrop.Height -= 10;
                if (admindrop.Size == admindrop.MinimumSize)
                {
                    admintimer.Stop();
                    iscollapsed = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admintimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sendcode fr = new sendcode();
            //fr.MdiParent = this;
            //fr.Show();
        }

        private void admindrop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


