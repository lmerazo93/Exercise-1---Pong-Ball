using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class BallCode : MonoBehaviour
{

    private int speed = 10;
    public TextMeshProUGUI scoreText;
    public AudioClip boomSound;
    public AudioClip blipSound;

    AudioSource audioSource;


    Rigidbody2D rb;

    void Start()
    {   
      InputSystem.EnableDevice(Accelerometer.current);
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
       // rb.AddForce(new Vector2(200, 200));

        scoreText.text = "Score: 0";
    }

    void FixedUpdate()
    {
        Vector2 accel = Accelerometer.current.acceleration.ReadValue();
        rb.AddForce(accel * speed);
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

}
        audioSource = GetComponent<AudioSource>();
    }
}