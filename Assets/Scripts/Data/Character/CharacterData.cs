using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

[CreateAssetMenu(menuName = "Data/Character/Base")]
public abstract class CharacterData : ScriptableObject
{
  [Header("Status")]
  [SerializeField] private int maxHp;
  [SerializeField] private float moveSpeed;

  [Header("Combat")]
  [SerializeField] private int damage;
  [SerializeField] private float attackInterval;
  [SerializeField] private BulletData bullet;

  [Header("View")]
  [SerializeField] private GameObject prefab;

  // マスタデータ（不変）として扱うためgetter経由で読み取りのみ可能
  public int MaxHp => maxHp;
  public float MoveSpeed => moveSpeed;
  public float AttackInterval => attackInterval;
  public BulletData Bullet => bullet;
  public GameObject Prefab => prefab;
}