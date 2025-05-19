using UnityEngine;

public class Player : MonoBehaviour
{
   // public float speed = 1.0f;
    private float practiceVariableGoesHere;
    private bool practiceVariableGoesDown;
    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input Manager Variables
        practiceVariableGoesHere = Input.GetAxis("Horizontal");
        practiceVariableGoesDown = Input.GetKey(KeyCode.Space);



        //Attempting #1
        //transform.position = new Vector3(1, 2, 2);

        //Attempting #2
        //transform.Translate(0, 1, 0);

        //Attempting #3
        transform.Translate(practiceVariableGoesHere * Time.deltaTime * Vector3.right);




    }
}
