# Ejercicio **010**

## Días hábiles e inhábiles

Dadas las siguientes cuatro variables:

* `DoW`: Una lista de días de la sema que representen los días inhabiles en la semana.
* `DoY`: Una lista de días del año que representen los días inhábiles del año.
* `Date`: Una fecha cualquiera.
* `n`: Una cantidad de días.

Calcular:

* `MaxDate`: El día siguiente hábil, posterior a agregar los `n` días hábiles a partir de `Date`.
* `Days`: Una lista de los días hábiles a partir de `Date`
* `NoDays`: Una lista de los días inhábiles a partir de `Date`

### Ejemplo

Para:

* `DoW` = `sábado`, `domingo`
* `DoY` =  `1 de enero`, `1 de mayo`, `16 de septiembre`, `25 de diciembre`
* `Date` = `9 de septiembre 2022`
* `n` = `6`

El resultado debe ser:

* `MaxDate` = `20 de septiembre 2022`
* `Days` = `9-sep-2022`, `12-sep-2022`, `13-sep-2022`, `14-sep-2022`, `15-sep-2022`, `19-sep-2022`
* `NoDays` = `10-sep-2022`, `11-sep-2022`, `16-sep-2022`, `17-sep-2022`, `18-sep-2022`
