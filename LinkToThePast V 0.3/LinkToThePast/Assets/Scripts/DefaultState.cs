using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class DefaultState : BaseOrientedState
{


  public DefaultState() {}


  public override BaseState Update(Link link, Orientation currentOrientation)
  {

    Vector2 directionalInput = link.directionalInput;
    base.Update(link, currentOrientation);

    link.velocity = directionalInput * link.moveSpeed;
    link.controller.Move(link.velocity * Time.deltaTime);

    if (Input.GetButtonDown("Attack"))
    {
      return new AttackState();
    }

    if (Input.GetButtonDown("Charge"))
    {
      return new BufferChargeState(link);
    }


    return this;
  }

  void ManageOrientation(Link link)
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

  }


}
