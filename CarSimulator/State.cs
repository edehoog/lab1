using System;
namespace CarSimulator
{
    public class State
    {
        // state variables
        public double position;
        public double velocity;
        public double accelation;
        public double time;

        // constructor that initializes everything in the stat to zero
        public State()
        {
            position = 0;
            velocity = 0;
            accelation = 0;
            time = 0;
        }

        // constructor that allows user initialization
        public State(double pos, double vel, double acc, double t)
        {
            position = pos;
            velocity = vel;
            accelation = acc;
            time = t;
        }

        // REQUIRES: pos, vel, acc, t is of type double
        // EFFECTS: no return, but sets the state of object
        public void Set(double pos, double vel, double acc, double t)
        {
            position = pos;
            velocity = vel;
            accelation = acc;
            time = t;
        }

    }
}
