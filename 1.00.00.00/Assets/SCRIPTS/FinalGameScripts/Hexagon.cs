using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{

    public Rigidbody2D rb; //the hexagon rigid body

    public float shrinkSpeed = 3f; //the speed at which it will shrink
    // Start is called before the first frame update
    void Start()
    {
        rb.rotation = Random.Range(0f, 360f);              //randomise initial position
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime; //Change the transform according to above variables

        if (transform.localScale.x <= 0.05f)           //If the hexagon has become this small, destroy it
        {
            Destroy(gameObject);
        }
    }
}
