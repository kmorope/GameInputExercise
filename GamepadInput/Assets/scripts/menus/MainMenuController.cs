using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MenuController {

    public override void ConfirmOption() {
        switch (_currentOption) {
            case 0:
                SceneManager.LoadScene("game");
                break;
            case 1:
                SceneManager.LoadScene("charselect");
                break;
        }
    }

}
