using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class ScreenBounds : MonoBehaviour
{
  [SerializeField] private Vector2 min;
  [SerializeField] private Vector2 max;

  // 画面外判定
  public bool IsOut(Vector3 pos)
  {
    return pos.x < min.x || pos.x > max.x || pos.y < min.y || pos.y > max.y;
  }
}