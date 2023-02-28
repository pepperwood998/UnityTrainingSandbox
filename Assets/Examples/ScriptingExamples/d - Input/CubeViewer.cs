using UnityEngine;

public class CubeViewer : MonoBehaviour
{
  [SerializeField]
  float rotateSpeed = 30;

  Vector2 lastTouchPoint;

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
        Debug.Log(lastTouchPoint + " - " + touch.position + ", " + touch.deltaPosition.x);
        lastTouchPoint = touch.position;

        transform.Rotate(touch.deltaPosition.y * rotateSpeed * Time.deltaTime, -(touch.deltaPosition.x * rotateSpeed) * Time.deltaTime, 0, Space.World);

      }
    }
  }
}
