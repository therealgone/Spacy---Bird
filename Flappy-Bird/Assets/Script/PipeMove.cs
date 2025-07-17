using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float movespeed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
    }
}
