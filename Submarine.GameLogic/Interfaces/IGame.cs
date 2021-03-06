﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Submarine.GameLogic.Interfaces
{
    public interface IGame
    {
        // Properties
        string LobbyId { get; set; }
        List<IPlayer> Players { get; set; }
        IBattlefield Battlefield { get; set; }



        // Methods
        string NewGame(int amountOfPlayers);
    }
}
