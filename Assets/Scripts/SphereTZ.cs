using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereTZ : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void Resize()
    {
        transform.localScale = new Vector3(3f, 3f, 3f);
    }

    public void Impulse()
    {
        rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }

    public void Delete()
    {
        Destroy(this.gameObject);
    }
}
