using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
  public float Speed;       // 移動速度
  public GameObject Effect; // 爆破エフェクト
  public AudioClip BangSe;  // 爆破時の効果音

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // Cubeを移動
    transform.position += Vector3.back * Speed * Time.deltaTime;

    // プレイヤーの後にいったら回転カメラをON
    if (transform.position.z < -2f)
    {
      GameObject.Find("Main Camera").GetComponent<CameraController>().rotate = true;
    }

    // 最後に爆発して消去
    if (transform.position.z < -8f)
    {
      // 爆破エフェクト
      Instantiate(Effect, transform.position, Quaternion.identity);
      // 効果音
      AudioSource.PlayClipAtPoint(BangSe, transform.position);
      // Cubeを消去
      Destroy(gameObject);
      // ゲームクリア
      GameObject.Find("GameMain").GetComponent<GameController>().mode = MODE.GAMECLEAR;
    }
  }
}
