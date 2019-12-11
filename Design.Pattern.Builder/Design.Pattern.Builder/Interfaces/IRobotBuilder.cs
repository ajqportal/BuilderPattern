using System;
using System.Collections.Generic;
using System.Text;
using Design.Pattern.Builder.Models;

namespace Design.Pattern.Builder.Interfaces
{
    public interface IRobotBuilder
    {
        void BuildRobotHead();
        void BuildRobotTorso();
        void BuildRobotArms();
        void BuildRobotLegs();
        Robot GetRobot();
    }
}
