using UnityEngine;

public class LifeCyclesPrinter : MonoBehaviour
{
  void Awake()
  {
    Debug.Log(name + " called Awake");
  }

  void Start()
  {
    Debug.Log(name + " called Start");
  }

  int updateCallCount = 0;
  void Update()
  {
    /// Ví d? ?? in ra 3 l?n thôi,
    /// in nhi?u nhìn kinh l?m :))
    if (updateCallCount < 3)
    {
      Debug.Log(name + " called Update");
      updateCallCount++;
    }
  }
}
