using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollectible : BaseCollectible {

  protected override void OnCollision(Collider2D collision)
  {
    linkStats.ModifyKeys(1);
    //PlaySound
  }
}
