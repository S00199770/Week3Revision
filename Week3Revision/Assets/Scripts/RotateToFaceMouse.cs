using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToFaceMouse : MonoBehaviour {

	
	void Update () {
        //get mouse position
        //mouse is in screen space, transform into world spae
        //unprojection
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //dont need Z axis, set to 0 to avoid issues of mouse dissapearing or being too far back
        mousePos.z = 0;

        //get the direction (angle) between us and the mouse
        //subtract their positions
        Vector3 direction = mousePos - transform.position;
        //set our forward direction to be that angle
        transform.up = direction;
	}
}
