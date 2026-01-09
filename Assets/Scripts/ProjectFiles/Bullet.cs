using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class Bullet : MonoBehaviour
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

  private void Update()
  {
    transform.position = moveable.Move(Vector2.right);
    if (screenBounds.IsOut(transform.position))
    {
      Destroy(this.gameObject);
    }
  }

  private void OnTriggerEnter2D(Collider2D col)
  {
    // 衝突する相手のレイヤー名を取得
    var layerName = LayerMask.LayerToName(col.gameObject.layer);
    // 敵か障害物に衝突したら消える
    if (layerName == "Enemy" || layerName == "Block")
    {
      Destroy(this.gameObject);
    }   
  }
}