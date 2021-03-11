using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EcoRankMgr : MonoBehaviour
{
    public Text t_name;

    public void Start()
    {
        t_name.text = PlayerPrefs.GetString("Username");
    }
}
