using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScheduleDrivingMgr : MonoBehaviour
{
    public Image succeed;

    public InputField Date;

    public InputField StartingPoint;
    public InputField ST1;
    public InputField ST2;

    public InputField StopOverPoint;
    public InputField SOT1;
    public InputField SOT2;

    public InputField EndPoint;
    public InputField ET1;
    public InputField ET2;

    public Text t_StartPoint;
    public Text t_ST1;
    public Text t_ST2;

    public Text t_StopOverPoint;
    public Text t_SOT1;
    public Text t_SOT2;

    public Text t_EndPoint;
    public Text t_ET1;
    public Text t_ET2;

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "ScheduleDriving")
        {
            UpdateText(StartingPoint, t_StartPoint);
            UpdateText(ST1, t_ST1);
            UpdateText(ST2, t_ST2);
            UpdateText(StopOverPoint, t_StopOverPoint);
            UpdateText(SOT1, t_SOT1);
            UpdateText(SOT2, t_SOT2);
            UpdateText(EndPoint, t_EndPoint);
            UpdateText(ET1, t_ET1);
            UpdateText(ET2, t_ET2);
        }

        if (SceneManager.GetActiveScene().name == "ScheduleBoarding")
        {
            UpdateText(StartingPoint, t_StartPoint);
            UpdateText(ST1, t_ST1);
            UpdateText(ST2, t_ST2);
            UpdateText(EndPoint, t_EndPoint);
            UpdateText(ET1, t_ET1);
            UpdateText(ET2, t_ET2);
        }
    }

    void UpdateText(InputField input, Text text)
    {
        if (input.text != null && Input.GetKeyUp(KeyCode.Return))
        {
            text.text = input.text + " Station";
        }
    }

    public void SucceedImgOn()
    {
        succeed.gameObject.SetActive(true);
    }

    public void SucceedImgOff()
    {
        succeed.gameObject.SetActive(false);
    }
}
