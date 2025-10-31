CREATE DATABASE IF NOT EXISTS pokedex_db;

USE pokedex_db;

CREATE TABLE pokemones (
    Id INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    Tipo VARCHAR(50),
    Altura DOUBLE,
    Peso DOUBLE,
    Habilidad VARCHAR(100),
    Activo BOOLEAN DEFAULT 1
);

select * from pokemones;

Drop table pokedex_db.pokemones;