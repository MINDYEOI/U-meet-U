using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Preference : MonoBehaviour
{
    public Image samesex;
    public Image oppositesex;
    public Image dontcare1;

    public Image talk;
    public Image silent;
    public Image dontcare2;

    public Image message;
    public Image call;
    public Image dontcare3;

    private void Update()
    {
        CheckboxFirstRow();
        CheckboxSecondRow();
        CheckboxThirdRow();
    }

    private void CheckboxFirstRow()
    {
        if(PlayerPrefs.GetInt("Sex")==1)
        {
            samesex.gameObject.SetActive(true);
            oppositesex.gameObject.SetActive(false);
            dontcare1.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Sex") == 2)
        {
            samesex.gameObject.SetActive(false);
            oppositesex.gameObject.SetActive(true);
            dontcare1.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Sex") == 3)
        {
            samesex.gameObject.SetActive(false);
            oppositesex.gameObject.SetActive(false);
            dontcare1.gameObject.SetActive(true);
        }
    }

    private void CheckboxSecondRow()
    {
        if (PlayerPrefs.GetInt("Talk") == 1)
        {
            talk.gameObject.SetActive(true);
            silent.gameObject.SetActive(false);
            dontcare2.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Talk") == 2)
        {
            talk.gameObject.SetActive(false);
            silent.gameObject.SetActive(true);
            dontcare2.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Talk") == 3)
        {
            talk.gameObject.SetActive(false);
            silent.gameObject.SetActive(false);
            dontcare2.gameObject.SetActive(true);
        }
    }

    private void CheckboxThirdRow()
    {
        if (PlayerPrefs.GetInt("Message") == 1)
        {
            message.gameObject.SetActive(true);
            call.gameObject.SetActive(false);
            dontcare3.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Message") == 2)
        {
            message.gameObject.SetActive(false);
            call.gameObject.SetActive(true);
            dontcare3.gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Message") == 3)
        {
            message.gameObject.SetActive(false);
            call.gameObject.SetActive(false);
            dontcare3.gameObject.SetActive(true);
        }
    }

    public void SexSame()
    {
        PlayerPrefs.SetInt("Sex", 1);
    }

    public void SexOpposite()
    {
        PlayerPrefs.SetInt("Sex", 2);
    }

    public void SexDontCare()
    {
        PlayerPrefs.SetInt("Sex", 3);
    }

    public void TalkYes()
    {
        PlayerPrefs.SetInt("Talk", 1);
    }

    public void TalkNo()
    {
        PlayerPrefs.SetInt("Talk", 2);
    }

    public void TalkDontCare()
    {
        PlayerPrefs.SetInt("Talk", 3);
    }

    public void MessageYes()
    {
        PlayerPrefs.SetInt("Message", 1);
    }

    public void MessageNo()
    {
        PlayerPrefs.SetInt("Message", 2);
    }

    public void MessageDontCare()
    {
        PlayerPrefs.SetInt("Message", 3);
    }
}
