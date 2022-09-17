using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pajaro : MonoBehaviour
{
    public Rigidbody2D rb;
    public float JumpSpeed;
    private bool isDead;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isDead )
        {
            rb.velocity = new Vector2(0, JumpSpeed);

        }
    }
    private void OnCollisionEnter2D()
    {
        isDead = true;
        GameManager.Instance.GameOver();
    }
}
