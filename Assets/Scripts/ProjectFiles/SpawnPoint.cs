using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class SpawnPoint : MonoBehaviour
{
  // 弾のプレハブを呼び出す
  public GameObject BulletPrefab;
  private InputHandler handler;

  private void Awake()
  {
    handler = GetComponent<InputHandler>();
  }
  private void Start()
  {
    
  }

  private void Update()
  {
    // スペースキーが押されたらBullet（弾）のプレハブが出現する
    if (handler.GetInputBullet())
    {
      Instantiate(BulletPrefab, transform.position, Quaternion.identity);
    }
  }
}
