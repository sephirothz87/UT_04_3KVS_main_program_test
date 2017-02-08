using System.Collections;
using System.Collections.Generic;

namespace GameHeroNS
{
    //游戏中的英雄（所有装备技能等等都已经加载完的状态）
    public class GameHero
    {
        public int id;

        //区别双方 红方1 蓝方2
        public int troop;
        //12345序号 暂时没想到怎么用，用于显示卡组的顺序？
        public int index;

        //位置
        //前后排
        public int row;
        //前后排位置，暂定从左到右
        public int row_index;
        //表示名
        public string name;



        //属性区
        //生命值
        public int health;
        //物理攻击
        public int attack_p;
        //物理防御
        public int defend_p;

        public string getName()
        {
            return name;
        }

        //public void GameHero(int id,int troop)
        //{

        //}
    }

    //游戏中最终使用的示例英雄
    public class Hero: GameHero
    {
    }
}
