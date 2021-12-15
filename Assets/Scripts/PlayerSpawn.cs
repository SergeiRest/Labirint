using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
	[SerializeField] private Transform _start;
	[SerializeField] private Transform _finish;
	[SerializeField] private Player _player;
	[SerializeField] private UI _uI;
    void Start()
    {
		Spawn();
    }

	public void Spawn()
	{
		var player = Instantiate(_player, _start.position, Quaternion.identity);
		player.Movement.Init(_start, _finish);
		_uI.GetPlayer(player);
	}
}
