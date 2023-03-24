# Azure Blob Storage Demo - C# / .NET 6 Application

This application demonstrates how to work with Azure Blob Storage to upload and download files. The application is written in C# and uses .NET 6.

### Prerequisites

- .NET 6 SDK: https://dotnet.microsoft.com/download/dotnet/6.0
- A valid Azure account
- A created Azure Storage Account

### Setup

1. Clone the repository or download the files to your desired directory.
2. Open the `Program.cs` file in a text editor or IDE.
3. Replace the `ConnectionString` in the line `private const string ConnectionString` with the connection string of your Azure Storage Account. You can find the connection string in the Azure Portal under "Access Keys" in the "Settings" section of the Storage Account.
4. If needed, change the value of `ContainerName` and `FileName` to use a different container or file.

### Running the Application

1. Open a terminal window or command prompt and navigate to the directory containing the files `ITSC.StorageAccount.sln`, `ITSC.StorageAccount.csproj`, and `Program.cs`.
2. Run the following command to install all required NuGet packages:

```
dotnet restore
```

3. Run the application with the following command:

```
dotnet run
```

The application will upload the file `storageaccount.jpeg` (or the file you specified) to the specified blob container and then download it again. The downloaded file will be saved as `downloaded-storageaccount.jpeg` (or according to the file you specified) in the same directory.

### File Structure

```
ITSC.StorageAccount
├── Root
│   ├── ITSC.StorageAccount.sln
│   └── ITSC.StorageAccount
│       ├── ITSC.StorageAccount.csproj
│       ├── Program.cs
│       └── storageaccount.jpeg
```



# Azure Blob Storage Demo - C# / .NET 6 Anwendung

Diese Anwendung demonstriert, wie man mit Azure Blob Storage arbeitet, um Dateien hoch- und herunterzuladen. Die Anwendung ist in C# geschrieben und verwendet .NET 6.

### Voraussetzungen

- .NET 6 SDK: https://dotnet.microsoft.com/download/dotnet/6.0
- Ein gültiges Azure-Konto
- Ein erstellter Azure Storage Account

### Setup

1. Klone das Repository oder lade die Dateien in das gewünschte Verzeichnis.
2. Öffne die Datei `Program.cs` in einem Texteditor oder einer IDE.
3. Ersetze den `ConnectionString` in der Zeile `private const string ConnectionString` mit dem Verbindungsstring deines Azure Storage Accounts. Den Verbindungsstring erhältst du in der Azure-Portal unter "Access Keys" im Bereich "Settings" des Storage Accounts.
4. Ändere bei Bedarf den Wert von `ContainerName` und `FileName`, um einen anderen Container oder eine andere Datei zu verwenden.

### Anwendung ausführen

1. Öffne ein Terminalfenster oder eine Eingabeaufforderung und navigiere zum Verzeichnis, das die Dateien `ITSC.StorageAccount.sln`, `ITSC.StorageAccount.csproj` und `Program.cs` enthält.
2. Führe den folgenden Befehl aus, um alle benötigten NuGet-Pakete zu installieren:

```
dotnet restore
```

3. Führe die Anwendung mit dem folgenden Befehl aus:

```
dotnet run
```

Die Anwendung lädt die Datei `storageaccount.jpeg` (oder die von dir angegebene Datei) in den angegebenen Blob-Container hoch und lädt sie dann wieder herunter. Die heruntergeladene Datei wird als `downloaded-storageaccount.jpeg` (oder entsprechend der von dir angegebenen Datei) im selben Verzeichnis gespeichert.

### Dateistruktur

```
ITSC.StorageAccount
├── Root
│   ├── ITSC.StorageAccount.sln
│   └── ITSC.StorageAccount
│       ├── ITSC.StorageAccount.csproj
│       ├── Program.cs
│       └── storageaccount.jpeg
```