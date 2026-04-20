# EntregaFinal--.Net-C-
# Carrito de Compras 📖

## Objetivos 📋
Desarrollar un sistema, que permita la administración del stock de productos a una PYME que tiene algunas sucursales de venta de ropa (de cara a los empleados): Empleados, Clientes, Productos, Categorias, Compras, Carritos, Sucursal, StockItem, etc., como así también, permitir a los clientes, realizar compras Online.
Utilizar Visual Studio 2022 community edition y crear una aplicación utilizando ASP.NET MVC Core (versión a definir por el docente, actualmente 8.0).

<hr />

## Enunciado 📢
La idea principal de este trabajo práctico, es que Uds. se comporten como un equipo de desarrollo.
Este documento, les acerca, un equivalente al resultado de una primera entrevista entre el cliente y alguien del equipo, el cual relevó e identificó la información aquí contenida. 
A partir de este momento, deberán comprender lo que se está requiriendo y construir dicha aplicación web.

Lo primero que deben hacer es comprender en detalle, que es lo que se espera y se busca como resultado del proyecto, para ello, deben recopilar todas las dudas que tengan entre Uds. y evacuarlas con su nexo (el docente) de cara al cliente. De esta manera, él nos ayudará a conseguir la información ya un poco más procesada. 
Es importante destacar, que este proceso no debe esperarse hacerlo 100% en clase; deben ir contemplandolas de manera independientemente, las unifican y hace una puesta comun dentro del equipo (ya sean de índole funcional o técnicas), en lugar de enviar consultas individuales, se sugiere y solicita que las envien de manera conjunta. 

Al inicio del proyecto, las consultas pueden ser enviadas por correo siguiente el siguiente formato:

Subject: [NT1-<CURSO LETRA>-GRP-<GRUPO NUMERO>] <Proyecto XXX> | Informativo o Consulta

Body: 

1.<xxxxxxxx>
2.< xxxxxxxx>

# Ejemplo
**Subject:** [NT1-A-GRP-5] Agenda de Turnos | Consulta

**Body:**

1.La relación del paciente con Turno es 1:1 o 1:N?
2.Está bien que encaremos la validación del turno activo, con una propiedad booleana en el Turno?

<hr />

Es sumamente importante que los correos siempre tengan:
1.Subject con la referencia, para agilizar cualquier interaccion entre el docente y el grupo
2. Siempre que envien una duda o consulta, pongan en copia a todos los participantes del equipo. 

Nota: A medida que avancemos en la materia, TODAS las dudas relacionadas al proyecto deberán ser canalizadas por medio de Github, y desde alli tendremos: seguimiento y las dudas con comentarios, accesibles por todo el equipo y el avance de las mismas. 

**Crear un Issue nuevo o agregar un comentario sobre un issue en cuestion**, si se requiere asistencia, evacuar una duda o lo que fuese, siempre arrobando al docente, ejemplo: @marianolongoort y agregando las etiquetas correspondientes.


### Proceso de ejecución en alto nivel ☑️
 - Crear un nuevo proyecto en [visual studio](https://visualstudio.microsoft.com/en/vs/) utilizando la template de MVC (Model-View-Controller).
 - Crear todos los modelos definidos y/o detectados por ustedes, dentro de la carpeta Models, cada uno en un archivo separado (Modelos anemicos, modelos sin responsabilidades).
 - En el proyecto trataremos de reducir al mínimo las herencias sobre los modelos anémicos.  Ej. la clase Persona, tendrá especializaciones como ser Empleado, Cliente, Alumno, Profesional, etc. según corresponda al proyecto.
 - Sobre dichos modelos, definir y aplica las restricciones necesarias y solicitadas para cada una de las entidades. [DataAnnotations](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=net-8.0).
 - Agregar las propiedades navegacionales que pudisen faltar, para las relaciones entre las entidades (modelos) nueva que pudieramos generar o encontrar.
 - Agregar las propiedades relacionales, en el modelo donde se quiere alojar la relacion (entidad dependiente). La entidad fuerte solo tendrá una propiedad Navegacional, mientras que la entidad debíl tendrá la propiedad relacional.
 - Crear una carpeta Data en la raíz del proyecto, y crear dentro al menos una clase que representará el contexto de la base de datos (DbContext - los datos a almacenar) para nuestra aplicacion. 
 - Agregar los paquetes necesarios para Incorporar Entity Framework e Identitiy en nuestros proyectos.
 - Crear el DbContext utilizando en esta primera estapa con base de datos en memoria (con fines de testing inicial, introduccion y fine tunning de las relaciones entre modelos). [DbContext](https://learn.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext?view=efcore-8.0), [Database In-Memory](https://docs.microsoft.com/en-us/ef/core/providers/in-memory/?tabs=vs).
 - Agregar las propiedades del tipo DbSet para cada una de las entidades que queremos persistir en el DbContext. Estas propiedades, serán colecciones de tipos que deseamos trabajar en la base de datos. En nuestro caso, serán las Tablas en la base de datos.
 - Agregar Identity a nuestro proyecto, y al menos definir IdentityUser como clase base de Persona en nuestro poryecto. Esto nos facilitará la inclusion de funcionalidades como Iniciar y cerrar sesion, agregado de entidades de soporte para esto Usuario y Roles que nos serviran para aplicar un control de acceso basado en roles (RBAC) basico. 
 - Por medio de Scaffolding, crear en esta instancia todos los CRUD (Create-Read-Update-Delete)/ABM (Altas-Bajas-Modificaiciones) de las entidades a persistir. Luego verificaremos cuales mantenemos, cuales removemos, y cuales adecuaremos para darle forma a nuestra WebApp.
 - Antes de continuar es importante realizar algun tipo de pre-carga de la base de datos. No solo es requisito del proyecto, sino que les ahorrara mucho tiempo en las pruebas y adecuaciones de los ABM.
 - Testear en detalle los ABM generados, y detectar todas las modificaciones requeridas para nuestros ABM e interfaces de usuario faltantes para resolver funcionalidades requeridas. (siempre tener presente el checklist de evaluacion final, que les dara el rumbo para esto).
 - Cambiar el dabatabase service provider de Database In Memory a SQL. Para aquellos casos que algunos alumnos utilicen MAC, tendran dos opciones para avanzar (adecuar el proyecto, para utilizar SQLLite o usar un docker con SQL Server instalado alli).
 - Aplicar las adecuaciones y validaciones necesarias en los controladores.  
 - Si el proyecto lo requiere, generar el proceso de auto-registración. Es importante aclarar que este proceso debe ser adecuado según las necesidades de cada proyecto, sus entidades y requerimientos al momento de auto-registrar; no seguir explicitamente un registro tan simple como email y password. 
 - A estas alturas, ya se han topado con varios inconvenientes en los procesos de adecuacion de las vistas y por consiguiente es una buena idea que generen ViewModels para desbloquear esas problematicas que nos estan trayendo los Modelos anemicos utilizados hasta el momento.
 - En el caso de ser requerido en el enunciado, un administrador podrá realizar todas tareas que impliquen interacción del lado del negocio (ABM "Alta-Baja-Modificación" de las entidades del sistema y configuraciones en caso de ser necesarias).
 - El <Usuario Cliente o equivalente> sólo podrá tomar acción en el sistema, en base al rol que que se le ha asignado al momento de auto-registrarse o creado por otro medio o entidad.
 - Realizar todos los ajustes necesarios en los modelos y/o código desde la perspectiva de funcionalidad.
 - Realizar los ajustes requeridos desde la perspectiva de permisos y validaciones.
 - Realizar los ajustes y mejoras en referencia a la presentación de la aplicaión (cuestiones visuales).
 
 Nota: Para la pre-carga de datos, las cuentas creadas por este proceso, deben cumplir las siguientes reglas de manera EXCLUYENTE:
 1. La contraseña por defecto para todas las cuentas pre-cargadas será: Password1!
 2. El UserName y el Email deben seguir la siguiente regla:  <classname>+<rolname si corresponde diferenciar>+<indice>@ort.edu.ar Ej.: cliente1@ort.edu.ar, empleado1@ort.edu.ar, empleadorrhh1@ort.edu.ar

<hr />

## Entidades 📄

- Persona
- Empleado
- Cliente
- Carrito
- CarritoItem
- Producto
- Categoria
- Marca
- Compra
- StockItem
- Sucursal

## `⚠️Importante: Todas las entidades deben tener su identificador único. Id⚠️`

`
Las propiedades descriptas a continuación, son las mínimas que deben tener las entidades. Uds. pueden proponer agregar las que consideren necesarias. Siempre validar primero con el docente.
De la misma manera Uds. deben definir los tipos de datos asociados a cada una de ellas, como así también las restricciones.
`

**Persona**
```
- UserName
- Nombre
- Apellido
- DNI
- Telefono
- Direccion
- FechaAlta
- Email
```

**Empleado**
```
- UserName
- Nombre
- Apellido
- DNI
- Telefono
- Direccion
- FechaAlta
- Email
- Legajo
```

**Cliente**
```
- UserName
- Nombre
- Apellido
- DNI
- Telefono
- Direccion
- FechaAlta
- Email
- Carritos
- Compras
```

**Carrito**
```
- Activo
- Cliente
- CarritoItems
- Subtotal (Dato calculado basado en la suma de los Subtotales de los CarritoItems)
```

**CarritoItem**
```
- Carrito 
- Producto
- ValorUnitario (debe tomar el valor de Producto.PrecioVigente al momento de agregarse al carrito)
- Cantidad
- Subtotal (Dato calculado basado en la ValorUnitario x Cantidad)
```

**Producto**
```
- Activo
- Nombre
- Descripcion
- PrecioVigente
- Categoria
- Imagen
- Marca
- StockItems
```

**Categoria**
```
- Nombre
- Descripcion
- Productos
```

**Marca**
```
- Nombre
- Descripcion
- Productos
```

**Sucursal**
```
- Nombre
- Direccion
- Telefono
- Email
- Activa (flag)
- StockItems
- Compras
```

**StockItem**
```
- Sucursal
- Producto
- Cantidad
```

**Compra**
```
- Cliente 
- Carrito
- Sucursal
- Fecha (Fecha y hora)
- Total (Persistido)
```

**NOTA:** aquí un link para refrescar el uso de los [Data annotations](https://www.c-sharpcorner.com/UploadFile/af66b7/data-annotations-for-mvc/).

<hr />

## Características y Funcionalidades ⌨️
`⚠️Todas las entidades, deben tener implementado su correspondiente ABM, a menos que sea implícito el no tener que soportar alguna de estas acciones.⚠️`
 
 **NOTA:** En el EP3, se deberán presentar las ABM de todoas las entidades, independientemente de que luego sean modificadas o eliminadas. El fin academico de esto, es que tomen contacto con formas de manejar los datos con los usuarios desde una interfaz gráfica de usuario y les sea más facil en el siguiente entregable comprender que deben modificar o adecuar.

## Generalidades 🏠
- Los Clientes pueden auto registrarse.
- Deberá contar con información institucional (inventada) relacionada al proyecto.
- Contenido anónimo que debe estar disponible (sin iniciar sesión):
	- La autoregistración desde el sitio, es exclusiva para los clientes. Por lo cual, se le asignará dicho rol.
	- Un cliente puede navegar los productos y sus descripciones sin iniciar sesión.
	- Los productos deshabilitados, deben visualizarse como pausados.
	- El stock no es relevante para los productos del catalogo.
	- Ver las sucursales y sus datos de contacto.
- Los empleados, deben ser agregados por otro empleado.
	- Al momento, del alta del empleado, se le definirá un username y la password será definida por el sistema.
    - También se le asignará a estas cuentas el rol de Empleado.

**Cliente**
- Para agregar productos al carrito, debe iniciar sesión primero. El inicio debe ser forzado y no se debe volver a preguntar producto o volver a realizar la acción de agregar.
- Puede agregar diferentes productos en el carrito y por cada producto modificar la cantidad que quiere.
	- Esta acción, no implica validación en stock.
	- El ciente, verá en el carrito el subtotal, por cada producto/cantidad.
	- También, verá el subtotal, del carrito.
Para realizar el proceso de compra en modo wizard:
- Una vez que está satisfecho con su carrito, puede -> "Comprar". El detalle del proceso verificar en Compra.

- Puede vaciar el carrito.
- Solo puede tener un carrito activo.
- Puede actualizar datos de contacto, direccion, telefono. Pero no puede modificar su Email, DNI, Nombre, Apellido, etc.
- Puede ver el historial de sus compras por medio de un listado con su código de compra,Fecha,Sucursal,Monto.
	- Puede visualizar los detalles de esa compra con los ítems adquiridos, subtotales y total de la compra.

`⚠️Importante: La finalidad de tener muchos carritos y solo uno activo en lugar de tener uno solo como daría la lógica, es una adecuación pensada para bajarles la cantidad de esfuerzo requerido en el proyecto y con fines académicos.⚠️`


**Empleado**
- Puede dar de alta otros empleados y ABM Completo.
- Puede listar las compras realizadas en el mes, en modo listado, ordenado de forma descendiente por valor de compra. Fecha,Cliente, Valor de la compra.
- Se puede acceder a los detalles de la compra.

- ABM de Productos, Marcas, Categorias, Sucursales y agregar productos al stock de cada sucursal. Considerar las restricciones que se detallan en cada caso. Ej. No se pueden eliminar productos.
- Puede habilitar y/o deshabilitar productos desde el listado con un boton On/Off.

**Producto, Categoria, Marca**
- No pueden eliminarse del sistema. 
- Solo los producto pueden dehabilitarse.

**Sucursal**
- Cada sucursal, tendrá su propio stock.
- Tendrá datos de locación y contacto.
- Por el mercado tan volatil, las sucursales, pueden crearse y "eliminarse" en todo momento.
	- La eliminación es una deshabilitación.
	- Sucursales deshabilitadas, no deben ser consideradas en la oferta de sucursales y búsqueda de stock.

**StockItem**
- Pueden crearse, pero nunca pueden eliminarse desde el sistema. 
- Puede modificarse la cantidad en todo momento que se dispone de dicho producto, en el stock.
- Para agregar un producto al stock de una sucursal, se debe realizar desde el listado de sucursales o desde los detalles de una sucursal. Al invocar el manejo del stock, ya debe quedar implicita la sucursal sobre la cual se trabaja y se debe seleccionar que producto agregar, de los no agregados previamente.
- Para manejar las cantidades de un producto ya existente, se podrá hacer directamente, desde el listado de stock con una entrada de cantidad y un botón de actualizar.

**Carrito**
- El carrito se crea automaticamente con la creación de un cliente, en estado activo. Independientemente de si fué auto-registración o creado por un empleado.
- Solo puede haber un carrito activo por usuario en el sistema.
- Un carrito que no está activo, no puede modificarse en ningún aspecto.
- No se puede eliminar carritos.
- El carrito, se desactiva al momento de realizarse una compra de manera automatica.
- Al vaciar el carrito, se eliminan todos los CarritoItems y datos que sean necesarios.
- El subtotal de Carrito y CarritoItem, es un dato calculado.

**CarritoItem**
- El valor unitario del carritoItem, debe tomar el precio que tenga vigente el producto y mantenerlo mientras esté en el carrito, como compromiso de la empresa para con el cliente (Congela el precio). Si el cliente, remueve el producto del carrito, pierde este beneficio. Por ahora no hay fecha de caducidad de esta promoción.
- El subtotal, debe ser una propiedad calculada, en base a la cantidad x el valor unitario.

**Compra**
- Al generarse la compra, se validará si hay disponibles en el stock de la sucursal que seleccionó el cliente todos los items y cantidades que tiene en el carrito.
	- Si hay stock, disminuye el stock correspondiente y crea la compra.
	- Si no hay stock, verifica en otras locaciones (solo si no hay en la sucursal original) si hay stock.
		- Si hay en alguna, propone las sucursales que tienen stock o indica que no hay en stock en ninguna.
	- Puede seleccionar una de las nuevas sucursales propuestas o cancelar la compra, en tal caso vacía el carrito con un mensaje de advertencia previo. 
	- Si seleccionó una nueva sucursal, finaliza la compra con esta nueva sucursal.
- Se le muestra le da las gracias al cliente con un mensaje cordial y se le dá el código de compra y los datos de la Sucursal que eligió y un detalle de los ítems comprados.
- Al generarse la compra efectivamente, el carrito que tiene asociado, pasa a estar en estado Inactivo y se crea un nuevo carrito activo.
- El total de la compra debe estar persistido.
- No se pueden eliminar las compras.

**Aplicación General**
- Información institucional.
- Se deben mostrar los productos por categoría (filtro).
- Los productos que están deshabilitados, deben visualizarse como Pausados. Independientemente, de que haya o no en stock.
- Los accesos a las funcionalidades y/o capacidades, debe estar basada en los roles que tenga cada individuo.
- No se debe poder repetir Producto.Nombre, Categoria.Nombre, Sucursal.Nombre, Persona.DNI y Marca.Nombre.

`
Nota: El negocio tiene lugar y posibilidades de tener un stock ilimitado y cada sucursal está preparado para vender cualquier producto, por lo cual esto no implica restricciones.
`
