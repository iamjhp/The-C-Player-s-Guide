﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboticInterface {
    public interface IRobotCommand {
        void Run(Robot robot);
    }
}
