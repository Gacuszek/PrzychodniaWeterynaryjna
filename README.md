# 🐾 Przychodnia Weterynaryjna – Aplikacja WinForms w C#

## 🎯 Cel projektu
Aplikacja desktopowa do zarządzania przychodnią weterynaryjną. Umożliwia prowadzenie ewidencji lekarzy, klientów, ich zwierząt oraz historii wizyt. Projekt został zrealizowany w języku C# z zastosowaniem paradygmatu obiektowego.

---

## 🛠 Technologie
- **Język programowania:** C#
- **Interfejs użytkownika:** WinForms
- **Baza danych:** Microsoft Access (.accdb)
- **Dostęp do bazy:** ADO.NET (OleDb)
- **Kontrola wersji:** Git + GitHub
- **IDE:** Visual Studio

---

## 📦 Struktura projektu
- `Form1.cs` – główne okno aplikacji (GUI)
- `DataAccess.cs` – warstwa komunikacji z bazą danych
- `PrzychodniaService.cs` – logika aplikacyjna
- `*.cs` (Klient, LekarzWeterynarii, Zwierze, Wizyta) – klasy modelowe
- `IHasContactInfo.cs` – interfejs do obsługi danych kontaktowych
- `Przychodnia.accdb` – baza danych w formacie Access

---

## ✅ Funkcjonalności
- Zarządzanie **lekarzami weterynarii** (dodawanie, edycja, usuwanie)
- Obsługa **klientów i ich zwierząt**
- Dodawanie i przeglądanie **wizyt pacjentów** z pełną dokumentacją:
  - opis, diagnoza, badania, leki, zalecenia, koszty
- Interfejs graficzny z formularzami i kontrolkami
- Dane przechowywane lokalnie w bazie Access

---

## 🧠 Programowanie obiektowe (OOP)

| Element            | Zastosowanie                                                                 |
|--------------------|------------------------------------------------------------------------------|
| **Dziedziczenie**  | `Klient` i `LekarzWeterynarii` dziedziczą po klasie `Osoba`                  |
| **Interfejsy**     | `IHasContactInfo` implementowany przez `Klient` i `Lekarz`                   |
| **Polimorfizm**    | Obsługa wspólnego interfejsu do wyświetlania kontaktów                      |
| **Hermetyzacja**   | Wszystkie właściwości są `public` z `get; set;`                              |
| **Biblioteki**     | `System.Data.OleDb`, `System.Windows.Forms`, `System.Collections.Generic`   |

---

## 🖼 Zrzuty ekranu
_(Dodaj w repo obrazy GUI, np. `screenshots/form_main.png`)_

---

## 🗂 Diagram klas UML
![diagram_uml](https://github.com/user-attachments/assets/9405d791-0d26-41a4-bf7a-f0bdff125292)


---

## 🚀 Instalacja i uruchomienie

1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/Gacuszek/PrzychodniaWeterynaryjna.git
   ```
2. Otwórz plik `.sln` w Visual Studio
3. Upewnij się, że plik `Przychodnia.accdb` znajduje się w katalogu projektu
4. Naciśnij **F5** lub uruchom projekt z poziomu Visual Studio

---

## 👨‍💻 Autorzy
Projekt zrealizowany w ramach kursu programowania obiektowego.  
## Tomasz Gackowski
## Rafał Soja

---

## 📄 Licencja
Projekt udostępniony na licencji MIT – możesz używać, modyfikować i rozpowszechniać.
