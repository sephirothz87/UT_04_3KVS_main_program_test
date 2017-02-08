using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_02 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("S_02 C# TEST");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("您按下了T键");

            //抽象工厂模式测试 2017-02-08-154032
            BaseFactory bf = new SonAFactory();
            BaseClass bc = bf.createSon();

            bc.DoThing();
            //抽象工厂模式测试 2017-02-08-154032
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("您按下了R键");

            //抽象工厂模式测试 2017-02-08-154032
            BaseFactory bf = new SonBFactory();
            BaseClass bc = bf.createSon();

            bc.DoThing();
            //抽象工厂模式测试 2017-02-08-154032
        }
    }

    //抽象工厂模式测试 2017-02-08-154032
    void test_func_20170208153114()
    {
        Debug.Log("test_func_20170208153114");
    }

    public abstract class BaseClass
    {
        public abstract void DoThing();
    }

    public class SonA : BaseClass
    {
        public override void DoThing()
        {
            Debug.Log("Do Thing in son A");
        }
    }

    public class SonB : BaseClass
    {
        public override void DoThing()
        {
            Debug.Log("Do Thing in son B");
        }
    }

    public interface BaseFactory
    {
        BaseClass createSon();
    }

    public class SonAFactory : BaseFactory
    {
        public BaseClass createSon()
        {
            return new SonA();
        }
    }

    public class SonBFactory : BaseFactory
    {
        public BaseClass createSon()
        {
            return new SonB();
        }
    }
    //抽象工厂模式测试 2017-02-08-154032
}
