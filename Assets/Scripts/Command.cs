﻿using UnityEngine;
using System.Collections;

public class Command 
{
	public virtual void Execute(GameObject actor){}	
}

public class FireCommand : Command
{
	public override void Execute (GameObject actor)
	{
		actor.GetComponent<CharacterComponent>().Fire();
	}
}

public class ReloadCommand : Command
{
    public override void Execute(GameObject actor)
    {
        actor.GetComponent<CharacterComponent>().Reload();
    }
}
