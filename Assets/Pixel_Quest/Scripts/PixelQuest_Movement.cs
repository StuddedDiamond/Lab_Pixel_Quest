using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 public class PixelQuest_Movement : MonoBehaviour
    {
        Rigidbody2D rigidbody2D;
    SpriteRenderer spriteRenderer;
        public int speed = 4;

        // Start is called before the first frame update
        void Start()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        }

        // Update is called once per frame
        void Update()
        {
        float horizontal = Input.GetAxis("Horizontal"); 
        if (horizontal > 0) { spriteRenderer.flipX = true; }
        else if (horizontal < 0) { spriteRenderer.flipX= false; }
            rigidbody2D.velocity = new Vector2(horizontal * speed, rigidbody2D.velocity.y);        
        }
}

    