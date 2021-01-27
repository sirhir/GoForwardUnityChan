using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12; //キューブの移動速度 x軸
    private float deadLine = -10; //キューブ消滅位置 x軸

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed*Time.deltaTime, 0, 0);

        if(transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "groundTag" || other.collider.tag == "cubePrefabTag")
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
