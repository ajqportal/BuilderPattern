using System;
using System.Collections.Generic;
using System.Text;
using Design.Pattern.Builder.Interfaces;
using Design.Pattern.Builder.Models;

namespace Design.Pattern.Builder.Builders
{
    public class RobotBuilder : IRobotBuilder
    {
        private readonly Robot _robot;

        public RobotBuilder() => _robot = new Robot();


        public void BuildRobotHead()
        {
            _robot.SetRobotHead("Tin Head");
            
        }

        public void BuildRobotTorso()
        {
            _robot.SetRobotTorso("Tin Torso");
        }

        public void BuildRobotArms()
        {
            _robot.SetRobotArms("Drilling Arms");
        }

        public void BuildRobotLegs()
        {
            _robot.SetRobotLegs("Ball Legs");
        }

        public Robot GetRobot()
        {
            return _robot;
        }
    }
}
