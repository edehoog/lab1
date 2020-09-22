using System;
using System.Runtime.InteropServices;

namespace CarSimulator
{
    public class DragRace
    {
        static void Main(string[] args)
        {

            Car myTesla = new Car("Tesla", 1500, 1000, 0.51);
            Car myPrius = new Car("Prius", 1000, 750, 0.43);

            double finishTimePrius = 0;
            double finishTimeTesla = 0;

            bool priusFinshed = false;
            bool teslaFinished = false;

            double finishLine = 402.3;

            // drive for 60 seconds with delta time of 1s
            double dt = 1;

            for (double t = 0; t < 60; t += dt)
            {
                myTesla.drive(dt);
                myPrius.drive(dt);

                State myTeslaState = myTesla.getState();
                State myPriusState = myPrius.getState();

                if (myTeslaState.position > finishLine && !teslaFinished)
                {
                    finishTimeTesla = t + dt;
                    teslaFinished = true;
                }
                if (myPriusState.position > finishLine && !priusFinshed)
                {
                    finishTimePrius = t + dt;
                    priusFinshed = true;
                }

                // print the time and current state
                Console.WriteLine("Tesla: t:{0}, a:{1}, v:{2}, x1:{3} ", myTeslaState.time, myTeslaState.accelation, myTeslaState.velocity, myTeslaState.position);
                Console.WriteLine("Prius: t:{0}, a:{1}, v:{2}, x1:{3} ", myPriusState.time, myPriusState.accelation, myPriusState.velocity, myPriusState.position);

                if (priusFinshed && teslaFinished)
                {
                    if (finishTimePrius < finishTimeTesla)
                    {
                        Console.WriteLine("My Prius won the race with a time of {0}, beating my Tesla which had a time of {1}", finishTimePrius, finishTimeTesla);
                    }
                    else
                    {
                        Console.WriteLine("My Tesla won the race with a time of {0}, beating my Prius which had a time of {1}", finishTimeTesla, finishTimePrius);
                    }
                    break;
                }

                // print who is in lead
                if (myTeslaState.position > myPriusState.position)
                {
                    Console.WriteLine("My Tesla is in the Lead!");
                }
                else if (myTeslaState.position < myPriusState.position){
                    Console.WriteLine("What? My Prius is beating the Tesla!");
                }
                else
                {
                    Console.WriteLine("My Tesla and Prius are tied!");
                }
            }
        }
    }
}
