using UnityEngine;
using System.Collections;

public class nanoflag_animate : MonoBehaviour
{

    public GameObject nanoflag;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTrigger2DEnter(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
        
    }
}

