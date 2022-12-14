using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentWalking : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            RaycastHit result;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out result, 100.0f)){
                agent.SetDestination(result.point);
            }
        }
    }
}
