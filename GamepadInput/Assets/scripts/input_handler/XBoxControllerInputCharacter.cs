using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XBoxControllerInputCharacter: MonoBehaviour
{
	[SerializeField]
	private float _umbral = 0.3f;

	[SerializeField]
	private bool _isListening = true;

	[SerializeField]
	private float _coolDownTime = 0.5f;

	[SerializeField]
	private CharacterPreviewController _character;
 
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
			 
			_character.Attack();
			 

			StartCoroutine(ToggleListening(true, _coolDownTime));

		}
		if (Input.GetAxis("B Button") == 1)
		{
			ToggleListening(false, 0); 
			 
			_character.Idle();
			 

			StartCoroutine(ToggleListening(true, _coolDownTime));

		}
		if (Input.GetAxis("X Button") == 1)
		{
			ToggleListening(false, 0); 
			 
			_character.Run();
			 

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

 
