# 🐾 Przychodnia Weterynaryjna – Aplikacja Desktopowa

## 📌 Temat i cel biznesowy aplikacji

Aplikacja służy do zarządzania klientami oraz ich zwierzętami w ramach małej przychodni weterynaryjnej. Umożliwia szybki dostęp do danych, ich edycję oraz prowadzenie rejestru pacjentów bez konieczności używania dokumentacji papierowej.

---

## 🛠 Użyte technologie

- **Język programowania**: C#
- **Framework**: .NET Framework
- **GUI**: Windows Forms
- **Baza danych**: Microsoft Access (`Dane.accdb`)
- **Biblioteki**: ADO.NET (`System.Data.OleDb`)

---

## 🧩 Funkcjonalności

### 👤 Klienci
- Dodawanie nowych klientów
- Edycja danych klientów
- Usuwanie klientów

### 🐶 Zwierzęta
- Dodawanie zwierząt do klientów
- Wyświetlanie listy zwierząt
- Usuwanie zwierząt

### 🔎 Wyszukiwanie i nawigacja
- Przejrzysty interfejs oparty o formularze
- Powiązanie klient–zwierzę

---

## 📷 Zrzuty ekranu



---

## ⚙️ Instalacja i uruchomienie

1. **Sklonuj repozytorium**:
   ```bash
   git clone https://github.com/Gacuszek/PrzychodniaWeterynaryjna
   ```

2. **Otwórz projekt w Visual Studio**.

3. **Upewnij się, że plik `Dane.accdb` znajduje się w folderze projektu.**

4. **Zbuduj i uruchom aplikację (`F5`).**

---

## 🧱 Architektura i paradygmat obiektowy

Projekt opiera się na zasadach programowania obiektowego:

### 📦 Klasy i ich odpowiedzialności

- `Klient` – dane kontaktowe właściciela
- `Zwierze` – dane o zwierzęciu
- `DataAccess` – operacje na bazie danych
- Formularze `Form1`, `MainForm`, `KlienciForm`, itp. – logika UI

### 🧠 Zasady OOP:
- **Enkapsulacja** – dane przechowywane jako właściwości, dostęp przez metody
- **Modularność** – każda forma i klasa odpowiada za jeden obszar funkcjonalności
- **Separacja warstw** – interfejs użytkownika oddzielony od logiki bazy danych

---

## 📄 Licencja

Projekt dostępny na licencji MIT.
