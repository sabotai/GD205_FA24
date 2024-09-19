using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    public Transform myHazard;
    public Transform[] myHazards;

    //public int myInt = 5;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
      startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
      //if (condition == true) { do the thing; }
      //in this case, if the GetKeyDown() method of the Input class is true
      //using this argument
        if (Input.GetKeyDown(KeyCode.A)) {
          //modify the position property of the transform of the same game object this script is attached to
          //add an offset of 1 unit on the x axis
          //transform.position += new Vector3(-1f,0f,0f);
          transform.position += Vector3.left;
        }
          if (Input.GetKeyDown(KeyCode.D)) {
            transform.position += Vector3.right;
          }
          if (Input.GetKeyDown(KeyCode.W)) {
            transform.position += Vector3.forward;
          }
          if (Input.GetKeyDown(KeyCode.S)) {
            transform.position += Vector3.back;
          }

        // if (transform.position == myHazard.position){
        //   Debug.Log("BOOM");
        //   transform.position = startPos;
        // }

        for (int howManyTimesLoopHasRun = 0; howManyTimesLoopHasRun < myHazards.Length; howManyTimesLoopHasRun++){
          if (transform.position == myHazards[howManyTimesLoopHasRun].position){
            transform.position = startPos;
          }
        }


        for (int howManyTimesLoopHasRun = 0; howManyTimesLoopHasRun < 5; howManyTimesLoopHasRun++){
          Debug.Log("howManyTimesLoopHasRun = " + howManyTimesLoopHasRun);
        }





        // for (int i = 0; i < myHazards.Length; i++){
        //   if (transform.position == myHazards[i].position){
        //     transform.position = startPos;
        //   }
        // }
    }
}
