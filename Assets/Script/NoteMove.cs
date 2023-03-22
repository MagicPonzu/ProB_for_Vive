using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMove : MonoBehaviour
{
    float speed;
    int x = -1;

    // Start is called before the first frame update
    void Start()
    {
        speed = Top.speedNum * 0.0001f;
        x = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Return))
        {
            x = -1 * x;
        }
        if(x == 1)
        {
            transform.localPosition -= new Vector3(0f, speed, 0f);
        }
        if(transform.localPosition.y <= 0)
        {
            Destroy(gameObject);
        }
    }
}
