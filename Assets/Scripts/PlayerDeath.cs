using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
	[SerializeField] private GameObject _cubeContainer;
	private PlayerTriggers _trigger;

	private void Start()
	{
		_trigger = GetComponent<PlayerTriggers>();
		_trigger.PlayerDeath += DeathAnimation;
	}

	private void DeathAnimation()
	{
		Instantiate(_cubeContainer, transform.position, Quaternion.identity);
	}
}
