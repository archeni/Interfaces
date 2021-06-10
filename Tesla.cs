using System;
using System.Collections.Generic;

namespace Garage
{
  public class Tesla : Vehicle, IElectricVehicle // Electric car
  {
    public double BatteryKWh { get; set; }
    public int CurrentChargePercentage { get; set; } = 0;

    public void ChargeBattery()
    {
      // method definition omitted
      CurrentChargePercentage = 100;
    }

    public override void Drive()
    {
      Console.WriteLine("The burgandy Tesla blazes past you. MMmmmmmm!");
    }

    public override void Turn(string direction)
    {
      base.Turn("right");
    }

    public override void Stop()
    {
      Console.WriteLine("The burgandy Tesla silently stops as if it never moved.");
    }
  }
}