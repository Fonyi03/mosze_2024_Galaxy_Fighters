using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float moveSpeed = 5;
    // Start is called before the first frame update
    public float hInput;
    public float vInput;

    void Start()
    {
        void Update()
        {
            hInput = Input.GetAxisRaw("Horizontal");
            vInput = Input.GetAxisRaw("Vertical");
            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed * hInput);
            transform.Translate(Vector2.up * Time.deltaTime * moveSpeed * vInput);
        }
    }

    void Update()
    {
        transform.Translate(Vector2.right* Time.deltaTime * moveSpeed * hInput);
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed * hInput);
        hInput = Input.GetAxisRaw("Horizontal");
        vInput = Input.GetAxisRaw("Vertical");

    }
}
