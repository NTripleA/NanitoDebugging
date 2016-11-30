using UnityEngine;
using System.Collections;

<<<<<<< HEAD
public class CheckpointScript : MonoBehaviour {
	public float posX;
	public float posY;
	// Use this for initialization
	void Start () {
		posX = this.transform.position.x;
		posY = this.transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
=======
public class CheckpointScript : MonoBehaviour{
    public float posX;
    public float posY;
    // Use this for initialization
    void Start() {
        posX = this.transform.position.x;
        posY = this.transform.position.y;
    }

 // public void play(string tag)
   // {
        //if (tag == "Checkpoint1")
        //{
           // Transform t = GameObject.FindGameObjectWithTag(tag).transform;
           // t.GetChild(0).GetComponent<Renderer>().enabled = false;
           // t.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
           // t.GetChild(0).GetComponent<SpriteRenderer>().
           // t.GetChild(1).GetComponent<SpriteRenderer>().enabled = true;
            //t.GetChild(1).GetComponent<Animation>().Play("nanoflag");
       // }
    //}

    // Update is called once per frame
    void Update()
    {


    }

  
}
>>>>>>> randomBranch
