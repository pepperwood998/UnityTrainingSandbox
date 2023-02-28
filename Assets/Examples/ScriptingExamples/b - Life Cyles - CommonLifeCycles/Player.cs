using UnityEngine;

public class Player : MonoBehaviour
{
  public float damage;
  public float health;
  Enemy enemy;

  void Awake()
  {
    damage = 10;
    health = 100;

    enemy = FindObjectOfType<Enemy>();
    Debug.Log("Enemy co damage = " + enemy.damage);
  }

  void Start()
  {

  }
}
