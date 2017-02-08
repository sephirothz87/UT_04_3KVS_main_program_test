using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GameHeroNS;
using GameMainNS;
using System;

public class S_01 : MonoBehaviour {
    GameMainNS.Battle mainBattle;


    // Use this for initialization
    void Start () {
        Debug.Log("Hello unity");

        //GameHeroNS.GameHero bh = new GameHeroNS.GameHero();
        //string bh_name = bh.name;
        //Debug.Log(bh.name);

        //mainBattle = new GameMainNS.Battle();
        //mainBattle.initLoad("mock data");


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("您按下了空格键");

            Debug.Log("");

            int dm = mainBattle.team_1_blue.heros[0]._01_on_attck_over(500);


            Debug.Log("dm");
            Debug.Log(dm);


        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("您按下了T键");

            //抽象工厂模式测试
            //test_func_20170208153114();
        }
    }
}
