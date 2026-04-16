using UnityEngine;

public class CheckCollision : MonoBehaviour
{


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bean") {
            Debug.Log("Comienzo a chocar");        
        }
    }
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Bean")
        {
            Debug.Log("Estoy chocando");
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Bean")
        {
            Debug.Log("He dejado de chocar");
            //Destroy(this.gameObject);
        }
    }
}
