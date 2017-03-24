using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPacksCollectible : BaseCollectible {

  public int value;

  protected override void OnCollision(Collider2D collision)
  {
    linkStats.ModifyArrows(value);
    //PlaySound
  }
}
