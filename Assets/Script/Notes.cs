using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    [SerializeField]float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition -= new Vector3(0f, speed, 0f);

        // transformを取得
        Transform myTransform = this.transform;
 
        // ローカル座標を基準に、座標を取得
        Vector3 localPos = myTransform.position;
        float z = localPos.z;

        if(z < -0.003f) {
            Destroy(this.gameObject);
        }
    }
}