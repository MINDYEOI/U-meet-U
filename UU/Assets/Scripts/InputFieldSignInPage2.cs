using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldSignInPage2 : MonoBehaviour
{
    public InputField inputID;
    public InputField inputPassword;
    public InputField inputUsername;
    public InputField inputStatus;

    public Text school;

    public Button btn_profile;
    public Image profile;

    public void Start()
    {
        school.text = PlayerPrefs.GetString("School");
    }

    public void SaveData()
    {
        PlayerPrefs.SetString("ID", inputID.text);
        PlayerPrefs.SetString("Password", inputPassword.text);
        PlayerPrefs.SetString("Username", inputUsername.text);
        PlayerPrefs.SetString("Status", inputStatus.text);
    }

    public void EditData()
    {
        PlayerPrefs.SetString("Password", inputPassword.text);
        PlayerPrefs.SetString("Username", inputUsername.text);
        PlayerPrefs.SetString("Status", inputStatus.text);
    }

    public void LoadData()
    {
        if(PlayerPrefs.HasKey("ID"))
        {
            inputID.text = PlayerPrefs.GetString("ID");
            inputPassword.text = PlayerPrefs.GetString("Password");
            inputUsername.text = PlayerPrefs.GetString("Username");
            inputStatus.text = PlayerPrefs.GetString("Status");
        }    
    }

    public void ProfileImg()
    {
        btn_profile.gameObject.SetActive(false);
        profile.gameObject.SetActive(true);
    }
}
