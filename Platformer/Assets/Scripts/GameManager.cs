using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;     // static variable that will hold singleton

    //called when script instance is being loaded 
    void Awake() {
        // Make a singleton to prevent more than one instance of an object
        if (instance == null) {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }

        else {
            Destroy(gameObject);
        }
    }
}
