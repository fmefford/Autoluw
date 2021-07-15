using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    private float time = 0f;
    private int hour = 12;
    private int date = 1;
    private int month = 1;
    private int year = 2020;

    enum Speed
    {
        Slow,
        Normal,
        Fast,
    }
    Speed currSpeed = Speed.Normal;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch(currSpeed)
        {
            case Speed.Slow:
                time += .5f * Time.deltaTime;
                break;
            case Speed.Normal:
                time += Time.deltaTime;
                break;
            case Speed.Fast:
                time += 2f * Time.deltaTime;
                break;
        }
        if (time >= 30)
        {
            time = 0;
            if (hour < 24)
            {
                hour++;
            }
            else
            {
                hour = 1;
                switch (month)
                {
                    case 1:

                    case 3:

                    case 5:

                    case 7:

                    case 8:

                    case 10:

                    case 12:
                        if (date < 31)
                        {
                            date++;
                        }
                        break;

                    case 4:

                    case 6:

                    case 9:

                    case 11:
                        if (date < 30)
                        {
                            date++;
                        }
                        break;

                    case 2:
                        if (date < 28)
                        {
                            date++;
                        }
                        break;
                }
            }
        }
    }

    public float getTime()
    {
        return time;
    }
}
