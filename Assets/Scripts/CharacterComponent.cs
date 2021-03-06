﻿using UnityEngine;
using System.Collections.Generic;
// don't attach this to a game object
public abstract class CharacterComponent: MonoBehaviour
{
	protected List<Observer> Observers = new List<Observer>();

	protected void Notify(GameObject actor, EVENTS e)
	{
		for (var i = 0; i < Observers.Count; i++)
			Observers[i].OnNotify(actor, e);
	}

	public virtual void Fire()
	{
		Notify(gameObject, EVENTS.FIRED);
	}
	public virtual void Jump()
	{
		Notify(gameObject, EVENTS.JUMPED);
	}
}
