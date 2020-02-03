using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public GameObject objectToSpawn;
    Vector3 mousePos;
    // Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
        //if the left mouse button was pressed
        //0 = left
        // 1 = right
        // 2 = middle

        if (Input.GetMouseButtonDown(0))
        {
            //get mouse position in world space
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //dont need z axis, set to 0
            mousePos.z = 0;

            Instantiate(objectToSpawn, mousePos, Quaternion.identity);
        }
	}
}
