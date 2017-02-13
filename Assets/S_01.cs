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

        //TODO 从上一个界面传来卡组参数，英雄装备等等等
        
        mainBattle = new GameMainNS.Battle();
        mainBattle.initLoad("mock data");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("您按下了空格键");
            

            mainBattle.team_1_blue.heros[0]._01_on_attack_over(mainBattle.team_1_blue.heros[0], mainBattle.team_1_blue.heros[0], mainBattle,500);

            Debug.Log(mainBattle.team_1_blue.heros[0].health);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("您按下了T键");

            mainBattle.team_1_blue.heros[1]._01_on_attack_over(mainBattle.team_1_blue.heros[0], mainBattle.team_1_blue.heros[0], mainBattle, 500);

            Debug.Log(mainBattle.team_1_blue.heros[1].health);
        }
    }
}
