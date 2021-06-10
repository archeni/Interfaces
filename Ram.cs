using System;

namespace Garage
{
  public class Ram : Vehicle, IGasVehicle // Gas powered truck
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
      Console.WriteLine("The silver Ram growls past you. RRRRrrummmmmble!");
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