using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float speed = 1f;
    Renderer Renderer;
    // Start is called before the first frame update
    void Start()
    {
        Renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, speed * Time.deltaTime, 0f);
    }
    private void OnMouseOver()
    
}
