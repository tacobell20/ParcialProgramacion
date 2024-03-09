using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    public float speed = -0.2f;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed);
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.CompareTag("Player"))
        {
            player.GetComponent<Health>().TakeDamage(2);

            Destroy(gameObject);
        }
    }
}
