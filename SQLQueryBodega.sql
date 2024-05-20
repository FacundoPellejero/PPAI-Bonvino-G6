-- Conectarse a la instancia de SQL Server y crear una nueva base de datos llamada 'Inventario'
CREATE DATABASE Bonvino;
GO

-- Usar la base de datos recién creada
USE Bonvino;
GO

-- Crear la tabla 'Bodega' con los campos especificados
CREATE TABLE Bodega (
    id INT PRIMARY KEY IDENTITY(1,1), -- Agrega un campo ID como clave primaria autoincremental
    nombre NVARCHAR(100) NOT NULL,
    descripcion NVARCHAR(255) NULL,
    coordenadas NVARCHAR(100) NULL, -- Asumo que las coordenadas se almacenarán como string
    ultimaActualizacion DATETIME NULL,
    periodoActualizacion INT NULL
);
GO


-- Insertar tres registros en la tabla 'Bodega'
INSERT INTO Bodega (nombre, descripcion, coordenadas, ultimaActualizacion, periodoActualizacion)
VALUES 
('Bodega Norton', 'Bodega principal en la ciudad', '40.712776,-74.005974', '2024-03-01', 2), 
('Bodega Colomé', 'Bodega en el norte de la ciudad', '40.748817,-73.985428', '2024-04-01', 1), 
('Bodega Zuccardi', 'Bodega en el sur de la ciudad', '40.730610,-73.935242', '2024-04-20', 3); 

GO



DELETE FROM Bodega;
GO

select * 
from Bodega