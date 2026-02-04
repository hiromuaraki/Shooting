using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class PlayerController : MonoBehaviour
{
  public GameObject Effect;
  private Moveable moveable;
  private InputHandler handler;
  private ScreenClamp screenClamp;
  
  // 起動(Unityがライフサイクルで自動で1回だけ呼ぶメソッド)
  private void Awake()
  {
    var gm = GameManager.Instance;
    moveable = GetComponent<Moveable>();
    handler = GetComponent<InputHandler>();
    screenClamp = GetComponent<ScreenClamp>();
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
    // 2次元の位置（縦・横）を設定
    Vector2 input = handler.GetInput();
    // キャラクターの位置を更新
    Vector3 pos = moveable.Move(input);
    transform.position = screenClamp.Clamp(pos);
  }

  // 衝突判定
  private void OnTriggerEnter2D(Collider2D col)
  {
    var layerName = LayerMask.LayerToName(col.gameObject.layer);

    // Enemyというレイヤー名のオブジェクトと衝突したら消える
    if (layerName == "Enemy")
    {
      Destroy(this.gameObject);
      Instantiate(Effect, transform.position, Quaternion.identity);
    }
  }
}
