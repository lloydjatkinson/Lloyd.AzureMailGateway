# Lloyd.AzureMailGateway
Provides a centralised outbound e-mail service for use in my projects. Configurable and supports multiple providers (e.g. SendGrid).


![](doc/Lloyd.AzureMailGateway.png)

----------

(This is currently a work in progress)

This Azure based service allows me to decouple my existing and future projects from specific E-Mail dependencies. I've often found that I want to add E-Mail sending support to my code - for logging purposes, reporting progress, events occurring etc.

This would usually mean I then need to repeat the same process of implementing E-Mail support. I decided to instead write an Azure Function with a HTTP endpoint that exposes an API. It accepts simple JSON payloads. These are then deserialized into an internal E-Mail type found in the `Lloyd.AzureMailGateway.Core` namespace. 

The software is architectured in a way to allow for new E-Mail providers to be implemented in a straightforward way via dependency injection. SendGrid is currently the only provider implemented.

Dependencies:

- Azure Functions
- SendGrid
- FluentValidation

Unit testing dependencies:

- xunit
- AutoFixture
- NSubstitute
- Shoudly