using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
  [SerializeField]
  Animator animator;
  [SerializeField]
  float speed = 2f;

  private void Update()
  {
    float sideAmount = Input.GetAxis("Horizontal");
    float forwardAmount = Input.GetAxis("Vertical");

    float moveAmount = Mathf.Clamp(sideAmount + forwardAmount, -1, 1);
    animator.SetFloat("Speed", Mathf.Abs(moveAmount));

    float moveX = transform.position.x + sideAmount * speed * Time.deltaTime;
    float moveZ = transform.position.z + forwardAmount * speed * Time.deltaTime;
    transform.position = new Vector3(moveX, transform.position.y, moveZ);
  }
}
