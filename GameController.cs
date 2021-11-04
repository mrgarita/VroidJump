using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// ゲームモード設定
public enum MODE
{
  GAME,
  GAMEOVER,
  GAMECLEAR,
  HAPPYEND
}

public class GameController : MonoBehaviour
{
  public MODE mode;

  // ゲームクリア時のBGM切り替え
  void ChangeBgm()
  {
    GameObject.Find("BGM").GetComponent<AudioSource>().enabled = false;
    GameObject.Find("ClearBGM").GetComponent<AudioSource>().enabled = true;

  }

  // コンティニュー処理（シーン再読み込み）
  void Continue()
  {
    SceneManager.LoadScene("GameScene");
  }

  // Start is called before the first frame update
  void Start()
  {
    mode = MODE.GAME; // ゲーム中
  }

  // Update is called once per frame
  void Update()
  {
    if (mode == MODE.GAMECLEAR)  // ゲームクリア時
    {
      ChangeBgm();  // BGM変更
      mode = MODE.HAPPYEND; // 終了時のアニメーションに移動
    }
    else if (mode == MODE.GAMEOVER)  // ゲームオーバー時
    {
      Invoke("Continue", 8);  // 8秒後にシーン再読み込み
    }

    // ゲームクリア後は、Enterキーでリプレイ
    if (mode == MODE.HAPPYEND && Input.GetKeyDown(KeyCode.Return))
    {
      Continue();
    }
  }
}
