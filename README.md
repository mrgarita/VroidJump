# VroidJump (1/3)
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

## シーンの作成
### 画面イメージ
<img width="381" alt="vroid_jump1" src="https://user-images.githubusercontent.com/32384416/140244875-056f7931-959e-42f7-83aa-47d083b26fa8.PNG">

### Planeを配置
- Position X Y Z = 0, 0, 0
- Scale **X**と**Z**を**10**に
- Inspectorの**Materials項目**Element 0に**QS-GRASS-2.1**を設定（好きなマテリアルでよい）
- 設定したマテリアル**QS-GRASS-2.1**の**Tiling**項目の**X**と**Y**をそれぞれ**20**に設定（マテリアル画像が荒くならないようにするため）

### Cubeを配置
- Position X Y Z = 0, 4, 15
- Materialを適当に設定
- Rigidbodyコンポーネント追加

### 3Dモデルを配置
- 名前を**Player**とする
- Position X Y Z = 0, 0, 0

### 3DモデルにAnimator Controllerを設定
とりあえず開始したら走ってるアニメーションを設定する
- Animator Controllerを作成し、名前を**PlayerAnimation**とする

アニメーションの設定
- エンティティ**Run**を作成
- Motiionを**RUN00_F**とする（走っているアニメ）
<img width="456" alt="vroid_jump1_animator" src="https://user-images.githubusercontent.com/32384416/140253804-52589592-f0e2-407b-adec-aeb49e900776.PNG">

### SkyBoxは適当に設定
- 画面イメージでは[Fantasy Skybox FREE](https://assetstore.unity.com/packages/2d/textures-materials/sky/fantasy-skybox-free-18353?locale=ja-JP)を使った
 
### シーンにAudioSourceを追加
- 名前を**BGM**として**AudioClip**に**BGM_04**（起動時のBGM）を設定
- Play On Awakeにチェック

## Cubeを動かすスクリプト
- [CubeController](https://github.com/mrgarita/VroidJump/blob/master/CubeController.cs) を作成しCubeにアタッチ
- アタッチ後、Inspectorウインドウの**Speed**項目に移動速度（**4**くらいが適当）を設定

## ここまでのイメージ
![vroidjump1](https://user-images.githubusercontent.com/32384416/140249994-a59e0be0-590a-4b86-85ac-1327edb7893c.gif)

[次のステップ＞＞ VroidJump (2/3)](https://github.com/mrgarita/VroidJump/tree/player_controller)
