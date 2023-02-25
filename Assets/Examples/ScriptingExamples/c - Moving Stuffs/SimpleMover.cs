using UnityEngine;

public class SimpleMover : MonoBehaviour
{
  float distFromStart;
  float speed = 1f; // 1 ??n v? trên giây
  float sideRange = 5f;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    float frameSpeed = speed * Time.deltaTime;

    //MoveToRight(frameSpeed);

    //transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));

    var targetPoint = new Vector3(sideRange, 0, 0);
    transform.position = Vector3.MoveTowards(transform.position, targetPoint, frameSpeed);
  }

  void MoveToRight(float frameSpeed)
  {
    transform.position += new Vector3(frameSpeed, 0, 0);
  }
}
