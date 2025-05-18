using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject Player;
    private Vector3 offset = new Vector3 (7, 1, 2.4f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position + offset;
    }
}
