using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldNextButton : MonoBehaviour
{
    public Button Next;

    public InputField inputSchool;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        { 
            Next.gameObject.SetActive(true);
            PlayerPrefs.SetString("School", inputSchool.text);
        }
    }
}
