using UnityEngine;
using UnityEngine.Rendering;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
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
        Instantiate(pipe, transform.position, transform.rotation);
    }
}
