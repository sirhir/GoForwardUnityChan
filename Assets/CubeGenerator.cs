using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject cubePrefab;

    private float delta = 0; //経過時間計測
    private float span = 1.0f; //キューブ生成間隔

    private float genPosX = 12; //キューブ生成位置 x軸

    private float offsetX = 0.5f;
    private float spaceX = 0.4f; //キューブ生成のx軸間隔
    private float offsetY = 0.3f;
    private float spaceY = 6.9f; //キューブ生成のy軸間隔

    private int maxBlockNum = 4; //一度に生成するキューブの上限個

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        
        if(this.delta > this.span)
        {
            this.delta = 0;
            int n = Random.Range(1, maxBlockNum+1); //一度に生成するキューブ数をランダムに決定
            for(int i=0; i<n; i++)
            {
                GameObject go = Instantiate(cubePrefab) as GameObject;
                go.transform.position = new Vector2(this.genPosX, this.offsetY + i*this.spaceY);
            }
            this.span = this.offsetX + this.spaceX*n;
        }
    }
}
