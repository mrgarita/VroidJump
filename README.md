# VroidJump (2/3)
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

## Playerにコンポーネント追加
- Rigidbodyを追加し、Constraintsの**Freeze Rotation項目X,Y,Zを全てチェック**（Cubetとぶつかったとき転ばないようにするため）
- Capsule Collider（イメージのモデルでは**Center Y** 0.8、**Height**に1.6を設定、**Radius**は0.3、3Dモデルに合わせて調整してください）
- Audio Listener（Main Cameraに最初からついていたAudio Listenerはこの時点で外しておく）

## Playerのアニメーションを改良する
- 作成済みの**PlayerAnimation**（Animator Controller）をダブルクリックして開く
- Parametersに**jump, damage, win**の3つのパラメタを追加

<img width="211" alt="vroid_jump2_parameter" src="https://user-images.githubusercontent.com/32384416/140259445-9596ee8b-1ce5-45ca-99d2-6526f706226c.PNG">

- エンティティ **Jump, Damage, Win, Lose, WinPose**を追加し遷移を以下のように設定

<img width="599" alt="vroid_jump2_entity" src="https://user-images.githubusercontent.com/32384416/140259607-b3e57e6d-4d68-4e47-8612-80f2f186f539.PNG">

### Run
- Motion: RUN00_F（設定済）
- **Run -> Damage**: Conditions **damage**が**true**
- **Run -> Jump**: Conditions **jump**が**true**
- **Run -> Win**: Conditions **win**が**true**
- Run -> Winのみ、Has Exit Timeにチェックする

### Jump
- Motion: JUMP00
- **Jump -> Run**: Conditions **jump**が**false**
- **Jump -> Damage**: Conditions **damage**が**true**
- Has Exit Timeは全てチェックを外す

### Damage
- Motion: DAMAGED01
- **Damage -> Lose**: Has Exit Timeにチェック

### Win
- Motion: WIN00
- **Win -> WinPose**: Has Exit Timeにチェック

### Lose
- Motion: LOSE00

### WinPose
- Motion: POSE23（決めポーズとなるため何でも好きなものを設定）

## Player用スクリプトを作成
- [PlayerController](https://github.com/mrgarita/VroidJump/blob/player_controller/PlayerController.cs)を作成しシーン上の**Player**にアタッチ
- アタッチ後、Inspectorの**Jump Power、Jump Se、Damage Se**をそれぞれ設定
- *Jump Power*は**5.5**くらいが適当
- *Jump Se*はジャンプした時の効果音（AudioClip）を設定（サンプルではRetro Games Sound FXの**Jump1**を使用）
- *Damage Se*はCubeとPlayerがぶつかった時の効果音（AudioClip）を設定（サンプルではRetro Games Sound FXの**Hit7**を使用）

## Planeの改良
- Playerの接地判定のためPlaneの*tag*を**Ground**とする

## Cubeの改良
- Playerとの当たり判定用に*tag*を**Cube**とする

## ここまでのイメージ
### Cubeにぶつかった時
![vroidjump2-1](https://user-images.githubusercontent.com/32384416/140261358-93171bfe-5f42-4306-bf8c-89de01dfccdd.gif)

### Cubeうまくジャンプした時
![vroidjump2-2](https://user-images.githubusercontent.com/32384416/140261373-62c36f95-ed5b-4539-8d25-ca86ade56b28.gif)

[次のステップ＞＞ VroidJump (3/3)](https://github.com/mrgarita/VroidJump/tree/game_controller)
