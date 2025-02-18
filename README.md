# F# Mutable Variable Swap Bug

This repository demonstrates a common error when working with mutable variables in F#. The `swap` function attempts to swap the values of two mutable variables, but it fails to do so correctly.  This is because F# passes values by value rather than by reference. The function operates on copies of the variables, not the original variables.

## Bug Report
The `bug.fs` file contains the buggy code. When run, the output is unexpected because the original variables x and y remain unchanged.

## Solution
The `bugSolution.fs` file demonstrates the corrected code, showing two different ways to correctly implement the swap function.