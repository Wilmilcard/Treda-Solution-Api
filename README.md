# Treda-Solution-Api
Api de Prueba para Treda Solutions

## Tecnologias usadas
- Visual Studio 2019
- C#
- Entity Frameworks

## Ejecucion:
- 1. Clonar el reporsitorio en Visual Studio (preferiblemente 2019)
- 2. En caso de que no se cuente con la base de datos, se ejecuta desde la `consola de administracion de paquetes` los comandos
-- 2.1. `enable-migrations`
-- 2.2. despues `update-database`
- 3. Se ejecuta el proyecto IIS Express
- 4. la ruta para consumir los controladores son:
-- 4.1. https://localhost:44368/api/Producto
-- 4.2. https://localhost:44368/api/Tienda
- 5. Si se desea hacer pruebas de post, se envian los json en el postman asi:
-- 5.1. para el producto: `{ "Nombre" : "Producto 2", "Descripcion" : "Descripcion producto 2", "Valor" : 45000, "Tienda" : 1, "Imagen" : "/Imagenes/Producto1.jpg" }`
-- 5.2. Para la tienda `{ "Nombre" : "prueba555", "FechaApertura" : "2020-12-31T20:49:10.2186357-05:00" }`
