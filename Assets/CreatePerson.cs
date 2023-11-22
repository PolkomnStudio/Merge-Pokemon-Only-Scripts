using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GamePlay
{
    public class CreatePerson : MonoBehaviour
    {
        [SerializeField] private GameObject personPrefLvl1;
        [SerializeField] private GameObject personPrefLvl2;
        [SerializeField] private GameObject personPrefLvl3;

        [SerializeField] private GameObject platforms;

        private void OnEnable()
        {
            Person.PersonLvlUp += CreatePersonLvlUp;
        }
        private void OnDisable()
        {
            Person.PersonLvlUp -= CreatePersonLvlUp;
        }



        public void CreatePersonLvlUp(Person.PersonLvl lvl, Transform transform)
        {
            switch (lvl)
            {
                case Person.PersonLvl.Lvl1:
                    GameObject Clone = Instantiate(personPrefLvl1, transform.position, transform.transform.rotation);
                    Clone.GetComponent<Person>().personCurrentLvl = lvl;
                    Clone.GetComponent<Person>().platforms = platforms;
                    break;
                case Person.PersonLvl.Lvl2:
                    GameObject Clone1 = Instantiate(personPrefLvl2, transform.position, transform.transform.rotation);
                    Clone1.GetComponent<Person>().personCurrentLvl = lvl;
                    Clone1.GetComponent<Person>().platforms = platforms;
                    break;
                case Person.PersonLvl.Lvl3:
                    GameObject Clone2 = Instantiate(personPrefLvl3, transform.position, transform.transform.rotation);
                    Clone2.GetComponent<Person>().personCurrentLvl = lvl;
                    Clone2.GetComponent<Person>().platforms = platforms;
                    break;

            }


        }
    }
}

