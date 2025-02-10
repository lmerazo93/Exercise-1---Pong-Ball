using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;


public class BallTest : MonoBehaviour
{

    int speed = 10;
    public Rigidbody2D ballRB;

    void Awake ()
    {
        InputSystem.EnableDevice(Accelerometer.current);
        EnhancedTouchSupport.Enable();
    }

      void FixedUpdate()
    {
        Vector2 accel = Accelerometer.current.acceleration.ReadValue();
        ballRB.AddForce(accel * speed);
    }

    void Update()
    {
        if (Touch.activeTouches.Count > 0)
        {
            Touch myTouch = Touch.activeTouches[0];
            if (myTouch.phase == TouchPhase.Moved)
            {
                ballRB.AddForce(myTouch.delta);
            }
        }
    }
  
}
