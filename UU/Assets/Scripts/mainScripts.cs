using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainScripts : MonoBehaviour
{
    public Image img_all;
    public Image img_driving;
    public Image img_boarding;

    public Image img_allUser;
    public Image img_drivingUser;
    public Image img_boardingUser;

    public Image sohee;

    public Image rating;

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            sohee.gameObject.SetActive(true);

            img_allUser.gameObject.SetActive(false);
            img_drivingUser.gameObject.SetActive(false);
            img_boardingUser.gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetString("Rating") =="true")
        {
            rating.gameObject.SetActive(true);
        }
    }

    public void All()
    {
        img_all.gameObject.SetActive(true);
        img_driving.gameObject.SetActive(false);
        img_boarding.gameObject.SetActive(false);

        img_allUser.gameObject.SetActive(true);
        img_drivingUser.gameObject.SetActive(false);
        img_boardingUser.gameObject.SetActive(false);
    }

    public void Driving()
    {
        img_all.gameObject.SetActive(false);
        img_driving.gameObject.SetActive(true);
        img_boarding.gameObject.SetActive(false);

        img_allUser.gameObject.SetActive(false);
        img_drivingUser.gameObject.SetActive(true);
        img_boardingUser.gameObject.SetActive(false);
    }

    public void Boarding()
    {
        img_all.gameObject.SetActive(false);
        img_driving.gameObject.SetActive(false);
        img_boarding.gameObject.SetActive(true);

        img_allUser.gameObject.SetActive(false);
        img_drivingUser.gameObject.SetActive(false);
        img_boardingUser.gameObject.SetActive(true);
    }
}
