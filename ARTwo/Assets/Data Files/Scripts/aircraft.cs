﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aircraft : MonoBehaviour
{
    public float xvalue, yvalue, zvalue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(xvalue,yvalue,zvalue)*Time.deltaTime);
    }
}
