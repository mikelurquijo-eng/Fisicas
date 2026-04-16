using UnityEngine;

public class Movement : MonoBehaviour
{

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();   
    }


    public void CheckMovement() {
        if (Input.GetKeyDown(KeyCode.W)) {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, gameObject.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, gameObject.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x+1, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}
