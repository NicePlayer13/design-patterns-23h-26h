# Design Pattern: Observer

## Beispiel: Online-Shop mit Warenkorb

In diesem Beispiel wird das Observer-Pattern verwendet, um ein Online-Shop-Szenario zu simulieren. Der `Cart` fungiert als Subject und benachrichtigt Observer, wenn sich der Warenkorb ändert.

### Beteiligte Klassen:

- `Cart` – Subject, verwaltet Items und Observer
- `IObserver`, `ISubject` – Interfaces nach GoF-Muster
- `TotalPriceDisplay` – Observer zur Anzeige der Artikelanzahl
- `InventoryChecker` – Observer zur Prüfung des Lagerbestands

### Pattern-Vorteile:

- Entkopplung von Logik und UI
- Dynamische Erweiterbarkeit um neue Observer
- Realitätsnahes Beispiel (Shop-System)

## Projektstruktur

- `src.DesignPatterns.Observer` enthält das Pattern als Produktionsteil
- `tests.DesignPatterns.Observer` enthält Unit-Tests (MSTest)

## Testabdeckung

Die wichtigsten Methoden des Patterns (Add, Remove, Notify) werden durch Unit-Tests abgedeckt.
