using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [SerializeField]
    private GameObject secondsHand, minutesHand, hoursHand;

    private string oldSeconds;

    private void Start()
    {
        secondsHand.transform.eulerAngles = new Vector3(6*int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("ss")), secondsHand.transform.eulerAngles.y, secondsHand.transform.eulerAngles.z);
    }

    // Update is called once per frame
    void Update()
    {
        string seconds = System.DateTime.UtcNow.ToString("ss");
        if (seconds != oldSeconds)
        {
            UpdateTimer();
        }
        oldSeconds = seconds;
    }

    void UpdateTimer()
    {
        int secondsInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("ss"));
        int minutesInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("mm"));
        int hoursInt = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("hh"));
        Debug.Log(secondsInt);
        secondsHand.transform.eulerAngles = Vector3.Slerp(secondsHand.transform.eulerAngles, new Vector3(secondsInt*6, secondsHand.transform.eulerAngles.y, secondsHand.transform.eulerAngles.z), Time.deltaTime);
    }
}
