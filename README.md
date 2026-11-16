# ApiProductos

API REST de ejemplo para consultar y administrar productos. Está construida con
ASP.NET Core y expone el controlador `ProductoController` bajo la ruta
`/api/Producto`.

## Funcionamiento

La API mantiene una colección de productos en memoria y permite consultar,
crear, actualizar y eliminar registros mediante operaciones HTTP. Incluye
Swagger/OpenAPI para explorar y probar los endpoints desde el navegador.

## Requisitos

- .NET SDK 9.0 o posterior.

## Instalación y ejecución

```bash
git clone https://github.com/Reclax/ApiProductos.git
cd ApiProductos
dotnet restore
dotnet run
```

Al iniciar, revisa la URL mostrada por .NET para abrir Swagger, normalmente
`https://localhost:7xxx/swagger` o `http://localhost:5xxx/swagger`.

## Estructura

- `Program.cs`: configuración de la aplicación y Swagger.
- `Controllers/ProductoController.cs`: endpoints REST.
- `Models/Producto.cs`: modelo de producto.

Los datos se reinician al detener la aplicación porque no se utiliza una base
de datos persistente.
