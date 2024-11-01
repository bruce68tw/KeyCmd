### 1.專案介紹
KeyCmd 的用途為文字加密/解密 console 程式，可用在 appsettings.json 的重要重要，使用的開發工具為 .NET Core 8

### 2.操作
語法: KeyCmd -e(encode)/-d(decode) key data
  - key 為加密鑰
  - data 為要加密的資料
  - 傳回值為加密/解密結果字串

### 3.下載 & 安裝
執行 KeyCmd 需要從 GitHub 下載以下兩個 Repo 檔案，解壓縮到本機目錄，並且確保 KeyCmd 可以正確參照 Base 專案：
  - KeyCmd：內容為 KeyCmd 主程式。
  - Base：包含 Base、BaseApi、BaseWeb、BaseEther 四個專案，KeyCmd 需要參照 Base 專案，下載的網址為 https://github.com/bruce68tw/Base

### 4.作者
 - Bruce Chen - *Initial work*

### 5.版權說明
本專案使用 [MIT 授權許可](https://zh.wikipedia.org/zh-tw/MIT許可證)。