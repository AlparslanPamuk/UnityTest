using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float playerSpeed = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        //Player spawn point 

        //This is where our player will start in the game as played

        //Player = game object =transform!

        transform.position = new Vector3(0, 3, 0);



    }

    // Update is called once per frame
    void Update()


    {
        // Player to move  left right up down
        //Player    (game object) movement as i wanted

        transform.Translate(Vector3.right * Input.GetAxis("Horizontal")* playerSpeed * Time.deltaTime);

        transform.Translate(Vector3.up * Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);

    }
}
