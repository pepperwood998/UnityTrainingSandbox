using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
  [SerializeField]
  float speed = 5;
  [SerializeField]
  float jumpSpeed = 7;

  Rigidbody rb;

  void Awake()
  {
    rb = GetComponent<Rigidbody>();
  }

  void Update()
  {
    float horizontal = Input.GetAxis("Horizontal");
    float frameSideSpeed = speed * horizontal * Time.deltaTime;

    float vertical = Input.GetAxis("Vertical");
    float frameForwardSpeed = speed * vertical * Time.deltaTime;

    Vector3 frameMove = Vector3.right * frameSideSpeed + Vector3.forward * frameForwardSpeed;
    transform.Translate(frameMove, Space.World);

    if (Input.GetKeyDown(KeyCode.Space))
    {
      rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
    }
  }
}
