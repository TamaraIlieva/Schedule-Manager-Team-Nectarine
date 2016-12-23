using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamNectarineScheduleManager
{
    class Schedule
    {
        private const int numberOfBreaks = 3;
        private string dayStart;
        private string dayEnd;
        private string lunchStart;
        private string lunchEnd;

        public Schedule()
        {
            this.dayStart = "0900";
            this.dayEnd = "1800";
            this.lunchStart = "1300";
            this.lunchEnd = "1400";
        }

        public Schedule(string dayStart, string dayEnd, string lunchStart, string lunchEnd)
        {
            this.dayStart = dayStart;
            this.dayEnd = dayEnd;
            this.lunchStart = lunchStart;
            this.lunchEnd = lunchEnd;
        }
    }
}
