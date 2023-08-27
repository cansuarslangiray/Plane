using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float _speed =15f;
    private float _rotationSpeed=100f;
    private float _verticalInput;
    private float _horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        _verticalInput = Input.GetAxis("Vertical");
        _horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * _speed *Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * _rotationSpeed * Time.deltaTime*_verticalInput*-1);
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime*_horizontalInput);

    }
}
