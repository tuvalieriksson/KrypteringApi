# Kryptering API

# Live Demo
Applikationen körs live på AWS Elastic Beanstalk: 
[KrypteringApi Swagger UI](http://kryptering-api-tuvali.eu-north-1.elasticbeanstalk.com/swagger)

# Teknikstack
Backend: .NET 10 (C#)
API-dokumentation: Swagger / OpenAPI
Testning: xUnit
CI/CD: GitHub Actions
Molnplattform: AWS (Elastic Beanstalk)

# CI/CD-Flöde
Projektet använder en automatiserad pipeline för att säkerställa kodkvalitet och kontinuerlig leverans:
1. Continuous Integration (CI): Vid varje Pull Request till dev eller main triggas GitHub Actions. Robotar bygger projektet och kör alla enhetstester automatiskt. Om testerna misslyckas blockeras mergen.
2. Continuous Deployment (CD): När kod mergas in i main-branchen publiceras applikationen automatiskt. Koden kompileras för Linux, paketeras och deployas direkt till AWS Elastic Beanstalk.

# Tester
Projektet inkluderar enhetstester för att verifiera krypteringslogiken i CipherService. För att köra testerna lokalt:
Bash -> dotnet test

# API Endpoints
GET /encrypt?text=Hej&shift=3 – Returnerar krypterad sträng.
GET /decrypt?text=Khm&shift=3 – Returnerar ursprunglig sträng.