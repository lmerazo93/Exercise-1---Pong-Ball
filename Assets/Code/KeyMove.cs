using UnityEngine;

public class KeyMove : MonoBehaviour
{
public int speed = 10;

void Update()
{
float xSpeed = Input.GetAxis("Horizontal") * speed;
Vector3 pos = transform.position;
pos.x += Time.deltaTime * xSpeed;
pos.x = Mathf.Clamp(pos.x, -2f, 2f);
transform.position = pos;

}
}
