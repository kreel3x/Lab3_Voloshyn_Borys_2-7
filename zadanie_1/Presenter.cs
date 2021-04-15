using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace zadanie_1
{
    class Presenter
    {
        public DispatcherTimer myTimer = new DispatcherTimer();
        private Model model = new Model();
        private MainWindow mainWin = null;

        public Presenter(MainWindow mainWin)
        {
            this.mainWin = mainWin;
            myTimer.Tick += myTimerTick;
            myTimer.Interval = TimeSpan.FromSeconds(0.1);

            this.mainWin.myStartEvent += myTimer.Start;
            this.mainWin.myStopEvent += myTimer.Stop;
            this.mainWin.myResetEvent += ResetTimer;
        }

        public void ResetTimer()
        {
            //model.timerValue = 0;
            model.timeVal = TimeSpan.FromSeconds(0);
            mainWin.textBlock.Text = model.timeVal.TotalSeconds.ToString();
        }
        public void myTimerTick(object sender, EventArgs e)
        {
            model.timeVal = model.timeVal + TimeSpan.FromSeconds(0.1);
            //model.timerValue = model.timerValue + 0.10;
            mainWin.textBlock.Text = model.timeVal.TotalSeconds.ToString();
        }



    }
}
