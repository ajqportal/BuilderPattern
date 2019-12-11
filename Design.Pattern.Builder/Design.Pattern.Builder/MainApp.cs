using System;
using Design.Pattern.Builder.Builders;
using Design.Pattern.Builder.Directors;
using Design.Pattern.Builder.Interfaces;

namespace Design.Pattern.Builder
{
    class MainApp
    {
        static void Main(string[] args)
        {
            IRobotBuilder oldStyleRobot = new RobotBuilder();
            RobotEngineer robotEngineer = new RobotEngineer(oldStyleRobot);
            robotEngineer.BuildRobot();
            var robot = robotEngineer.GetRobot();

            Console.WriteLine($"Your robot has been built with the following specs.\nHead: {robot.RobotHead}\nTorso: {robot.RobotTorso}\nArms: {robot.RobotArms}\nLegs: {robot.RobotLegs}");
            Console.ReadLine();
        }
    }
}
