using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float movespeed = 5;
    public float deadZone = -11;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;

        if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
