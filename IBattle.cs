﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemontest
{
    internal interface IBattle
    {
        void StartBattle(Player player1, Player player2);
        void EndBattle(Player winner);
    }
}
