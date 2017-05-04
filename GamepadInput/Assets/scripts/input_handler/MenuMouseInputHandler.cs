using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputHandler : InputHandler {

    public void SetOption(int option) {
        MenuController menuController = (MenuController)_actor;
        menuController.SetOption(option);
        menuController.ConfirmOption();
    }

}