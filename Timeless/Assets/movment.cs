using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    // Start is called before the first frame update
    public float MovmentSpeed = 30;
    public float JumpForce = 1;

    private Rigidbody2D rigidbody;
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        var movment = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movment, 0, 0) * Time.deltaTime * MovmentSpeed;

        if (Input.GetButton("Jump") && Mathf.Abs(rigidbody.velocity.y)< 0.001)
        {
            rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
