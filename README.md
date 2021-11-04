# VroidJump 1
Vroidモデルを使ったジャンプゲーム

## 完成イメージです
- 画像クリックでYouTube動画で確認できます

[![ゲームイメージ](https://img.youtube.com/vi/KiAOWw25O24/0.jpg)](https://www.youtube.com/watch?v=KiAOWw25O24)
## 使っているアセット

## シーンの作成
### 画面イメージ
<img width="381" alt="vroid_jump1" src="https://user-images.githubusercontent.com/32384416/140244875-056f7931-959e-42f7-83aa-47d083b26fa8.PNG">

### Plane
- Position X Y Z = 0, 0, 0
- Scale XとZを10に
- Materialを適当に設定

### Cubeの配置
- Position X Y Z = 0, 4, 15
- Materialを適当に設定

### 3Dモデルを配置
- 名前を**Player**とする
- Position X Y Z = 0, 0, 0
### 3DモデルにAnimator Controllerを設定
- エンティティRunを作成
- MotiionをRUN00_Fとする
<img width="456" alt="vroid_jump1_animator" src="https://user-images.githubusercontent.com/32384416/140253804-52589592-f0e2-407b-adec-aeb49e900776.PNG">

### SkyBoxは適当に設定
- 画面イメージでは[Fantasy Skybox FREE](https://assetstore.unity.com/packages/2d/textures-materials/sky/fantasy-skybox-free-18353?locale=ja-JP)を使った
 
### AudioSourceを作成
- 名前をBGMとしてBGM用のAudioClipを設定しておく
- Play On Awakeにチェック

## Cubeを動かすスクリプト
- [CubeController](https://github.com/mrgarita/VroidJump/blob/master/CubeController.cs) を作成しCubeにアタッチ

## ここまでのイメージ
![vroidjump1](https://user-images.githubusercontent.com/32384416/140249994-a59e0be0-590a-4b86-85ac-1327edb7893c.gif)
