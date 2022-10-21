using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unicycle : MonoBehaviour, IVehicle
{
    public void Start()
    {
        Debug.Log("I'm a unicycle");
    }
}

public class Bicycle : MonoBehaviour, IVehicle
{
    public void Start()
    {
        Debug.Log("I'm a Bicycle");
    }
}

public class Tandem : MonoBehaviour, IVehicle
{
    public void Start()
    {
        Debug.Log("I'm a tandem bike");
    }
}

public class Tricycle : MonoBehaviour, IVehicle
{
    public void Start()
    {
        Debug.Log("I'm a tricycle");
    }
}

public class GoKart : MonoBehaviour, IVehicle
{
    public void Start()
    {
        Debug.Log("I'm a go kart");
    }
}

public class FamilyBike : MonoBehaviour, IVehicle
{
    public void Start()
    {
        Debug.Log("I'm a family bike");
    }
}
