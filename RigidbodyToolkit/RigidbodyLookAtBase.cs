using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody))]

public class RigidbodyLookAtBase : MonoBehaviour {
  public float force = 0.1f;
  public void LookAt(Vector3 facingDirection, Vector3 targetPosition) {
    Vector3 relativeDirection = targetPosition - transform.position;
    float degreesBetweenFacingDirectionAndTarget = Vector3.Angle(facingDirection, relativeDirection);
    Vector3 crossProduct = Vector3.Cross(facingDirection, relativeDirection);
    Vector3 torque = crossProduct * degreesBetweenFacingDirectionAndTarget * force;
    rigidbody.AddTorque(torque);
  }
}

