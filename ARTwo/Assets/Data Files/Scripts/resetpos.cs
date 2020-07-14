using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetpos : MonoBehaviour
{
    Vector3 originalpos;
    // Start is called before the first frame update
    void Start()
    {
        originalpos = transform.localPosition;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.CompareTag("AEROPLANEWALL"))
        {
            transform.localPosition = originalpos;
        }
        else if (collide.gameObject.CompareTag("CLOUDWALL"))
        {
            transform.localPosition = originalpos;
        }
    }
}
