using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Person : MonoBehaviour
{
    private Rigidbody rb;
    private Camera cam;
    private List<Transform> cellPositions = new List<Transform>();
    public GameObject platforms;
    [SerializeField] private Material defaultCellMaterial;
    [SerializeField] private Material greenCellMaterial;
    private Transform activeCell;
    public static Action<PersonLvl, Transform> PersonLvlUp;
    private Vector3 lastCellposition;

    //[SerializeField] private Animator anim;

    private int ID;

    public PersonLvl personCurrentLvl;
    public enum PersonLvl
    {
        Lvl1,
        Lvl2,
        Lvl3
    };

    private void Start()
    {
        ID = GetInstanceID();
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
        lastCellposition = transform.position;
        GetAllChildObjects(platforms.transform);
    }

    
    private void OnTriggerEnter(Collider other)
    {
        

        Person otherPerson = other.gameObject.GetComponent<Person>();
        if (otherPerson != null)
        {
            
            if (otherPerson.personCurrentLvl == personCurrentLvl && personCurrentLvl != PersonLvl.Lvl3)
            {
                if (ID < other.gameObject.GetComponent<Person>().ID) { return; }
                {
                    otherPerson.gameObject.SetActive(false);
                    gameObject.SetActive(false);

                    int nextIndex = (int)personCurrentLvl + 1;
                    PersonLvl nextLevel = (PersonLvl)nextIndex;
                    PersonLvlUp?.Invoke(nextLevel, otherPerson.transform);
                }
               
            }
            else
            {
                transform.position = otherPerson.lastCellposition;
            }

        }
    }

   

    private void GetAllChildObjects(Transform parent)
    {
        foreach (Transform child in parent)
        {
            // Добавляем дочерний объект в список
            cellPositions.Add(child);
        }
    }

    private void OnMouseDrag()
    {
        var x = Input.GetAxis("Mouse X");
        var y = Input.GetAxis("Mouse Y");

        var position = transform.position;

        position.x = (Mathf.Clamp(position.x + x * 100f * Time.deltaTime, -3f, 3f));
        position.z = (Mathf.Clamp(position.z + y * 100f * Time.deltaTime, 0.75f, 3.5f));

        transform.position = position;

        rb.isKinematic = true;
        #region First realization
        //Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f);


        //Vector3 objPosition = cam.ScreenToWorldPoint(mousePosition);

        //objPosition.x = Mathf.Clamp(objPosition.x, -3f, 3f);
        //objPosition.z = Mathf.Clamp(objPosition.y, 0.75f, 3.5f);



        //transform.position = new Vector3(objPosition.x, 0f, objPosition.z);
        #endregion

        #region GreenCell
        //Vector3 closestCell = cellPositions[3].transform.position;
        //float closestDistance = Vector3.Distance(transform.position, (closestCell));

        //foreach (Transform cell in cellPositions)
        //{
        //    float distance = Vector3.Distance(transform.position, cell.transform.position);
        //    if (distance < closestDistance)
        //    {
        //        //cell.GetComponent<MeshRenderer>().material = greenCellMaterial;
        //        closestCell = cell.transform.position;
        //        closestDistance = distance;
        //        //cell.GetComponent<MeshRenderer>().material = greenCellMaterial;
        //    }
        //    else
        //    {
        //        //cell.GetComponent<MeshRenderer>().material = defaultCellMaterial;
        //    }

        //}
        #endregion

    }

    private void OnMouseUp()
    {
       
        transform.position = SnapToCell(transform.position);
        rb.isKinematic = false;
        lastCellposition = transform.position;
    }


    private Vector3 SnapToCell(Vector3 position)
    {
        
        Vector3 closestCell = cellPositions[3].transform.position;
        float closestDistance = Vector3.Distance(new Vector3(position.x, 0f, position.z), (closestCell));

        foreach (Transform cell in cellPositions)
        {
            float distance = Vector3.Distance(new Vector3(position.x, 0f, position.z), cell.transform.position);
            if (distance < closestDistance)
            {
                //cell.GetComponent<MeshRenderer>().material = greenCellMaterial;
                closestCell = cell.transform.position;
                closestDistance = distance;
                //cell.GetComponent<MeshRenderer>().material = defaultCellMaterial;
            }
            
        }
        
        
        return new Vector3(closestCell.x, 0f, closestCell.z);
    }
}
