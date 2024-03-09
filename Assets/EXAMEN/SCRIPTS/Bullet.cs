using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 0.2f;

    void Start()
    {
        transform.SetParent(null);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed, 0);
    }

    private void OnTriggerEnter(Collider Asteroid)
    {
        if (Asteroid.CompareTag("Asteroid"))
        {
            FindObjectOfType<Score>().AddScore();
            Asteroid.GetComponent<Health>().TakeDamage(1);

        }
    }
   
}
