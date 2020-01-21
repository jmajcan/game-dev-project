using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

    //This uses input to control the game
    public GameObject player;


	//Control Mapping
	KeyCode upButton = KeyCode.W;
	KeyCode downButton = KeyCode.S;
	KeyCode leftButton = KeyCode.A;
	KeyCode rightButton = KeyCode.D;

    private void Awake() {
        player = GameObject.Find("Player");
    }

    public void ProcessInput()
    {
        //Process input for up button (W)
        if (Input.GetKeyDown (upButton)) {
            OnUpInputDown ();
        }
        if (Input.GetKey (upButton)) {
            OnUpInputHold ();
        }
        if (Input.GetKeyUp (upButton)) {
            OnUpInputUp ();
        }

        //Process input for down button (S)
        if (Input.GetKeyDown (downButton)) {
           OnDownInputDown ();
        }
        if (Input.GetKey (downButton)) {
            OnDownInputHold ();
        }
        if (Input.GetKeyUp (downButton)) {
            OnDownInputUp ();
        }

        //Process input for left button (A)
        if (Input.GetKeyDown (leftButton)) {
            OnLeftInputDown ();
        }
        if (Input.GetKey (leftButton)) {
            OnLeftInputHold ();
        }
        if (Input.GetKeyUp (leftButton)) {
            OnLeftInputUp ();
        }

        //Process input for right button (D)
        if (Input.GetKeyDown (rightButton)) {
            OnRightInputDown ();
        }
        if (Input.GetKey (rightButton)) {
            OnRightInputHold ();
        }
        if (Input.GetKeyUp (rightButton)) {
            OnRightInputUp ();
        }
    }


//--------------------------------------------------------------------------------------
// Input Functions
//--------------------------------------------------------------------------------------

    //---------------------------------------------------------------------------
    //Up Input
    //---------------------------------------------------------------------------
    public void OnUpInputDown () {
        //TODO: Occurs once when UP input is pressed
    }

    public void OnUpInputHold () {
        player.GetComponent<Player>().Move(Vector2.up); //Calls Move method in Player script
    }

    public void OnUpInputUp () {
        //TODO: Occurs once when UP input is released
    }

    //---------------------------------------------------------------------------
    //Down Input
    //---------------------------------------------------------------------------
    public void OnDownInputDown () {
        //TODO: Occurs once when DOWN input is pressed
    }

    public void OnDownInputHold () {
        player.GetComponent<Player>().Move(Vector2.down); //Calls Move method in Player script
    }

    public void OnDownInputUp () {
        //TODO: Occurs once when DOWN input is released
    }

    //---------------------------------------------------------------------------
    //Left Input
    //---------------------------------------------------------------------------
    public void OnLeftInputDown () {
        //TODO: Occurs once when LEFT input is pressed
    }

    public void OnLeftInputHold () {
        player.GetComponent<Player>().Move(Vector2.left); //Calls Move method in Player script
    }

    public void OnLeftInputUp () {
        //TODO: Occurs once when LEFT input is released
    }

    //---------------------------------------------------------------------------
    //Right Input
    //---------------------------------------------------------------------------
    public void OnRightInputDown () {
        //TODO: Occurs once when RIGHT input is pressed
    }

    public void OnRightInputHold () {
        player.GetComponent<Player>().Move(Vector2.right); //Calls Move method in Player script
    }

    public void OnRightInputUp () {
        //TODO: Occurs once when RIGHT input is released
    }
}

   
