# Repository Pattern
This project contains a few repository abstractions that can be used as starting points for defining 
the persistence needs of your domain model

## What is a Repository?
It represents all objects of a certain type as a conceptual set, like a collection with 
more elaborate querying cabability.

## Benefits
- provides a common abstraction for persistence concerns
- promotes seperation of concerns (i.e. domain logic & UI can vary independantly from data and backend data source of an app)
- communicates design decisions (provides & controls direct access to certain objects)
- enables easier testability
- improves maintainability

## Design Tips
- think of it as an in-memory collection
- set up access through a known, common access interface
- consider adding derived repository interfaces that add more methods as required by specific bounded contexts in your domain 
- include add & remove methods to encapulate insertion/deletion operations of object data
- only provide repositories for aggregate roots that require direct data access
- keep your clients focused on the domain model, while delegating all persistence concerns to the repository (domain model 
should be persistence ignorant

## Avoid these common problems in repository logic
- n+1 query errors (ineffecient query usage)
- inappropriate use of eager vs. lazy loading
- fetching more data than is required

## Returning IQueryable from Repository
### The pros
- flexible
- queries can be built anywhere
- minimal repository code required
- only return data that is needed
- a smaller set of Repository methods

### The many cons
- query logic is now everywhere
- violates SRP
- violates Seperation of Concerns
- creates confusion about where query executes (on the data source or not?)
- compiled code can cause runtime exceptions
- no encapsulation

## Generic repository trade-offs
What is more valuable to your solution:
1. a consistent persistence implementation (with possible unused methods), or
2. individually designed classes with a variety of bespoke methods

## CQRS
Repository abstractions can sometimes get too large, violating ISP. 

One solution for this is CQRS:

- query-focused repos can benefit from caching
- command-focused repositories can benefit from async execution using queues

Too many read methods can start to complicate caching logic (a problem that can be solved using Specifications)
