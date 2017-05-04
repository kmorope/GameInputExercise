using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MenuController : Actor {

    [SerializeField]
    protected RectTransform _selectedOptionIcon;

    [SerializeField]
    protected RectTransform[] _options;

    [SerializeField]
    protected Vector3 _offset;

    protected int _currentOption = 0;

    public void NextOption() {
        MoveOptionTo(1);
    }

    public void PrevOption() {
        MoveOptionTo(-1);
    }

    private void MoveOptionTo(int direction) {
        int nextOption = _currentOption + direction;
        nextOption = Mathf.Clamp(nextOption, 0, (_options.Length - 1));
        SetOption(nextOption);
    }


    public void SetOption(int optionIndex) {
        _currentOption = optionIndex;
        _selectedOptionIcon.position = _options[_currentOption].position + _offset;

    }

    public abstract void ConfirmOption();
}
