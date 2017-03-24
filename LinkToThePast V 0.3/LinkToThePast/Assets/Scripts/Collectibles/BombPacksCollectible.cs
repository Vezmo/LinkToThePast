using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPacksCollectible : BaseCollectible
{

  public int value;

  protected override void OnCollision(Collider2D collision)
  {
    linkStats.ModifyBombs(value);
    //PlaySound
  }
}
