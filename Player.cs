using UnityEngine;

public class Player : MonoBehaviour
{
    //Input Variables
    private float horizontalInput;
    private float verticalInput;
    private float backwardInput;
    private float forwardInput;
    public GameObject jokeProjectile;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input Manager Variables
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        backwardInput = Input.GetAxis("Backward");
        forwardInput = Input.GetAxis("Forward");



        //practiceVariableGoesDown = Input.GetKey(KeyCode.Space);



        //Attempting #1
        //transform.position = new Vector3(1, 2, 2);

        //Attempting #2
        //transform.Translate(0, 1, 0);

        //Attempting #3
        transform.Translate(horizontalInput * Vector3.right);
        transform.Translate(verticalInput * Vector3.up);
        transform.Translate(backwardInput * Vector3.back);
        transform.Translate(forwardInput * Vector3.forward);

        //Attempting #4 Projectiles & Collision Detection
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(jokeProjectile, transform.position, jokeProjectile.transform.rotation);
        }




    }
}
