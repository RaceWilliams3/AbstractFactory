using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct VehicleRequirements
{
    public int numberOfWheels;
    public int passengers;
    public bool hasEngine;
    public bool hasCargo;
    public bool offRoad;
}


public abstract class AbstractVehicleFactory : MonoBehaviour
{
    public abstract IVehicleFactory CycleFactory();
    public abstract IVehicleFactory MotorVehicleFactory();
    public abstract IVehicleFactory OffroadVehicleFactory();
}

public class CycleFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements requirements)
    {
        switch (requirements.numberOfWheels)
        {
            case 1:
                return new Unicycle();
            case 2:
                if(requirements.passengers > 1)
                    return new Tandem();
                return new Bicycle();
            case 3:
                return new Tricycle();
            case 4:
                if (requirements.hasCargo)
                    return new GoKart();
                return new FamilyBike();
            defualt:
                return new Bicycle();

        }
        return null;
    }
}

public class MotorVehicleFactory : IVehicleFactory
{
    public IVehicle Create (VehicleRequirements requirements)
    {
        if (requirements.hasCargo)
        {
            return new Truck();
        }
        else if (requirements.numberOfWheels <= 2)
        {
            return new MotorBike();
        }
        else
            return new Car();
    }
}

public class OffroadVehicleFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements requirements)
    {
        switch(requirements.numberOfWheels)
        {
            case 2:
                if (requirements.hasEngine)
                    return new DirtBike();
                else
                    return new MountainBike();
            case 4:
                if (requirements.hasCargo)
                    return new TrophyTruck();
                else
                {
                    if (requirements.passengers <= 2)
                        return new ATV();
                    else
                        return new SxS();
                }
                
            default:
                return new WalkingStick();
        }
        return null;
    }
}

public class VehicleFactory : AbstractVehicleFactory
{
    public override IVehicleFactory CycleFactory()
    {
        return new CycleFactory();
    }

    public override IVehicleFactory MotorVehicleFactory()
    {
        return new MotorVehicleFactory();
    }

    public override IVehicleFactory OffroadVehicleFactory()
    {
        return new OffroadVehicleFactory();
    }
}
