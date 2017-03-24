using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Controller2D))]
public class Link : Framework
{

  public Vector2 velocity;

  public Vector2 directionalInput;
  public Controller2D controller;
  public int moveSpeed = 95;

  public Orientation currentOrientation;
  private Orientation startingOrientation = Orientation.Down;

  public bool isOrientedDown;
  public bool isOrientedLeft;
  public bool isOrientedRight;
  public bool isOrientedUp;
  public BaseState state;
  public Animator anim;
  public SpriteRenderer renderer;
  private bool canFlip;
  public float attackDuration;
  public  bool isAttacking = false;
  public bool isBufferingCharge = false;

  protected override void OnStart()
  {
    currentOrientation = Orientation.Down;
    anim = GetComponent<Animator>();
    renderer = GetComponent<SpriteRenderer>();
    state = new DefaultState();


  }

  protected override void OnUpdate()
  {
    controller = GetComponent<Controller2D>();
    directionalInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    directionalInput.Normalize();


    state = state.Update(this, currentOrientation);
    print(state);

    AnimatorStuff();

  }

  private void LateUpdate()
  {
    if (velocity == Vector2.zero)
    {
      transform.position = new Vector3(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.y), transform.position.z);
    }
  }

 

  void AnimatorStuff()
  {

    //For Animator purposes only
    isOrientedRight = (currentOrientation == Orientation.Left || currentOrientation == Orientation.Right);
    isOrientedUp = currentOrientation == Orientation.Up;
    isOrientedDown = currentOrientation == Orientation.Down;


    anim.SetInteger("velocityX", (int)velocity.x);
    anim.SetInteger("velocityY", (int)velocity.y);

    anim.SetBool("isAttacking", isAttacking);
    anim.SetBool("isOrientedDown", isOrientedDown);
    anim.SetBool("isOrientedLeft", isOrientedLeft);
    anim.SetBool("isOrientedRight", isOrientedRight);
    anim.SetBool("isOrientedUp", isOrientedUp);
    anim.SetBool("isBufferingCharge", isBufferingCharge);

  }


}
