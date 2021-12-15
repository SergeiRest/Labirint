using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishParticle : MonoBehaviour
{
	[SerializeField] private ParticleSystem _confetti;
	[SerializeField] private FinishPoint _point;

	private void Start()
	{
		_point.FinalChord += StartParticle;
	}

	private void StartParticle()
	{
		_confetti.gameObject.SetActive(true);
		_confetti.Play();
		Disable();
	}

	private void Disable()
	{
		_point.FinalChord -= StartParticle;
	}
}
