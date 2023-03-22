using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningMover : MonoBehaviour
{
  [SerializeField]
  Animator animator;
  [SerializeField]
  float speed = 2f;
  [SerializeField]
  float rotateSpeed = 5f;

  private void Update()
  {
    float sideAmount = Input.GetAxis("Horizontal");
    float forwardAmount = Input.GetAxis("Vertical");

    var targetSideDir = new Vector3(sideAmount, 0, 0).normalized;
    var targetForwardDir = new Vector3(0, 0, forwardAmount).normalized;

    float moveX = transform.position.x;
    float moveZ = transform.position.z;
    float moveAmount = 0;
    float rotateAmount = rotateSpeed * Time.deltaTime;
    Vector3 rotateDir = transform.forward;
    bool isRotating = false;
    if (Mathf.Abs(sideAmount) > 0)
    {
      float sideAngle = Vector3.Angle(transform.forward, targetSideDir);
      if (sideAngle <= 0.1f || sideAngle <= rotateAmount * Mathf.Rad2Deg)
      {
        moveX = transform.position.x + sideAmount * speed * Time.deltaTime;
        moveAmount = Mathf.Abs(sideAmount);
      }
      else
      {
        isRotating = true;
        rotateDir = Vector3.RotateTowards(transform.forward, targetSideDir, rotateAmount, 0f);
      }
    }
    if (Mathf.Abs(forwardAmount) > 0)
    {
      float forwardAngle = Vector3.Angle(transform.forward, targetForwardDir);
      if (forwardAngle <= 0.1f || forwardAngle <= rotateAmount * Mathf.Rad2Deg)
      {
        moveZ = transform.position.z + forwardAmount * speed * Time.deltaTime;
        moveAmount = Mathf.Abs(forwardAmount);
      }
      else
      {
        isRotating = true;
        rotateDir = Vector3.RotateTowards(transform.forward, targetForwardDir, rotateAmount, 0f);
      }
    }

    transform.position = new Vector3(moveX, transform.position.y, moveZ);
    animator.SetFloat("Speed", moveAmount);

    var lastForward = transform.forward;
    transform.rotation = Quaternion.LookRotation(rotateDir);
    var newForward = transform.forward;

    if (isRotating)
    {
      float lastAngleToRight = Vector3.Angle(lastForward, Vector3.right);
      float newAngleToRight = Vector3.Angle(newForward, Vector3.right);
      if (
        (newAngleToRight < lastAngleToRight && Vector3.Dot(transform.forward, Vector3.forward) > 0) ||
        (newAngleToRight > lastAngleToRight && Vector3.Dot(transform.forward, Vector3.forward) < 0))
      {
        animator.SetBool("TurningRight", true);
        animator.SetBool("TurningLeft", false);
      }
      else if (
        (newAngleToRight < lastAngleToRight && Vector3.Dot(transform.forward, Vector3.forward) < 0) ||
        (newAngleToRight > lastAngleToRight && Vector3.Dot(transform.forward, Vector3.forward) > 0))
      {
        animator.SetBool("TurningRight", false);
        animator.SetBool("TurningLeft", true);
      } 
    }
    else
    {
      animator.SetBool("TurningRight", false);
      animator.SetBool("TurningLeft", false);
    }
  }
}
