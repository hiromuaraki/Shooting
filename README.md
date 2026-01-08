# 2D シューティングゲーム（Unity）

Unity を使った 2D シューティングゲームの学習用プロジェクトです。

## 参考資料
本プロジェクトは、以下の書籍を参考にしています。

- [マンガでわかる Unity ゲーム開発入門](https://book.impress.co.jp/books/1121101081)

※ 書籍の内容をそのまま写経するのではなく、  
　設計やクラス構成は自分なりに考え直して実装しています。

## 目的
- Unity を使ったゲーム開発の基礎を実践的に学ぶ
- MonoBehaviour を用いたコンポーネント指向設計の理解
- 入力処理・移動処理などの責務分離を意識した設計
- Git / GitHub を用いたソースコード管理の練習

## 開発環境
- Unity（version: 6.3）
- C#
- Visual Studio Code

## 構成概要
- PlayerController  
  プレイヤーキャラクターの制御を担当
- Enemy  
  敵キャラクターの挙動を管理
- CharacterMovement  
  プレイヤー・敵共通の移動処理
- InputHandler  
  キーボード入力の取得処理
- GameManager  
  ゲーム全体の管理クラス

## 開発状況
現在開発中です。