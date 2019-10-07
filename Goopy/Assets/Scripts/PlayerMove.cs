using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerSpeed = 1;

    float horizontal = 0.0f;
    float vertical = 0.0f;

    private Rigidbody rb = new Rigidbody();

    // Don't do it the dream is better than the reality
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
            horizontal = Input.GetAxis(Keybindings.hori);               
            vertical = Input.GetAxis(Keybindings.vert);

        var camera = Camera.main;
        var forward = camera.transform.forward;
        var right = camera.transform.right;

        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        var move = (forward * vertical + right * horizontal).normalized;

        rb.AddForce(move * playerSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
}
