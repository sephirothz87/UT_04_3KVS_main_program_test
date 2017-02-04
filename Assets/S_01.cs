using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using BasicHeroNS;

public class S_01 : MonoBehaviour {
	// Use this for initialization
	void Start () {
        Debug.Log("Hello unity");

        BasicHeroNS.BasicHero bh = new BasicHeroNS.BasicHero();
        string bh_name = bh.name;
        Debug.Log(bh.name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
