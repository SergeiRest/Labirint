using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loader : MonoBehaviour
{
	[SerializeField] private FinishPoint _point;
	[SerializeField] private RawImage _finishPanel;
	private int _buildIndex;
    void Start()
    {
		_finishPanel.gameObject.SetActive(false);
		_buildIndex = SceneManager.GetActiveScene().buildIndex;
		_point.LevelComplete += SceneReload;
    }

	private async void SceneReload()
	{
		_finishPanel.gameObject.SetActive(true);
		Color color = new Color(0, 0, 0, 0);
		for (float i = 0; i < 1; i += 0.01f)
		{
			_finishPanel.color = color;
			color.a = i;
			await System.Threading.Tasks.Task.Delay(10);
		}
		await System.Threading.Tasks.Task.Delay(3000);
		SceneManager.LoadScene(_buildIndex);
	}
}
