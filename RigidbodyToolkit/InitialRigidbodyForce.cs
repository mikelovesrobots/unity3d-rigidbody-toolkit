using UnityEngine;
using System.Collections;

// Use for providing that initial oomph, like a cannonball launch, thrown rock or 
// paper airplane.  Contrast with the built-in ConstantForce, which applies force 
// each update and would be more suitable for a self-powered rigidbody like a
// missile, ship, or simulation of gravity.  -- The author

[RequireComponent (typeof(Rigidbody))]

public class InitialRigidbodyForce : MonoBehaviour {
  public Vector3 force;
  public Vector3 relativeForce;
  public Vector3 torque;
  public Vector3 relativeTorque;

  void Start () {
    rigidbody.AddForce(force);
    rigidbody.AddRelativeForce(relativeForce);
    rigidbody.AddTorque(torque);
    rigidbody.AddRelativeTorque(relativeTorque);
  }
}
