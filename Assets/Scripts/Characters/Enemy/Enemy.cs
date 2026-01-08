using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class Enemy : MonoBehaviour
{
  private float MoveSpeed { get; set; }
  private CharacterMovement movement;
  private void Awake()
  {
    var gm = GameManager.Instance;
    movement = GetComponent<CharacterMovement>();
  }

  // 他オブジェクトの初期化が終わった後の処理
  void Start()
  {
    
  }

  // 状態更新
  void Update()
  {
    // ザコ敵の移動
    MoveSpeed = 2f;
    movement.Move(Vector2.left, MoveSpeed);

    // 画面の外まで進んだら消す
    if (transform.position.x <= -10.0f)
    {
      Destroy(this.gameObject);
    }
  }
}
