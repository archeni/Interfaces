using System;
using System.Collections.Generic;

namespace Garage
{
  public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
  {
    public double FuelCapacity { get; set; }
    public int CurrentTankPercentage { get; set; } = 0;

    public void RefuelTank()
    {
      // method definition omitted
      CurrentTankPercentage = 100;
    }

    public override void Drive()
    {
      Console.WriteLine("The white Cessna flashes by you. Zoooooom!");
    }

    public override void Turn(string direction)
    {
      base.Turn("right");
    }

    public override void Stop()
    {
      Console.WriteLine("The white Cessna rolls down the runway for a mile before stopping.");
    }
  }
}