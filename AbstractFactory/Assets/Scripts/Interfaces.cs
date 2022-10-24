using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVehicle 
{
    string Start();
}

public interface IVehicleFactory
{
    public IVehicle Create(VehicleRequirements requirements);
}

