using UnityEngine;

public class CubeViewer : MonoBehaviour
{
  Vector2 lastTouchPoint;
  float rotateSpeed = 300;

  void Update()
  {
    if (Input.touchCount > 0)
    {
      Touch touch = Input.GetTouch(0);

      if (touch.phase == TouchPhase.Began)
      {
        lastTouchPoint = touch.position;
      }
      else if (touch.phase == TouchPhase.Moved)
      {
        Vector2 currentTouchPoint = touch.position;
        float xDiff = Mathf.Sign(currentTouchPoint.x - lastTouchPoint.x);
        float yDiff = Mathf.Sign(currentTouchPoint.y - lastTouchPoint.y);
        //transform.Rotate(Vector3.up, -(xDiff * rotateSpeed) * Time.deltaTime, Space.World);
        transform.rotation = Quaternion.Euler(yDiff * rotateSpeed * Time.deltaTime, -(xDiff * rotateSpeed) * Time.deltaTime, 0f) * transform.rotation;

        //transform.Rotate(Vector3.right, yDiff * rotateSpeed * Time.deltaTime, Space.World);
        
        lastTouchPoint = touch.position;
      }
    }
  }
}
