using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using GameHeroNS;
using GameMainNS;

public class S_01 : MonoBehaviour {
    GameMainNS.Battle mainBattle;


    // Use this for initialization
    void Start () {
        Debug.Log("Hello unity");

        GameHeroNS.GameHero bh = new GameHeroNS.GameHero();
        string bh_name = bh.name;
        Debug.Log(bh.name);

        mainBattle = new GameMainNS.Battle();
        mainBattle
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
