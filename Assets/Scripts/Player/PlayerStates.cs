using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStates : MonoBehaviour
{
	[SerializeField] private Material _shieldMaterial;
	[SerializeField] private Material _basicMaterial;
	private BasePlayerStates _currentState;
	private MeshRenderer _renderer;

	
	private void Start()
	{
		_renderer = GetComponent<MeshRenderer>();
		SetBasicState();
	}

	public BasePlayerStates GetCurrentState()
	{
		return _currentState;
	}

	public void SetProtectedState()
	{
		_currentState = new PlayerShieldState(_renderer);
		_currentState.Start(_shieldMaterial);
	}

	public void SetBasicState()
	{
		_currentState = new PlayerBasicState(_renderer);
		_currentState.Start(_basicMaterial);
	}

}
