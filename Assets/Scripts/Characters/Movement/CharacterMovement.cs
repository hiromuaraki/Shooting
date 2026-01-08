using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class CharacterMovement : MonoBehaviour
{  
  // 移動処理
  public Vector3 CalculateMove(Vector2 direction, float speed)
  {
    return transform.position + (Vector3)(direction * speed * Time.deltaTime);
  }
}
