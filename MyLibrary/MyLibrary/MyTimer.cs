using System;
using System.ComponentModel;

namespace MyLibrary
{
    public class MyTimer
    {
        //declare background worker

        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private int tInterval;

        //delegate and event
        public delegate void timerTick();
        //event
        public event timerTick tick;
        public MyTimer()
        {
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            backgroundWorker.DoWork += new DoWorkEventHandler(DoWork);
            backgroundWorker.WorkerSupportsCancellation = true;
            tInterval = 100; // sleeping for 100 millisecond



        }

        //property of tickInterval
        public int tickInt
        {
            get
            {
                return tInterval;
            }
            set
            {

                tInterval = value;
            }
        }

        //start button
        public void Start()
        {
            if (backgroundWorker.IsBusy == false)
            {
                backgroundWorker.RunWorkerAsync(); // run the background worker
            }
        }


        //method
        private void DoWork(object sender, DoWorkEventArgs e)
        {
            //what to do in background
            // Go to Sleep:
            while (backgroundWorker.CancellationPending == false)
            {
                // sleeping for tInterval
                System.Threading.Thread.Sleep(tInterval);
                //call tick event
                tick();

            }

        }

        public void Stop()
        {
            backgroundWorker.CancelAsync();
        }
    }
}
