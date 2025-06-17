using UnityEngine;

public class AnalogClock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;

    void Update()
    {
        System.DateTime time = System.DateTime.Now;

        float hour = time.Hour % 12 + time.Minute / 60f;
        float minute = time.Minute + time.Second / 60f;
        float second = time.Second + time.Millisecond / 1000f;

        hourHand.localRotation = Quaternion.Euler(hour * 30f, 0f, 0f);     // X-axis
        minuteHand.localRotation = Quaternion.Euler(minute * 6f, 0f, 0f);  // X-axis
        secondHand.localRotation = Quaternion.Euler(second * 6f, 0f, 0f);  // X-axis
    }
}
