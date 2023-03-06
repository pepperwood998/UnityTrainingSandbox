using UnityEngine;

public class CubeViewer : MonoBehaviour
{
  [SerializeField]
  float rotateSpeed = 30;

  Vector2 lastTouchPoint;

  void Update()
  {
    // Co cham vao man hinh
    if (Input.touchCount > 0)
    {
      // Lay ra diem cham
      Touch touch = Input.GetTouch(0);

      // Giai doan vua an vao man hinh
      if (touch.phase == TouchPhase.Began)
      {
        lastTouchPoint = touch.position;
      }
      // Giai doan vuot tren man hinh
      else if (touch.phase == TouchPhase.Moved)
      {
        Debug.Log(lastTouchPoint + " - " + touch.position + ", " + touch.deltaPosition.x);
        lastTouchPoint = touch.position;

        float rotateX = touch.deltaPosition.y * rotateSpeed * Time.deltaTime;
        float rotateY = -(touch.deltaPosition.x * rotateSpeed) * Time.deltaTime;
        transform.Rotate(rotateX, rotateY, 0, Space.World);

      }
    }
  }
}
