using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Generator : MonoBehaviour
{
	[SerializeField] private NavMeshSurface _navMeshSurface;
	[SerializeField] private GameObject _gamePlane;
	[SerializeField] private GameObject _wall;
	[SerializeField] private GameObject _deathPlane;
	private int rand;
	float xsc;
	float zsc;
    void Start()
    {
		xsc = -(_gamePlane.transform.localScale.x - 2) / 2;
		zsc = -(int)(_gamePlane.transform.localScale.z - 3) / 2;
		for(float i = xsc; i < (_gamePlane.transform.localScale.x - 2) / 2; i += 1.5f)
		{
			for(float j = zsc; j < (_gamePlane.transform.localScale.z - 2) / 2; j++)
			{
				int rand = Random.Range(0, 3);
				if(rand == 1)
				{
					var obj = Instantiate(_wall, new Vector3(i, 1, j), Quaternion.identity);
				}
				else if (rand == 2)
				{
					var obj = Instantiate(_deathPlane, new Vector3(i, 0.5f, j), Quaternion.identity);
				}


			}
		}

		_navMeshSurface.BuildNavMesh();
	}
}
