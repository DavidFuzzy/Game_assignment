using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public AudioClip crack;

    public int maxHits;

    private int numberOfHits;

    public LevelManager myLevelManager;

    bool isbreakable = false;

    public static int breakableCount = 0;
  
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isbreakable = (this.tag == "break");
        if (isbreakable) // if isbreakable is true
        {
            Handelhits();
        }
    }





    void Handelhits()
    {
        numberOfHits++;
        if (numberOfHits >= maxHits)
        {
            //decrement the number of breakable bricks
            breakableCount--;
            AudioSource.PlayClipAtPoint(crack,this.transform.position);
            Destroy(this.gameObject);

            myLevelManager.BrickDestoryed();
        }
    }

	// Use this for initialization
	void Start () {

        myLevelManager = GameObject.FindObjectOfType<LevelManager>();

        numberOfHits = 0;
        isbreakable = this.tag == ("break");

        //keeps track of breakable tags
        if (isbreakable)
        {
            breakableCount++;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
