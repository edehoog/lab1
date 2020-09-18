using System;
namespace CarSimulator
{

    public class Physics1D
    {
        // Implement the methods
        public static double compute_position(double x0, double v, double dt)
        { // to do
            double x1 = x0 + (v * dt);
            return x1;
        }
        public static double compute_velocity(double v0, double a, double dt)
        { // to do
            double v1 = v0 + (a * dt);
            return v1;
        }
        public static double compute_velocity(double x0, double t0, double x1, double t1)
        { // to do
            double v = (x1 - x0) / (t1 - t0);
            return v;
        }
        public static double compute_acceleration(double v0, double t0, double v1, double t1)
        { // to do
            double a = (v1 - v0) / (t1 - t0);
            return a;
        }
        public static double compute_acceleration(double f, double m)
        { // to do
            double a = f / m;
            return a;
        }
    }
}
