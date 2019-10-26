using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MeleeUnit : MonoBehaviour
{
    public GameObject Base1;
    public GameObject Base2;
    public GameObject Base3;

    public GameObject enemy;
    NavMeshAgent agent;
    public float speed = 5f;
    public float health = 20f;
    public float attackDam = 5f;
    
    public GameObject thisObjectSpawn;
    // Start is called before the first frame update
    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();
        //enemy = GameObject.FindGameObjectWithTag("ranger");
        for (int i = 0; i < 4; i++)
        {
            GameObject spawn = Instantiate(this.gameObject, Base1.transform.position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
