using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Attempting #1
        //transform.position = new Vector3(1, 2, 2);

        //Attempting #2
        transform.Translate(0, 1, 0);




    }
}
