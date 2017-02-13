using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_02 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("S_02 C# TEST");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("您按下了T键");

            //工厂模式测试，可以选择不重写方法  2017-2-8 18:01:01


            //HeroF hf = new ZhaoYunF();
            //Hero h = hf.createHero();

            //h.onDam();

            //Hero h = new ZhaoYun();
            //h.onDam();

            test_function20170213165249();

            //工厂模式测试，不重写方法  2017-2-8 18:01:01

            //抽象工厂模式测试 2017-02-08-154032
            //BaseFactory bf = new SonAFactory();
            //BaseClass bc = bf.createSon();

            //bc.DoThing();
            //抽象工厂模式测试 2017-02-08-154032
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("您按下了R键");

            //抽象工厂模式测试 2017-02-08-154032
            //BaseFactory bf = new SonBFactory();
            //BaseClass bc = bf.createSon();

            //bc.DoThing();
            //抽象工厂模式测试 2017-02-08-154032
        }
    }

    
    //工厂模式测试，不重写方法  2017-2-8 18:01:01

    //public class Hero
    //{
    //    public void onDam()
    //    {
    //        Debug.Log("Hero onDam");
    //    }
    //}
    void test_function20170213165249()
    {
        HeroF AF = new ZhaoYunF();
        HeroF BF = new LvBuF();

        Hero A = AF.createHero();
        Hero B = BF.createHero();

        A.onDam();
        B.onDam();

        A.onAtt();
        B.onAtt();
    } 

    public abstract class Hero
    {
        public abstract void onDam();

        public virtual void onAtt()
        {
            Debug.Log("Hero onAtt");
        }
    }

    public interface HeroF
    {
        Hero createHero();
    }

    public class ZhaoYun : Hero
    {
        public override void onDam()
        {
            Debug.Log("ZhaoYun onDam");
        }

        public override void onAtt()
        {
            Debug.Log("ZhaoYun onAtt");
        }
    }

    public class LvBu :Hero
    {
        public override void onDam()
        {
            Debug.Log("LvBu onDam");
        }

        //public override void onAtt()
        //{
        //    Debug.Log("LvBu onAtt");
        //}
    }

    public class ZhaoYunF :HeroF
    {
        public Hero createHero()
        {
            return new ZhaoYun();
        }
    }

    public class LvBuF : HeroF
    {
        public Hero createHero()
        {
            return new LvBu();
        }
    }









    //工厂模式测试，不重写方法  2017-2-8 18:01:01

    //抽象工厂模式测试 2017-02-08-154032
    //void test_func_20170208153114()
    //{
    //    Debug.Log("test_func_20170208153114");
    //}

    //public abstract class BaseClass
    //{
    //    public abstract void DoThing();
    //}

    //public class SonA : BaseClass
    //{
    //    public override void DoThing()
    //    {
    //        Debug.Log("Do Thing in son A");
    //    }
    //}

    //public class SonB : BaseClass
    //{
    //    public override void DoThing()
    //    {
    //        Debug.Log("Do Thing in son B");
    //    }
    //}

    //public interface BaseFactory
    //{
    //    BaseClass createSon();
    //}

    //public class SonAFactory : BaseFactory
    //{
    //    public BaseClass createSon()
    //    {
    //        return new SonA();
    //    }
    //}

    //public class SonBFactory : BaseFactory
    //{
    //    public BaseClass createSon()
    //    {
    //        return new SonB();
    //    }
    //}
    //抽象工厂模式测试 2017-02-08-154032
}
