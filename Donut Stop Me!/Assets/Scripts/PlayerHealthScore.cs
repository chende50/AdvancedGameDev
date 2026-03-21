using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerHealthScore : MonoBehaviour
{
    public static int playerHealth = 3;
    public static int donutsCollected = 0;

    public GameObject healthText;
    public GameObject scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerHealth = 3;
        donutsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.GetComponent<TMP_Text>().text = "Health: " + playerHealth;
        scoreText.GetComponent<TMP_Text>().text = "Donuts Collected: " + donutsCollected;

        if (playerHealth <= 0)
        {
            Debug.Log("Player died");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
