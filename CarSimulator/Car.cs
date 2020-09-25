using System;
namespace CarSimulator
{
    public class Car
    {
        protected double mass;
        protected string model;
        private double dragArea;
        protected double engineForce;

        public State myCarState = new State();

        protected double rho = 1.225;
        private double dragForce;
        protected double x1;
        private double netForce;
        protected double v, x0, t, a;

        // empty constructor
        public Car() { }

        //constructor that allows user initialization
        public Car(string model, double mass, double engineForce, double dragArea)
        {
            this.model = model;
            this.mass = mass;
            this.engineForce = engineForce;
            this.dragArea = dragArea;
        } 
        // EFFECTS: returns objects model name
        public string getModel()
        {
            return model;
        }

        // EFFECTS: returns objects mass
        public double getMass()
        {
            return mass;
        }

        // REQUIRES: dt is of type double and the value passed is considered to be seconds
        // EFFECTS: no return, but updates object state
        public virtual void Drive(double dt)
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

        // EFFECTS: returns the objects state
        public State getState()
        {
            return myCarState;
        }

    }
        public class Prius : Car
        {
            public Prius() : base()
            {

            }
            public Prius(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
            {

            }
        }
        public class Mazda3 : Car
        {
            public Mazda3() : base()
            {

            }
            public Mazda3(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
            {

            }
        }
        public class Tesla3 : Car
        {
            public Tesla3() : base()
            {

            }
            public Tesla3(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
            {

            }
        }
        public class Herbie : Car
        {
            public Herbie() : base()
            {

            }
            public Herbie(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
            {

            }

            // REQUIRES: dt is of type double and the value passed is considered to be seconds
            // EFFECTS: no return, but updates object state
            public override void Drive(double dt)
            {
                // Herbie ignores air resistance
                v = myCarState.velocity;
                x0 = myCarState.position;
                t = myCarState.time;
                a = CarSimulator.Physics1D.compute_acceleration(engineForce, mass);
                v = CarSimulator.Physics1D.compute_velocity(v, a, dt);
                x1 = CarSimulator.Physics1D.compute_position(x0, v, dt);
                t += dt;

                myCarState.Set(x1, v, a, t);
            }
        }

}
