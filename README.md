# How To Develop Unity with GitHub

## 1. 強烈推薦使用Sourcetree
圖形介面整潔好用，省去打指令的時間 
https://www.sourcetreeapp.com/
## 2. 不要改.gitignore
You will destroy the entire repo
## 3. 在開始更改之前，務必用branch功能
用branch功能分出自己的branch，
修改完時commit+push(CP)後會將更動推到這個branch上

注意！不要CP main.unity
這是主要場景，我最後一次整合

## 4. 要merge前請先開Pull Request給我看
用法很簡單，去github頁面中中間左邊Branch Menu選到自己的branch上，然後在右邊有個New pull request

點進去之後確認Base是master，compare是你自己的branch
然後在底下的檔案比較畫面中確認以下幾件事情：
+ 增加的東西看起來是你有碰過的東西
+ 你沒有增加main.unity
(如果你有的話在compare的部分請刪掉你自己的更改，保留原始檔)
+ 沒有出現甚麼奇怪的meta檔
(如果你不知道甚麼是不該出現的，你可以看一下.gitignore)
(雖然理論上他應該要幫你擋掉)

上面的步驟做完之後理論上github要寫可以automatically merge，這時就寫一下title跟description然後按Create Pull Request了
Create的時候我會看到，也記得去Trello把你負責的部分從In Progress移到Awaiting to be Checked
我檢查沒問題的話就會按Approve，你就可以去按merge了

## 5.有不確定的事情一定要問我
Github很好用但沒用好世界會毀滅，愛護地球你我有責
