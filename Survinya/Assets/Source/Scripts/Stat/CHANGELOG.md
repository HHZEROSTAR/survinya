# Changelog

All notable changes to this package will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]




## [0.1.0] - 2024-10-24

### Added

- 新增 `IActor` 介面中的 `IsDead` 屬性與 `IsInRange`、`TakeDamage` 方法。
- 在 `Actor` 類中新增對應方法的實作。
- ActorRegistry 繫結
- ActorSpatial 繫結
- ActorService 繫結
- 新增 `ActorSpatial.cs`，實現：
  - GetNearbyActors 範圍搜尋
  - GetNearestActor 最近目標搜尋
- 新增 `ActorRegistry.cs`，實現：
  - actors 列表管理
  - Register/Unregister 方法
  - GetActors 查詢方法
- 新增 `ActorService.cs`，實現：
  - ActorRegistry 注入與管理
  - IActorSpatial 空間搜尋邏輯整合
  - Actor 必要服務方法實現
- 新增 `Actor.cs` 基礎類別，實現：
  - Actor 生命週期管理
  - ActorType 識別系統
  - 角色數值初始化介面
  - 基礎屬性管理（血量、經驗值、等級）
  - 虛擬方法：傷害、經驗獲取、升級機制

- 新增 `APlayer.cs` 玩家類別，實現：
  - 玩家特定的 ActorType 設定
  - 玩家數值初始化
  - IActorService 生命週期整合
  - 敵人搜尋相關方法

- 新增 `AEnemy.cs` 敵人類別，實現：
  - 敵人特定的 ActorType 設定
  - 敵人數值初始化
  - IActorService 生命週期整合
  - 玩家搜尋方法
- 新增 `Survinya.sln.DotSettings` 設定檔。
- 新增 `Survinya.Stats.csproj.DotSettings` 設定檔。
- 新增 `StatsInstaller` 腳本，提供依賴注入功能。
- 新增測試圖片 `square.png` 用於繪製測試。
- 新增預製件 `Canvas - PlayerStats` 以顯示玩家狀態。
- 新增並更新測試場景 `StatsTest.unity` 以包含新預製件驗證。
- 新增 `Unit - Player.prefab` 預製件，設定玩家單位參數。
- 新增 `Unit - Enemy.prefab` 預製件，設定敵人單位參數。
- 新增 `Unit.prefab` 核心預製件，包含基本單位結構。

### Changed

- AEnemy.cs: 調整敵人攻擊邏輯，移除檢查玩家是否已死亡的部分。修改近戰攻擊的傷害值從1到10。
- Actor.cs: 新增 IsInvincible 屬性及冷卻機制用的共常式方法。
- APlayer.cs: 受到傷害時啟用無敵狀態，並於1秒後自動解除。
- 調整 `AEnemy` 和 `APlayer` 類中的傷害處理邏輯，使用新增的 `TakeDamage` 方法。
- 更新測試場景和預製件以符合新的命名結構與功能。
- 更新 `ActorState.cs` 和 `ActorService.cs`，移除臨時 ActorState 類別
- 更新 `ActorService.cs`，移除臨時 ActorSpatial 介面
- 更新 `ActorService.cs`，移除臨時 ActorRegistry 類別
- 更新 `Actor.cs`，移除臨時 IActorService 介面
- 更新 `PlayerStatsDisplay.cs`，移除臨時類別
- 更新 `StatsInstaller.cs` 的命名空間
- 更新相關 Prefabs 與場景設定

### Fixed

- 修正 ActorState 未被正確初始化的問題
- 確保 CurrentHealth 和 MaxHealth 可被正確讀取
-

### Removed

- 移除 `EntityMono` 臨時類別

### Refactor

- 將命名空間從 `Survinya.Stats` 修改為 `Survinya.Stat`
- 調整檔案目錄結構以與新命名空間一致
- 將 `Stats.asmdef` 重新命名為 `Survinya.Stats.asmdef`。
- 更新 `rootNamespace` 為 `Survinya`。


