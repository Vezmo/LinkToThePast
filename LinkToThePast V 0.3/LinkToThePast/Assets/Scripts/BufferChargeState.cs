using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class BufferChargeState : BaseOrientedState {

  private float bufferTimerToCharge;
  private Orientation onStartOrientation;
  private float currentBufferTime;

  public BufferChargeState(Link link)
  {
    bufferTimerToCharge = 1f;
    currentBufferTime = 0;
    link.isBufferingCharge = true;
  }

  public override BaseState Update(Link link, Orientation currentOrientation)
  {

    base.Update(link, currentOrientation);

    link.velocity = Vector2.zero;



    if (Input.GetButtonUp("Charge"))
    {
      link.isBufferingCharge = false;
      return new DefaultState();
    }


    if (Input.GetButton("Charge"))
    {
      currentBufferTime += Time.deltaTime;

      if (currentBufferTime >= bufferTimerToCharge)
      {
        link.isBufferingCharge = false;
        return new ChargeState();
      }



    }





    return this;
}
  
}
