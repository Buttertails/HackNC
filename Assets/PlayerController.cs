using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public int rotationSpeed;
    //public Rigidbody2D rb;
    //public GameObject up;
    //public GameObject down;
    //public GameObject left;
    //public GameObject right;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
        movementDirection.Normalize();
        transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);
        if(movementDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
        /*
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector2(-1, 0) * speed * Time.deltaTime);
            //transform.Translate(new Vector2(-1, 0) * speed * Time.deltaTime);
            transform.LookAt(left.transform.position);

            //Quaternion.Slerp(transform.rotation, left.transform.rotation, 2 * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector2(1, 0) * speed * Time.deltaTime);
            //transform.Translate(new Vector2(1, 0) * speed * 2 * Time.deltaTime);
            transform.LookAt(right.transform.position);

            //Quaternion.Slerp(transform.rotation, right.transform.rotation, 2 * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector2(0, 1) * speed * Time.deltaTime);
            //transform.Translate(new Vector2(0, 1) * speed * Time.deltaTime);
            transform.LookAt(up.transform.position);

            //Quaternion.Slerp(transform.rotation, up.transform.rotation, 2 * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector2(0, -1) * speed * Time.deltaTime);
            //transform.Translate(new Vector2(0, -1) * speed * Time.deltaTime);
            transform.LookAt(down.transform.position);

            //Quaternion.Slerp(transform.rotation, down.transform.rotation, 2 * Time.deltaTime);
        }*/
    }
}
