using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{

    public int jumpForce;
    public int speed = 1;
    private bool canJump;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

    }

    public void Movement() {
        if (Input.GetKeyDown(KeyCode.W)){
            transform.position += Time.deltaTime * Vector3.forward * speed;
        }
        else if (Input.GetKeyDown(KeyCode.A)){
            transform.position += Time.deltaTime * Vector3.left * speed;
        }
        else if (Input.GetKeyDown(KeyCode.S)){
            transform.position += Time.deltaTime * Vector3.back * speed;
        }
        else if (Input.GetKeyDown(KeyCode.D)){
            transform.position += Time.deltaTime * Vector3.right * speed;
        }
    }

    
}
