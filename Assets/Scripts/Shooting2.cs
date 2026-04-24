using UnityEngine;

public class Shooting2 : MonoBehaviour
{

    public float force;
    public GameObject bullet;
    public Transform gun;
    private Quaternion quat;
    private RaycastHit hit;
    MeshRenderer mr;
    Color originalColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        quat = new Quaternion(0, 0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet = Object.Instantiate(bullet, transform.position + Vector3.forward, quat);
            //newBullet.GetComponent<Rigidbody>().AddForce(this.transform.forward * force);
            newBullet.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, force), ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        int layerMask = 1 << 10;
        layerMask = ~layerMask;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            Debug.Log("Did hit" + hit.collider.gameObject.name);
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("not hitting");
        }

    }
}

