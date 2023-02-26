using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheForce : MonoBehaviour
{
  [SerializeField]
  ForceMode forceMode;
  Rigidbody rb;

  void Awake()
  {
    rb = GetComponent<Rigidbody>();
  }

  void Start()
  {
    var force = Vector3.right * 5;

    rb.AddForce(force, forceMode);
  }
}
