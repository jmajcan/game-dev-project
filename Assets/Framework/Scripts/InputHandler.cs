using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

    //Things which input controls
    public GameObject player;
    private PlayerController playerController;


	//Control Mapping
	KeyCode upButton = KeyCode.W;
	KeyCode downButton = KeyCode.S;
	KeyCode leftButton = KeyCode.A;
	KeyCode rightButton = KeyCode.D;

    //Input Flags
    bool upInput = false;
    bool downInput = false;

    private void Awake() {
        player = GameObject.Find("Player");
        playerController = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    private void FixedUpdate () {
        ProcessInput();
    }

    public void ProcessInput()
    {
        //Process input for up button (W)
        if (Input.GetKeyDown (upButton)) {
            OnUpInputDown ();
        }
        if (Input.GetKey (upButton)) {
            upInput = true;
            OnUpInputHold ();
        } else {
            upInput = false;
        }
        if (Input.GetKeyUp (upButton)) {
            OnUpInputUp ();
        }

        //Process input for down button (S)
        if (Input.GetKeyDown (downButton)) {
           OnDownInputDown ();
        }
        if (Input.GetKey (downButton)) {
            downInput = true;
            OnDownInputHold ();
        } else {
            downInput = false;
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


        if (!upInput && !downInput){
            OnNoInputUpDown ();
        }

        //Set Rotation Point towards mouse and set targetRotation it in player
        Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = point - player.transform.position;
        float rotationAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rotationAngle = rotationAngle - 90;
        playerController.SetTargetRotation(Quaternion.Euler(0, 0, rotationAngle));

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
        playerController.Accelerate(1);
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
        playerController.Accelerate(-1);
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
    }

    public void OnRightInputUp () {
        //TODO: Occurs once when RIGHT input is released
    }

    //---------------------------------------------------------------------------
    //Absence of Input
    //---------------------------------------------------------------------------

    public void OnNoInputUpDown () {
        playerController.Accelerate(0);
    }
}

   
