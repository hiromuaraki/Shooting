using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class Moveable : MonoBehaviour
{  
  [SerializeField] private float speed;
  
  // 移動処理
  public Vector3 Move(Vector2 direction)
  {
    return transform.position + (Vector3)(direction * speed * Time.deltaTime);
  }
}
