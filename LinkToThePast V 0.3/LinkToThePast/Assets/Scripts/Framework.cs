using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Framework : MonoBehaviour {

  protected virtual void OnAwake() { }

  private void Awake()
  {
    OnAwake();
  }

	protected virtual void OnUpdate() { }

  private void Update()
  {
    OnUpdate();
  }

  protected virtual void OnStart() { }

  private void Start()
  {
    OnStart();
  }
	

}
