using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamNectarineScheduleManager
{
    class Worker : Employee
    {
        private Team team;
        private ContractType contractType;

        public Worker()
        {
            this.contractType = ContractType.FullTime;
        }

    }
}
