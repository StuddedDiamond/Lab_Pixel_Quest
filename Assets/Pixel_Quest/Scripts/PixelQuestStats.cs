using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PixelQuestStats : MonoBehaviour
{

    private int coinCounter = 0;
    private int _health = 3;
    private int _maxHealth = 3;
    public string nextLevel = "Level2";
    public Transform respawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":
                {
                    string nextLevel = collision.transform.GetComponent<LevelGoal>().nextLevel;
                        SceneManager.LoadScene(nextLevel);
                    break;
                }

            case "Coin":
                {
                    coinCounter++;
                    Destroy(collision.gameObject);
                    break;
                }

            case "Health":
                {
                    if (_health < _maxHealth)
                    {
                        _health++;
                        Destroy(collision.gameObject);
                    }
                    break;
                }

            case "Death": {
                    _health--;

                   if (_health <= 0) { 
                        string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                }
                   else
                    {
                        transform.position = respawnPoint.position;
                    }
                   break;
                } 
        }
    }


}
