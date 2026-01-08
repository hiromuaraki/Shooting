using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class CharacterMovement : MonoBehaviour
{  
  // 移動処理
  public void Move(Vector2 moveDirection, float moveSpeed, bool isPlayer=false)
  {
    Vector3 pos = transform.position;
    // キャラクターの座標を取得し現在位置の更新
    pos += (Vector3)moveDirection * moveSpeed * Time.deltaTime;;
    //キャラクターの位置が画面内に収まるように制限
    if (isPlayer)
    {
      pos.x = Mathf.Clamp(pos.x, -8.4f, 8.4f);
      pos.y = Mathf.Clamp(pos.y, -4.5f, 4.5f);
    }

    // キャラクターの位置を更新
    transform.position = pos;
    
  }
}
