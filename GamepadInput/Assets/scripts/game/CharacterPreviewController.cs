using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterPreviewController : MonoBehaviour {

    [SerializeField]
    private GameObject _selectedCharacter;

    [SerializeField]
    private GameObject[] _characters;

    private void Start () {
        HideAllCharacters();
        int selectedCharacterIndex = PlayerPrefs.GetInt(CharSelectMenuController.CHARACTER, 0);
        _selectedCharacter = _characters[selectedCharacterIndex];
        ShowSelectedCharacter();
    }   

    private void HideAllCharacters() {
        foreach (GameObject character in _characters)
            character.SetActive(false);
    }

    private void ShowSelectedCharacter() {
        _selectedCharacter.SetActive(true);
    }

    public void Run() {
        _selectedCharacter.GetComponent<WarriorAnimationDemoFREE>().Run();
    }

    public void Idle() {
        _selectedCharacter.GetComponent<WarriorAnimationDemoFREE>().Idle();
    }

    public void Attack() {
        _selectedCharacter.GetComponent<WarriorAnimationDemoFREE>().Attack();
    }

    public void Exit() {
        SceneManager.LoadScene("intro");
    }    
}
