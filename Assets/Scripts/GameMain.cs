using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using BaseHeroNS;

//游戏主程序
namespace GameMainNS

{
    public static class GameMain
    {
        //TODO 从上一个界面传来卡组参数，英雄装备等等等

        //TODO 从配置文件中读取英雄属性


    }

    //用来管理战场所有的状态
    //考虑作成单例模式？
    public class Battle
    {
        enum TeamEnum
        {
            team_1_blue = 1,
            team_2_red = 2
        }

        public Team team_1_blue;
        public Team team_2_red;

        public Battle()
        {
            
        }


        //开始，初始化战场
        //参数是从上一个页面传来的阵容配置
        //双方阵容配置如何传递？网络的部分，先不考虑
        public void initLoad(string data)
        {
            this.team_1_blue = new Team();
            this.team_2_red = new Team();

            //BaseHero bh = new BaseHero();
            //BaseHero h = bh.getBasicInfoFromConfig(1);

            //Hero h = bh.getBasicInfoFromConfig(1);

            //Hero h = new Hero();
            //h = h.init(1);


            //_0001_ZhaoYun h = new _0001_ZhaoYun();

            //this.team_1_blue.heros[0]=h;

            //HeroFactory hf1 = new _0001_ZhaoYunF();
            //Hero h1 = hf1.createHero();
            //this.team_1_blue.heros[0]=h1;

            //HeroFactory hf2 = new _0002_LvBuF();
            //Hero h2 = hf2.createHero();
            //this.team_1_blue.heros[1] = h2;

            //读取到了id为1的英雄，根据id 1来新建一个赵云
            //TODO 映射关系  
            //TODO 反射
            Hero h1 = new _0001_ZhaoYun(1, 2164, 113, 85);
            this.team_1_blue.heros[0] = h1;


            Hero h2 = new _0002_LvBu(2, 2102, 150, 90);
            this.team_1_blue.heros[1] = h2;
        }
    }

    public class Team
    {
        //public Hero[] heros = new Hero[5];
        public Hero[] heros;

        public Team()
        {
            this.heros = new Hero[5];
        }
    }

    public abstract class Hero
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

        public Hero()
        {

        }

        public Hero(int id, int health, int attack_p, int defend_p)
        {
            this.id = id;
            this.health = health;
            this.maxHealth = health;
            this.attack_p = attack_p;
            this.defend_p = defend_p;
        }

        public virtual void _01_on_attack_over(Hero hero_a, Hero hero_b, Battle battle, int basic_damage) {
            Debug.Log("Hero common _01_on_attack_over");
        }

        /*
        public void _01_on_attack_over(Hero hero_a, Hero hero_b, Battle battle, int basic_damage)
        {
            Debug.Log("Hero _01_on_attack_over");
        }*/
    }

    //public interface HeroFactory
    //{
    //    Hero createHero();
    //}

    public class _0001_ZhaoYun : Hero
    {
        public _0001_ZhaoYun() : base()
        {

        }
        public _0001_ZhaoYun(int id, int health, int attack_p, int defend_p) : base(id, health, attack_p, defend_p)
        {

        }
        public override void _01_on_attack_over(Hero hero_a, Hero hero_b, Battle battle, int basic_damage)
        {
            Debug.Log("_0001_ZhaoYun _01_on_attack_over");


            //Debug.Log("before");
            //Debug.Log(hero_b.health);
            //Debug.Log(hero_b.maxHealth);


            float dec_per = (float)this.health / this.maxHealth;

            int real_damage = (int)(basic_damage * dec_per);

            if (real_damage < 50)
            {
                hero_b.health -= 50;
            }
            else
            {
                hero_b.health -= (int)(basic_damage * dec_per);
            }

            //Debug.Log("after");
            //Debug.Log(hero_b.health);
            //Debug.Log(hero_b.maxHealth);
        }
    }

    //public class _0001_ZhaoYunF : HeroFactory
    //{
    //    public Hero createHero()
    //    {
    //        return new _0001_ZhaoYun(1, 2164,113,85);
    //    }
    //}

    public class _0002_LvBu : Hero
    {
        public _0002_LvBu() : base()
        {

        }
        public _0002_LvBu(int id, int health, int attack_p, int defend_p) : base(id, health, attack_p, defend_p)
        {

        }
    }

    //public class _0002_LvBuF : HeroFactory
    //{
    //    public Hero createHero()
    //    {
    //        return new _0002_LvBu();
    //    }
    //}
}
