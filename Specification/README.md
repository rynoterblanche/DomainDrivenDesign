# Specification Pattern

A simple starter implementation of the specification pattern - this abstraction can be used to encapsulate 
business logic with strongly typed, reusable specifications.

## What is a Specification?
A specification is a predicate that determines if an objects satisfies some criteria. Each specification is 
a Value Object and is thus immutable.

- helps avoid domain knowledge duplication ( DRY principle)
- provides declarative approach to defining domain logic ( improved maintenance )
- meshes smoothly with repositories to provide query access to domain objects

## What are the use cases?
1. In-memory validation - checking if an object meets certain criteria (for example input request objects)
2. Data selection / querying - finding data records that match a certain specification.
3. Creation to purpose - creating new objects that comply with certain criteria.

## Benefits of Specifications
 - named via ubiquitous language
 - reusable
 - seperates persistence from domain model and UI
 - keeps business logic out of persistence layer and DB
 - helps entities and aggregates follow SRP

## When not to use the Specification pattern?
- If only 1 out of the 3 use cases above apply to your solution
- If your application is simple enough and you do not expect it's complecity to grow much

## Use Specifications when?
- You have to cover more than one of the above use cases
- Your codebase has become complex and you need ensure DRY (don't repeat yourself)