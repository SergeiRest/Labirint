using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
	public delegate void OnLevelComplete();
	public OnLevelComplete LevelComplete;
	private void OnTriggerEnter(Collider other)
	{
		if(other.TryGetComponent(out Player player))
		{
			Debug.Log("Finish");
			LevelComplete?.Invoke();
		}
	}
}
