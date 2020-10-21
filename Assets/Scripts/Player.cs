using System.Collections;
using System.Collections.Generic;
using StarterKit.Base;
using UnityEngine;

public class Player : BaseObject
{
    public override void BaseObjectUpdate()
    {
        float translation = Input.GetAxis("Horizontal") * 20;
        translation *= Time.deltaTime;

        transform.Translate(translation, 0, 0);
    }
}
