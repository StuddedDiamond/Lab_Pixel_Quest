using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    public float speed = 4;
    public string nextLevel = "Level2";

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rigidbody2D.velocity = new Vector2 (xInput * speed, rigidbody2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.W))
        {
            rigidbody2D.velocity += new Vector2(rigidbody2D.velocity.x, -1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rigidbody2D.velocity += new Vector2(rigidbody2D.velocity.x, 3);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log ("Hit");
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
       
    }
}
