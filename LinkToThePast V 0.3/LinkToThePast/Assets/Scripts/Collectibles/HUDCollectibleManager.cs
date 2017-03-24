using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDCollectibleManager : MonoBehaviour
{

  public Sprite[] numberSprites;

  public SpriteRenderer hundredsRupee;
  public SpriteRenderer tenthsRupee;
  public SpriteRenderer unitRupee;
  public SpriteRenderer tenthsBomb;
  public SpriteRenderer UnitBomb;
  public SpriteRenderer tenthsArrow;
  public SpriteRenderer UnitArrow;
  public SpriteRenderer keys;

  public LinkStats linkStats;

  // Use this for initialization
  void Start ()
  {
    linkStats = GameObject.FindGameObjectWithTag("Player").GetComponent<LinkStats>();
  }
	
	// Update is called once per frame
	void Update ()
  {
		
	}

  public void RecalculateRupees()
  {
    hundredsRupee.sprite = numberSprites[Mathf.FloorToInt(linkStats.currentRupees/100)];
    tenthsRupee.sprite = numberSprites[Mathf.FloorToInt((linkStats.currentRupees%100)/10)];
    unitRupee.sprite = numberSprites[Mathf.FloorToInt((linkStats.currentRupees%100)%10)];
  }

  public void RecalculateBombs()
  {
    tenthsBomb.sprite = numberSprites[(Mathf.FloorToInt(linkStats.currentBombs/10))];
    UnitBomb.sprite = numberSprites[(Mathf.FloorToInt(linkStats.currentBombs%10))];
  }

  public void RecalculateArrows()
  {
    tenthsArrow.sprite = numberSprites[(Mathf.FloorToInt(linkStats.currentArrows / 10))];
    UnitArrow.sprite = numberSprites[(Mathf.FloorToInt(linkStats.currentArrows % 10))];
  }

  public void RecalculateKeys()
  {
    keys.sprite = numberSprites[linkStats.currentKeys];
  }
}
