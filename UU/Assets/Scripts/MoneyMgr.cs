using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyMgr : MonoBehaviour
{
    public Text t_money;

    public void Update()
    {
        t_money.text = PlayerPrefs.GetInt("Money", 0).ToString();
    }

    public void SetMoney(int money)
    {
        PlayerPrefs.SetInt("Money", money);
    }

    public string GetMoney()
    {
       return PlayerPrefs.GetInt("Money").ToString();
    }

    public void SubMoney(int cost)
    {
        int Money = PlayerPrefs.GetInt("Money");

        if(Money>=cost) PlayerPrefs.SetInt("Money", Money - cost);
    }

    public void AddMoney(int cost)
    {
        int Money = PlayerPrefs.GetInt("Money");

        PlayerPrefs.SetInt("Money", Money + cost);
    }
}
