using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class Bullet : MonoBehaviour
{
  private Moveable moveable;
  private ScreenBounds screenBounds;

  private void Awake()
  {
    moveable = GetComponent<Moveable>();
    screenBounds = GetComponent<ScreenBounds>();
  }

  private void Start()
  {
    
  }

  private void Update()
  {
    transform.position = moveable.Move(Vector2.right);
    if (screenBounds.IsOut(transform.position))
    {
      Destroy(this.gameObject);
    }
  }
}