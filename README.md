# VroidJump
Vroidモデルを使ったジャンプゲーム

## シーンの作成
### Plane
- Position X Y Z = 0, 0, 0
- Scale XとZを10に
- Materialを適当に設定
### Cubeの配置
- Position X Y Z = 0, 4, 15
- Materialを適当に設定
### 3Dモデルを配置
- 名前をPlayerとする
- Position X Y Z = 0, 0, 0
### SkyBoxは適当に設定
### AudioSourceを作成
- 名前をBGMとしてBGM用のAudioClipを設定しておく
- Play On Awakeにチェック

## Cubeを動かすスクリプト
- [CubeController]()を作成しCubeにアタッチ

