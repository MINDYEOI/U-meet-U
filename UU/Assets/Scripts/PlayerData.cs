using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour
{
    public Text schoolRank;
    public Text naturalRank;
    public Text usage;
    public Text level;

    public void Start()
    {
        if(SceneManager.GetActiveScene().name == "ProfilePage")
        {
            schoolRank.text = GetSchoolRank().ToString();
            naturalRank.text = GetRankNatural().ToString();
            usage.text = GetUsage().ToString();
            level.text = GetLevel().ToString();
        }
    }

    public void DeleteData()
    {
        PlayerPrefs.DeleteAll();
    }

    public int GetSchoolRank()
    {
        return PlayerPrefs.GetInt("RankSchool", 50);
    }
    public void SetSchoolRank(int num)
    {
        PlayerPrefs.GetInt("RankSchool", num);
    }
    public int GetRankNatural()
    {
       return  PlayerPrefs.GetInt("RankNatural", 100);
    }
    public void SetRankNatural(int num)
    {
        PlayerPrefs.GetInt("RankNatural", num);
    }
    public string GetLevel()
    {
        return PlayerPrefs.GetString("Level", "sprout");
    }
    public void SetLevel(string level)
    {
        PlayerPrefs.GetString("Level", level);
    }
    public int GetUsage()
    {
        return PlayerPrefs.GetInt("Usage", 11);
    }
    public void SetUsage(int num)
    {
        PlayerPrefs.GetInt("Usage", num);
    }
}
