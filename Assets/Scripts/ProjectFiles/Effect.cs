using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class Effect : MonoBehaviour
{
    private void OnAnimationFinish()
  {
    // アニメーションが終了したらエフェクトを消す
    Destroy(this.gameObject);
  }
}
