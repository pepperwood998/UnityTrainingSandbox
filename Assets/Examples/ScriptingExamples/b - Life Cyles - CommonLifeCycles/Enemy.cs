using UnityEngine;

public class Enemy : MonoBehaviour
{
  public float damage;
  public float health;
  Player player;

  void Awake()
  {
    damage = 15;
    health = 90;

    player = FindObjectOfType<Player>();
    Debug.Log("Player co damage = " + player.damage);
  }

  void Start()
  {
  }
}
