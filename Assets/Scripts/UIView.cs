using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace GamePlay
{
    public class UIView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI MoneyText;
        [SerializeField] private TextMeshProUGUI PokeballText;
        [SerializeField] private TextMeshProUGUI RequiredMoneyText;

        private void OnEnable()
        {
            GameData.MoneyCountChange += MoneyChange;
            GameData.PokeballCountChange += PokeballChange;
            GameData.RequiredMoneyToCreateChange += RequiredMoneyChange;
        }

        private void OnDisable()
        {
            GameData.MoneyCountChange -= MoneyChange;
            GameData.PokeballCountChange -= PokeballChange;
            GameData.RequiredMoneyToCreateChange -= RequiredMoneyChange;
        }

        private void MoneyChange(int Count)
        {
            MoneyText.text = Count.ToString();
        }

        private void PokeballChange(int Count)
        {
            PokeballText.text = Count.ToString();
        }
        private void RequiredMoneyChange(int Count)
        {
            RequiredMoneyText.text = Count.ToString();
        }
    }
}

