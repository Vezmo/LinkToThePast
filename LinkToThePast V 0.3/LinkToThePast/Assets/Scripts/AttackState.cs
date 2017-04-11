using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : BaseState
{
  private float attackduration;
  private bool isAnimated;
// oli tu suces en criss

  public AttackState()
  {
    //Length of attack animation
    attackduration = 0.233f;
    isAnimated = false;
  }

  public override BaseState Update(Link link, Orientation currentOrientation)
  {
    if (!isAnimated)
    {
      if (currentOrientation == Orientation.Down)
      {
        link.anim.Play("DownSwing", 0, 0f);
      }
      if (currentOrientation == Orientation.Right || currentOrientation == Orientation.Left)
      {
        link.anim.Play("SideSwing", 0, 0f);
      }
      if (currentOrientation == Orientation.Up)
      {
        link.anim.Play("UpSwing", 0, 0f);
      }
      isAnimated = true;
    }

    link.velocity = Vector2.zero;
    attackduration -= Time.deltaTime;
    
    if (Input.GetButtonDown("Attack"))
    {
      return new AttackState();
    }

    if (attackduration <= 0)
    {
      return new DefaultState();
    }
    return this;
  }
}
