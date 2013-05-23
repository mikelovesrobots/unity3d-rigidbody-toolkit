using UnityEngine;
using System.Collections;

public class RigidbodyFloatingController : MonoBehaviour {
    private const string HORIZONTAL_AXIS = "Horizontal"; 
    private const string VERTICAL_AXIS = "Vertical"; 
    private const string JUMP_BUTTON = "Jump"; 

    public float AdvanceForce = 200f;
    public float SidestepForce = 200f;
    public float JumpForce = 200f;
    public float HoverThrottleDecay = 0.97f;
    public float HoverMinThrottle = 0.5f;

    private float hoverThrottle = 0f;

    void FixedUpdate() {
        AdjustHoverThrottle();
        ApplyForceToRigidbody();
    }

    private void AdjustHoverThrottle() {
        hoverThrottle = (hoverThrottle * HoverThrottleDecay) + ((1 - HoverThrottleDecay) * HoverIntention);
        hoverThrottle = Mathf.Max(hoverThrottle, HoverMinThrottle);
    }

    private void ApplyForceToRigidbody() {
        var force = ForwardForce + HorizontalForce + VerticalForce;
        rigidbody.AddForce(force);
    }

    private float HoverIntention {
        get { return Input.GetButton(JUMP_BUTTON) ? 1f : 0f; }
    }

    private Vector3 ForwardForce {
        get {
            var forward = Camera.main.transform.forward;
            var input = Input.GetAxis(VERTICAL_AXIS);
            return forward * input * AdvanceForce;
        }
    }

    private Vector3 HorizontalForce {
        get {
            var right = Camera.main.transform.right;
            var input = Input.GetAxis(HORIZONTAL_AXIS);
            return right * input * SidestepForce;
        }
    }

    private Vector3 VerticalForce {
        get {
            var up = Camera.main.transform.up;
            return up * hoverThrottle * JumpForce;
        }
    }
}
