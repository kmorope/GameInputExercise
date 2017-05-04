using UnityEngine;
using UnityEngine.SceneManagement;

public class CharSelectMenuController : MenuController {

    public const string CHARACTER = "character";

	private void Start () {
        int savedOption = PlayerPrefs.GetInt(CHARACTER, 0);
        SetOption(savedOption);
	}

    public override void ConfirmOption() {
        PlayerPrefs.SetInt(CHARACTER, _currentOption);
    }

    public void Exit() {
        SceneManager.LoadScene("intro");
    }

}
