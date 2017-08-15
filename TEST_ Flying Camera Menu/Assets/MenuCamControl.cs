using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamControl : MonoBehaviour {
    public Transform GreenPos, BluePos, RedPos;
    public Transform DestPos;




    void Start ()
    {
        DestPos = GreenPos;
        	
	}
	
	
	void Update ()
    {
        transform.localPosition = Vector3.Lerp(transform.localPosition, DestPos.position, 0.01f);
        transform.rotation = Quaternion.Slerp(transform.localRotation, DestPos.rotation, 0.01f);
        	
	}

    public void MoveToGreen ()
    {
        DestPos = GreenPos;
    }

    public void MoveToBlue ()
    {
        DestPos = BluePos;
    }

    public void MoveToRed ()
    {
        DestPos = RedPos;
    }
}
