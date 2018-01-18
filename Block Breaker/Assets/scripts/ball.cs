using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

    private paddle myPaddle;

    private Vector3 paddleToBallVector;

    private bool hasStarted = false;

    float randomX, randomY;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(hasStarted == true)
        {
            this.GetComponent<AudioSource>().Play();
        }

        if(collision.gameObject.name == "bordertop")
        {
            randomY = Random.Range(-0.2f,0f);
            Vector2 tweak = new Vector2(randomX, randomY);
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
        else
        {
            Vector2 tweak = new Vector2(randomX, randomY);
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
        
    }

    // Use this for initialization
    void Start () {
        randomX = Random.Range(0f,0.2f);
        randomY = Random.Range(0f, 0.2f);

        myPaddle = GameObject.FindObjectOfType<paddle>();

        paddleToBallVector = this.transform.position - myPaddle.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

        if(!hasStarted) // if hasStarted == false 
        {
            this.transform.position = myPaddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;

                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            } 
        }

    }
}
