using UnityEngine;

public class PhysicsMover : MonoBehaviour
{
  Rigidbody rb;
  float forceAmount = 10;

  void Awake()
  {
    rb = GetComponent<Rigidbody>();
  }

  void Start()
  {
    rb.AddForce(Vector3.up * forceAmount, ForceMode.Impulse);
  }
}
