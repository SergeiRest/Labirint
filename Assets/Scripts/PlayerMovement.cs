using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMovement : MonoBehaviour
{
	private Transform _finishPoint;
	private Transform _startPoint;
	private NavMeshAgent _navMeshAgent;


	private IEnumerator StartMove()
	{
		yield return new WaitForSecondsRealtime(2);
		_navMeshAgent.SetDestination(_finishPoint.position);
	}

	public void Init(Transform startPoint, Transform finishPoint)
	{
		_navMeshAgent = GetComponent<NavMeshAgent>();
		_startPoint = startPoint;
		_finishPoint = finishPoint;
		StartCoroutine(StartMove());
	}

	public void Return()
	{

	}
}
