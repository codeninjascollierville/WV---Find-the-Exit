using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PYPlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float moveForward++;
        Vector3 destination = new Vector3(horizontal, 0, moveForward);
        transform.Translate(destination * speed * Time.deltaTime);
    }
}