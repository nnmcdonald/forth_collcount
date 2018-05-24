( collcount.fs
  Nathaniel McDonald
  4/27/18
  For CSCE 331
  Assignment 7 
   )

: collodd ( n -- 3*n+1)
  3 *
  1 +
;

: colleven ( n -- n/2 )
  2 /
;

: collatz ( n -- cn )
  DUP 
  1 = IF 1 ELSE
  DUP
  2 mod
  1 = IF collodd ELSE colleven THEN 
  THEN
;

: collcount ( n -- c )
  DUP
  1 = IF 0 ELSE
  collatz
  DUP
  1 = IF 0 + ELSE recurse 1 + THEN
  THEN
;

