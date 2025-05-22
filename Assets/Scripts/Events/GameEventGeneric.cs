using System;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent<T> : GameEvent
{
    public T Value { get; set; }

    List<GameEventListener<T>> listeners = new List<GameEventListener<T>>();

    public override void Invoke()
    {
        foreach (var listener in listeners)
        {
            listener.Response.Invoke(Value);
        }
    }

    public void Invoke(T value)
    {
        Value = value;
        Invoke();
    }

    internal void AddListener(GameEventListener<T> gameEventListener)
    {
        if (!listeners.Contains(gameEventListener))
        {
            listeners.Add(gameEventListener);
        }
    }

    internal void RemoveListener(GameEventListener<T> gameEventListener)
    {
        listeners.Remove(gameEventListener);
    }
}
