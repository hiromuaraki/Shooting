using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class Boss : MonoBehaviour
{
  
  public GameObject Effect;
  // UnityのInspectorから設定
  [SerializeField] private int hp;

  public enum ActionPattern
  {
    Appear, // 出現
    Wait,   // 待機
  }

  // 現在の行動パターン
  private ActionPattern currentAction;
  
  private Moveable moveable;

  private void Awake()
  {
    moveable = GetComponent<Moveable>();
  }

  private void Start()
  {
    
  }

  private void Update()
  {
    switch (this.currentAction)
    {
      case ActionPattern.Appear:
        UpdateAppearAction();
        break;
      case ActionPattern.Wait:
        break;
    }
  }

  private void OnTriggerEnter2D(Collider2D col)
  {
    // ボス出現中は当たり判定をしない
    if (this.currentAction == ActionPattern.Appear)
    {
      return;
    }
    
    // 衝突相手のレイヤー名を取得
    var layerName = LayerMask.LayerToName(col.gameObject.layer);
    // ボスのHPを1ずつ減らす
    if (layerName == "Bullet")
    {
      this.hp--;
      Instantiate(Effect, transform.position, Quaternion.identity);
    }
    
    // HPが０になったらがボスを消す
    if (this.hp  == 0)
    {
      Destroy(this.gameObject);
      // 条件が達成されたらテキストにアタッチされているスクリプトへ点数加算が実行される。
      GameObject.Find("Text").GetComponent<ScoreCounter>().AddScoreBoss();
    }
  }

  private void UpdateAppearAction()
  {
    transform.position = moveable.Move(Vector2.left);
    // 指定の位置まで移動したら待機パターンに切り替え
    if (transform.position.x <= 7f)
    {
      this.currentAction = ActionPattern.Wait;
    }
  }
}
