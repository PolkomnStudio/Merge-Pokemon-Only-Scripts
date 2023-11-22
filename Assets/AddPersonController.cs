using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GamePlay
{
    public class AddPersonController : MonoBehaviour
    {
        [SerializeField] private GameData gameData;
        [SerializeField] private CreatePerson createPerson;
        [SerializeField] private Transform spawnPosition;
        

        private void OnEnable()
        {
            UIInput.AddPersonBtnActive += AddNewPerson;
        }

        private void OnDisable()
        {
            UIInput.AddPersonBtnActive -= AddNewPerson;
        }

        private void AddNewPerson()
        {
            if (gameData.MoneyCount >= gameData.RequiredMoneyToCreate )
            {
                gameData.SubMoneyCount();
                createPerson.CreatePersonLvlUp(gameData.PersonLvl, spawnPosition);
            }
        }
    }
}

