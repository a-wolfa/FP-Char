using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPCamera : MonoBehaviour
{

    public Transform Player;
    public float MouseSensitivity = 2f;
    float camerVerticalRotation = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // mouse input

        float inputX = Input.GetAxis("Mouse X") * MouseSensitivity;
        float inputY = Input.GetAxis("Mouse Y") * MouseSensitivity;


        // rotate camera up and down

        camerVerticalRotation -= inputY;
        camerVerticalRotation = Mathf.Clamp(camerVerticalRotation, -90f, 90f);
        transform.localEulerAngles = Vector3.right * camerVerticalRotation;

        
        // rotae camer left and right

        Player.Rotate(Vector3.up * inputX);
    }
}
