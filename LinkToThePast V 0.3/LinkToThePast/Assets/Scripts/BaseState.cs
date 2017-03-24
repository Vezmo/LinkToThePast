using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseState
{

  public abstract BaseState Update(Link link, Orientation current);


  

}
