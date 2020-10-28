using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    Vector3 tempPos = Vector3.zero; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = transform.postition;

        tempPos.x += 1f; //tempPos.x = tempPos.x + 1f;

        transform.postition = tempPos; // go new position
        

    }
}
