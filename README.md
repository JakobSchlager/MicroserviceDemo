# Microservice Demo

## 1. Use Case
![image](https://user-images.githubusercontent.com/55581391/136433521-38e91ef3-4eb7-4f1c-9162-08a731e1c783.png)
### 1.1. User Story
Ein Benutzer möchte auf der Seite einen Film auswählen. Anschließend will er einen Sitzplatz reservieren. Zuletzt will der benutzer sein Ticket noch herunterladen können.
## 2. Domänen/ Services
![image](https://user-images.githubusercontent.com/55581391/136434931-d894a8ca-d859-4b56-b7a5-4bdd6448cdfc.png)
*Ausbau auf mehrere Sitzplätze pro Reservierung, Benutzer, Bank?*
## 3. Kommunikation (Upstream/Downstream oder gleichwertig)
![image](https://user-images.githubusercontent.com/55581391/136553512-34940f9f-99c8-4d18-b9ae-20d8356fa597.png)
## 4. Entwicklungsumgebung
### 4.1. Programmiersprache und Framework
Backend: C#: Entity Framework Core - ASP.NET, eventuell JavaScript (TypeScript) mit Express oder Java mit Spring Boot  
Falls Zeit für ein kleines Frontend bleibt: TypeScript: Angular
### 4.2. Datenhaltung
MariaDB/ MySql
### 4.3. Dateinaustausch (Synchron/ Asynchron)
Synchron: Http (REST)
Dateinformat: JSON  
Asynchron:  
![image](https://user-images.githubusercontent.com/55581391/136698121-5b2a57e3-068f-4fdd-a737-da0a78b20dab.png)
*Als Messagebus wäre Azure Message Bus, NServiceBus, RabbitMQ möglich. ALlerdings noch keine Lösung für transactional outbox bei Azure Service Bus gefunden (für die basic Preisklasse).*
## 5. Services rudimentär implementieren
## 6. Qualitätskriterien 
## 7. Patterns und Technologien
## 8. Einrichtung der Technologien und Services auf VMs
## 9. Test
