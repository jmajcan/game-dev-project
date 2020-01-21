using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    //Game Objects to act upon
    public GameObject player;

    private void Awake () {
        player = GameObject.Find("Player");
    }

    //Up Input
    public void OnUpInputDown () {
        //TODO: Occurs once when UP input is pressed
    }

    public void OnUpInputHold () {
        //TODO: Occurs every update/fixedUpdate when UP input is held down
    }

    public void OnUpInputUp () {
        //TODO: Occurs once when UP input is released
    }

    //---------------------------------------------------------------------------
    //Down Input
    public void OnDownInputDown () {
        //TODO: Occurs once when DOWN input is pressed
    }

    public void OnDownInputHold () {
        //TODO: Occurs every update/fixedUpdate when DOWN input is held down
    }

    public void OnDownInputUp () {
        //TODO: Occurs once when DOWN input is released
    }

    //---------------------------------------------------------------------------
    //Left Input
    public void OnLeftInputDown () {
        //TODO: Occurs once when LEFT input is pressed
    }

    public void OnLeftInputHold () {
        //TODO: Occurs every update/fixedUpdate when LEFT input is held down
    }

    public void OnLeftInputUp () {
        //TODO: Occurs once when LEFT input is released
    }

    //---------------------------------------------------------------------------
    //Right Input
    public void OnRightInputDown () {
        //TODO: Occurs once when RIGHT input is pressed
    }

    public void OnRightInputHold () {
        //TODO: Occurs every update/fixedUpdate when RIGHT input is held down
    }

    public void OnRightInputUp () {
        //TODO: Occurs once when RIGHT input is released
    }
}