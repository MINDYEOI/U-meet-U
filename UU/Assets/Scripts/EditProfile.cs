using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditProfile : MonoBehaviour
{
    public Text t_school;

    public void Start()
    {
        t_school.text = PlayerPrefs.GetString("School");
    }
}
