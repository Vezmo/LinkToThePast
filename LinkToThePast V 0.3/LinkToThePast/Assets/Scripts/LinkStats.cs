using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkStats : MonoBehaviour {

  private int startingRupees = 0;
  public int currentRupees;

  private int startingBombs = 0;
  public int currentBombs;

  private int startingArrows = 0;
  public int currentArrows;

  private int startingKeys = 0;
  public int currentKeys;

  public HUDCollectibleManager HUD;
  // Use this for initialization
  void Start () {

    currentRupees = startingRupees;
    currentBombs = startingBombs;
    currentArrows = startingArrows;
    currentKeys = startingKeys;

  }
	
	// Update is called once per frame
	void Update () {
		
	}

  public void ModifyRupees(int value)
  {
    currentRupees += value;
    HUD.RecalculateRupees();
  }
  public void ModifyBombs(int value)
  {
    currentBombs += value;
    HUD.RecalculateBombs();
  }
  public void ModifyArrows(int value)
  {
    currentArrows += value;
    HUD.RecalculateArrows();
  }

  public void ModifyKeys(int value)
  {
    currentKeys += value;
    HUD.RecalculateKeys();
  }
}
