using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
  public float Speed;       // ˆÚ“®‘¬“x
  
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // Cube‚ðˆÚ“®
    transform.position += Vector3.back * Speed * Time.deltaTime;
  }
}
