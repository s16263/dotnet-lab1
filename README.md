# dotnet-lab1

Projekt został wykonany w ramach ćwiczeń z systemu kontroli wersji Git.  
Repozytorium zawiera historię pracy z wykorzystaniem commitów, gałęzi, merge, rebase oraz rozwiązania konfliktu.

## 1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?

Git wykona merge typu **fast-forward**, gdy gałąź docelowa nie posiada nowych commitów od momentu utworzenia gałęzi roboczej. W takiej sytuacji Git jedynie przesuwa wskaźnik gałęzi do przodu.

**Merge commit** powstaje wtedy, gdy obie gałęzie mają własne nowe commity i ich historie się rozeszły. Wtedy Git musi połączyć je specjalnym commitem scalającym.

## 2. Czym w praktyce różni się merge od rebase?

**Merge** łączy dwie gałęzie zachowując ich oryginalną historię. W większości przypadków powstaje dodatkowy commit scalający, który pokazuje moment połączenia gałęzi.

**Rebase** przenosi commity z jednej gałęzi na koniec drugiej gałęzi. Powoduje to, że historia projektu jest bardziej liniowa i czytelna, ponieważ wygląda tak, jakby wszystkie commity powstały jeden po drugim.

## 3. W jaki sposób został rozwiązany konflikt w repozytorium?

Konflikt został wywołany poprzez zmianę tego samego fragmentu kodu w pliku `Program.cs` na dwóch różnych gałęziach.

Podczas próby wykonania merge Git zgłosił konflikt i w pliku pojawiły się znaczniki konfliktu (`<<<<<<<`, `=======`, `>>>>>>>`). Konflikt został rozwiązany ręcznie poprzez edycję pliku, wybranie odpowiedniej wersji komunikatu oraz usunięcie markerów konfliktu. Następnie poprawiony plik został dodany do repozytorium i zakończono operację merge.