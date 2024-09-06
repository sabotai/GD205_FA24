using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      //if (condition == true) { do the thing; }
      //in this case, if the GetKeyDown() method of the Input class is true
      //using this argument
        if (Input.GetKeyDown("space")) {

          //modify the position property of the transform of the same game object this script is attached to
          //add an offset of 1 unit on the x axis
          transform.position += new Vector3(1f,0f,0f);
        }
    }
}
