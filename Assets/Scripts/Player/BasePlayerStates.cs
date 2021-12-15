using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePlayerStates
{
	protected MeshRenderer _renderer;

	protected BasePlayerStates(MeshRenderer renderer)
	{
		_renderer = renderer;
	}

	public abstract void Start(Material material);
}
