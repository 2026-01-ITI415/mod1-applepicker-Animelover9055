using UnityEngine;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public static int score = 0;

    private TMP_Text uiText;

    void Awake()
    {
        uiText = GetComponent<TMP_Text>();
    }

    void Update()
    {
        uiText.text = "Score: " + score;
    }
}