# WPF_TSD_project

## Description

Projet WPF pour la gestion d'une collection de livres.  
Fonctionnalités :
- Liste des livres (ListBox + DataTemplate)
- Détails et édition dans un UserControl
- Ajout et suppression avec confirmation (bubbling d'événement)
- Slider "Adjust the darkness" en bas

## Lancement

### Prérequis
- .NET 8 SDK installé : https://dotnet.microsoft.com/download/dotnet/8.0

### Commandes

```bash
dotnet build
dotnet run
```

## Structure

- `Models/Book.cs` : modèle des livres
- `MainWindow.xaml` : UI principale
- `Views/BookDetailsControl` : UserControl pour édition
- `Resources/DataTemplates.xaml` : DataTemplate pour la ListBox

