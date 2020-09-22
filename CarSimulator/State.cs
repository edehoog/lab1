using System;
namespace CarSimulator
{
    public class State
    {
        public double position;
        public double velocity;
        public double accelation;
        public double time;

        //implement methods like set, constructors (if applicable)

        //constructor that initializes everything in the stat to zero
        public State()
        {
            position = 0;
            velocity = 0;
            accelation = 0;
            time = 0;
        }

        //constructor that allows user initialization
        public State(double pos, double vel, double acc, double t)
        {
            position = pos;
            velocity = vel;
            accelation = acc;
            time = t;
        }

        //allows the user to modify the state values
        public void Set(double pos, double vel, double acc, double t)
        {
            position = pos;
            velocity = vel;
            accelation = acc;
            time = t;
        }

    }
}
