using System;
using System.Collections.Generic;
using System.Text;
using Design.Pattern.Builder.Interfaces;

namespace Design.Pattern.Builder.Models
{
    public class Robot: IRobotPlan
    {
        public string RobotHead { get; set; }
        public string RobotTorso { get; set; }
        public string RobotArms { get; set; }
        public string RobotLegs { get; set; }

        public void SetRobotHead(string head)
        {
            RobotHead = head;
        }

        public void SetRobotTorso(string torso)
        {
            RobotTorso = torso;
        }

        public void SetRobotArms(string arms)
        {
            RobotArms = arms;
        }

        public void SetRobotLegs(string legs)
        {
            RobotLegs = legs;
        }
    }
}
