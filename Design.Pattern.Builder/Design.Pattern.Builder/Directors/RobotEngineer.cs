using System;
using System.Collections.Generic;
using System.Text;
using Design.Pattern.Builder.Interfaces;
using Design.Pattern.Builder.Models;

namespace Design.Pattern.Builder.Directors
{
    public class RobotEngineer
    {
        private readonly IRobotBuilder _robotBuilder;

        public RobotEngineer(IRobotBuilder robotBuilder)
        {
            _robotBuilder = robotBuilder;
        }

        public Robot GetRobot()
        {
            return _robotBuilder.GetRobot();
        }

        public void BuildRobot()
        {
            _robotBuilder.BuildRobotHead();
            _robotBuilder.BuildRobotTorso();
            _robotBuilder.BuildRobotArms();
            _robotBuilder.BuildRobotLegs();
        }
    }
}
