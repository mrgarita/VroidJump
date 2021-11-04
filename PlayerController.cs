using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  Animator animator;      // Animatorコンポーネント取得用
  bool isJump;            // ジャンプ中か？
  public float JumpPower;   // ジャンプ力
  public AudioClip JumpSe;  // ジャンプ時の効果音
  public AudioClip DamageSe;  // Cubeにぶつかった時の効果音

  // Start is called before the first frame update
  void Start()
  {
    isJump = false;
    animator = gameObject.GetComponent<Animator>(); // Animatorコンポーネント取得
    animator.SetBool("damage", false);
    animator.SetBool("jump", false);
  }

  // Update is called once per frame
  void Update()
  {
    // 左マウスボタンクリック（ジャンプ中でないとき）
    if (Input.GetMouseButtonDown(0) && !isJump)
    {
      isJump = true;

      // ジャンプさせる
      Vector3 force = Vector3.up * JumpPower;
      gameObject.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);

      animator.SetBool("jump", true); // ジャンプ中のアニメに変更
      AudioSource.PlayClipAtPoint(JumpSe, transform.position);  // ジャンプ時の効果音再生
    }

    // ゲーム終了時のアニメーション
    if (GameObject.Find("GameMain").GetComponent<GameController>().mode == MODE.HAPPYEND)
    {
      animator.SetBool("win", true);
    }

  }

  private void OnCollisionEnter(Collision col)
  {
    // プレイヤーがCubeと衝突したら
    if (col.gameObject.tag == "Cube")
    {
      // 回転カメラON
      GameObject.Find("Main Camera").GetComponent<CameraController>().rotate = true;

      // Cubeの移動を停止
      col.gameObject.GetComponent<CubeController>().Speed = 0f;

      // 衝突時のアニメーションと効果音
      animator.SetBool("damage", true);
      AudioSource.PlayClipAtPoint(DamageSe, transform.position);

      // ゲームオーバー
      GameObject.Find("GameMain").GetComponent<GameController>().mode = MODE.GAMEOVER;
    }

    // 地面（Plane）と接地したか？
    if (col.gameObject.tag == "Ground")
    {
      // ジャンプ中の状態を解除
      isJump = false;
      animator.SetBool("jump", false);
    }
  }
}
