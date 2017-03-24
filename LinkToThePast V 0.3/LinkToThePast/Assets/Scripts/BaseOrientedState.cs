using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseOrientedState : BaseState
{

  public override BaseState Update(Link link, Orientation current)
  {
    link.renderer.flipX = link.currentOrientation == Orientation.Left;

    if (link.directionalInput == Vector2.down)
    {
      link.currentOrientation = Orientation.Down;
    }
    if (link.directionalInput == Vector2.left)
    {
      link.currentOrientation = Orientation.Left;
    }
    if (link.directionalInput == Vector2.right)
    {
      link.currentOrientation = Orientation.Right;
    }
    if (link.directionalInput == Vector2.up)
    {
      link.currentOrientation = Orientation.Up;
    }

    //Managing the event where 2 directions are pressed at the same time
    if ((link.directionalInput.x > 0 && link.directionalInput.y > 0) || (link.directionalInput.x > 0 && link.directionalInput.y < 0))
    {
      link.currentOrientation = Orientation.Right;
    }
    if ((link.directionalInput.x < 0 && link.directionalInput.y > 0) || (link.directionalInput.x < 0 && link.directionalInput.y < 0))
    {
      link.currentOrientation = Orientation.Left;
    }

    return this;
  }

}
  
