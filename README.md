# 起動方法
![image](https://github.com/user-attachments/assets/965171fe-7306-4004-aca3-d954d553ac72)
本ページ内の右側に「Releases」とあるので、ここから最新のバージョンをクリックする。
![image](https://github.com/user-attachments/assets/d47fb219-5e38-4ab7-aa4a-bb9c51d880b8)
Assetの項目から「UEFNSupportTool.zip」をクリックしてダウンロードする（Source Codeではないので注意）
ダウンロードしたZipファイルを解凍し、「UEFNSupportTool.exe」を起動する。

## ウイルスの検知がされた場合
※現在対策を考えています。

Windows画面の下部にある検索バーより「Windowsセキュリティ」を選ぶ。
「保護の履歴」からUEFNSupportToolを見つけ許可する。
> 脅威がブロックされましたを押すと詳細を確認できるので、影響を受けた項目から「file: C:\Users\UserName\Downloads\UEFNSupportTool.Zip」と表示されているものが対象。身に覚えがないソフトを間違えて選ばないように注意。


# 機能

# Verse Tag Support
![image](https://github.com/user-attachments/assets/b70b1f77-c44e-4028-a2b1-eda3e50d6df2)
UEFN上でアクタを複数選択し、コピー、もしくは切り取りをする（Ctrl+C または Ctrl+X)

![image](https://github.com/user-attachments/assets/45c3a1b1-1b80-480d-903f-750efd132c68)
ペーストボタンを押し、「Begin Map」から始まる文字列が表示させるのを確認する。
問題が無さそうであれば「変換」ボタンを押し、VerseTagMarkupを付与する処理を行う。
変換後は「コピー」を押してクリップボードに情報を保存する。

![image](https://github.com/user-attachments/assets/8ec9a8d2-eb0b-45c8-94b9-54892148ff24)
UEFNに戻り、ビューポートで貼り付けをするとVerseTagMarkupが付与された状態でアクタが配置される（Ctrl+V)

ここまでの流れでエラー（正常に貼り付けが行われない、付与に漏れがあるなど）があれば、不具合報告をする。

