using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMove : MonoBehaviour
{
    [SerializeField]float speed;
    int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.0001f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Return)) //エンターキー入力
        {
            x = 1;
        }
        if(Input.GetKey(KeyCode.Space)) //スペースキー入力
        {
            x = 0;
        }

        while(x == 1) {
            transform.localPosition -= new Vector3(0f, speed, 0f);
            if(transform.localPosition.y <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}