﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COSE71197_DL.Models
{
    public interface IHardwareRepository
    {
        IEnumerable<Hardware> GetAllHardware { get;  }
        IEnumerable<Hardware> GetHardwareOnSale { get;  }
        Hardware GetHardwareByID(int hardwareId); 
    }
}

