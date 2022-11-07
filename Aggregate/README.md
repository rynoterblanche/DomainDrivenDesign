# Aggregates

An aggregate demo of a Workflow and Tasks.

## What is an aggregate?

An aggregate is a cluster of associated objects that we treat as a unit for the purpose of data changes. 
It can also be described as a transactional graph of objects. Aggregates encapsulate business rules and
invariants.

- consists of one or more entities and/or value objects that change together
- treated as a unit for data change
- enforces data consistency across multiple objects
- data changes adhere to ACID principles (atomic, consistent, isolated, durable) 

## Aggregate root

This is the entry point of an aggregate and it ensures the integrity of the entire graph of objects 
represented by that aggregate. The aggregate root is responsible for maintaining it's invariants.

Cascading delete is a good test for whether an object should be an aggregate root (when deleting the root it should
make sense to also delete it's children).

## Associations in aggregates

The modeled relationship between entities.

- default to one-way relationships when modelling associations
- carefully consider any cases where you think you might need bi-directional associations since this adds complexities

A biderectional association means that both objects can be understood only together. When application requirements 
do not call for traversal in both directions, adding a traversal direction reduces interdependence and simplifies 
the design.

## Handling relationships that span aggregates

- external objects should interact with the aggregate root only
- aggregate object relationships are not the same as relationships between persisted data (ORM data)

## Understanding invariants in DDD

An invariant is a condition that should always be true for the system to be in a consistent state.

For example, the status of a workflow aggregate can only be 'Complete' if all it's tasks are 'Done'.

## Tips

- aggregates are not always the answer
- aggregates can connect only by the root
- don't overlook using foreign keys for non-root entities
- too many foriegn keys to non-root entities may suggest a design problem
- aggregates of one (containing only one object) are acceptable
- follow the rule of "cascading deletes": when deleting an aggregate it should make sense to also 
delete it's child objects, and if it doesn't then the aggregate structure is probably incorrect
