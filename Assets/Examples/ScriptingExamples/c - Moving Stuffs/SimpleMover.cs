using UnityEngine;

public class SimpleMover : MonoBehaviour
{
  //float distFromStart;
  float speed = 1f; // 1 don vi tren giay
  //float sideRange = 5f;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    float frameSpeed = speed * Time.deltaTime;

    //MoveToRight(frameSpeed);

    var translateVector = new Vector3(frameSpeed, 0, 0);
    transform.Translate(translateVector);

    //var targetPoint = new Vector3(sideRange, 0, 0);
    //transform.position = Vector3.MoveTowards(transform.position, targetPoint, frameSpeed);
  }

  //void MoveToRight(float frameSpeed)
  //{
  //  //transform.position += new Vector3(frameSpeed, 0, 0);
  //  transform.position = transform.position + new Vector3(frameSpeed, 0, 0);
  //}
}
