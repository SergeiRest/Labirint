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


	private async void StartMove()
	{
		await System.Threading.Tasks.Task.Delay(2000);
		_navMeshAgent.isStopped = false;
		_navMeshAgent.SetDestination(_finishPoint.position);
	}

	public void Init(Transform startPoint, Transform finishPoint)
	{
		_navMeshAgent = GetComponent<NavMeshAgent>();
		_startPoint = startPoint;
		_finishPoint = finishPoint;
		StartMove();
	}

	public void Return()
	{
		gameObject.SetActive(true);
		transform.position = _startPoint.position;
		StartMove();
	}

	public void StopMove()
	{
		_navMeshAgent.isStopped = true;
	}
}
