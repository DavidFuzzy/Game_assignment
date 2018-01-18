using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnBricks : MonoBehaviour {

    public List<GameObject> listOfBricks = new List<GameObject>();

	// Use this for initialization
	void Start () {
		
        if(SceneManager.GetActiveScene().name == "level 2")
        {
            //loads all GameObjects in Resources folder
            //and saves them in list 
            listOfBricks.AddRange(Resources.LoadAll<GameObject>(""));

            Vector3 position = new Vector3(-4f, 2.5f, 0);
            Vector3 position2 = new Vector3(-4f, 3.5f, 0);

            for (int i = 1; i <= 10; i++)
            {
                //gets a random object from list and saves it in go 
                GameObject go = listOfBricks[Random.Range(0, listOfBricks.Count)];

                //Quaternion.identity is a default rotation
                Instantiate(go, position, Quaternion.identity);

                position.x += 1f;
            }
            for (int i = 1; i <= 10; i++)
            {
                //gets a random object from list and saves it in go 
                GameObject go = listOfBricks[Random.Range(0, listOfBricks.Count)];

                //Quaternion.identity is a default rotation
                Instantiate(go, position2, Quaternion.identity);

                position2.x += 1f;
            }

        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
