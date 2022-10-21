using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Car : MonoBehaviour, IVehicle
{
    public void Start()
    {
        Debug.Log("I'm a car");
    }
}

public class MotorBike : MonoBehaviour, IVehicle
{
    public void Start()
    {
        Debug.Log("I'm a motorbike");
    }
}

public class Truck : MonoBehaviour, IVehicle
{
    public void Start()
    {
        Debug.Log("I'm a truck");
    }
}
