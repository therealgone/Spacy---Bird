using UnityEngine;
using UnityEngine.Rendering;

public class PipeSpawn : MonoBehaviour
{
    public GameObject Pipes;
    public float spawnRate = 1;
    private float timer = 0;
    public float spawnHeight = 5;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame      
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        
    }
    void spawnPipe()

    {
        
        float lowestPoint = transform.position.y - spawnHeight;
        float highestPoint = transform.position.y + spawnHeight;
        Instantiate(Pipes, new Vector3(transform.position.x,Random.Range(lowestPoint, highestPoint),0), transform.rotation);
    }
}
