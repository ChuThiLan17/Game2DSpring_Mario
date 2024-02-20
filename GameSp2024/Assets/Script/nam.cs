using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nam : MonoBehaviour
{
    public float left, right;
    private bool isRight;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var Nam_x = transform.position.x;

        if (Nam_x < left)
        {
            isRight = true;
        }
        if (Nam_x > right)
        {
            isRight = false;
        }
        if (isRight)
        {
            transform.Translate(new Vector3(Time.deltaTime * speed,0,0));
        }else{
            transform.Translate(new Vector3(-Time.deltaTime * speed,0,0));
        }
    }
}