# DomainDrivenDesign
This library gives a template and interfaces for Domain Drive Design.

CQRS can be used without event sourcing or DDD, just as these concepts work without CQRS. However there is no denying that three concepts complement each other.

So this library gives a template to implement a DDD pattern using the Event Sourcing pattern, which can be implemented with a CQRS pattern. With this pattern, application state is stored as sequence of events. Each event represents a set of changes to the data. The current state is constructed by replaying the events

![alt text](https://www.codeproject.com/KB/architecture/555855/CQRS.jpg)

Reference: This is a re-implementation of Greg Young's [SimpleCQRS](https://github.com/gregoryyoung/m-r) project, arguably the de-facto sample application for CQRS, DDD & Event Sourcing.

