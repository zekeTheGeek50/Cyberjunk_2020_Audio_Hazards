﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float delay = 1f;

    public float damage;
    void Start()
    {
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length + delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
