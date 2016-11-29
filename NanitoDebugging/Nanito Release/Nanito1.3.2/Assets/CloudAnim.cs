using UnityEngine;
using System.Collections;

public class CloudAnim : MonoBehaviour {

	Vector3 pos1;
	Vector3 pos2;
	int posdecision;
	int posdecision1;

	float x1;
	float x2;
	float z1;
	float z2;
	float y;

	void Start() {

		posdecision = Random.Range (1, 3);
		posdecision1 = Random.Range (1, 4);

		y = transform.position.y;

		if (posdecision == 1) {

			x1 = transform.position.x - 10;
			x2 = transform.position.x + 10;

			if (posdecision1 == 1) {
				z1 = transform.position.z - 5;
				z2 = transform.position.z + 5;
			}

			else if (posdecision1 == 2) {
				z1 = transform.position.z + 5;
				z2 = transform.position.z - 5;
			}
			else if (posdecision1 == 3) {
				z1 = transform.position.z + 0;
				z2 = transform.position.z + 0;
			}
			 
			pos1 = new Vector3(x1,y,z1);
			pos2 = new Vector3(x2,y,z2);


		} else {
			z1 = transform.position.z - 10;
			z2 = transform.position.z + 10;

			if (posdecision1 == 1) {
				x1 = transform.position.x - 5;
				x2 = transform.position.x + 5;
			}
				
			else if (posdecision1 == 2) {
				x1 = transform.position.x + 5;
				x2 = transform.position.x - 5;
			}
			else if (posdecision1 == 3) {
				x1 = transform.position.x + 0;
				x2 = transform.position.x + 0;
			}

			pos1 = new Vector3(x1,y,z1);
			pos2 = new Vector3(x2,y,z2);

		}


	}

	void Update() {
		this.gameObject.transform.position = Vector3.Lerp (pos1, pos2, Mathf.PingPong(Time.time/1.5f, 1.0f));
	}
}  

