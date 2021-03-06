﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
public class RaycastController : MonoBehaviour {

  public LayerMask collisionMask;

  public int horizontalRayCount = 8;
  public int verticalRayCount = 8;

  public const float skinWidth = 0.015f;
  [HideInInspector]
  public float horizontalRaySpacing;
  [HideInInspector]
  public float verticalRaySpacing;

  public BoxCollider2D collider;
  public RayCastOrigins raycastOrigins;

  public virtual void Start()
  {
    collider = GetComponent<BoxCollider2D>();
    CalculateRaySpacing();

  }

  public void UpdateRaycastOrigins()
  {

    Bounds bounds = collider.bounds;
    bounds.Expand(skinWidth * -2);

    raycastOrigins.bottomLeft = new Vector2(bounds.min.x, bounds.min.y);
    raycastOrigins.bottomRight = new Vector2(bounds.max.x, bounds.min.y);
    raycastOrigins.topLeft = new Vector2(bounds.min.x, bounds.max.y);
    raycastOrigins.topRight = new Vector2(bounds.max.x, bounds.max.y);

  }

  public void CalculateRaySpacing()
  {
    Bounds bounds = collider.bounds;
    bounds.Expand(skinWidth * -2);

    horizontalRayCount = Mathf.Clamp(horizontalRayCount, 2, int.MaxValue);
    verticalRayCount = Mathf.Clamp(verticalRayCount, 2, int.MaxValue);

    horizontalRaySpacing = bounds.size.y / (horizontalRayCount - 1);
    verticalRaySpacing = bounds.size.x / (verticalRayCount - 1);
  }
  public struct RayCastOrigins
  {
    public Vector2 topRight, topLeft;
    public Vector2 bottomRight, bottomLeft;
  }
}
