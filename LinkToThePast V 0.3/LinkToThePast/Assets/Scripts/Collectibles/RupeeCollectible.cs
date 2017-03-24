using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RupeeCollectible : BaseCollectible
{

  public int value;


  protected override void OnCollision(Collider2D collision)
  {
    linkStats.ModifyRupees(value);
  }
}
