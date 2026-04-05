# 🌱 MorePlants Aging Fix

Prevents decorative plants from aging in the **MorePlants** mod.

---

## 📌 What this mod does

Some decorative plants from the MorePlants mod incorrectly age over time.

This mod fixes that by forcing all decorative plants (`moreplants_deco_*`) to **never become "old"**, keeping their intended visual state permanently.

---

## ⚙️ How it works

This mod uses **Harmony patches** to override the `IsOld()` method for:

* `StandardBasicMorePlants`
* `StandardMorePlants`

If the plant prefab ID starts with:

```
moreplants_deco_
```

➡️ The plant will **never age**

---

## 🧩 Compatibility

* ✔ Requires: **MorePlants mod**
* ✔ Safe to add/remove mid-game
* ✔ Works with existing saves
* ✔ No configuration needed

---

## ⚠️ Notes

* Only affects **decorative plants**
* Does NOT modify gameplay balance
* No impact on performance

---


## 🧪 Known Issues

None so far.

If you find any issues, feel free to open a GitHub issue.

---

## 🙌 Credits

* Original mod: **MorePlants**
* Patch by: *YourName*

---

## ⭐ Support

If you like this mod, consider leaving a ⭐ on GitHub or 👍 on Steam!

---
