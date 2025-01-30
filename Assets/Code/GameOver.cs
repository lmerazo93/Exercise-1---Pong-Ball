using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   
   private void OnTriggerEnter2D(Collider2D other)
   {
       if (other.CompareTag("Ball"))
       {
           SceneManager.LoadScene("Game Over");
           
       }
   }
}
