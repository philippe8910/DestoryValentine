using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    public GameObject fractured;
    public float breakForce;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
            BreakTheThing();

    }
    public void BreakTheThing()
    {
        GameObject frac = Instantiate(fractured, transform.position, transform.rotation);
        
        foreach (Rigidbody rb in frac.GetComponentsInChildren<Rigidbody>())
        {
            Vector3 force = (rb.transform.position - transform.position).normalized * breakForce;
            rb.mass = 2.5f;
            rb.AddForce(force);
        }
        Destroy(gameObject);
    }

}
