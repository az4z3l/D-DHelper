﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_DHelper.Source
{
    interface IMasterInterface
    {
        void CreateCharacter();
        void OpenSpellsBase();
        void OpenCharactersBase();
        void OpenItemsBase();
        void OpenDiceRoller();
        void OpenMonstersBase();
        void OpenInitiativeCounter();
        void OpenAdventuresJournal();
        void OpenOwnContentBuilder();
    }
}
