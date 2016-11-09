using UnityEngine;
using System.Collections;

public class WeatherLight : MonoBehaviour {

	public Light Source;
	public float PULSE_RANGE = 4.0f;
	public float PULSE_SPEED = 3.0f;

	void Start () {
		Source.intensity = 0;
	}

	void Update () {
		Source.intensity = Mathf.PingPong(Time.time * PULSE_SPEED, PULSE_RANGE);
	}
}
