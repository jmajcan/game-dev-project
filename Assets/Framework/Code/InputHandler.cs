using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

    //This uses input to control the game
    GameController myGameController;

	//Control Mapping
	KeyCode upButton = KeyCode.W;
	KeyCode downButton = KeyCode.S;
	KeyCode leftButton = KeyCode.A;
	KeyCode rightButton = KeyCode.D;

    //Input Variables
    Vector2 directionalInput;


    private void Awake() {
        myGameController = new GameController();
    }

    public void ProcessInput()
    {
        //Process input for up button (W)
        if (Input.GetKeyDown (upButton)) {
            myGameController.OnUpInputDown ();
        }
        if (Input.GetKey (upButton)) {
            myGameController.OnUpInputHold ();
        }
        if (Input.GetKeyUp (upButton)) {
            myGameController.OnUpInputUp ();
        }

        //Process input for down button (S)
        if (Input.GetKeyDown (downButton)) {
            myGameController.OnDownInputDown ();
        }
        if (Input.GetKey (downButton)) {
            myGameController.OnDownInputHold ();
        }
        if (Input.GetKeyUp (downButton)) {
            myGameController.OnDownInputUp ();
        }

        //Process input for left button (A)
        if (Input.GetKeyDown (leftButton)) {
            myGameController.OnLeftInputDown ();
        }
        if (Input.GetKey (leftButton)) {
            myGameController.OnLeftInputHold ();
        }
        if (Input.GetKeyUp (leftButton)) {
            myGameController.OnLeftInputUp ();
        }

        //Process input for right button (D)
        if (Input.GetKeyDown (rightButton)) {
            myGameController.OnRightInputDown ();
        }
        if (Input.GetKey (rightButton)) {
            myGameController.OnRightInputHold ();
        }
        if (Input.GetKeyUp (rightButton)) {
            myGameController.OnRightInputUp ();
        }
    }
}

   
