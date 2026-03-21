using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] static int playerHealth = 3;
    static int donutsCollected = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Danger"))
        {
            playerHealth -= 1;
            Debug.Log("Player touched danger. Player health: " +  playerHealth);
        }
        else if (collision.gameObject.CompareTag("Donut"))
        {
            donutsCollected += 1;
            Debug.Log("Player touched donut. Donuts collected: " + donutsCollected);
            collision.gameObject.SetActive(false);
        }
    }
}
