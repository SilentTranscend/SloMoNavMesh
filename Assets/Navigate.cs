using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigate : MonoBehaviour
{
    public Transform start;
    public Transform end;
    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Patrol());
    }

    IEnumerator Patrol()
    {
        while (true)
        {
            agent.SetDestination(start.position);
            yield return new WaitUntil(() => Vector3.Distance(transform.position, start.position) < 0.2f);
            agent.SetDestination(end.position);
            yield return new WaitUntil(() => Vector3.Distance(transform.position, end.position) < 0.2f);
        }
    }
}
