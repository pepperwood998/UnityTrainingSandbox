using UnityEngine;

public class LockMissle : MonoBehaviour
{
  [SerializeField]
  GameObject target;

  float speed = 1;

  void Update()
  {
    float frameSpeed = speed * Time.deltaTime;
    transform.position = Vector3.MoveTowards(transform.position, target.transform.position, frameSpeed);
  }
}
