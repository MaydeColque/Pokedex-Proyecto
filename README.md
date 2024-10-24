# 💎 Pokédex App 

Una aplicación donde podrás guardar tus Pokémon favoritos. Desarrollada en C#, utiliza .Net Framework para la interfaz de usuario y SQL Server para obtener información sobre los Pokémon.

## 📌 Características Principales

- **Nuevo Pokémon:** Permite agregar pokémon a tu colección.
- **Modificar datos:** Edita la información de un pokémon de manera rápida.
- **Eliminar:** Puedes enviar los pokémon que ya no necesites a la papelera.
- **Papelera:** Aquí los pokémon eliminados permanecerán almacenados hasta que decidas restaurarlos o eliminarlos permanentemente.
- **Búsqueda de Pokémon:** Tienes la posibilidad de buscar un pokémon por nombre o número.
- **Información:** Muestra el nombre, número, imagen, tipo, debilidad y descripción de cada pokémon almacenado.
- **Interfaz Amigable:** Un diseño intuitivo y fácil de usar para mejorar la experiencia del usuario.

🔗Clic en el enlace para aprender cómo usar la app paso a paso: <a href="https:&#x2F;&#x2F;www.canva.com&#x2F;design&#x2F;DAGTrC18hzY&#x2F;ODd5pvI7iGuMqjxyfXC6_Q&#x2F;view?utm_content=DAGTrC18hzY&amp;utm_campaign=designshare&amp;utm_medium=embeds&amp;utm_source=link" target="_blank">💻 Pokédex | Aplicación de Escritorio</a>

### ✅ Validaciones

- Al **agregar** o **modificar** un pokémon:
  - Verifica que el número y el nombre no estén duplicados en la base de datos.
  - Comprueba que el número ingresado sea válido (es decir, que sea un número).
  - Es obligatorio ingresar tanto el nombre como el número.
De no cumplirse con estas condiciones no permite que la operación avance.
  
- Al **eliminar** desde la papelera:
  - Solicita confirmación antes de eliminar un pokémon permanentemente.
  - La papelera se desactiva cuando está vacía y se reactivará cuando haya al menos un pokémon eliminado.
  
- En la **búsqueda de pokémon**:
  - Si no se encuentran coincidencias por nombre o número, se notifica al usuario con un mensaje emergente.

- Para realizar cualquier operación, ya sea agregar, modificar o eliminar, verifica que se haya seleccionado un pokémon. Si no es así, emite un mensaje de advertencia indicando que no se ha seleccionado ningún pokémon.
 
## 🔴 Tecnologías Utilizadas

- **C#:** Utilizado para manejar la lógica de negocio y las interacciones con la base de datos.
- **.Net Framework:** Utilizado para la interfaz de usuario.
- **SQL Server:** Base de datos utilizada para obtener información sobre los Pokémon.

## 🟢Requisitos de Instalación

- **SQL Server:** Asegúrate de tener SQL Server instalado y configurado en tu sistema.
- **Visual Studio:** Para compilar y ejecutar la aplicación.

## ⚙ Configuración de la Base de Datos

1. Abre SQL Server.
2. Inicia una "Query" nueva.
3. Copia y pega el siguiente script:
~~~   
USE [master]
GO
/****** Creacion de la BD******/
CREATE DATABASE [POKEMON_DB]
GO

USE POKEMON_DB;
GO			
-- Creacion de las tablas
CREATE TABLE [dbo].[ELEMENTOS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](10) NULL
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[POKEMONS](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](300) NULL,
	[UrlImagen] [nvarchar](200) NULL,
	[IdTipo] [int] NULL,
	[IdDebilidad] [int] NULL,
	[IdEvolucion] [int] NULL,
	[Activo] [int] NULL
) ON [PRIMARY]
GO
-- Ingreso de datos por Defecto
INSERT INTO ELEMENTOS
VALUES
	('Planta'),
	('Fuego'),
	('Agua'),
	('Eléctrico'),
	('Tierra');

INSERT INTO POKEMONS(Numero, Nombre, Descripcion, UrlImagen, IdTipo, IdDebilidad, IdEvolucion, Activo)
VALUES
    ('1', 'Bulbasaur', 'Este Pokémon nace con una semilla en el lomo, que brota con el paso del tiempo.', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/001.png', 1,2,0,1),
	('2', 'Ivysaur', 'Cuando le crece bastante el bulbo del lomo, pierde la capacidad de erguirse sobre las patas traseras.', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/002.png', 1,3,0,1),
	('25', 'Pikachu', 'Cuando se enfada, este Pokémon descarga la energía que almacena en el interior de las bolsas de las mejillas.', 'https://assets.pokemon.com/assets/cms2/img/pokedex/full/025.png', 4,1,0,1);
GO
~~~
4. **Ejecuta** el script SQL proporcionado para crear la estructura de la base de datos. Y listo! 👍

## 🔓 Uso

1. Clona el repositorio a tu máquina local.
2. Abre el proyecto en Visual Studio.
3. Configura la base de datos según las instrucciones anteriores.
4. Compila y ejecuta la aplicación.

## 🛑 Información Adicional❕
Este proyecto fue creado con fines de aprendizaje. Es menester comprender que su principal objetivo es construir conocimiento.
