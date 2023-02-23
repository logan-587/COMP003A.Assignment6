﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Interfaces are contracts that the inheriting class has to implement
    /// </summary>
    internal interface IVehicle
    {
        /// <summary>
        /// This method is required to be implemented in the inheriting class
        /// </summary>
        public void GetInfo();
    }
}
