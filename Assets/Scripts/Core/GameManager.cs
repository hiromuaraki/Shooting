using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  public enum Wave
  {
    Block, // 1. 障害物ウェーブ
  }
  // Blockのプレハブを呼び出す
  public GameObject BlockPrefab;

  // 避ける障害物の数
  public int BlockNums;

  // 障害物の出現間隔
  public float BlockInterval;
  
  // ウェーブとウェーブの間の待ち時間
  public float WaveInterval;

  // 現在のウェーブ
  private Wave currentWave = Wave.Block;

  // 生成した数を数える
  [SerializeField] private int spawnCount = 0;

  // 出現時間を計算
  private float timeCount = 0.0f;
  
  // ゲーム起動中一回しか生成されないことを保証
  public static GameManager Instance { get; private set; }

  // 起動
  private void Awake()
  {
    if (Instance != null)
    {
      Destroy(gameObject);
      return;
    }
    Instance = this;
    DontDestroyOnLoad(gameObject);
  }

  // 状態更新
  private void Update()
  {
    switch (this.currentWave)
    {
      case Wave.Block: // 障害物
        UpdateBlockWave();
        break;
    }
  }

  private void UpdateBlockWave()
  {
    // ゲーム内の経過時間を更新していく
    this.timeCount += Time.deltaTime;

    // 出現数分作成が終わっているとき
    if (this.spawnCount >= BlockNums)
    {
      // ウェーブ待機時間を過ぎたら次のウェーブに進む
      if (this.timeCount >= WaveInterval)
      {
        // ここから次のウェーブへ移行するスクリプトを追記
      }
    }
    else
    {
      // 出現間隔時間を超えたら障害物を作る
      if (this.timeCount >= BlockInterval)
      {
        // 障害物生成
        // ゲーム画面の右の外側から出現させる設定
        Instantiate(BlockPrefab, new Vector3(10.0f, 0f, 0), Quaternion.identity);
        // 出現した数に +1
        this.spawnCount++;
        // 時間カウントを0にリセット
        this.timeCount = 0;
      }
    }
  }
}