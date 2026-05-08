using UnityEngine;

public class spike_ball : MonoBehaviour
{

    private Vector3 initPos = Vector3.zero;
    public GameObject spikeBall;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        initPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ocean")
        {
            GameObject newObject = Instantiate(spikeBall, initPos, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
