using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using BaseHeroNS;

//游戏主程序
namespace GameMainANS

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
            //this.team_1_blue = new Team();
            //this.team_2_red = new Team();
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
    //public class Hero
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

        public Hero(int id)
        {
            //读取到了id为1的英雄，根据id 1来新建一个赵云
            //TODO 映射关系

        }

        public Hero(int id, int health, int attack_p, int defend_p)
        {
            this.id = id;
            this.health = health;
            this.maxHealth = health;
            this.attack_p = attack_p;
            this.defend_p = defend_p;
        }

        public Hero init(int id)
        {
            //func(id) 返回_01_ZhaoYun
            string str = "_0001_ZhaoYun";

            //配置中读取到的属性
            int health = 2164;
            int attack_p = 113;
            int defend_p = 85;

            this.id = id;
            this.health = health;
            this.maxHealth = health;
            this.attack_p = attack_p;
            this.defend_p = defend_p;

            _0001_ZhaoYun bh = new _0001_ZhaoYun();

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

        public void _01_on_attck_over()
        {

        }

        public abstract int _01_on_attck_over(int basic_damage);

        //实际各个英雄，管理特殊的结算点，结算方法，技能函数等
        public class _0001_ZhaoYun : Hero
        {
            public _0001_ZhaoYun(int id, int health, int attack_p, int defend_p) : base(id, health, attack_p, defend_p)
            {
            }

            public _0001_ZhaoYun()
            {

            }

            public override int _01_on_attck_over(int basic_damage)
            {
                Console.WriteLine("_0001_ZhaoYun _01_on_attck_over");
                Debug.Log("_0001_ZhaoYun _01_on_attck_over");
                float dec_per = 1.0f - this.health / this.maxHealth;
                return (int)(basic_damage * dec_per);
            }
        }
    }
}
