using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float distance = 5f; // How far it moves from the start
    public float speed = 2f;    // How fast it moves

    private Vector3 startPos;

    void Start()
    {
        // Save the starting position
        startPos = transform.position;
    }

    void Update()
    {
        // PingPong returns a value that moves back and forth
        float movement = Mathf.PingPong(Time.time * speed, distance);

        // Update the platform's X position
        transform.position = new Vector3(startPos.x, startPos.y, startPos.z + movement);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
