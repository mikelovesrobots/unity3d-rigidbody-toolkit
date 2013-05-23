using UnityEngine;
using System.Collections;

// If a rigidbody is facing a target (RigidbodyLookAtTransform) and powering toward its goal 
// (ConstantForce - relative forward thrust), you've got a pretty good missile.  But it 
// will likely still have a bit of sideways-drift that may cause it to miss its target,
// especially when the target is trying to evade.  There's where this script comes in.
//
// Place on the same object as a RigidbodyLookAtTransform to compensate for sideways-drift
// or target evasion.  After a little tweaking, your missile won't miss.
// 
// Keep in mind though, it's often more fun for the player when the missile sometimes misses.
// Therein is the magic that keeps us returning to physics-simulations.
//
// - The author

[RequireComponent (typeof(RigidbodyLookAtBase))]

public class RigidbodyCourseCorrector : MonoBehaviour {

  public float compensationForce = 4f;
  private RigidbodyLookAtTransform rigidbodyLookAtTransform;

  void Start () {
    rigidbodyLookAtTransform = GetComponent<RigidbodyLookAtTransform>();
  }

  void FixedUpdate () {
    Vector3 targetVector = (rigidbodyLookAtTransform.target.position - transform.position).normalized;
    Vector3 offCourseVector = targetVector - rigidbody.velocity.normalized;
    rigidbody.AddForce(offCourseVector * compensationForce);
  }
}
