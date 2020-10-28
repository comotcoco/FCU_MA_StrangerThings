using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
	public float speed = 0.0f;
	public float distance = 0.0f;
	public float time = 0.0f;
    public bool Alive = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SpeedCheck();
    }

    void SpeedCheck()
    {
        speed = distance / time;

        if (speed > 110) 
        {
            print ("you are going too fast");
        }
    }
}
