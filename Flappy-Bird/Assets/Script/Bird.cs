using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapforce;
    public Game_Logic logic;
    public bool birdIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Game_Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            rb.linearVelocity = Vector2.up * flapforce;
        }
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Application.Quit();
        }

        Screen();
    }

    private void Screen()
    {
        if ( transform.position.y < -6 || transform.position.y > 5.5 || transform.position.x < -10 )
        {
            logic.gameOver();
            birdIsAlive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;


    }
}
