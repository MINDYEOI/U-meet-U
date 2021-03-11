using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProfileMgr : MonoBehaviour
{
    public Text t_Name;
    public Text t_message;

    public void Start()
    {
        t_Name.text = PlayerPrefs.GetString("Username");
        t_message.text = PlayerPrefs.GetString("Status");
    }
}
