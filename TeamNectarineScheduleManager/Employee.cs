using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamNectarineScheduleManager
{
    class Employee
    {
        private Schedule defaultSchedule;
        private Team team;
        private string username; // needed for log-in
        private string password; // needed for log-in

        public Employee()
        {
            this.defaultSchedule = new Schedule();
            this.team = new Team();
        }
    }
}
