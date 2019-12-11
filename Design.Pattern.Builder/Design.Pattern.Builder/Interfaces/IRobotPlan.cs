using System;
using System.Collections.Generic;
using System.Text;

namespace Design.Pattern.Builder.Interfaces
{
    public interface IRobotPlan
    {
        void SetRobotHead(string head);
        void SetRobotTorso(string torso);
        void SetRobotArms(string arms);
        void SetRobotLegs(string legs);
    }
}
