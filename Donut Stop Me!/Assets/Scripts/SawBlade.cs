using UnityEngine;

public class SawBlade : MonoBehaviour
{
    [SerializeField] private int SPIN_SPEED;
    [SerializeField] private int MOVE_SPEED;
    [SerializeField] private float POSITION;

    private Vector3 spinVector = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spinVector.x = SPIN_SPEED * Time.deltaTime;
        gameObject.transform.Rotate(spinVector, Space.Self);

        POSITION += MOVE_SPEED * Time.deltaTime;
        gameObject.transform.localPosition = new Vector3(0, 0, Mathf.Sin(POSITION));
    }
}
