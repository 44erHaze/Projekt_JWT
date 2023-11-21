**Projektdokumentation: Ski-Service Management**

**1. Einleitung**
Im Rahmen des Moduls 295 � Backend f�r Applikationen realisieren habe ich das Projekt "Ski-Service Management" durchgef�hrt. Das Ziel dieses Projekts war es, die interne Verwaltung der Ski-Service Auftr�ge 
f�r die Firma Jetstream-Service zu digitalisieren. Die Firma f�hrt in der Wintersaison Skiservicearbeiten durch und ben�tigte eine Web- und Datenbank basierte Anwendung, um die Serviceauftr�ge effizient zu verwalten.

**2. IPERKA-Analyse**
Die IPERKA-Analyse wurde als grundlegender Schritt f�r das Projekt durchgef�hrt:

- **I - Informationsgewinnung:** Ich begann mit der Erfassung aller relevanten Informationen �ber die Anforderungen des Projekts. 
Dazu geh�rten die Funktionen des Auftragsmanagements, die Anforderungen an die Authentifizierung und die Dienstleistungen, die das Unternehmen anbietet.

- **P - Planung:** Nach der Informationsgewinnung plante ich die Schritte des Projekts. 
Dies umfasste die Erstellung einer Web-API, das Design und die Implementierung der Datenbank, die Erstellung von Unit-Tests, die Realisierung der Anwendungsfunktionen und die Dokumentation.

- **E - Durchf�hrung:** Die Umsetzung erfolgte schrittweise. Zuerst erstellte ich das Web-API-Projekt unter Verwendung von ASP.NET Core. 
Dann entwarf und implementierte ich die Datenbank unter Verwendung des Entity Framework Core. Die Funktionen des Auftragsmanagements wurden entsprechend den Anforderungen realisiert.

- **R - Reflexion:** In dieser Phase habe ich das Projekt reflektiert und sicherzustellen versucht, dass die entwickelte L�sung den Anforderungen entspricht. 
Ich �berpr�fte auch, ob die Anwendung effizient und benutzerfreundlich ist.

- **K - Kommunikation:** W�hrend des gesamten Projekts habe ich eng mit dem Team und den Stakeholdern kommuniziert. 
Insbesondere wurden regelm��ige Updates �ber den Entwicklungsfortschritt bereitgestellt.

- **A - Anpassung:** Wo n�tig, wurden Anpassungen vorgenommen. Dies umfasste etwaige Fehlerbehebungen, Optimierungen und die Integration von optionalen Erweiterungen gem�� den zus�tzlichen Anforderungen.

**3. Umsetzung der Anforderungen**

- **Authentifizierung und Autorisierung:** Die Anforderungen an die Authentifizierung wurden durch die Verwendung von JWT-Token und dem [Authorize]-Attribut f�r bestimmte Endpunkte umgesetzt.

- **Datenbankdesign:** Das Datenbankdesign erfolgte unter Ber�cksichtigung der Anforderungen an die Dienstleistungen, Kundeninformationen und Status der Auftr�ge. 
Die Normalisierung und die referenzielle Integrit�t wurden sichergestellt.

- **Web-API:** Die Web-API wurde unter Verwendung von ASP.NET Core erstellt. Die Endpunkte f�r die Anzeige und Bearbeitung von Serviceauftr�gen wurden gem�� den Anforderungen implementiert.


**4. Tests**

- **Unit-Tests:** Es wurden Unit-Tests erstellt, um sicherzustellen, dass einzelne Komponenten der Anwendung ordnungsgem�� funktionieren.

- **API-Tests mit Postman:** Die Web-API wurde umfassend mit Postman getestet, um sicherzustellen, dass alle Endpunkte korrekt arbeiten und die Anforderungen erf�llt sind.

**5. Versionierung und Repository-Management**

- **Git-Repository:** Das gesamte Projekt wurde in einem Git-Repository verwaltet, um die Versionskontrolle und Zusammenarbeit im Team zu erleichtern.

**6. Projektmanagement**

- **IPERKA-Dokumentation:** Die gesamte Projektdurchf�hrung wurde nach dem IPERKA-Modell dokumentiert. Dies umfasste alle Phasen von der Informationsgewinnung bis zur Anpassung.

**7. Fazit**

Das Projekt "Ski-Service Management" wurde erfolgreich durchgef�hrt und erf�llt die gestellten Anforderungen. Die digitale L�sung erm�glicht eine effiziente Verwaltung von 
Serviceauftr�gen und bietet eine benutzerfreundliche Schnittstelle f�r Mitarbeiter und Administratoren. Die Einhaltung der IPERKA-Prinzipien hat zur strukturierten und erfolgreichen Umsetzung des Projekts beigetragen.