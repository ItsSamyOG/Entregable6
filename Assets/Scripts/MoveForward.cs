using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 5f;
    private float upperLim = 30f;
    private float lowerLim = -10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Bala fallida
        if (transform.position.z > upperLim)
        {
            Destroy(gameObject);
        }

       
         void OnTriggerEnter(Collider otherCollider)
        {
            // Destruyo el proyectil
            Destroy(gameObject);
        }

        }
    }
