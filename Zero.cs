using System;
using System.Collections.Generic;

namespace Garage
{
  public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
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
      Console.WriteLine("The midnight blue Zero zips by you. Yeeeeeeooow!");
    }

    public override void Turn(string direction)
    {
      base.Turn("right");
    }

    public override void Stop()
    {
      base.Stop();
    }
  }
}