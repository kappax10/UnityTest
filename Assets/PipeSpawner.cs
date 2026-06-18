using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (timer < spawnRate)
        {
          timer += Time.deltaTime;  
        }
        else
        {
            Instantiate(Pipe, transform.position, transform.rotation);
        }
    }
}
