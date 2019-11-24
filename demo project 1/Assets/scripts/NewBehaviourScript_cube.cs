using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript_cube : MonoBehaviour
{
    Vector3 vec1,vec;
    
    // Start is called before the first frame update
    void Start()
    {
       /* vec1 = transform.position;
        Debug.Log(vec1.x);
        Debug.Log(vec1.y);
        Debug.Log(vec1.z);

        GetComponent<Renderer>().material.color = new Color(0.5f, 1, 1); //C#
        GetComponent<Renderer>().material.color = new Color(0.5f,1,2); //C#
       // GameObject.Destroy(gameObject, 3);
       */ 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            vec = transform.localPosition;
            vec.y += 4;
            transform.localPosition = vec;
            Debug.Log("you have pressed space bar key!");
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            vec = transform.localPosition;
            vec.x += 4;
            transform.localPosition = vec;
            Debug.Log("you have pressed space bar key!");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            vec = transform.localPosition;
            vec.x -= 4;
            transform.localPosition = vec;
            Debug.Log("you have pressed space bar key!");
        }
        /*
        if (Input.GetKeyDown(KeyCode.R))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
        
        vec1.x += 0.011f;
        vec1.y += 0.011f;
        //transform.position = vec1;
        transform.Rotate(vec1);
        */ 
    }
         
}
