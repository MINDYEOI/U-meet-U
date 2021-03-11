using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonSetting : MonoBehaviour
{
    public Image menutoggle;

    public void ButtonSettingOn()
    {
        menutoggle.gameObject.SetActive(true);
    }

    public void ButtonSettingOff()
    {
        menutoggle.gameObject.SetActive(false);
    }
}
