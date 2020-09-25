using System;
namespace CarSimulator
{

    public class Physics1D
    {
        // REQUIRES: x0, v, dt is passed as type double
        // EFFECTS: returns the postion
        public static double compute_position(double x0, double v, double dt)
        {
            double x1 = x0 + (v * dt);
            return x1;
        }
        // REQUIRES: v0, a and dt is passed as type double
        // EFFECTS: returns the velocity based on initial velocity, acceleration and time
        public static double compute_velocity(double v0, double a, double dt)
        { // to do
            double v1 = v0 + (a * dt);
            return v1;
        }
        // REQUIRES: x0, t0, x1, t1 is passed as type double
        // EFFECTS: returns the velocity based on postion and time
        public static double compute_velocity(double x0, double t0, double x1, double t1)
        { // to do
            double v = (x1 - x0) / (t1 - t0);
            return v;
        }
        // REQUIRES: v0, t0, v1, t1 is passed as type double
        // EFFECTS: returns the acceleration based on velocity and time
        public static double compute_acceleration(double v0, double t0, double v1, double t1)
        { // to do
            double a = (v1 - v0) / (t1 - t0);
            return a;
        }
        // REQUIRES: f, m is passed as type double
        // EFFECTS: returns the acceleration based on force and mass
        public static double compute_acceleration(double f, double m)
        { // to do
            double a = f / m;
            return a;
        }
    }
}
