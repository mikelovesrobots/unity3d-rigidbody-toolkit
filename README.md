Rigidbody Toolkit
===============================

Installation
------------

Copy the RigidbodyToolkit directory to your Assets/Plugins folder.  
Make the plugins folder if it doesn't exist.

Synopsis
--------

Contains a useful set of rigidbody scripts:

InitialRigidbodyForce
---------------------
Use for providing that initial oomph, like a cannonball launch, thrown rock or 
paper airplane.  Contrast with the built-in ConstantForce, which applies force 
each update and would be more suitable for a self-powered rigidbody like a
missile, ship, or simulation of gravity.

RigidbodyCourceCorrector
------------------------
If a rigidbody is facing a target (RigidbodyLookAtTransform) and powering toward its goal 
(ConstantForce - relative forward thrust), you've got a pretty good missile.  But it 
will likely still have a bit of sideways-drift that may cause it to miss its target,
especially when the target is trying to evade.  There's where this script comes in.

Place on the same object as a RigidbodyLookAtTransform to compensate for sideways-drift
or target evasion.  After a little tweaking, your missile won't miss.
 
Keep in mind though, it's often more fun for the player when the missile sometimes misses.
Therein is the magic that keeps us returning to physics-simulations.

RigidbodyFloatingController
---------------------------
Just a little rigidbody controller for Camera bots and the like.  Try bumping the drag
and angular drag up a bit to make recoil more predictable when bumping into objects.

RigidbodyKeepUpright
--------------------
Keeps a rigidbody object upright.  Useful for simulating ships.

RigidbodyLookAtTarget
---------------------
Assign a Vector3 target and the rigidbody will always turn to face it.  Useful for
birds circling or missiles homing or anything else of that nature.

RigidbodyLookAtTransform
------------------------
Assign a transform target and the rigidbody will always turn to face it.  More useful
than RigidbodyLookAtTarget for moving targets.


Note from the author
--------------------

Contact me if you've got any questions, bugs or contract work to throw my way.

Cheers,

Mike

mikelovesrobots@gmail.com

@mikelovesrobots on Twitter
