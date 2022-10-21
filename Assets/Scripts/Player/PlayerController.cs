using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 单行注释
    /*
        多行注释
     */

    // 移动速度
    public float moveSpeed;
    // 水平输入
    public float hInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(new Vector3(hInput, 0, 0) * Time.deltaTime * moveSpeed);
    }
}
