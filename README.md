# Practice_VirtualMethod
資策會全端班練習作業

## 作業需求說明
預設 class Person / class Employee:Person
員工有三種職位，本薪外領有不同種的工資
| Position  | AdditionalCompensation    | Description                          |
|-----------|---------------------------|--------------------------------------|
| Engineer ( 工程師 )  | OvertimePay ( 加班費 )    |                                      |
| Sales( 業務 ) | Bonus ( 分紅 )            |                                      |
| Managemet ( 經理 ) | LeaderBonus ( 領導加成* ) | *依照下屬人數而定，領導 1 人 10 萬元 |

**寫一個函數計算回傳所有人的薪資**

## 練習重點
  - custom type 自訂型別
  - Inheritance 繼承型別
  - virtural method 虛擬方法
  
## 程式碼說明
- 於型別 class Employee 中設計  `public override int CalcTotalPay()`;
- 繼承 Employee 型別的三種子型別 class Engineer, Sales. Managemet 中設計 `public override int CalcTotalPay()`
- 以上的設計，始我們將不同 position 的 Employee 加到 `List<Employee>` 並列出各自薪資時，並不會因存入 List<Employee> 後型別為 Employee 而使 CalcTotalPay() 的計算結果失真

## 其他
- 本專案目前僅手動測試。
- 練習 Unit testing (單元測試) 視為本方案後續要練習的課題。
