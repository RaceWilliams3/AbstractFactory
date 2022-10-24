using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unicycle : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a unicycle");
    }
}

public class Bicycle : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a Bicycle");
    }
}

public class Tandem : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a tandem bike");
    }
}

public class Tricycle : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a tricycle");
    }
}

public class GoKart : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a go kart");
    }
}

public class FamilyBike : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a family bike");
    }
}


public class MountainBike : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a mountain Bike");
    }
}


public class WalkingStick : MonoBehaviour, IVehicle
{
    public string Start()
    {
        return ("I'm a walking stick");
    }
}
