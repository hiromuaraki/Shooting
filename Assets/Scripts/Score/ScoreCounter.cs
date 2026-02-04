using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class ScoreCounter : MonoBehaviour
{
    private int score;
    [SerializeField] private int enemyDamage;
    [SerializeField] private int bossDamage;
    Text textComponent;

    private void Start()
  {
    // テキスト部分に「Score 点数」と表示する。点数の部分は可変
    this.textComponent = GameObject.Find("Text").GetComponent<Text>();
    this.textComponent.text = "Score " + this.score.ToString();
  }

  // ザコ敵を倒したら100点
  public void AddScoreEnemy()
  {
    this.score += this.enemyDamage;
    this.textComponent.text = "Score " + this.score.ToString();
  }

  // ボスを倒したら5000点
  public void AddScoreBoss()
  {
    this.score += bossDamage;
    this.textComponent.text = "Score " + this.score.ToString();
  }
}
