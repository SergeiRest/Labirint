using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

[RequireComponent(typeof(PlayerStates))]
[RequireComponent(typeof(PlayerMovement))]
public class PlayerTriggers : MonoBehaviour
{
	private PlayerStates _states;
	private PlayerMovement _movement;
	public delegate void OnPlayerDeath();
	public OnPlayerDeath PlayerDeath;
	private void Start()
	{
		_movement = GetComponent<PlayerMovement>();
		_states = GetComponent<PlayerStates>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.TryGetComponent(out DeathBlock death))
		{
			if (_states.GetCurrentState() is PlayerBasicState)
			{
				Death();
			}
		}
	}

	private async void Death()
	{
		_movement.StopMove();
		PlayerDeath.Invoke();
		await Task.Delay(200);
		gameObject.SetActive(false);
		await Task.Delay(1000);
		_movement.Return();
	}
}
