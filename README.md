# TiendaBarrio

1.
Nombre del proyecto: TiendaBarrio

Caso: Tienda de barrio

Integrantes: Jhonier Marmol, Diego Sepulveda

Roles: Jhonier Marmol: Modelos y datos + Servicios
Diego Sepulveda: Lider tecnico + ventanas y documentacion

2. 
Funcionalidades (CRUD):
Categorias: crear, listar, editar y eliminar categorias (nombre, descripción)
Productos: crear, listar, editar y eliminar productos (nombre, precio, stock, categoría elegida desde un ComboBox)
Validaciones con encapsulamiento: nombre obligatorio, precio > 0, stock ≥ 0, categoría obligatoria
La app nunca se cierra por un dato inválido: se muestran mensajes y se conserva el formulario abierto

Reportes con LINQ (2 mínimos, dejamos 3):
Productos por categoría (GroupBy): cuántos productos hay en cada categoría
Productos con stock bajo (Where): productos con stock por debajo de un umbral (ej. ≤ 5)
Precio promedio por categoría (Average + GroupBy)

Formularios:
Formulario Qué hace
FormPrincipal	Menú con botones: Categorías, Productos, Reportes, Salir
FormCategoria	CRUD de categorías (DataGridView + campos)
FormProducto CRUD de productos + ComboBox de categoría + validaciones
FormReportes Muestra los 2–3 reportes LINQ (botones o pestañas)

3.Reparto de archivos:
Jhonier Marmol: Modelos/Datos + Servicios
Diego Sepulveda: Líder técnico
La documentación/ventanas se comparte, jhonier también es dueño de un formulario para cumplir "todos programan"

Diego Sepulveda: Líder técnico + ventanas + documentación
Archivo / clase	Capa
Tienda.sln, Tienda.Escritorio.csproj (y referencias entre proyectos) Solución
Paquetes NuGet: Microsoft.EntityFrameworkCore.Sqlite, Microsoft.EntityFrameworkCore.Design Setup
AppDbContext.cs	Datos
FormPrincipal.cs Escritorio
FormCategoria.cs Escritorio
FormReportes.cs	Escritorio
README.md (descripción, integrantes, cómo ejecutar, captura) Documentación

Jhonier Marmol: Modelos/Datos + Servicios + un formulario
Archivo / clase	Capa
Categoria.cs	Modelos
Producto.cs	Modelos
IRepositorio.cs (interfaz genérica)	Datos
RepositorioBase.cs	Datos
CategoriaRepositorio.cs	Datos
ProductoRepositorio.cs	Datos
ProductoServicio.cs (validaciones/reglas)	Servicios
ReportesServicio.cs (los LINQ)	Servicios
FormProducto.cs (CRUD + ComboBox)	Escritorio
Commits: cada uno sube sus archivos con mensajes claros

4. Las dos tablas y su relacion:
# Tabla Categorias:

| Columna   | Tipo    | Restriccion          |
|--------------------------------------------|
| id        | `Int`   | `PK, Autoincremental`|
| Nombre    | `String`| `obligatorio, único` |
|Descripcion|	`String`|	`opcional`           |

# Tabla productos:

| Columna	  |Tipo	    |Restricción                      |
|-------------------------------------------------------|
|Id         |	`int`   |	`PK, autoincremental`           |
| Nombre	  |`int`    |	`obligatorio`                   |
|Precio	    |`decimal`|	`> 0`                           | 
|Stock	    |`int`	  |`≥ 0`                            |
|CategoriaId|`int`	  |`FK - Categorias.Id, obligatorio`|

Relación: 
Una Categoría tiene muchos Productos (1 → N).
Un Producto pertenece a una sola Categoría (N → 1).
