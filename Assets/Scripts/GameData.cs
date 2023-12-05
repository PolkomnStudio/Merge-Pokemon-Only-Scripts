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
        public static event Action<int> DamageChange;

        public Person.PersonLvl PersonLvl { get; private set; }

        public int MoneyCount { get; private set; }

        public int PokeballCount { get; private set; }

        public int WavesLvl { get; private set; }

        public int RequiredMoneyToCreate { get; private set; }

        public int DamageLvl1 { get; private set; }
        public int DamageLvl2 { get; private set; }
        public int DamageLvl3 { get; private set; }


        public int AttackSpeed { get; private set; }
        public int MoneyIncome { get; private set; }
        

        private void Start()
        {
            DamageLvl1 = 5;
            DamageLvl2 = 10;
            DamageLvl3 = 23;
            
            PersonLvl = Person.PersonLvl.Lvl1;
            switch (PersonLvl)
            {
                case Person.PersonLvl.Lvl1:
                    ChangeDamageHandler(DamageLvl1);
                    break;
                case Person.PersonLvl.Lvl2:
                    ChangeDamageHandler(DamageLvl2);
                    break;
                case Person.PersonLvl.Lvl3:
                    ChangeDamageHandler(DamageLvl3);
                    break;
            }
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

        private void ChangeDamageHandler(int damage)
        {
            DamageChange?.Invoke(damage);
        }
    }

    
}

