using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBasicState : BasePlayerStates
{
	public PlayerBasicState(MeshRenderer renderer) : base (renderer)
	{

	}

	public override void Start(Material material)
	{
		_renderer.material = material;
	}
}
