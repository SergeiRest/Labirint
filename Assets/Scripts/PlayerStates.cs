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
		_currentState = SetBasicState();
	}

	public BasePlayerStates GetCurrentState()
	{
		return _currentState;
	}

	public BasePlayerStates SetProtectedState()
	{
		var state = new PlayerShieldState(_renderer);
		state.Start(_shieldMaterial);
		return state;
	}

	public BasePlayerStates SetBasicState()
	{
		var state = new PlayerBasicState(_renderer);
		state.Start(_basicMaterial);
		return state;
	}

}
