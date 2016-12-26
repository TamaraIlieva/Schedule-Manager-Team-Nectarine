using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamNectarineScheduleManager
{
    class Activity
    {
        private ActivityType activityType;

        public Activity()
        {
            this.activityType = ActivityType.Backoffice; // this is the default activity
        }
    }
}
