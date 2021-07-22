using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    //单例化
    public static GameManager instance;

    public Text txt_Time;

    public Text txt_Lives;
    public int lives_red;
    public int lives_blue;

    public Image img_GameOver;

    public float timer = 5f;
    public float currentTime = 0;
    public float currentTime1 = 0;
    public float time = 0;

    public int flag = 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //txt_lives.text = "Lives:" + 5 + "\n" + "Times:" + 2; \n是换行命令

    }

    // Update is called once per frame
    void Update()
    {
        if (flag == 0)
        {
            //每一帧，在txt_lives上更新玩家剩余生命值数量
            txt_Lives.text = "Lives_red: " + lives_red + "\n" + "Lives_blue: " + lives_blue;

            //作业1：如何进行四舍五入，仅仅保留currentTime的后两位 (Time: X.XX s)
            time = (float)Math.Round(currentTime, 2);
            txt_Time.text = "Time: " + time + " s";

            //当玩家生命值小于等于0的时候，游戏结束，出现img_GameOver
            if (lives_red <= 0 || lives_blue <= 0)
            {
                img_GameOver.gameObject.SetActive(true);
                flag = 1;
            }
        }

        

        if (flag == 1) {
            if (currentTime1 < 2)
            {
                currentTime1 += Time.deltaTime;
            }

            if (currentTime1 >= 2f)
            {
                Debug.Log("Timers up!");
                currentTime1 = 0;
                img_GameOver.gameObject.SetActive(false);
                lives_red = 5;
                lives_blue = 5;
                time = 0;
                flag = 0;
            }

        }

        if (currentTime < 10)
        {
            currentTime += Time.deltaTime;
        }

        if (currentTime >= 10f)
        {
            Debug.Log("Timers up!");
            currentTime = 0;
        }
    }

    public void LifeDecrease()
    {
        lives_red -= 1;
        lives_blue -= 1;
    }
}