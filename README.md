# Como Empezar

Bienvenidos a al tutorial de como crear tu propia civilizacion para worldbox, la idea de este turorial es de que puedas descargar el ejemplo, y modificar tanto eliminar como agregar atributos, civilizaciones, sprites, etc. Es un tutorial basico y limitado ya que la informacion que se recopilo para hacer este tutorial fue limitada, corta o no oficial por parte del creador, NO ME HAGO RESPONSABLE DEL MAL USO QUE LE DEN.

# ES RECOMENDABLE VER EL [VIDEO](https://youtu.be/5LfrDDBBsqg) CREDITOS DE [MOD](https://gamebanana.com/mods/532810)

### Que hacer?

Tienen que descargar el archivo zip  apretando en el boton de code arriba de todo (Es de color celeste), luego en *Download Zip*

Luego lo agregan en la carpeta mods descomprimida, tienen el [video](https://www.youtube.com/watch?v=Aq6i8k8zjGk&ab_channel=VMASPAD) como hacerlo. De todas formas tienen un video de que trata de como inicializar el proyecto

* NO MODIFICAR `Test.cs`
* NO MODIFICAR `ResourcesHelper.cs`
* NO MODIFICAR `MoreRacesTab.cs`

##### Dentro de los archivos aparecera lo que se puede modificar y lo que no

En cada archivo estara una palabra clave `orange_slime` basicamente es el nombre clave que tiene la unidad cuando se crea, en cada archivo estara separado cuando debes copiar cada cosa y en donde declarar cada una, solo leer los comentarios y podras saber que cosas agregar.

En la estructura de archivos de las imagenes, solo cambia los sprites con el nombre clave o con el mismo que hayas creado, recuerda dejar al menos uno de cada uno para saber su estructura, las imagenes por lo general no llevan este id, si no que lo tiene la misma carpata:

`GameReources/actors/races/orange_slime`

Luego para tener un codigo mas legible para que lo puedas modificar como quieras, habra una lista de las variables que tienes que modificar para poder saber que es cada parte, basicamente que puedas darle su propio ID

### En este mod habran 2 unidades diferentes, en las cuales tendran cosas diferentes, ya que asi sabras donde hay que modificar para agregar una nueva unidad

Tomaremos el caso de royal_slime, es la unidad que modificaremos, aquen que si quieres puede modificar la otra unidad, es lo mismo.

En cada archivo:

* Main.cs
* MoreRaces2.cs
* MoreRacesBuilds.cs
* MoreRacesButtons.cs
* MoreRacesKingdoms.cs
* MoreRacesRaceLibrary.cs
* MoreRacesRaces.cs
* MoreRacesTab.cs

Estaran las propiedades, tanto de la unidad, como del imperio y sus comportamientos respecto a los otros imperios, tanto agregados como los que vienen dentro del juego, el `ID = royal_slime` es el nombre que va a tomar para definir esta unidad y sus características

# Main

Solo agregas el ID que defines, y que usaras en cada situacion o que menciones a tu unidad

# MoreRaces2

Archivo que maneja las importaciones de las imagenes

# MoreRacesBuilds

Agrega las imagenes de cada civilizacion y sus nombres de los archivos

# MoreRacesButtons

Crea los botones en el tab, con sus titulos y descripciones

# MoreRacesKingdoms

Crea los reinos de las civilizaciones en ambos estados como nomadas y en formacion de imperios, ademas de algunos efectos

# MoreRacesRaceLibrary

Inicializa los archivos de imagenes dentro del juego

# MoreRacesRaces

Crea la raza de forma personalizada con sus efectos, es posible agregarle efectos externos pero aun dezconosco la forma de hacerlo, luego defines otras partes de la raza como vida, razgos, etc
