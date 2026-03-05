using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class SpinningBlade : MonoBehaviour
{
    [SerializeField] private int SPIN_SPEED;

    private Vector3 spinVector = Vector3.zero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        spinVector.y = SPIN_SPEED * Time.deltaTime;
        gameObject.transform.Rotate(spinVector, Space.Self);
    }
}
