using StarterKit.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : BaseObject
{
    public Transform target;

    public override void BaseObjectUpdate()
    {
        transform.position = new Vector3(target.position.x, 0f, -10f);
    }
}
