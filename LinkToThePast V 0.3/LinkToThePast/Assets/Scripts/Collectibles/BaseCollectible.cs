using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseCollectible : MonoBehaviour {

  public LinkStats linkStats;

  protected abstract void OnCollision(Collider2D collision);

  private void OnTriggerEnter2D(Collider2D collision)
  {

    if (collision.tag == "Player")
    {
      linkStats = GameObject.FindGameObjectWithTag("Player").GetComponent<LinkStats>();
      OnCollision(collision);
      Destroy(gameObject);

    }

  }
}
