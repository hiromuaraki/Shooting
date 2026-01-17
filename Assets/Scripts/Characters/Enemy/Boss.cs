using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class Boss : MonoBehaviour
{
    // UnityのInspectorから設定
    [SerializeField] private int hp;

    private void Start()
  {
    
  }

  private void Update()
  {
    
  }

  private void OnTriggerEnter2D(Collider2D col)
  {
    // 衝突相手のレイヤー名を取得
    var layerName = LayerMask.LayerToName(col.gameObject.layer);
    // ボスのHPを1ずつ減らす
    if (layerName == "Bullet") this.hp--;
    
    // HPがボスを消す
    if (this.hp  == 0)
    {
      Destroy(this.gameObject);
    }
  }
}
