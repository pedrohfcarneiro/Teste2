using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1_Script : MonoBehaviour {
    public Transform GamePos;
    public Camera MainCam;
    public float smooth = 5f;
    public float zoom = 20f;


    void Start ()
    {
		
	}
	
	
	void Update ()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, GamePos.position, 0.1f);
        transform.rotation = Quaternion.Slerp(transform.rotation, GamePos.rotation, 0.1f);

        MainCam.fieldOfView = Mathf.Lerp(MainCam.fieldOfView, zoom, Time.deltaTime * smooth);
    }





}
