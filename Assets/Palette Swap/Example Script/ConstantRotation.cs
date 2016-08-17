using UnityEngine;
using System.Collections;

public class ConstantRotation : MonoBehaviour {

	public Vector3 rotationAxis;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		transform.Rotate (rotationAxis * Time.fixedDeltaTime);
	}
}
