using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XBoxControllerInputHandler : InputHandler
{
    [SerializeField]
    private float _umbral = 0.3f;

    [SerializeField]
    private bool _isListening = true;

    [SerializeField]
    private float _coolDownTime = 0.5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("A Button") == 1)
        {
            ToggleListening(false, 0); 
            ((MenuController)_actor).ConfirmOption();
            StartCoroutine(ToggleListening(true, _coolDownTime));

        }
        if (Input.GetAxis("LeftJS Y") > _umbral && _isListening)
        {
            ToggleListening(false, 0);
            ((MenuController)_actor).NextOption();
            StartCoroutine(ToggleListening(true, _coolDownTime));

        }
        if (Input.GetAxis("LeftJS X") > _umbral && _isListening)
        {
            ToggleListening(false, 0);
            ((MenuController)_actor).NextOption();
            StartCoroutine(ToggleListening(true, _coolDownTime));

        }
        if (Input.GetAxis("LeftJS Y") < (_umbral * -1) && _isListening)
        {
            ToggleListening(false, 0);
            ((MenuController)_actor).PrevOption();
            StartCoroutine(ToggleListening(true, _coolDownTime));
        }
        if (Input.GetAxis("LeftJS X") < (_umbral * -1) && _isListening)
        {
            ToggleListening(false, 0);
            ((MenuController)_actor).PrevOption();
            StartCoroutine(ToggleListening(true, _coolDownTime));
        }
    }

    IEnumerator ToggleListening(bool status, float delay)
    {
        if (status)
        {
            yield return new WaitForSeconds(delay);
        }
        _isListening = status;
    }
}
