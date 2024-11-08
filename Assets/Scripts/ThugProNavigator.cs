using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ThugProNavigator : MonoBehaviour
{
    NavMeshAgent DvaAgent;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        DvaAgent = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
        //DvaAgent.SetDestination(target.position);

      Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

      RaycastHit laserImpactReport = new RaycastHit();

      if (Physics.Raycast(laser, out laserImpactReport)){
        if (Input.GetMouseButtonDown(0)){
            DvaAgent.SetDestination(laserImpactReport.point);
        }
      }
    }
}
