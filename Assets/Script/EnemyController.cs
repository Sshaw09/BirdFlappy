using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public bool vertical;
    public float changeTime = 2.0f;

    Rigidbody2D rigidbody2D;
    float timer;
    int direction = 1;
    public GameObject projectilePrefab;

    
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        timer = changeTime;

        InvokeRepeating ("BirdPoops", 0.0f, .5f);
    }

    void Update()
    {
        timer -= Time.deltaTime;
        

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
        
    }
    
    void FixedUpdate()
    {
        Vector2 position = rigidbody2D.position;
        
        if (vertical)
        {
            position.y += Time.deltaTime * speed * direction;;
        }
        else
        {
            position.x += Time.deltaTime * speed * direction;;
        }
        
        rigidbody2D.MovePosition(position);
    }

    void BirdPoops()
    {
        Instantiate (projectilePrefab, rigidbody2D.position + Vector2.down * 0.5f, Quaternion.identity);
    }

}
