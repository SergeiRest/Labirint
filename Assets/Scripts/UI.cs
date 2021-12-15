using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
	private Player _player;
	private IEnumerator TimeToDropTheShield()
	{
		yield return new WaitForSecondsRealtime(2);
		Debug.Log("Хватит жать");
		Drop();
	}

	public void GetPlayer(Player player)
	{
		_player = player;
	}

    public void OnDown()
	{
		_player.States.SetProtectedState();
		StartCoroutine(TimeToDropTheShield());
	}


	public void OnUp()
	{
		Drop();
	}

	private void Drop()
	{
		_player.States.SetBasicState();
	}

	
}
