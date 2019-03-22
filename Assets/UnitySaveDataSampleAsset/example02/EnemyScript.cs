using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Enemy Information
    public EnemyData data;

    // Gameplay data
    float timer;
    int limit = 5;
    bool moveLeft = false;


    // load enemy information into gameplay data
    void Start()
    {
        gameObject.name = name;
        timer = data.moveTime;
        GetComponent<SpriteRenderer>().color = data.color;
    }

    // Counts down from moveTime to 0
    void Update()
    {
        //countdown timer
        timer -= Time.deltaTime;
        if (timer <= 0) {
            Move();
            timer += data.moveTime;
        }
    }

    //Move enemy left and right
    void Move() {
        if (!moveLeft)
        {
            transform.position += Vector3.right;
        }
        else {
            transform.position += Vector3.left;
        }

        if (Mathf.Abs(transform.position.x) >= limit) {
            moveLeft = !moveLeft;
        }

    }

}
