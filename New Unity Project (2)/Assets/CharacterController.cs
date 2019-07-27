using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    protected double speed = 1.0;

    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 position = this.transform.position;
            position.x++;
            this.transform.position = position;

        }

        /*
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Vector2 position = this.transform.position;
            position.y++;
            this.transform.position = position;
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 position = this.transform.position;
            position.y--;
            this.transform.position = position;
        }

    */
    }

}
