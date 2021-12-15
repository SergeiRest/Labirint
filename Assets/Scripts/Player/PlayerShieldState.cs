using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShieldState : BasePlayerStates
{
	public PlayerShieldState(MeshRenderer renderer) : base(renderer)
	{

	}
	public override void Start(Material material)
	{
		_renderer.material = material;
	}
}
