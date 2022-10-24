using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Client : MonoBehaviour
{

    [Header("UI")]
    public Button create;
    public Toggle hasEngine;
    public Toggle carriesCargo;
    public Toggle Offroad;
    public Slider passengers;
    public Slider wheels;

    public TMP_Text text;

    private VehicleRequirements requirements;
    private IVehicle x;

    void Update()
    {
        requirements.hasEngine = hasEngine.isOn;
        requirements.hasCargo = carriesCargo.isOn;
        requirements.passengers = (int)passengers.value;
        requirements.numberOfWheels = (int)wheels.value;
        requirements.offRoad = Offroad.isOn;
            
    }

    public void OnCreateButton()
    {
        x = GetVehicle(requirements);
        text.text = x.Start();
    }

    public IVehicle GetVehicle(VehicleRequirements requirements)
    {
        var factory = new VehicleFactory();
        IVehicle vehicle;

        if (requirements.offRoad)
        {
            vehicle = factory.OffroadVehicleFactory().Create(requirements);
        }
        else
        {
            if (requirements.hasEngine)
            {
                vehicle = factory.MotorVehicleFactory().Create(requirements);
            }
            else
            {
                vehicle = factory.CycleFactory().Create(requirements);
            }
        }
        return vehicle;

    }
}
