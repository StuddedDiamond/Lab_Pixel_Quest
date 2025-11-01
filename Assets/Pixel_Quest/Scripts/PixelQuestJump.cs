using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelQuestJump : MonoBehaviour
{

    private Rigidbody2D _rigidbody2D;
    public float jumpForce = 10;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
            }
        }
    }
}
