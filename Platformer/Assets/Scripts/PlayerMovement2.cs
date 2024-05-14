using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    //variables for the game
    float speed;        //determine move speed
    float move;         //determine direction of movement

    float jump;         //determine how high the jump is
    bool isJumping;     //tracks if object is jumping or not

    Rigidbody2D rb;

    public static PlayerMovement2 instance;

    void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //  public Transform startPos

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;                //set speed value to ten
                      //set jump value to 400f

        rb = GetComponent<Rigidbody2D>();       //store the rb of the object
    }

    // Update is called once per frame
    void Update()
    {
        //move the player
        move = Input.GetAxis("Horizontal");         //set move to read any of the unity Horizontal keybinds

        rb.velocity = new Vector2(speed * move, rb.velocity.y);         //move on the x axis (left or right)

        
    }

    
}