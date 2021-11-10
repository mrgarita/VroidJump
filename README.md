# VroidJump (3/3)
Vroidモデルを使ったジャンプゲーム

## 完成した際のイメージです
- 画像クリックでYouTube動画で確認できます

[![ゲームイメージ](https://img.youtube.com/vi/KiAOWw25O24/0.jpg)](https://www.youtube.com/watch?v=KiAOWw25O24)

## 使っているアセット（全てFree）
- [Fantasy Skybox](https://assetstore.unity.com/packages/2d/textures-materials/sky/fantasy-skybox-free-18353?locale=ja-JP)（スカイボックス）
- [Nature Materials vol.1](https://assetstore.unity.com/packages/2d/textures-materials/nature/nature-materials-vol-1-21113)（床のマテリアル）
- [Fx Explosion Pack](https://assetstore.unity.com/packages/vfx/particles/fire-explosions/fx-explosion-pack-30102)（爆破エフェクト）
- [Unity-chan! Model](https://assetstore.unity.com/packages/3d/characters/unity-chan-model-18705)（モデルのアニメとポーズ）
- [Retro Games Sound FX](https://assetstore.unity.com/packages/audio/sound-fx/retro-games-sound-fx-27280)（効果音）
- [Casual Game BGM #5](https://assetstore.unity.com/packages/audio/music/casual-game-bgm-5-135943)（BGM）

## ゲームクリア時のBGMをシーンに配置しておく
- シーンにAudioSourceを追加し、名前を**ClearBGM**とする
- ClearBGMの**AudioClip**に**BGM_01**（ゲームクリア時の曲）を設定（Play On Awakeにチェック）
- ClearBGMの**Audio Sourceコンポーネントのチェックは外しておく**（シーン起動時に鳴らないようにするため）

## Game全体の処理用
- シーンにCreate Emptyで空のオブジェクト追加
- 名前を**GameMain**とする

## Game全体のスクリプト
- スクリプト[GameController](https://github.com/mrgarita/VroidJump/blob/game_controller/GameController.cs)を作成し、GameMainにアタッチ

## ゲームクリアとゲームオーバー時のプレイヤーを中心に回転するカメラ
- スクリプト[CameraController](https://github.com/mrgarita/VroidJump/blob/game_controller/CameraController.cs)を作成し、**Main Camera**にアタッチ
- アタッチ後、Inspectorウインドウの**Target**を**Player**とし、**Distance**に**3**に設定

## Cubeの改良
- ゲームクリア時にCubeを爆破させて消すためスクリプト[CubeController](https://github.com/mrgarita/VroidJump/blob/game_controller/CubeController.cs)を修正
- Inspectorの**Effect**（爆破エフェクト）に**Explosion6**、**Bang Se**（爆破音）に**Shoot08**を設定（お好みでなんでも良い）

## Playerの改良
- ゲームオーバーとゲームクリア処理に対応させるため、[PlayerController](https://github.com/mrgarita/VroidJump/blob/game_controller/PlayerController.cs)スクリプト修正

以上で冒頭の完成した際のイメージになるはずです。
