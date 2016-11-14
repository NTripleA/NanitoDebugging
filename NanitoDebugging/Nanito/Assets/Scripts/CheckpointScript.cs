using UnityEngine;
using System.Collections;

public class CheckpointScript : MonoBehaviour{
    public float posX;
    public float posY;
    // Use this for initialization
    void Start() {
        posX = this.transform.position.x;
        posY = this.transform.position.y;
    }

  void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
            this.transform.GetChild(1).GetComponent<Renderer>().enabled = true;
            this.transform.GetChild(1).GetComponent<Animation>().Play("nanoflag");
        }
    }
    // Update is called once per frame
    void Update()
    {


    }

  
}