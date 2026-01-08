using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class PlayerController : MonoBehaviour
{

  private float MoveSpeed { get; set; }
  private bool IsPlayer { get; set; }
  private CharacterMovement movement;
  private InputHandler handler;
  private ScreenClamp screenClamp;
  
  // 起動(Unityがライフサイクルで自動で1回だけ呼ぶメソッド)
  private void Awake()
  {
    var gm = GameManager.Instance;
    movement = GetComponent<CharacterMovement>();
    handler = GetComponent<InputHandler>();
    screenClamp = GetComponent<ScreenClamp>();

    this.MoveSpeed = 4f;
    this.IsPlayer = true;
  }

  // 他オブジェクトの初期化が終わった後の処理
  private void Start()
  {
    
  }
  // 状態更新
  // 毎フレームゲーム内の状態を更新
  // そのため毎フレーム呼ばれる
  private void Update()
  {
    Debug.Log($"Update呼ばれた TimeFrameCount={Time.frameCount}");
    // 2次元の位置（縦・横）を設定
    Vector2 input = handler.GetInput();
    movement.Move(input, MoveSpeed, IsPlayer);
  }

  private void OnTriggerEnter2D(Collider2D col)
  {
    var layerName = LayerMask.LayerToName(col.gameObject.layer);

    // Enemyというレイヤー名のオブジェクトと衝突したら消える
    if (layerName == "Enemy")
    {
      Destroy(this.gameObject);
    }
  }
}
