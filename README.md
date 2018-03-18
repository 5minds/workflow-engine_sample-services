# FakeServices zur Evaluierung der WorkflowEngine

## Was sind die Ziele dieses Projekts?

Einfach Verwendung von REST-Services zur Interaktion mit einer Workflow-Engine.

## Relevante URLs

> **TODO:** Eine Liste relevanter URLs, wie bspw. die URL des Production-Systems, Links auf Jenkins Reports, verwendete 3rd-Party-APIs etc.
>
> **Beispiel:**
>
> *   http://buchbinder-preview.mindassist.net - Preview-Server
> *   http://buchbinder.de/irgendeine_kampagne.html - visuelle Vorlage für unser Redesign

## Wie kann ich das Projekt aufsetzen?

### Voraussetzungen

*   .NET Core `>= 2.0`:
*   httpie: https://httpie.org

## Wie kann ich das Projekt benutzen?

### Benutzung

Starten der Anwendung mittels:

```shell
  > dotnet run
```

Vertrag bestätigen

```shell
  > http POST http://localhost:5000/api/autoreject X-CORRELATION-ID:12345 TradeId=123 Reason=hello
```

Vertrag automatisch ablehnen

```shell
  > http POST http://localhost:5000/api/autoreject X-CORRELATION-ID:12345 TradeId=123 Reason=hello
```

Vertrag manuel ablehnen

```shell
  > http POST http://localhost:5000/api/autoreject X-CORRELATION-ID:12345 TradeId=123 Reason=hello
```

Vertrags-Annahme anzeigen

```shell
  > http POST http://localhost:5000/api/autoreject X-CORRELATION-ID:12345 TradeId=123 Reason=hello
```

Vertrags-Ablehnung anzeigen

```shell
  > http POST http://localhost:5000/api/autoreject X-CORRELATION-ID:12345 TradeId=123 Reason=hello
```

### Wen kann ich auf das Projekt ansprechen?

*   Martin Möllenbeck (martin.moellenbeck@5minds.de)
