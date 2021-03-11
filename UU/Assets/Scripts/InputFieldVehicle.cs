using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldVehicle : MonoBehaviour
{
    public InputField inputVehiclePlate;
    public InputField inputManufacturer;
    public InputField inputModelName;

    public Button btn_car;
    public Button btn_license;

    public Image car;
    public Image license;

    public void SaveData()
    {
        PlayerPrefs.SetString("VeciclePlate", inputVehiclePlate.text);
        PlayerPrefs.SetString("Manufacturer", inputManufacturer.text);
        PlayerPrefs.SetString("ModelName", inputModelName.text);
    }

    public void CarImg()
    {
        btn_car.gameObject.SetActive(false);
        car.gameObject.SetActive(true);
    }

    public void LicenseImg()
    {
        btn_license.gameObject.SetActive(false);
        license.gameObject.SetActive(true);
    }
}
