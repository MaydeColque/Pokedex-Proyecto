# Pokédex App 

Una aplicación donde podrás guardar información acerca de tus Pokémons favoritos. Desarrollada en C#, utiliza .Net Framework para la interfaz de usuario y SQL Server para obtener información sobre los Pokémon.

## Características Principales
- **Nuevo Pokémon:** Podrás ingresar nuevos pokémons a tu collección.
- **Modificar datos:** de forma rápida y sencilla.
- **Eliminar:** Es posible enviar a los pokémons que ya no deseas a la papelera.
- **Papelera:** Desde aquí podrás recuperar tus pokémons o eliminarlos definitivamente.
- **Búsqueda de Pokémon:** Permite buscar Pokémons por nombre o número de Pokédex.
- **Información:** Proporciona detalles almacenados sobre cada Pokémon, como tipo, debilidad y una breve descripción de cada uno.
- **Interfaz Amigable:** Diseño intuitivo y fácil de usar.

## Tecnologías Utilizadas

- **Lenguaje:** C#
- **.Net Framework:** Utilizado para la interfaz de usuario.
- **SQL Server:** Base de datos utilizada para obtener información sobre los Pokémon.

## Requisitos de Instalación

- **SQL Server:** Asegúrate de tener SQL Server instalado y configurado en tu sistema.
- **Visual Studio:** Para compilar y ejecutar la aplicación.

## Configuración de la Base de Datos

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

## Uso

1. Clona el repositorio a tu máquina local.
2. Abre el proyecto en Visual Studio.
3. Configura la base de datos según las instrucciones anteriores.
4. Compila y ejecuta la aplicación.

## Información Adicional
Este proyecto fue creado con fines de aprendizaje. Es menester comprender que su principal objetivo es construir conocimiento.
