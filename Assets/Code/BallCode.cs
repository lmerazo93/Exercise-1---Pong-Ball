using UnityEngine;
using TMPro;

public class BallCode : MonoBehaviour
{
    int score = 0;

    public TextMeshProUGUI scoreText;

    void Start()
    {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(200, 200));

        scoreText.text = "Score: 0";
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Brick"))
        {
            Destroy(other.gameObject);
            score += 10;
            scoreText.text = "Score: " + score;
        }
    }

}
