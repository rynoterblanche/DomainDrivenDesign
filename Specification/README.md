# Specification Pattern

## What is the Specification pattern?

- Helps avoid domain knowledge duplication ( apply DRY )
- Provides declarative approach to defining domain logic ( improved maintenance )

## What are the use cases?

1. In-memory validation - checking if an object meets certain criteria (for example input request objects)
2. Database data retrieval - finding data records that match a certain specification.
3. Constructor-to-order - creating new objects that comply with certain criteria.

## When not to use the Specification pattern?

- If only 1 out of the 3 use cases above apply to your solution
- If your application is simple enough and you do not expect it's complecity to grow much

## Use Specifications when?

- You have to cover more than one of the above use cases
- Your codebase has become complex and you need ensure DRY (do not repeat yourself)