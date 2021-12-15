using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
	public delegate void OnLevelComplete();
	public OnLevelComplete LevelComplete;
	public OnLevelComplete FinalChord; // Делегат на запуск конфети при финише
	private void OnTriggerEnter(Collider other)
	{
		if(other.TryGetComponent(out Player player))
		{
			FinalChord?.Invoke();
			RebootPrepairing();
		}
	}

	private async void RebootPrepairing()
	{
		await System.Threading.Tasks.Task.Delay(2000);
		LevelComplete?.Invoke();
	}
}
