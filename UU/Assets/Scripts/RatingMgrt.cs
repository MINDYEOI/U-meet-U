using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RatingMgrt : MonoBehaviour
{
    public Image img_rating;

    private void Start()
    {

            PlayerPrefs.SetString("Rating", "true");

    }

    public void RatingOn()
    {
        img_rating.gameObject.SetActive(true);
    }

    public void RatingOff()
    {
        img_rating.gameObject.SetActive(false);

        PlayerPrefs.SetString("Rating", "false");
    }
}
