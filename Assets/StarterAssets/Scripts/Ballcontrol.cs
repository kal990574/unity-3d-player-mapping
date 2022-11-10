using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballcontrol : MonoBehaviour
{
    public Vector3 scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange; 
    }
}
