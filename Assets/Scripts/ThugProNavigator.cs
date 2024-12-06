using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ThugProNavigator : MonoBehaviour
{
    NavMeshAgent DvaAgent;
    public Transform target;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        DvaAgent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(target); //example for scott
        //DvaAgent.SetDestination(target.position);
      if (DvaAgent.remainingDistance > 0.5f){
        anim.SetFloat("Forward", 1);
      } else {
        anim.SetFloat("Forward", 0);
      }

      Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

      RaycastHit laserImpactReport = new RaycastHit();

      if (Physics.Raycast(laser, out laserImpactReport)){
        if (Input.GetMouseButtonDown(0)){
            DvaAgent.SetDestination(laserImpactReport.point);
        }
      }
    
    }

    void OnTriggerStay(Collider col){
      if (col.tag == "breakable" && Input.GetKeyDown(KeyCode.E)){
        Debug.Log("trigger is running and destroying " + col.gameObject.name);
        Destroy(col.gameObject);
      }
    }
}
