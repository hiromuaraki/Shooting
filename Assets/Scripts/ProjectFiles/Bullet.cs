using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;

public class Bullet : MonoBehaviour
{
  private float MoveSpeed { get; set; }
  private CharacterMovement movement;

  private void Awake()
  {
    this.MoveSpeed = 10f;
    movement = GetComponent<CharacterMovement>();
  }

  private void Start()
  {
    
  }

  private void Update()
  {
    transform.position = movement.CalculateMove(Vector2.right, this.MoveSpeed);
    if (transform.position.x >= 10.0f)
    {
      Destroy(this.gameObject);
    }
  }
}