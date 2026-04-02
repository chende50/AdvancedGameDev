using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public GameObject ending;

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
        switch(collision.gameObject.tag)
        {
            case "Danger":
                PlayerHealthScore.playerHealth -= 1;
                Debug.Log("Player touched danger. Player health: " + PlayerHealthScore.playerHealth);
                break;

            case "Donut":
                PlayerHealthScore.donutsCollected += 1;
                Debug.Log("Player touched donut. Donuts collected: " + PlayerHealthScore.donutsCollected);
                collision.gameObject.SetActive(false);
                break;

            case "Ocean":
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Debug.Log("Player died");
                break;

            case "Ending":
                if(PlayerHealthScore.donutsCollected == 3)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
                ending.GetComponent<TMP_Text>().text = "YOU WIN!";
                break;
        }
    }
}
