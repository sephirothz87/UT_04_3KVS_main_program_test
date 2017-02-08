using System;
using System.Collections;
using System.Collections.Generic;

//游戏设计好的英雄
namespace BaseHeroNS
{
    //插入时间点一览，枚举类型
    public enum InertSettlePoint
    {
        BeforeAttack    =   1,
        AfterAttack     =   2
    }

    //用于管理英雄插入结算时间点的结构体
    public struct InsertSettleSetting
    {
        bool BeforeAttack,
           AfterAttack;


    }

    //英雄基类，用来管理公共属性
    public abstract class BaseHero
    {
        //英雄的id
        public int id;

        //属性区
        //生命值
        public int maxHealth;
        public int health;
        //物理攻击
        public int attack_p;
        //物理防御
        public int defend_p;

        public BaseHero()
        {
        }

        public BaseHero(int id, int health,int attack_p, int defend_p)
        {
            this.id = id;
            this.health = health;
            this.maxHealth = health;
            this.attack_p = attack_p;
            this.defend_p = defend_p;
        }

        /*
        //从配置文件中读取英雄的基础信息
        //public BaseHero getBasicInfoFromConfig(int id)
        public BaseHero getBasicInfoFromConfig(int id)
        {

            //func(id) 返回_01_ZhaoYun
            string str = "_0001_ZhaoYun";

            //配置中读取到的属性
            int health = 2164;
            int attack_p = 113;
            int defend_p = 85;


            //BaseHero bh = new BaseHero();
            //BaseHero bh = new BaseHero(id, health, attack_p, defend_p);

            //TODO 通过反射实现用字符串新建英雄
            //Type son_class = Type.GetType(str);

            switch (id)
            {
                case 0:
                    break;
                case 1:
                    bh = new _0001_ZhaoYun(id, health, attack_p, defend_p);
                    break;
                default:
                    break;
            }

            return bh;
        }
        */

        //暂时定5个技能函数
        public void skill_1()
        {

        }

        public void skill_2()
        {

        }

        public void skill_3()
        {

        }

        public void skill_4()
        {

        }

        public void skill_5()
        {

        }

        public int _01_on_attck_over(int basic_damage)
        {
            return 0;
        }


    }

    //实际各个英雄，管理特殊的结算点，结算方法，技能函数等
    public class _0001_ZhaoYun : BaseHero
    {
        public _0001_ZhaoYun(int id, int health, int attack_p, int defend_p) : base(id, health, attack_p, defend_p)
        {
        }

        public _0001_ZhaoYun()
        {

        }

        public int _01_on_attck_over(int basic_damage)
        {
            Console.WriteLine("_0001_ZhaoYun _01_on_attck_over");
            float dec_per = 1.0f - this.health / this.maxHealth;
            return (int)(basic_damage * dec_per);
        }
    }
}
