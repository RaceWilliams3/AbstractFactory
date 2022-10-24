using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Car : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a car");
    }
}

public class MotorBike : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a motorbike");
    }
}

public class Truck : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a truck");
    }
}


public class TrophyTruck : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a trophy truck");
    }
}


public class DirtBike : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a dirtbike");
    }
}


public class ATV : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm an ATV");
    }
}


public class SxS : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a Side by side");
    }
}



