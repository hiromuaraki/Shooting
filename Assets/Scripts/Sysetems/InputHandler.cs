using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
  void Start()
  {
    
  }

  void Update()
  {
    
  }
  // 上下左右の矢印キーを受け取る
  public Vector2 GetInput()
  {
    return new Vector2(
      Input.GetAxisRaw("Horizontal"),
      Input.GetAxisRaw("Vertical")
    ).normalized;
  }
}