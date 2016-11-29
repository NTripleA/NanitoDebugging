using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ClosedDoor : MonoBehaviour {

    public Texture2D fadeTexture;
    float fadeSpeed = 0.8f;
    int drawDepth = -1000;
    bool change;

    private float alpha = 0.0f;
    private int fadeDir = 1;
    // Use this for initialization
    void Start () {

        change = false;
        alpha = 0.0f;
        fadeDir = -1;

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if(change)
        {
            alpha -= fadeDir * fadeSpeed * Time.deltaTime;
            alpha = Mathf.Clamp01(alpha);
            GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);

            GUI.depth = drawDepth;

            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), fadeTexture);
        }
    }

    IEnumerator ChangeLevel()
    {
        Debug.Log("IN");
        change = true;
        yield return new WaitForSeconds(fadeSpeed);
        SceneManager.LoadScene("SampleScenes/Scenes/Car");
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            StartCoroutine(ChangeLevel());
        }
    }

    
}
