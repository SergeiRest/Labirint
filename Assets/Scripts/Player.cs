using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private PlayerStates _playerStates;
	[SerializeField] private PlayerMovement _movement;
	private void Start()
	{
		_playerStates = GetComponent<PlayerStates>();
	}
	public PlayerStates States
	{
		get { return _playerStates; }
	}

	public PlayerMovement Movement
	{
		get { return _movement; }
	}
}
