# Backend Coding Challenge: Authentication

## Description:

Within the framework of an agile project, new security mechanisms for an access system of doors are to be implemented. Until now, access to the system via network zones and VPN has been secured on an on-premises hosted system, thus, a security implementation was not mandatory until now. However, in the course of a planned migration to the cloud, this requirement has changed.

Access to the current version of the service is available to anyone who has access to the network. This access lets you access all doors and even unlock them. The service is accessible externally through a REST API and can be read and modified through this. This represents a security risk and must not be ignored.

Your first project as a new developer in the company will be to secure both endpoints of the service.

## Acceptance Criteria:

### (Junior) Consultant:

1. Both endpoints need to be secured with OAuth2
2. OAuth2 can be implemented with either Spring or Keycloak
3. OAuth2 should be implemented with a local authorization server

### Senior Consultant and above:

1. Both endpoints need to be secured with MTLS
2. MTLS can be implemented with either Spring, nginx or apache
3. Used certificates can either be self signed or valid ones for example from Let's encrypt
4. The backend/rest controller should validate the sent certificates

## General Conditions:
- The structure of the microservice at hand follows the Hexagonal-Architecture (aka. Clean Architecture - [https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)). Incorporate your implementation into the existing application architecture
- Additional dependencies can be added if needed, as well as external software like docker
- The included tests will only be successful when both endpoints return an HTTP 403
- You should complete this coding challenge within `3` days. Please keep this guidance in mind and submit your (partial) result upon expiration of this time frame
- If you draw up any notes or sketches during your implementation, please hand them in together with your solution

## Bonus Tasks (everyone):

- Write additional integration tests for your security implementation
- Secure both API endpoints with different credentials/roles/certificates

---

## Beschreibung:

Im Rahmen eines agilen Projekts sollen neue Sicherheitsmechanismen f??r ein Zugangssystem von T??ren implementiert werden. Bisher wurde der Zugriff zum System ??ber Netzwerkzonen und VPN auf ein On-Premises gehostetes System abgesichert. Daher war eine Sicherheitsimplementierung bisher nicht zwingend notwendig. Im Zuge einer geplanten Migration in die Cloud, hat sich diese Anforderung jedoch ge??ndert.

Zugriff auf die aktuelle Version des Services hat jeder, der Zugang zum Netzwerk hat. Dieser Zugang l??sst einen s??mtliche T??ren abrufen und diese sogar entriegeln. Der Service ist nach au??en durch eine REST API erreichbar und kann ??ber diese ausgelesen und ver??ndert werden. Dies stellt ein Sicherheitsrisiko dar und darf nicht ignoriert werden.

Dein erstes Projekt als neuer Entwickler im Unternehmen wird es sein, beide Endpunkte des Services abzusichern.

## Akzeptanzkriterien:

### (Junior) Consultant:

1. Beide API Endpunkte sollen durch OAuth2 gesichert weren
2. OAuth2 kann entweder mit Spring oder Keycloak realisiert werden
3. OAuth2 soll mit einem lokalen Autorisierungsserver realisiert werden

### Senior Consultant und h??her:

1. Beide API Endpunkte sollen durch MTLS gesichert weren
2. MTLs kann mit Spring, nginx oder apache realisiert werden
3. Die verwendeten Zertifikate k??nnen selbst signiert oder valide sein (z.B. von let's encrypt)
4. Das Backend/Rest Controller soll die gesendeten Zertifikate auf Validit??t pr??fen

## Rahmenbedingungen:
- Die Struktur des vorliegenden Microservices folgt der Hexagonalen-Architektur (aka. Clean Architecture - [https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html](https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)). Halte dich bei deiner Implementierung an die bestehende Anwendungsarchitektur
- Zus??tzlich Abh??ngigkeiten d??rfen hinzugef??gt werden, dies gilt auch f??r externe Software wie docker
- Die mitgelieferten Tests sind nur dann erfolgreich, wenn beide Endpunkte einen HTTP 403 zur??ckgeben. 
- F??r diese Coding Challenge haben wir `3` Tage eingeplant. Bitte richte dich bei deiner Umsetzung nach diesem Richtwert und reiche dein (Teil-)Ergebnis nach Ablauf dieser Arbeitszeit ein
- Solltest du w??hrend der Bearbeitung Zeichnungen oder Notizen anfertigen, reiche diese zusammen mit deiner L??sungen ein

## Bonusaufgaben (alle):

- Schreibe zus??tzlich Integration Tests f??r deine Sicherheitsimplementierung
- Sichere beide API Endpunkte durch unterschiedliche Zugangsdaten/Rollen/Zertifikate
