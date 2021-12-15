using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
	[SerializeField] private GameObject _gamePlane;
	[SerializeField] private GameObject _wall;
	private int rand;
	int xsc;
	int zsc;
    void Start()
    {
		xsc = -(int)(_gamePlane.transform.localScale.x - 1) / 2;
		zsc = -(int)(_gamePlane.transform.localScale.z - 2) / 2;
		for(int i = xsc; i < (_gamePlane.transform.localScale.x) / 2; i++)
		{
			for(int j = zsc; j < (_gamePlane.transform.localScale.z - 2) / 2; j++)
			{
				int rand = Random.Range(0, 2);
				if(rand == 1)
				{
					var obj = Instantiate(_wall, new Vector3(i, 1, j), Quaternion.identity);
				}
				
			}
		}
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
