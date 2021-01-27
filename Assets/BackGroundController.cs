using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    private float scrollSpeed = -1;
    private float deadLine = -16;
    private float startLine = 15.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.scrollSpeed*Time.deltaTime, 0,0); //背景を移動
        if(transform.position.x < this.deadLine) // 画面外に出たら右端に移動
        {
            transform.position = new Vector2(this.startLine, 0);
        }
    }
}
