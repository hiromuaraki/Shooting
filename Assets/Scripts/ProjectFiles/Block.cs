using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class Block : MonoBehaviour
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

  // 状態更新
  private void Update()
  {
    // 障害物の移動
    transform.position = moveable.Move(Vector2.left);
    // 画面の外に出たら消える
    if (screenBounds.IsOut(transform.position))
    {
      Destroy(this.gameObject);
    }
  }
}
