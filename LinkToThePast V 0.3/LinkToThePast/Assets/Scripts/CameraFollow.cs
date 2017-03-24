using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

  public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

  void LateUpdate()
  {
    transform.position = new Vector3(Mathf.RoundToInt(target.transform.position.x), Mathf.RoundToInt(target.transform.position.y), transform.position.z);
  }
}
