using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockFall : MonoBehaviour
{
    public GameObject Rock;
    public GameObject[] Plateforms;
    private int rand;
    private int listLenght;

    // Start is called before the first frame update
    void Start()
    {
        Plateforms = GameObject.FindGameObjectsWithTag("Plateform");
        
    }

    public void RockSpawn()

    {
        Plateforms = GameObject.FindGameObjectsWithTag("Plateform");
        listLenght = Plateforms.Length;
        rand = Random.Range(0, listLenght - 1);
        Instantiate(Rock, Plateforms[rand].transform);
    }


}
