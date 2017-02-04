using System.Collections;
using System.Collections.Generic;

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

    //游戏中的英雄（所有装备技能等等都已经加载完的状态）
    public class BaseHero
    {
        //英雄的id
        public int id;

        //从配置文件中读取英雄的基础信息
        public BaseHero getBasicInfoFromConfig(int id)
        {
            BaseHero bh=new BaseHero();
            return bh;
        }
    }

    //游戏中最终使用的示例英雄
    public class ZhaoYun: BaseHero
    {
    }
}
