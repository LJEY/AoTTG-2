﻿using Assets.Scripts.Characters;

namespace Assets.Scripts.Services.Events
{
    public delegate void OnSpawn<in T>(T entity) where T : Entity;
    public delegate void OnKilled<in T1, in T2>(T1 killer, T2 victim) where T1 : Entity where T2 : Entity;

    public delegate void OnUnRegister<in T>(T entity) where T : Entity;
}