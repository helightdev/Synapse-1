﻿using UnityEngine;

namespace Synapse.Api
{
    public class Elevator
    {
        internal Elevator(Lift lift) => Lift = lift;

        private Lift Lift;

        public GameObject GameObject => Lift.gameObject;

        public Lift.Status Status { get => Lift.status; set => Lift.SetStatus((byte)value); }

        public bool Locked { get => Lift._locked; set => Lift.SetLock(value); }

        public float MaxDistance { get => Lift.maxDistance; set => Lift.maxDistance = value; }

        public void Use() => Lift.UseLift();
    }
}
