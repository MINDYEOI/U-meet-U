using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkbox : MonoBehaviour
{
    public Image x1;
    public Image x2;
    public Image x3;
    public Image x4;

    public Image img_privacy;

    public void CheckboxOn1()
    {
        x1.gameObject.SetActive(true);
    }
    public void CheckboxOn2()
    {
        x2.gameObject.SetActive(true);
    }
    public void CheckboxOn3()
    {
        x3.gameObject.SetActive(true);
    }
    public void CheckboxOn4()
    {
        x4.gameObject.SetActive(true);
    }
    public void PrivacyOff()
    {
        img_privacy.gameObject.SetActive(false);
    }
}
