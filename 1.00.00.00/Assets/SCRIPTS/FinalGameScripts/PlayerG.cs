using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerG : MonoBehaviour
{

    public float moveSpeed = 600f;  //The movespeed of the hexagon player

    float movement = 0f; //the variable that will store input from the user


    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal"); //get horizontal arrow keys input
    }

    void FixedUpdate()
    {
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed); //rotate around the centrepoint by using all variables
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
