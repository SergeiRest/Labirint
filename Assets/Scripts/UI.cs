using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
	[SerializeField] private RawImage _pausePanel;

	private void Start()
	{
		_pausePanel.gameObject.SetActive(false);
	}

	public void Pause()
	{
		Time.timeScale = 0;
		FogTheWindow();
	}

	private async void FogTheWindow()
	{
		_pausePanel.gameObject.SetActive(true);
		Color color = new Color(0, 0, 0, 0);
		for (float i = 0; i < 1; i += 0.01f)
		{
			_pausePanel.color = color;
			color.a = i;
			await System.Threading.Tasks.Task.Delay(10);
		}
	}

	public void Resume()
	{
		_pausePanel.gameObject.SetActive(false);
		Time.timeScale = 1;
	}

	public void Exit()
	{
		Application.Quit();
	}
}
