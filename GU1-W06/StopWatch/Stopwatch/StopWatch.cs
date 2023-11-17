using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    public class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;

        public DateTime StartTime
        {
            get { return startTime; }
        }

        public DateTime EndTime
        {
            get { return endTime; }
        }

        public StopWatch()
        {
            startTime = DateTime.Now;
        }

        public void Start()
        {
            startTime = DateTime.Now;
        }

        public void Stop()
        {
            endTime = DateTime.Now;
        }

        public double GetElapsedTime()
        {
            TimeSpan elapsed = endTime - startTime;
            return elapsed.TotalMilliseconds;
        }
    }
}
