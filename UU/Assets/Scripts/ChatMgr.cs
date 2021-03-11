using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ChatMgr : MonoBehaviour
{
    public GameObject UserArea, PartnerArea, DateArea;
    public RectTransform ContentRect;
    public Scrollbar scrollbar;
    public Toggle MineToggle;
    AreaScripts LastArea;

    public void ReceiveMessage(string text)
    {
        if (MineToggle.isOn) Chat(true, text, "나", null);
        else Chat(false, text, "타인", null);
    }

    public void LayoutVisible(bool b)
    {
        AndroidJavaClass kotlin = new AndroidJavaClass("com.unity3d.player.SubActivity");
        kotlin.CallStatic("LayoutVisible", b);
    }

    public void Chat(bool isSend, string text, string user, Texture picture)
    {
        if (text.Trim() == "") return;

        bool isBottom = scrollbar.value <= 0.00001f;

        AreaScripts Area = Instantiate(isSend ? UserArea : PartnerArea).GetComponent<AreaScripts>();
        Area.transform.SetParent(ContentRect.transform, false);
        Area.boxRect.sizeDelta = new Vector2(250, Area.boxRect.sizeDelta.y);
        Area.textRect.GetComponent<Text>().text = text;
        Fit(Area.boxRect);

        float X = Area.textRect.sizeDelta.x + 42;
        float Y = Area.textRect.sizeDelta.y;

        //두줄이상일경우
        if (Y > 49)
        {
            for (int i = 0; i < 100; i++)
            {
                Area.boxRect.sizeDelta = new Vector2(X - i * 2, Area.boxRect.sizeDelta.y);
                Fit(Area.boxRect);

                if (Y != Area.textRect.sizeDelta.y)
                {
                    Area.boxRect.sizeDelta = new Vector2(X - (i * 2) + 2, Y);

                    break;
                }
            }
        }
        else Area.boxRect.sizeDelta = new Vector2(X, Y);

        DateTime t = DateTime.Now;
        Area.time = t.ToString("yyyy/MM/dd/HH/mm");
        Area.user = user;

        int hour = t.Hour;
        if (t.Hour == 0) hour = 12;
        else if (t.Hour > 12) hour -= 12;
        Area.timeText.text = (t.Hour>12?"PM" : "AM")+hour+":"+t.Minute.ToString("D2");

        if(LastArea != null&&LastArea.time.Substring(0,10)!=Area.time.Substring(0,10))
        {
            Transform CurDatearea = Instantiate(DateArea).transform;
            CurDatearea.SetParent(ContentRect.transform, false);
            CurDatearea.SetSiblingIndex(CurDatearea.GetSiblingIndex() - 1);

            string week = "";
            switch (t.DayOfWeek)
            {
                case DayOfWeek.Sunday:week = "Sunday";break;
                case DayOfWeek.Monday: week = "Monday"; break;
                case DayOfWeek.Tuesday: week = "Tuesday"; break;
                case DayOfWeek.Wednesday: week = "Wednesday"; break;
                case DayOfWeek.Thursday: week = "Thursday"; break;
                case DayOfWeek.Friday: week = "Friday"; break;
                case DayOfWeek.Saturday: week = "Saturday"; break;
            }
            CurDatearea.GetComponent<AreaScripts>().dateText.text = t.Year + "년" + t.Month + "월" + t.Day + "일" + week + "요일";
        }

        Fit(Area.boxRect);
        Fit(Area.areaRect);
        Fit(ContentRect);
        LastArea = Area;

        if (!isSend && !isBottom) return;
        Invoke("ScrollDelay", 0.03f);
    }

    void Fit(RectTransform Rect) => LayoutRebuilder.ForceRebuildLayoutImmediate(Rect);
}
