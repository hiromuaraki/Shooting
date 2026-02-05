using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

[CreateAssetMenu(menuName = "Data/Bullet")]
public class BulletData : ScriptableObject
{
  [SerializeField] private int damage;
  [SerializeField] private float speed;
  [SerializeField] private float lifeTime;
  [SerializeField] private GameObject prefab;
}