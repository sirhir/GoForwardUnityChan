using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    private GameObject gameOverText;
    private GameObject runLengthText;

    private float len = 0; //走った距離
    private float speed = 5f; //走る速度(今回ユニちゃんは見かけだけ走りなのでここで仮初めの速度設定)
    
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        this.gameOverText  = GameObject.Find ("GameOver");
        this.runLengthText = GameObject.Find ("RunLength");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isGameOver == false)
        {
            this.len += this.speed * Time.deltaTime;
            this.runLengthText.GetComponent<Text> ().text = "Distance:  "  + len.ToString ("F2") + "m";
        }

        if (this.isGameOver == true)
        {
            // クリックされたらシーンをロードする
            if (Input.GetMouseButtonDown (0))
            {
                //SampleSceneを読み込む
                SceneManager.LoadScene ("SampleScene");
            }
        }
    }

    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;        
    }
}
