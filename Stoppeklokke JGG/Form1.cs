using System;
using System.Windows.Forms;

namespace Stoppeklokke_JGG
{
    public partial class Form1 : Form
    {

        int timeSec;
        int timeMin;
        int timeHour;
        bool isActive;
        
        //Om jeg trykker på "start" knappen vil isActive bli true.
        private void BttnStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }
        public Form1()
        {
            InitializeComponent();
        }

        //Når jeg starter programmet vil timeren bli resettet.
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetTime();

            isActive = false;
        }

        //Når jeg trykker på stopknappen stopper timeren uten å bli resettet.
        private void BttnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        //Når jeg trykker på "Reset" knappen vil timeren resette seg, den vil også stoppe.
        private void BttnReset_Click(object sender, EventArgs e)
        {
            isActive = false;

            ResetTime();
        }

        //private void ResetTime() forteller hva ResetTime(); gjør.
        private void ResetTime()
        {
            timeSec = 0;
            timeMin = 0;
            timeHour = 0;
        }

        //Her står det hva som skjer for hvert tick av timeren jeg satt inn i form1.cs[Design]
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Her sier den at sekunder skal starte om "isActive" er true.
            if (isActive)
            {
                timeSec++;

                //Her sier den at om sekunder blir mer eller lik 60 vil et minutt bli lagt til.
                if (timeSec >= 60)
                {

                    timeMin++;
                    timeSec = 0;
                }
                //Her sier den at om minuttene blir mer eller lik 60 vil en time bli lagt til.
                if (timeMin >= 60)
                {
                    timeHour++;
                    timeMin = 0;
                }
            }
            DrawTime();
        }

        //Her forteller "private void DrawTime()" hva "DrawTime()" gjør.
        //Den forteller hvilket format tallene skal være.
        private void DrawTime()
        {
            lblSec.Text = String.Format("{0,00}", timeSec);
            lblMin.Text = String.Format("{0,00}", timeMin);
            lblHour.Text = String.Format("{0,00}", timeHour);
        }
    }
}
