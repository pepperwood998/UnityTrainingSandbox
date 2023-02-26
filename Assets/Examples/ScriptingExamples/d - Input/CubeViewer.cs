using UnityEngine;

public class CubeViewer : MonoBehaviour
{
  [SerializeField]
  float rotateSpeed = 30;

  void Update()
  {
    if (Input.touchCount > 0)
    {
      Touch touch = Input.GetTouch(0);

      if (touch.phase == TouchPhase.Moved)
      {
        transform.Rotate(touch.deltaPosition.y * rotateSpeed * Time.deltaTime, -(touch.deltaPosition.x * rotateSpeed) * Time.deltaTime, 0, Space.World);
      }
    }
  }
}
