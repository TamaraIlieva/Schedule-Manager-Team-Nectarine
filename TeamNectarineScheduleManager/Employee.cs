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
        private ContractType contractType;

        public Employee()
        {
            this.defaultSchedule = new Schedule();
            this.contractType = ContractType.FullTime;
        }
    }
}
