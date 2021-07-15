using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public int speed = 7;
    float screenHalfWidth; 

    public event System.Action OnPlayerDeath;

    void Start() {
        float halfPlayerWidth = transform.localScale.x / 2f;
        screenHalfWidth = Camera.main.aspect * Camera.main.orthographicSize - halfPlayerWidth;
    }

    // Update is called once per frame
    void Update() {
        float inputx = Input.GetAxisRaw("Horizontal");
        float vel = inputx * speed;
        transform.Translate(Vector2.right * vel * Time.deltaTime);

        if (transform.position.x < -screenHalfWidth) {
            transform.position = new Vector2(screenHalfWidth, transform.position.y);
        }
        if (transform.position.x > screenHalfWidth) {
            transform.position = new Vector2(-screenHalfWidth, transform.position.y);
        }
    }

    void OnTriggerEnter2D(Collider2D triggerCollider) {
        if (triggerCollider.tag == "Falling Block") {
            if (OnPlayerDeath != null) {
                OnPlayerDeath();
            }
            Destroy(gameObject);
        }
    }
}
