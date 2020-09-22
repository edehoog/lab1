using System;
namespace CarSimulator
{
    public class Car
    {
        private double mass;
        private string model;
        private double dragArea;
        private double engineForce;
        public State myCarState = new State();

        private double rho = 1.225;
        private double dragForce;
        private double x1;
        private double netForce;
        double v, x0, t, a;

        /// implement constructor and methods
        public Car(string model, double mass, double engineForce, double dragArea)
        {
            this.model = model;
            this.mass = mass;
            this.engineForce = engineForce;
            this.dragArea = dragArea;
        }

        public string getModel()
        {
            return model;
        }

        public double getMass()
        {
            return mass;
        }
        public void drive(double dt)
        {
            v = myCarState.velocity;
            x0 = myCarState.position;
            t = myCarState.time;

            dragForce = 0.5 * rho * dragArea * Math.Pow(v, 2.0);
            netForce = engineForce - dragForce; 
            a = CarSimulator.Physics1D.compute_acceleration(netForce, mass);
            v = CarSimulator.Physics1D.compute_velocity(v, a, dt);
            x1 = CarSimulator.Physics1D.compute_position(x0, v, dt);
            t += dt;

            myCarState.Set(x1, v, a, t);
        }

        public State getState()
        {
            return myCarState;
        }

        //implement inheritence


    }
}
