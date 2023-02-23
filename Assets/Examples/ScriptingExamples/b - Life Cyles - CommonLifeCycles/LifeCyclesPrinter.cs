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
    /// V� d? ?? in ra 3 l?n th�i,
    /// in nhi?u nh�n kinh l?m :))
    if (updateCallCount < 3)
    {
      Debug.Log(name + " called Update");
      updateCallCount++;
    }
  }
}
