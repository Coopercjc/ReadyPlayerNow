using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 7;
    float screenHalfWidthInWorldUnits;
    public event System.Action OnPlayerDeath;

    
    
    // Start is called before the first frame update
    void Start()
    {
        screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize;
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw ("Horizontal");
        float velocity = inputX * speed;
        transform.Translate(Vector2.right * velocity * Time.deltaTime);

        float halfPlayerWidth = transform.localScale.x / 2f;

        if (transform.position.x < -screenHalfWidthInWorldUnits){
            transform.position= new Vector2(screenHalfWidthInWorldUnits - halfPlayerWidth, transform.position.y);
        }

        if (transform.position.x > screenHalfWidthInWorldUnits){
            transform.position= new Vector2(-screenHalfWidthInWorldUnits + halfPlayerWidth, transform.position.y);
        }
        
    }

    void OnTriggerEnter2D(Collider2D triggerCollider){
        if (triggerCollider.tag == "Falling Block"){
            if(OnPlayerDeath != null){
                OnPlayerDeath();
            }
            Destroy (gameObject);
        }
    }
}
