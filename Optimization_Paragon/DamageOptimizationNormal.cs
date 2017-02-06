using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimization_Paragon
{
    public class DamageOptimizationNormal : Optimization
    {
        public double DmgPct { get; set; }

        public int AttackSpeedPoints { get; set; }
        public int CritPoints { get; set; }
        public int PowerPoints { get; set; }
        public int IncrCritPct { get; set; }

        private int CurrentAttackSpeedPoints { get; set; }
        private int CurrentCritPoints { get; set; }
        private int CurrentPowerPoints { get; set; }

        public DamageOptimizationNormal(int incrCritPct)
        {
            IncrCritPct = incrCritPct;
        }

        public double Optimize(int points)
        {
            return Optimize(points, IncrCritPct);
        }

        public double Optimize(int points, int incrCritPct)
        {
            double dmgPct = 0;
            double currentDmgPct = 0;

            for (int i = 0; i <= points; i++)
            {
                for (int j = 0; j <= (points - i); j++)
                {
                    for (int k = 0; k <= (points - (i + j)); k++)
                    {
                        if (points == (i + j + k))
                        {
                            currentDmgPct = BestCombination(i, j, k, incrCritPct);

                            if (currentDmgPct >= dmgPct)
                            {
                                AttackSpeedPoints = CurrentAttackSpeedPoints;
                                CritPoints = CurrentCritPoints;
                                PowerPoints = CurrentPowerPoints;
                                dmgPct = currentDmgPct;
                            }
                        }
                    }

                    if (points == (i + j))
                    {
                        BestCombination(i, j, 0, incrCritPct);

                        if (currentDmgPct >= dmgPct)
                        {
                            AttackSpeedPoints = CurrentAttackSpeedPoints;
                            CritPoints = CurrentCritPoints;
                            PowerPoints = CurrentPowerPoints;
                            dmgPct = currentDmgPct;
                        }
                    }
                }

                if(points == i)
                {
                    BestCombination(i, 0, 0, incrCritPct);

                    if (currentDmgPct >= dmgPct)
                    {
                        AttackSpeedPoints = CurrentAttackSpeedPoints;
                        CritPoints = CurrentCritPoints;
                        PowerPoints = CurrentPowerPoints;
                        dmgPct = currentDmgPct;
                    }
                }
            }

            DmgPct = CalcDamage(AttackSpeedPoints, CritPoints, PowerPoints, incrCritPct);
            return DmgPct;
        }

        public double CalcDamage(int attackSpeed, int crit, int power, int incrCritPct)
        {
            double powerPct = Math.Round(1 + power * (double) 0.06, 2);
            double attackSpeedPct = Math.Round(1 + attackSpeed * (double) 0.055, 3);
            double critPct = Math.Round(((1 - crit * 0.04) + crit * 0.04 * (1.5 + (incrCritPct / 100))), 2);

            if((double) Math.Round(crit * 0.04) > 100.00)
            {
                critPct = -1;
            }

            double dmgPct = Math.Round(powerPct*attackSpeedPct*critPct, 3);

            return dmgPct;
        }

        private double BestCombination(int points1, int points2, int points3, int incrCritPct)
        {
            double dmgPct1 = CalcDamage(points1, points2, points3, incrCritPct);
            double dmgPct2 = CalcDamage(points1, points3, points2, incrCritPct);
            double dmgPct3 = CalcDamage(points2, points1, points3, incrCritPct);
            double dmgPct4 = CalcDamage(points2, points3, points1, incrCritPct);
            double dmgPct5 = CalcDamage(points3, points1, points2, incrCritPct);
            double dmgPct6 = CalcDamage(points3, points2, points1, incrCritPct);

            double[] dmgPcts = new double[] {dmgPct1, dmgPct2, dmgPct3, dmgPct4, dmgPct5, dmgPct6};
            double dmgPctMax = dmgPcts.Max();

            if (dmgPct1 == dmgPctMax)
            {
                CurrentAttackSpeedPoints = points1;
                CurrentCritPoints = points2;
                CurrentPowerPoints = points3;
            }

            if (dmgPct2 == dmgPctMax)
            {
                CurrentAttackSpeedPoints = points1;
                CurrentCritPoints = points3;
                CurrentPowerPoints = points2;
            }

            if (dmgPct3 == dmgPctMax)
            {
                CurrentAttackSpeedPoints = points2;
                CurrentCritPoints = points1;
                CurrentPowerPoints = points3;
            }

            if (dmgPct4 == dmgPctMax)
            {
                CurrentAttackSpeedPoints = points2;
                CurrentCritPoints = points3;
                CurrentPowerPoints = points1;
            }

            if (dmgPct5 == dmgPctMax)
            {
                CurrentAttackSpeedPoints = points3;
                CurrentCritPoints = points1;
                CurrentPowerPoints = points2;
            }

            if (dmgPct6 == dmgPctMax)
            {
                CurrentAttackSpeedPoints = points3;
                CurrentCritPoints = points2;
                CurrentPowerPoints = points1;
            }

            return dmgPctMax;
        }

        // When is crit better than normal dmg
        public int CritRules()
        {
            bool found = false;
            int points = -1;

            for(int i = 6; !found; i++)
            {
                if(Optimize(i, 150) < Optimize(i-6, 250))
                {
                    points = i;
                    found = true;
                }
            }

            return points;
        }
    }
}

