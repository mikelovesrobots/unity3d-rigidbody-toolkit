using UnityEngine;
using System.Collections;

// Keep in mind that you can also increase the angular drag on your
// rigidbody.  I often find the default setting to be too low for
// my needs. - The author

[RequireComponent (typeof(Rigidbody))]

public class RigidbodyLookAtTarget : RigidbodyLookAtBase {
  public Vector3 target;

  void Update () {
    LookAt(transform.forward, target);
  }
}
