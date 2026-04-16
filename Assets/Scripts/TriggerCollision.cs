using UnityEngine;

public class TriggerCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionTriggerEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bean")
        {
            Debug.Log("Comienzo a chocar");
        }
    }
    void OnCollisionTriggerStay(Collision collision)
    {
        if (collision.gameObject.name == "Bean")
        {
            Debug.Log("Estoy chocando");
        }
    }
    void OnCollisionTriggerExit(Collision collision)
    {
        if (collision.gameObject.name == "Bean")
        {
            Debug.Log("He dejado de chocar");
            //Destroy(this.gameObject);
        }
    }
}
