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
        
        
            GameObject spawn = Instantiate(this.gameObject, thisObjectSpawn.transform.position, Quaternion.Euler(0f,0f,0f));
            spawn.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 0f, speed), ForceMode.Impulse);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
