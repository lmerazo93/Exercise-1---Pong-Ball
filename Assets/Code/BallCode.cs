using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BallCode : MonoBehaviour
{
    

    public TextMeshProUGUI scoreText;
    public AudioClip boomSound;
    public AudioClip blipSound;

    AudioSource audioSource;

    void Start()
    {   
        audioSource = GetComponent<AudioSource>();
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(200, 200));

        scoreText.text = "Score: 0";
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Brick"))
        {
            audioSource.PlayOneShot(boomSound);
            PublicVars.score += 10;
            scoreText.text = "Score: " + PublicVars.score;

             if (GameObject.FindGameObjectsWithTag("Brick").Length < 2)
            {
                SceneManager.LoadScene("Win");
            }

            Destroy(other.gameObject);


        } else {
            audioSource.PlayOneShot(blipSound);
        }
    }

}
