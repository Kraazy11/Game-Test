using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    private float lifeRemaining;
    public int maxLife = 3;

    // Start is called before the first frame update
    void Start()
    {
        lifeRemaining = maxLife;
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeRemaining = lifeRemaining - 1;
    }

    private void FixedUpdate()
    {
        
    }
}
