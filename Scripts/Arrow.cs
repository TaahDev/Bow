using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    private Rigidbody rb;
    private Vector3 defaultRot = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude < 0.05f)
            return;

        transform.rotation = Quaternion.Euler(defaultRot) * Quaternion.LookRotation(rb.velocity);
    }

    public void SetDefaultRot(Vector3 rot)
    {
        defaultRot = rot;
    }
}
