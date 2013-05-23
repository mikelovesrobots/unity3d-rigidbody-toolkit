using UnityEngine;
using System.Collections;

// Keep in mind that you can also increase the angular drag on your
// rigidbody.  I often find the default setting to be too low for
// my needs. - The author

[RequireComponent (typeof(Rigidbody))]

public class RigidbodyKeepUpright : RigidbodyLookAtBase {
  void Update () {
    LookAt(transform.up, transform.position + (Vector3.up * 10));
  }
}
