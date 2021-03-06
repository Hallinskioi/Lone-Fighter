using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShip : MonoBehaviour
{
    //Movement
    public float movementSpeed;
    public float rotationSpeed;

    //Shooting
    public float roundsPerMinute;
    private float fireDelay;

    public Transform Cannon;
    public GameObject Laser;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Time.time > fireDelay)
            {
                Shoot();
            }
        }
    }


    void Shoot()
    {
        fireDelay = Time.time + roundsPerMinute;
        Instantiate(Laser, Cannon.position, Cannon.rotation);
    }
}
