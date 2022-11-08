# Domain Events
Simple demo for domain events

## What are Domain Events?
Domain events alert that some activity or state change occurred in a domain. Other 
domains can subscribe and respond to these events in a loosely coupled manner. This promotes
seperation of concern across domain models.

## Features of Domain Events
- can communicate outside a domain
- are encapsulated as objects
- each event is a full-fledged class

## Pointers
- domain events represent the past (something that already happened at the point of crearing the event)
- domain events should typically be immutable objects
- describe events clearly using the ubiquitous language of your domain's bounded context
- use the command name causing the event to be fired
- create events only as needed

## Designing Domain Events
- consider a base class: DomainEventBase
- it's a good idea to include the date & time an event occurred
- provide event specific detail that is informative and useful (avoiding creating bloated
event classes with too much detail)
- avoid code that introduce behaviour or side affects in the construction of your event