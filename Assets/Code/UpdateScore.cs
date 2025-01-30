using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UpdateScore : MonoBehaviour
{
public TextMeshProUGUI scoreText;

    void Start()
    {
        scoreText.text = "SCORE: " + PublicVars.score;
        PublicVars.score = 0;
    }


}
