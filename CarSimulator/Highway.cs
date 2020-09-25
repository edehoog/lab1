using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace CarSimulator
{
    public class Highway
    {
        static void Main(string[] args)
        {
            double dt = 1;

            int fleetNumberPerType = 25;

            // set the car constants
            string teslaModel = "Tesla3";
            int teslaMass = 1500;
            int teslaEngineForce = 1000;
            double teslaDrageArea = 0.51;

            string priusModel = "Prius";
            int priusMass = 1000;
            int priusEngineForce = 750;
            double priusDrageArea = 0.43;

            string mazdaModel = "Mazda3";
            int mazdaMass = 1250;
            int mazdaEngineForce = 850;
            double mazdaDrageArea = 0.41;

            string herbie = "Herbie";
            int herbieMass = 1000;
            int herbieEngineForce = 1250;
            double herbieDrageArea = 0;
            double choice = 0;

            do
            {
                // pt3 is the four seperate fleets while pt4 is the fleet with all cars in a list
                Console.WriteLine("Would you like to run Q2 part 3 or part 4? (Enter 3 for part 3 or 4 for part 4)");
                try
                {
                    choice = Convert.ToDouble(Console.ReadLine());
                }
                catch 
                {
                    continue;
                }
            } while (choice != 3.0 && choice != 4.0) ;

            if (choice == 1.0)
            {
                //Step 1 (part3): implement fleets of arrays/lists per vehicle type
                // and compute states

                Tesla3[] myTeslas = new Tesla3[fleetNumberPerType].Select(s => new Tesla3(teslaModel, teslaMass, teslaEngineForce, teslaDrageArea)).ToArray();
                Prius[] myPriuses = new Prius[fleetNumberPerType].Select(s => new Prius(priusModel, priusMass, priusEngineForce, priusDrageArea)).ToArray();
                Mazda3[] myMazdas = new Mazda3[fleetNumberPerType].Select(s => new Mazda3(mazdaModel, mazdaMass, mazdaEngineForce, mazdaDrageArea)).ToArray();
                Herbie[] myHerbies = new Herbie[fleetNumberPerType].Select(s => new Herbie(herbie, herbieMass, herbieEngineForce, herbieDrageArea)).ToArray();

                for (double t = 0; t < 60; t += dt)
                {
                    for (int i = 0; i < fleetNumberPerType; i++)
                    {
                        myTeslas[i].Drive(dt);
                        State myTeslasState = myTeslas[i].getState();
                        Console.WriteLine("Model:{0}, t:{1}, a:{2}, v:{3}, x1:{4} ", myTeslas[i].getModel(), myTeslasState.time, myTeslasState.accelation, myTeslasState.velocity, myTeslasState.position);
                        myPriuses[i].Drive(dt);
                        State myPriusesState = myTeslas[i].getState();
                        Console.WriteLine("Model:{0}, t:{1}, a:{2}, v:{3}, x1:{4} ", myPriuses[i].getModel(), myPriusesState.time, myPriusesState.accelation, myPriusesState.velocity, myPriusesState.position);
                        myMazdas[i].Drive(dt);
                        State myMazdasState = myMazdas[i].getState();
                        Console.WriteLine("Model:{0}, t:{1}, a:{2}, v:{3}, x1:{4} ", myMazdas[i].getModel(), myMazdasState.time, myMazdasState.accelation, myMazdasState.velocity, myMazdasState.position);
                        myHerbies[i].Drive(dt);
                        State myHerbiesState = myHerbies[i].getState();
                        Console.WriteLine("Model:{0}, t:{1}, a:{2}, v:{3}, x1:{4} ", myHerbies[i].getModel(), myHerbiesState.time, myHerbiesState.accelation, myHerbiesState.velocity, myHerbiesState.position);
                    }
                }
            }
            else
            {
                //Step 2 (part4): implement all the fleet in one list and compute states
                var myCars = new List<Car>();

                for (int i = 0; i < fleetNumberPerType; i++)
                {
                    myCars.Add(new Tesla3(teslaModel, teslaMass, teslaEngineForce, teslaDrageArea));
                    myCars.Add(new Prius(priusModel, priusMass, priusEngineForce, priusDrageArea));
                    myCars.Add(new Mazda3(mazdaModel, mazdaMass, mazdaEngineForce, mazdaDrageArea));
                    myCars.Add(new Herbie(herbie, herbieMass, herbieEngineForce, herbieDrageArea));
                }

                for (double t = 0; t < 60; t += dt)
                {
                    for (int i = 0; i < myCars.Count(); i++)
                    {
                        myCars[i].Drive(dt);
                        State myCarState = myCars[i].getState();
                        // These values are overstated, drag is understated
                        Console.WriteLine("Model:{0}, t:{1}, a:{2}, v:{3}, x1:{4} ", myCars[i].getModel(), myCarState.time, myCarState.accelation, myCarState.velocity, myCarState.position);
                    }
                }
            }
        }

    }
}
