# CmdTracker🚀

**CmdTracker** ist ein einfaches CLI-Tool zur Befehlsverarbeitung mit einer **Undo-Funktion**.\
Du kannst Zahlen **inkrementieren, dekrementieren, verdoppeln, zufällige Werte hinzufügen** und Befehle rückgängig machen.

## 📌 Funktionen

✔ **Erhöhen** (+1), **Verringern** (-1) und **Verdoppeln** einer Zahl\
✔ **Zufällige Addition** (Zahl zwischen 1-10)\
✔ **Undo-Funktion**, um den letzten Befehl rückgängig zu machen\
✔ **Einfaches CLI-Interface**

## 🚀 Installation & Ausführung

### 1️⃣ **Projekt klonen:**

```sh
git clone https://github.com/abdullah-alhoty/CmdTracker.git  
cd CmdTracker  
```

### 2️⃣ **Zum Master-Branch wechseln:**

```sh
git checkout master
```

### 3️⃣ **Programm ausführen:**

```sh
dotnet run  
```

### 4️⃣ **Verfügbare Befehle:**

```sh
increment   # +1 zur aktuellen Zahl  
decrement   # -1 von der aktuellen Zahl  
double      # *2 (Verdoppeln)  
randadd     # + zufällige Zahl (1-10)  
undo        # Letzte Aktion rückgängig machen  
exit        # Programm beenden  
```

---

## 📚 **Beispiel für eine Nutzung**

```sh
Bitte Startwert eingeben: 5  
> increment   # 5 → 6  
> double      # 6 → 12  
> randadd     # 12 → 20 (z. B. +8)  
> undo        # 20 → 12 (zieht +8 wieder ab)  
> exit        # Beenden  
```

---

## 🛠 **Technologien & Code-Struktur**

- **Sprache:** C#
- **Design-Pattern:** Command Pattern für Undo-Funktion
- **Projektstruktur:**
  - 📂 `Commands/` → Enthält alle Befehle (`IncrementCommand`, `RandAddCommand`, ...)
  - 📂 `Core/` → Enthält die Hauptlogik (`CommandProcessor`)
  - 📄 `Program.cs` → Einstiegspunkt

---

## 📺 **GitHub Repository**

📌 **Repo-Link:** [CmdTracker auf GitHub](https://github.com/abdullah-alhoty/CmdTracker)

🎯 **Viel Spaß mit CmdTracker!** Bei Fragen einfach melden. 🚀😊
 
