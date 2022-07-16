# Ejercicio **007**

## Descomposición de cadena de caracteres en Pares

Dada una cadena de caracteres `s`, descomponer ésta en una lista de `n` pares `(X,Y)` donde:

* `n` Es la cantidad de caracteres en la cadena.
* `X` Es cada uno de los caracteres de `s`.
* `Y` Es la cadena `s` pero sin el caracter `X`.

### Ejemplo1

* Dado s=`ABCD`, la lista de pares sería:
`(A, BCD)`, `(B, ACD)`, `(C, ABD)` y `(D, ABC)`.

### Ejemplo2

* Dado s=`AB`, la lista de pares sería:
`(A, B)` y `(B, A)`.

### Ejemplo3

* Dado s=`HOLAMUNDO`, la lista de pares sería:
`(H,OLAMUNDO)`,  `(O,HLAMUNDO)`,  `(L,HOAMUNDO)`,  `(A,HOLMUNDO)`,  `(M,OLAUNDO)`,  `(U,HOLAMNDO)`,  `(N,HOLAMUDO)`,  `(D,HOLAMUNO)` y `(O,HOLAMUND)`

### Ejemplo4

* Dado s=`A`, la lista de pares sería:
`(A,)`.
