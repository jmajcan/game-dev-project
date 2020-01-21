using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Player : MonoBehaviour {

    //Variables which instantiate other scripts
    InputHandler myInputHandler;

    // Start is called before the first frame update
    void Start () {
        myInputHandler = new InputHandler ();
    }

    // Update is called once per frame
    private void FixedUpdate () {
        myInputHandler.ProcessInput ();
    }

    public void Move (Vector2 direction)
    {
        //TODO: Make player move based on input
    }
}