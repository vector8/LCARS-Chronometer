using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class StardateCalculator : MonoBehaviour
{
    Text text;
    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        System.DateTime currentTime = System.DateTime.Now;

        string stardate = currentTime.ToString("yyyyMMdd");
        float hours = currentTime.Hour + (currentTime.Minute / 60f);
        string hourString = (hours / 24f).ToString();
        hourString = hourString.Substring(2, 2);
        stardate += "." + hourString;

        text.text = stardate;
    }
}
