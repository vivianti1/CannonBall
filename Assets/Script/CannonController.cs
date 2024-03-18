using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float rotationSpeed;
    public float xDegrees, yDegrees; 

    public Transform cannonBody;

    // Update is called once per frame
    void Update()
    {
       CannonMovement(); 
    }

    void CannonMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        xDegrees += horizontalInput *rotationSpeed  *Time.deltaTime;
        yDegrees += verticalInput *rotationSpeed * Time.deltaTime;

        cannonBody.localEulerAngles = new Vector3(x:0, yDegrees, z:xDegrees);
        
    }
}
