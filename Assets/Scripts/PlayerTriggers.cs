using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerStates))]
public class PlayerTriggers : MonoBehaviour
{
	private PlayerStates _states;
	private void Start()
	{
		_states = GetComponent<PlayerStates>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.TryGetComponent(out DeathBlock death))
		{
			Debug.Log("Попал ты папаша");
			Debug.Log(_states.GetCurrentState());
			if (_states.GetCurrentState() is PlayerBasicState)
				Debug.Log("Абоба");
			else
				Debug.Log("Ещё подумай");
		}
	}
}
