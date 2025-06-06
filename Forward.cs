using UnityEngine;

public class Forward : MonoBehaviour
{

    private Vector3 moveDirection;
    private float speed = 10f;

    public void SetDirection(Vector3 dir)
    {
        moveDirection = dir.normalized;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        transform.position += speed * Time.deltaTime * moveDirection;
    }
}
