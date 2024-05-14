using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal4 : MonoBehaviour
{
    //called when a Collision is detected
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))      //if the object colliding with is the player
        {
            SceneManager.LoadScene("Congrats");           //move to level 3
        }
    }
}

