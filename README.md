# F# Mutability and Immutability Bug

This repository demonstrates a common issue in F# related to mutability and immutability when attempting to swap the values of variables.  The example highlights the difference between using mutable variables (which allow in-place swapping) and immutable variables (which require returning new values).  Incorrectly trying to modify immutable variables leads to compile-time errors, demonstrating a key aspect of F#'s type system.

## Bug Description
The code initially demonstrates swapping using mutable variables, which works as expected.  However, when attempting to replicate the swap using immutable variables and modifying them within a function, it fails to compile due to immutability restrictions. The solution shows the correct approach for swapping values using immutable variables by returning a tuple.

## How to Reproduce
1. Clone this repository.
2. Open `bug.fs` to see the example showcasing the issue.
3. Open `bugSolution.fs` to see the corrected approach for swapping immutable variables.
4. Compile and run using your preferred F# compiler (e.g., `fsharpc`).