using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.5f;
    [SerializeField]
    private float _speedMultiplier = 2;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am alive and my name is ");
        transform.position = new Vector3(0, 0, 0);
    }

    void CalculateMovement()
    {
        //float horizontalInput = horizontalInput.GetAxis("Horizontal");
        //float verticalInput = verticalInput.GetAxis("Vertical");

        Vector3 direction = new Vector3(0, 0, 0);
        transform.Translate(direction * _speed * Time.deltaTime);

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -3.8f, 0), 0);

        if (transform.position.x >= 11.15f)

        {
            transform.position = new Vector3(-11.15f, transform.position.y, 0);
        }

        else if (transform.position.x <= -11.15f)

        {
            transform.position = new Vector3(11.15f, transform.position.y, 0);
        }
    }



   
}
