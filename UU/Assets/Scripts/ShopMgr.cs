using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopMgr : MonoBehaviour
{
    public Text t_ID;

    public Button btn_send;
    public Button btn_load;

    public GameObject send;
    public GameObject load;

    public Image coffeepage;

    public MoneyMgr mgr;

    public Text sendMoney;
    public Text addMoney;

    public void Start()
    {
        t_ID.text = PlayerPrefs.GetString("ID");
    }

    public void Load()
    {
        mgr.AddMoney(int.Parse(addMoney.text.ToString()));
    }

    public void Send()
    {
        mgr.SubMoney(int.Parse(sendMoney.text.ToString()));
    }

    public void SendPanelOn()
    {
        send.gameObject.SetActive(true);
    }

    public void SendPanelOff()
    {
        send.gameObject.SetActive(false);
    }

    public void LoadPanelOn()
    {
        load.gameObject.SetActive(true);
    }

    public void LoadPanelOff()
    {
        load.gameObject.SetActive(false);
    }

    public void CoffeeOn()
    {
        coffeepage.gameObject.SetActive(true);
    }

    public void CoffeeOff()
    {
        coffeepage.gameObject.SetActive(false);
    }
}
