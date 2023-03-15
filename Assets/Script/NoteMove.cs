using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMove : MonoBehaviour
{
    [SerializeField]float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.0003f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition -= new Vector3(0f, speed, 0f);
        if(transform.localPosition.y <= 0)
        {
            Destroy(gameObject);
        }
    }
}