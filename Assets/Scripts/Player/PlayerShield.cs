using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShield : MonoBehaviour
{
	private Player _player;
	private IEnumerator TimeToDropTheShield()
	{
		yield return new WaitForSecondsRealtime(2);
		Drop();
	}

	public void GetPlayer(Player player)
	{
		_player = player;
	}

    public void MouseDown()
	{
		_player.States.SetProtectedState();
		StartCoroutine(TimeToDropTheShield());
	}


	public void MouseUp()
	{
		Drop();
	}

	private void Drop() // Возвращение к стандартному состоянию
	{
		_player.States.SetBasicState();
	}

	
}
