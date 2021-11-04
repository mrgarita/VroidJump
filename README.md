# VroidJump 2
Vroidモデルを使ったジャンプゲーム

## 完成イメージです
- 画像クリックでYouTube動画で確認できます

[![ゲームイメージ](https://img.youtube.com/vi/KiAOWw25O24/0.jpg)](https://www.youtube.com/watch?v=KiAOWw25O24)

## 使っているアセット（全てFree）
- [Fantasy Skybox](https://assetstore.unity.com/packages/2d/textures-materials/sky/fantasy-skybox-free-18353?locale=ja-JP)（スカイボックス）
- [Nature Materials vol.1](https://assetstore.unity.com/packages/2d/textures-materials/nature/nature-materials-vol-1-21113)（床のマテリアル）
- [Fx Explosion Pack](https://assetstore.unity.com/packages/vfx/particles/fire-explosions/fx-explosion-pack-30102)（爆破エフェクト）
- [Unity-chan! Model](https://assetstore.unity.com/packages/3d/characters/unity-chan-model-18705)（モデルのアニメとポーズ）
- [Retro Games Sound FX](https://assetstore.unity.com/packages/audio/sound-fx/retro-games-sound-fx-27280)（効果音）
- [Casual Game BGM #5](https://assetstore.unity.com/packages/audio/music/casual-game-bgm-5-135943)（BGM）

## Playerにコンポーネント追加
- Rigidbody
- Capsule Collider（イメージのモデルではCenter Y 0.8、Heightに1.6を設定、Radiusは0.3、3Dモデルに合わせて調整してください）
- Audio Listener（Main Cameraに最初からついていたAudio Listenerはこの時点で外す）

## Playerのアニメーションを作成
- Animator Controllerを作成し、PlayerAnimationとする
- Parametersに追加 jump, damage, winを追加


## Player用スクリプトを作成
- [PlayerController]()を作成しシーン上の**Player**にアタッチ
- アタッチ後、InspectorのJump Power、Jump Se、Damage Seをそれぞれ設定
- Jump Powerは5.5くらい
- Jump Seはジャンプした時の効果音（AudioClip）を設定
- Damage SeはCubeとPlayerがぶつかった時の効果音（AudioClip）を設定

## Cubeの改良
- Playerとの当たり判定用に**tag**を**Cube**とする


## ここまでのイメージ
![vroidjump1](https://user-images.githubusercontent.com/32384416/140249994-a59e0be0-590a-4b86-85ac-1327edb7893c.gif)
