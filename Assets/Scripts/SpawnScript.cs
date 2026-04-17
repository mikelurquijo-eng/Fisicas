using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public Object prefab;
    public int rows;
    public int columns;
    public int distance = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        for (int i = 0; i<rows; i++) {
            for (int j = 0; j < columns; j++) {
                Vector3 position = new Vector3(i * distance, 0,  j * distance);
                Object.Instantiate(prefab, position, this.transform.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
