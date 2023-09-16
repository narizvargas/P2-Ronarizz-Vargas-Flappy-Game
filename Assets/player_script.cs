using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{
    public Rigidbody2D mybody;
    public float flapstrength = 1;
    public LogicScript logic;
    public bool playerIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerIsAlive)
        {
            mybody.velocity = Vector2.up * flapstrength;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        playerIsAlive = false;
    }
}
