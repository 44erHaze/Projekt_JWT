**Projektdokumentation: Ski-Service Management**

**1. Einleitung**
Im Rahmen des Moduls 295 – Backend für Applikationen realisieren habe ich das Projekt "Ski-Service Management" durchgeführt. Das Ziel dieses Projekts war es, die interne Verwaltung der Ski-Service Aufträge 
für die Firma Jetstream-Service zu digitalisieren. Die Firma führt in der Wintersaison Skiservicearbeiten durch und benötigte eine Web- und Datenbank basierte Anwendung, um die Serviceaufträge effizient zu verwalten.

**2. IPERKA-Analyse**
Die IPERKA-Analyse wurde als grundlegender Schritt für das Projekt durchgeführt:

- **I - Informationsgewinnung:** Ich begann mit der Erfassung aller relevanten Informationen über die Anforderungen des Projekts. 
Dazu gehörten die Funktionen des Auftragsmanagements, die Anforderungen an die Authentifizierung und die Dienstleistungen, die das Unternehmen anbietet.

- **P - Planung:** Nach der Informationsgewinnung plante ich die Schritte des Projekts. 
Dies umfasste die Erstellung einer Web-API, das Design und die Implementierung der Datenbank, die Erstellung von Unit-Tests, die Realisierung der Anwendungsfunktionen und die Dokumentation.

- **E - Durchführung:** Die Umsetzung erfolgte schrittweise. Zuerst erstellte ich das Web-API-Projekt unter Verwendung von ASP.NET Core. 
Dann entwarf und implementierte ich die Datenbank unter Verwendung des Entity Framework Core. Die Funktionen des Auftragsmanagements wurden entsprechend den Anforderungen realisiert.

- **R - Reflexion:** In dieser Phase habe ich das Projekt reflektiert und sicherzustellen versucht, dass die entwickelte Lösung den Anforderungen entspricht. 
Ich überprüfte auch, ob die Anwendung effizient und benutzerfreundlich ist.

- **K - Kommunikation:** Während des gesamten Projekts habe ich eng mit dem Team und den Stakeholdern kommuniziert. 
Insbesondere wurden regelmäßige Updates über den Entwicklungsfortschritt bereitgestellt.

- **A - Anpassung:** Wo nötig, wurden Anpassungen vorgenommen. Dies umfasste etwaige Fehlerbehebungen, Optimierungen und die Integration von optionalen Erweiterungen gemäß den zusätzlichen Anforderungen.

**3. Umsetzung der Anforderungen**

- **Authentifizierung und Autorisierung:** Die Anforderungen an die Authentifizierung wurden durch die Verwendung von JWT-Token und dem [Authorize]-Attribut für bestimmte Endpunkte umgesetzt.

- **Datenbankdesign:** Das Datenbankdesign erfolgte unter Berücksichtigung der Anforderungen an die Dienstleistungen, Kundeninformationen und Status der Aufträge. 
Die Normalisierung und die referenzielle Integrität wurden sichergestellt.

- **Web-API:** Die Web-API wurde unter Verwendung von ASP.NET Core erstellt. Die Endpunkte für die Anzeige und Bearbeitung von Serviceaufträgen wurden gemäß den Anforderungen implementiert.


**4. Tests**

- **Unit-Tests:** Es wurden Unit-Tests erstellt, um sicherzustellen, dass einzelne Komponenten der Anwendung ordnungsgemäß funktionieren.

- **API-Tests mit Postman:** Die Web-API wurde umfassend mit Postman getestet, um sicherzustellen, dass alle Endpunkte korrekt arbeiten und die Anforderungen erfüllt sind.

**5. Versionierung und Repository-Management**

- **Git-Repository:** Das gesamte Projekt wurde in einem Git-Repository verwaltet, um die Versionskontrolle und Zusammenarbeit im Team zu erleichtern.

**6. Projektmanagement**

- **IPERKA-Dokumentation:** Die gesamte Projektdurchführung wurde nach dem IPERKA-Modell dokumentiert. Dies umfasste alle Phasen von der Informationsgewinnung bis zur Anpassung.

**7. Fazit**

Das Projekt "Ski-Service Management" wurde erfolgreich durchgeführt und erfüllt die gestellten Anforderungen. Die digitale Lösung ermöglicht eine effiziente Verwaltung von 
Serviceaufträgen und bietet eine benutzerfreundliche Schnittstelle für Mitarbeiter und Administratoren. Die Einhaltung der IPERKA-Prinzipien hat zur strukturierten und erfolgreichen Umsetzung des Projekts beigetragen.