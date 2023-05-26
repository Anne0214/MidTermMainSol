# MidTermMainSol

<img width="226" alt="image" src="https://github.com/Anne0214/MidTermMainSol/assets/63950140/7deb282e-ed30-4870-876e-a411861cecd0">


請從有0526數字的資料夾點進去，找到專案資料夾，進行改寫
架構說明如下
- Forms專案下放所有前端程式，包含Form、使用者自訂義控件、前端專用方法等等。請務必將你的前端相關程式放在裡面，並且使用簡單易懂的英文命名。
- ISpan2023.UCook.BackEnd專案下請放所有資料層和服務層的程式，包含dto、assembler、repositories。如果你的dto沒有被放進去，請自行放入。
- 目前ISpan2023.UCook.BackEnd專案有參考老師在教ADO.NET時所用的SqlDataLayer類別庫(取名一樣)，可以使用。如果出現無法使用的情況，可以using看看有沒有幫助，或重新加入參考，dll檔在ISpan2023.UCook.BackEnd的資料夾內

## Forms專案詳細
- 請絕對不要動user controls資料夾，有任何使用上問題請直接反應。僅供檢視控件邏輯。
- view models資料夾放vm，請自由使用
- FormEdit & FormSearch是個模塊的範例，請自由修改使用。
- 如果在工具箱沒看到Maggie做的文字框控件，請建置專案看看。
- FormExportCSV為輸出csv用的視窗，請先無視。但請記得在各自的模塊加上輸出csv按鈕。
- FormLogin、FormLoginFail、LoginManagement、Staff、FormMain為父視窗所使用。除FormMain外皆不可改。FormMain可以在各模塊的按鈕的使用click事件，呼叫各模塊視窗出來看效果。
- IExportCsv勿動，待完成。
- ImageUpload含圖片上傳服務。會將用戶上傳的圖片儲存在專案的資料夾(以亂數命名)，同時會回傳給資料庫，讓資料庫可以儲存圖片位置。用戶在呼叫圖片時能找到。

## ISpan2023.UCook.BackEnd專案詳細
- 如果你的Dto不在裡面，請自己放。
- 想寫第二點但不知道寫神摸

祝大家Good luck!
