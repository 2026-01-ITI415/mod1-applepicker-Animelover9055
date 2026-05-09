using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour
{
    private List<GameObject> basketList;

    public GameObject gameOverPanel;

    void Start()
{
    if (gameOverPanel != null)
    {
        gameOverPanel.SetActive(false);
    }

    basketList = new List<GameObject>();

    GameObject[] baskets = GameObject.FindGameObjectsWithTag("Basket");

    foreach (GameObject basket in baskets)
    {
        basketList.Add(basket);
    }

    basketList.Sort((a, b) => b.transform.position.y.CompareTo(a.transform.position.y));
}

    public void AppleMissed()
    {
        GameObject[] apples = GameObject.FindGameObjectsWithTag("Apple");

        foreach (GameObject apple in apples)
        {
            Destroy(apple);
        }

        if (basketList.Count > 0)
        {
            GameObject basketToRemove = basketList[0];
            basketList.RemoveAt(0);
            Destroy(basketToRemove);
        }

        if (basketList.Count == 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
        }

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        ScoreCounter.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}