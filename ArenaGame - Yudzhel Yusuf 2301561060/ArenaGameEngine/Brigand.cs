﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Brigand : Hero
    {
        public Brigand(string name) : base(name)
        {

        }

        public override void TakeDamage(int incomingDamage)
        {
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 30)
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            int dice = Random.Shared.Next(0, 100);
            if (dice <= 30)
            {
                baseAttack = Strength * 3;
            }
            return baseAttack;
        }
    }
}
