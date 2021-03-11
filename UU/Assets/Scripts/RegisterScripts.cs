using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterScripts : MonoBehaviour
{
    public Image awaiting;
    public Image approved;

    public void Awaitng()
    {
        awaiting.gameObject.SetActive(true);
    }

    public void Approved()
    {
        approved.gameObject.SetActive(true);
    }
}
