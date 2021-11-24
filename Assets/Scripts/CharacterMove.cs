using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMove : MonoBehaviour
{
    NavMeshAgent agent;
    [SerializeField] GameObject[] targets;
    int count = 0;
    GameObject currTarget;

    void Start()
    {
        count = targets.Length;
        agent = GetComponent<NavMeshAgent>();
        currTarget = targets[Random.Range(0, count)];
        agent.destination =  currTarget.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.remainingDistance < 1.1f)
        {
            currTarget = targets[Random.Range(0, count)];
            print(currTarget);
        }
        agent.destination = currTarget.transform.position;
    }

}
