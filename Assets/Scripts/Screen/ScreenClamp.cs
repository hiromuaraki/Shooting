using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class ScreenClamp : MonoBehaviour
{
  // Unity Inspectorから調整可能
  [SerializeField] private Vector2 min;
  [SerializeField] private Vector2 max;

  public Vector3 Clamp(Vector3 pos)
  {
    //キャラクターの位置が画面内に収まるように制限 
    pos.x = Mathf.Clamp(pos.x, min.x, max.x);
    pos.y = Mathf.Clamp(pos.y, min.y, max.y);
    return pos;
  }
  
}