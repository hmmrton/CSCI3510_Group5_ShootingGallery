using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetStack : Target
{
    public float impactForce;

    Rigidbody targetRigidbody;

    // Start is called before the first frame update
    private void Start()
    {
        targetRigidbody = target.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public override void Process(RaycastHit hit)
    {
        targetRigidbody.AddForce(-hit.normal * impactForce);

        effectScript.Play(hit, hitSound, hitEffect, effectDuration);
    }
}
