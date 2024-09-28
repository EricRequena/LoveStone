using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEffect
{
    void Effect();
    void Effect(Fighter target);
    void Effect(Fighter[] targets);
}

