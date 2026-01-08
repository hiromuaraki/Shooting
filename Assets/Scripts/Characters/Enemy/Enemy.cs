using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class Enemy : MonoBehaviour
{
  private Moveable moveable;
  private ScreenBounds screenBounds;
  private void Awake()
  {
    var gm = GameManager.Instance;
    moveable = GetComponent<Moveable>();
    screenBounds = GetComponent<ScreenBounds>();
  }

  // 他オブジェクトの初期化が終わった後の処理
  private void Start()
  {
    
  }

  // 状態更新
  private void Update()
  {
    // ザコ敵の移動
    transform.position = moveable.Move(Vector2.left);
    
    // 画面の外まで進んだら消す
    if (screenBounds.IsOut(transform.position))
    {
      Destroy(this.gameObject);
    }
  }
}
