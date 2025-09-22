返回 [README](../README.md)

# Git Commit

## **基本結構**

```
<type>([optional scope]): <description>

[optional body]

[optional footer(s)]
```

> 如上 `<>`、`[]` 符號，這兩組是解釋性符號，實際撰寫時不需要輸入這些符號。

> `<>` 表示**必填**；`[]` 表示*選填*。

---

### 基本組成要素

- **Header -- 標題行**

    - **Type（類型）：** 必要欄位，表示 Commit 的性質
    - _**Scope（範圍）：** 可選欄位，用括號包圍，表示影響的範圍_
    - **Description（描述）：** 必要欄位，簡短描述變更內容，不超過 50 個字元


- **Body -- 內容**

    - _詳細說明變更的原因和方式_
    - _每行不超過 72 個字元_
    - _與標題行之間需要空行分隔_


- **Footer -- 頁尾**

    - **記錄重大變更（BREAKING CHANGE）**
    - _關聯的 Issue 編號_
    - _其他相關資訊_

---

### 常用的 Type 類型

| 類型         | **用途說明**          |
|------------|-------------------|
| `feat`     | 新功能               |
| `fix`      | 修 bug             |
| `docs`     | 文件變更              |
| `style`    | 格式變更（無功能變動）       |
| `refactor` | 重構程式碼（非新功能或修 bug） |
| `test`     | 加入測試或測試變動         |
| `chore`    | 雜項，不影響程式的修改       |
| `perf`     | 性能優化              |
| `ci`       | 持續整合設定            |
| `build`    | 建構系統或外部依賴變更       |

## **基本範例**

```
feat: 新增使用者登入功能

實作 OAuth 2.0 認證機制，支援 Google 和 Facebook 登入。
包含登入狀態管理和錯誤處理。

Closes #123
```

### **包含 Scope 的範例**

```
fix(auth): 修復登入頁面在 Safari 瀏覽器的崩潰問題

解決 token 驗證時的型別不匹配問題，確保在所有主流瀏覽器
都能正常運作。

Fixes #456
```

### **重大變更範例**

```
feat!: 更新 API 回應格式

BREAKING CHANGE: API 回應格式從 XML 改為 JSON。
用戶端需要更新解析邏輯以支援新格式。

Migration guide: https://docs.example.com/migration
```

