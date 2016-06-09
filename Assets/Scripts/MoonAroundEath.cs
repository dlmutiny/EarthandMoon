using UnityEngine;
using System.Collections;

public class MoonAroundEath : MonoBehaviour {

	
	// Update is called once per frame
	void Update ()
    {

        transform.RotateAround(Vector3.zero, Vector3.up, -1 * Time.deltaTime);

    }
}
