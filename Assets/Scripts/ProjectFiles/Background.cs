using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class Background : MonoBehaviour
{
  // スクロールのスピード
  public float ScrollSpeed;

  // 背景を配置する間隔
  public float bgInterval;

  private void Start()
  {
    
  }

  private void Update()
  {
    // 左に少しずつ移動させる
    var nextPos = transform.position.x - (ScrollSpeed * Time.deltaTime);
    transform.position = new Vector2(nextPos, 0);

    // 画面外の左側まできたら右側に移動させる
    if (transform.position.x <= -bgInterval)
    {
      transform.position = new Vector2(bgInterval, 0);
    }
  }


}
