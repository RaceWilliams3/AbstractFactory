using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Client : MonoBehaviour
{

    [Header("UI")]
    public Button create;
    public Toggle hasEngine;
    public Toggle carriesCargo;
    public Slider passengers;
    public Slider wheels;

    private VehicleRequirements requirements;
    private IVehicle x;

    void Update()
    {
        requirements.hasEngine = hasEngine.isOn;
        requirements.hasCargo = carriesCargo.isOn;
        requirements.passengers = (int)passengers.value;
        requirements.numberOfWheels = (int)wheels.value;
            
    }

    public void OnCreateButton()
    {
        x = GetVehicle(requirements);
        x.Start();
    }

    public IVehicle GetVehicle(VehicleRequirements requirements)
    {
        var factory = new VehicleFactory();
        IVehicle vehicle;

        if (requirements.hasEngine)
        {
            vehicle = factory.MotorVehicleFactory().Create(requirements);
        }
        else
        {
            vehicle = factory.CycleFactory().Create(requirements);
        }
        return vehicle;

    }
}
