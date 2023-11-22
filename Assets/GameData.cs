using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace GamePlay
{
    public class GameData : MonoBehaviour
    {
        public static event Action<int> MoneyCountChange;
        public static event Action<Person.PersonLvl> PersonLvlChange;
        public static event Action<int> PokeballCountChange;
        public static event Action<int> WavesLvlChange;
        public static event Action<int> RequiredMoneyToCreateChange;

        public Person.PersonLvl PersonLvl { get; private set; }

        public int MoneyCount { get; private set; }

        public int PokeballCount { get; private set; }

        public int WavesLvl { get; private set; }

        public int RequiredMoneyToCreate { get; private set; }


        private void Start()
        {
            PersonLvl = Person.PersonLvl.Lvl1;
            MoneyCount = 100;
            ChangeMoneyCountHandler();
            PokeballCount = 0;
            ChangePokeballCountHandler();
            WavesLvl = 1;
            RequiredMoneyToCreate = 75;
            ChangeRequiredMoneyToCreateHandler();
        }

        public void SubMoneyCount()
        {
            if (MoneyCount - RequiredMoneyToCreate >= 0 )
            {
                MoneyCount -= RequiredMoneyToCreate;
                ChangeMoneyCountHandler();
            }
        }

        private void AddMoneyCount()
        {

            MoneyCount++; ;
            ChangeMoneyCountHandler();
            
        }

        private void ChangeMoneyCountHandler()
        {
            MoneyCountChange?.Invoke(MoneyCount);
        }




        private void ChangePokeballCountHandler()
        {
            PokeballCountChange?.Invoke(PokeballCount);
        }



        private void RequiredMoneyToCreateUp()
        {

            RequiredMoneyToCreate *= WavesLvl;
            ChangeRequiredMoneyToCreateHandler();

        }
        private void ChangeRequiredMoneyToCreateHandler()
        {
            RequiredMoneyToCreateChange?.Invoke(RequiredMoneyToCreate);
        }
    }

    
}

