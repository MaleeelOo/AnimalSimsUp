using System;
using System.Collections.Generic;
using System.Text;

namespace animalsimsup
{
    class Time
    {
        private DateTime lastTime;
        public Time()
        {
            lastTime = DateTime.Now;
        }
        public double get_elapsed_time()
        {
            TimeSpan elapsed = DateTime.Now - lastTime;
            lastTime = DateTime.Now;
            return elapsed.TotalSeconds;
        }
    }
}
