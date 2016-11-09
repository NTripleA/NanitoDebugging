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
	float x;
	float y;
	float z;

	void Start() {

		posdecision = Random.Range (1, 5);
		posdecision1 = Random.Range (1, 4);

		x = transform.position.x;
		y = transform.position.y;
		z = transform.position.z;


		if (posdecision < 3) {

			if (posdecision == 1) {
				x1 = transform.position.x - 5;
				x2 = transform.position.x + 5;

				if (posdecision1 == 1) {
					z1 = transform.position.z - 5;
					z2 = transform.position.z + 5;
				}

				else if (posdecision1 == 2) {
					z1 = transform.position.z + 5;
					z2 = transform.position.z - 5;
				}
				else if (posdecision1 == 3) {
					z1 = transform.position.z;
					z2 = transform.position.z;
				}
			
			} else if (posdecision == 2) {
				x1 = transform.position.x + 5;
				x2 = transform.position.x - 5;

				if (posdecision1 == 1) {
					z1 = transform.position.z - 5;
					z2 = transform.position.z + 5;
				}
				
				else if (posdecision1 == 2) {
					z1 = transform.position.z + 5;
					z2 = transform.position.z - 5;
				}
				else if (posdecision1 == 3) {
					z1 = transform.position.z;
					z2 = transform.position.z;
				}
			} 

			pos1 = new Vector3(x1,y,z1);
			pos2 = new Vector3(x2,y,z2);

		} else {
			if (posdecision == 3) {
				z1 = transform.position.z - 5;
				z2 = transform.position.z + 5;

				if (posdecision1 == 1) {
					x1 = transform.position.x - 5;
					x2 = transform.position.x + 5;
				}
				
				else if (posdecision1 == 2) {
					x1 = transform.position.x + 5;
					x2 = transform.position.x - 5;
				}
				else if (posdecision1 == 3) {
					x1 = transform.position.x;
					x2 = transform.position.x;
				}

			} else if (posdecision == 4) {
				z1 = transform.position.z + 5;
				z2 = transform.position.z - 5;

				if (posdecision1 == 1) {
					x1 = transform.position.x - 5;
					x2 = transform.position.x + 5;
				}
				
				else if (posdecision1 == 2) {
					x1 = transform.position.x + 5;
					x2 = transform.position.x - 5;
				}
				else if (posdecision1 == 3) {
					x1 = transform.position.x;
					x2 = transform.position.x;
				}

			}

			pos1 = new Vector3(x1,y,z1);
			pos2 = new Vector3(x2,y,z2);
		}


	}

	void Update() {
		this.gameObject.transform.position = Vector3.Lerp (pos1, pos2, Mathf.PingPong(Time.time/1.5f, 1.0f));
	}
}  

