--USE [ControlHardwareSoftware]
--GO

--INSERT INTO [dbo].[Usuario] ([nombre], [cargo], [departamento], [correo], [telefono])
--VALUES 
--('Juan Pérez', 'Gerente de IT', 'Sistemas', 'juan.perez@empresa.com', '+505 8888-1111'),
--('María López', 'Contadora Senior', 'Contabilidad', 'maria.lopez@empresa.com', '+505 8888-2222'),
--('Carlos Ruiz', 'Analista de Soporte', 'Sistemas', 'carlos.ruiz@empresa.com', '+505 8888-3333'),
--('Ana García', 'Directora de RRHH', 'Recursos Humanos', 'ana.garcia@empresa.com', '+505 8888-4444'),
--('Roberto Gómez', 'Ejecutivo de Ventas', 'Comercial', 'roberto.gomez@empresa.com', '+505 8888-5555'),
--('Lucía Méndez', 'Asistente Administrativo', 'Administración', 'lucia.mendez@empresa.com', '+505 8888-6666'),
--('Ricardo Torres', 'Desarrollador Web', 'Sistemas', 'ricardo.torres@empresa.com', '+505 8888-7777'),
--('Elena Martínez', 'Jefa de Logística', 'Operaciones', 'elena.martinez@empresa.com', '+505 8888-8888'),
--('Fernando Castro', 'Analista Financiero', 'Contabilidad', 'fernando.castro@empresa.com', '+505 8888-9999'),
--('Sofía Herrera', 'Diseñadora Gráfica', 'Marketing', 'sofia.herrera@empresa.com', '+505 8888-0000');
--GO

--USE [ControlHardwareSoftware]
--GO

--INSERT INTO [dbo].[Usuario] ([nombre], [cargo], [departamento], [correo], [telefono])
--VALUES 
--('Alejandro Vargas', 'Especialista en Redes', 'Sistemas', 'alejandro.vargas@empresa.com', '+505 8888-1212'),
--('Beatriz Solís', 'Auditora Interna', 'Finanzas', 'beatriz.solis@empresa.com', '+505 8888-2323'),
--('Gabriel Zelaya', 'Soporte Técnico L2', 'Sistemas', 'gabriel.zelaya@empresa.com', '+505 8888-3434'),
--('Isabel Castillo', 'Analista de Nómina', 'Recursos Humanos', 'isabel.castillo@empresa.com', '+505 8888-4545'),
--('Marcos Juárez', 'Gerente de Proyectos', 'Operaciones', 'marcos.juarez@empresa.com', '+505 8888-5656'),
--('Patricia Núñez', 'Asesora Legal', 'Legal', 'patricia.nunez@empresa.com', '+505 8888-6767'),
--('Samuel Espinoza', 'Community Manager', 'Marketing', 'samuel.espinoza@empresa.com', '+505 8888-7878'),
--('Valeria Rivas', 'Asistente de Gerencia', 'Administración', 'valeria.rivas@empresa.com', '+505 8888-8989'),
--('Héctor Blandón', 'Encargado de Compras', 'Logística', 'hector.blandon@empresa.com', '+505 8888-9090'),
--('Natalia Pasos', 'Analista de Datos', 'Sistemas', 'natalia.pasos@empresa.com', '+505 8888-0101');
--GO


--USE [ControlHardwareSoftware]
--GO

--INSERT INTO [dbo].[Ubicacion] ([nombre_area], [direccion], [descripcion])
--VALUES 
--('Oficina Central', 'Piso 1, Ala Norte', 'Oficinas administrativas principales'),
--('Sala de Servidores', 'Sótano, Sector A', 'Cuarto frío con control de acceso'),
--('Departamento de Contabilidad', 'Piso 2, Oficina 204', 'Área de finanzas y auditoría'),
--('Recursos Humanos', 'Piso 1, Ala Sur', 'Atención al personal y reclutamiento'),
--('Sala de Conferencias A', 'Piso 3, Salón Principal', 'Equipada para videoconferencias'),
--('Área de Desarrollo', 'Piso 2, Espacio Abierto', 'Estaciones de trabajo para programadores'),
--('Recepción', 'Planta Baja, Entrada Principal', 'Módulo de atención a visitantes'),
--('Bodega de IT', 'Sótano, Sector B', 'Resguardo de equipo nuevo y repuestos'),
--('Marketing y Diseño', 'Piso 3, Oficina 305', 'Área creativa y publicidad'),
--('Sucursal Externa - Norte', 'Km 12 Carretera Norte', 'Oficina de enlace regional');
--GO

--USE [ControlHardwareSoftware]
--GO

--INSERT INTO [dbo].[Equipo] 
--([codigo_inventario], [tipo_equipo], [marca], [modelo], [numero_serie], [fecha_compra], [estado], [id_usuario], [id_ubicacion])
--VALUES 
--('EQ-001', 'Laptop', 'Dell', 'Latitude 5420', 'SN-DELL-9912', '2023-01-15', 'Activo', 1, 1),
--('EQ-002', 'Desktop', 'HP', 'EliteDesk 800', 'SN-HP-8823', '2022-11-20', 'Activo', 2, 3),
--('EQ-003', 'Laptop', 'Lenovo', 'ThinkPad T14', 'SN-LEN-7734', '2023-05-10', 'Activo', 7, 6),
--('EQ-004', 'Servidor', 'Dell', 'PowerEdge R740', 'SN-DELL-SRV01', '2021-08-12', 'Activo', 3, 2),
--('EQ-005', 'Laptop', 'Apple', 'MacBook Pro M2', 'SN-AAPL-5545', '2023-09-01', 'Activo', 10, 9),
--('EQ-006', 'Impresora', 'Epson', 'EcoTank L3210', 'SN-EPS-4456', '2022-03-15', 'Activo', 6, 7),
--('EQ-007', 'Desktop', 'Custom', 'Workstation Pro', 'SN-CUST-3367', '2023-02-28', 'Mantenimiento', 9, 6),
--('EQ-008', 'Tablet', 'Samsung', 'Galaxy Tab S8', 'SN-SAM-2278', '2023-06-20', 'Activo', 4, 4),
--('EQ-009', 'Laptop', 'Asus', 'ZenBook 14', 'SN-ASU-1189', '2022-12-05', 'Baja', 5, 8),
--('EQ-010', 'Servidor', 'HP', 'ProLiant DL380', 'SN-HP-SRV02', '2021-05-30', 'Activo', 3, 2);
--GO

--USE [ControlHardwareSoftware]
--GO

--INSERT INTO [dbo].[Componente] ([id_equipo], [tipo_componente], [descripcion], [marca], [modelo], [capacidad])
--VALUES 
--(1, 'Memoria RAM', 'Módulo DDR4 SO-DIMM', 'Crucial', 'Basics', '16GB'),
--(1, 'Disco Duro', 'SSD M.2 NVMe', 'Samsung', '980 Pro', '512GB'),
--(2, 'Procesador', 'Intel Core i5', 'Intel', '12400', '3.5 GHz'),
--(2, 'Memoria RAM', 'DDR4 DIMM', 'Kingston', 'Fury', '8GB'),
--(3, 'Batería', 'Litio-Ion interna', 'Lenovo', 'Standard', '50Wh'),
--(3, 'Memoria RAM', 'DDR4 Soldered', 'Lenovo', 'Onboard', '16GB'),
--(4, 'Disco Duro', 'SAS Hot Plug', 'Seagate', 'Savvio', '1.2TB'),
--(4, 'Disco Duro', 'SAS Hot Plug', 'Seagate', 'Savvio', '1.2TB'),
--(4, 'Memoria RAM', 'ECC Registered', 'Hynix', 'Server RAM', '32GB'),
--(4, 'Fuente Poder', 'Redundante 750W', 'Dell', 'Titanium', '750W'),
--(5, 'Procesador', 'Apple M2 Chip', 'Apple', 'M2 8-Core', 'N/A'),
--(5, 'Disco Duro', 'SSD Integrado', 'Apple', 'NAND Flash', '512GB'),
--(7, 'Tarjeta Video', 'NVIDIA RTX 3060', 'MSI', 'Ventus', '12GB'),
--(7, 'Fuente Poder', '80 Plus Gold', 'EVGA', 'SuperNova', '650W'),
--(8, 'Pantalla', 'Super AMOLED', 'Samsung', 'Digitizer', '11"'),
--(10, 'Controladora', 'Smart Array RAID', 'HP', 'P408i-a', '2GB Cache'),
--(10, 'Disco Duro', 'SSD Enterprise', 'Intel', 'D3-S4510', '960GB'),
--(10, 'Memoria RAM', 'DDR4 SmartMemory', 'HP', 'ECC RDIMM', '64GB'),
--(6, 'Cabezal', 'PrecisionCore Printhead', 'Epson', 'Heat-Free', 'N/A'),
--(2, 'Disco Duro', 'HDD SATA', 'Western Digital', 'Blue', '1TB');
--GO


--USE [ControlHardwareSoftware]
--GO

--INSERT INTO [dbo].[Software] ([nombre], [version_actual], [tipo_software], [fabricante])
--VALUES 
--('Windows 11 Pro', '23H2', 'Sistemas Operativos', 'Microsoft'),
--('Microsoft Office 365', '16.0', 'Ofimática', 'Microsoft'),
--('Adobe Photoshop', '2024 (25.1)', 'Diseño', 'Adobe'),
--('Visual Studio Code', '1.85', 'Desarrollo', 'Microsoft'),
--('SQL Server Management Studio', '19.2', 'Bases de Datos', 'Microsoft'),
--('Kaspersky Endpoint Security', '12.3', 'Seguridad', 'Kaspersky Lab'),
--('Google Chrome', '120.0', 'Navegador', 'Google'),
--('AutoCAD', '2024', 'Diseño', 'Autodesk'),
--('Slack', '4.35', 'Comunicación', 'Salesforce'),
--('WinRAR', '6.24', 'Utilidad', 'win.rar GmbH');
--GO

--USE [ControlHardwareSoftware]
--GO

--INSERT INTO [dbo].[Licencia] 
--([id_software], [tipo_licencia], [clave_licencia], [cantidad_licencias], [fecha_compra], [fecha_vencimiento], [proveedor], [estado])
--VALUES 
--(1, 'OEM', 'W269N-WFGWX-YVC9B-4J6C9-T83GX', 50, '2023-01-10', '2025-12-31', 'Microsoft Partner', 'Activa'),
--(2, 'Suscripción Anual', 'OFFICE-365-SUBS-2024', 100, '2024-01-01', '2025-01-01', 'SoftwareOne', 'Activa'),
--(3, 'Suscripción Mensual', 'ADOBE-CC-7788-9900', 10, '2024-02-15', '2024-03-15', 'Adobe Direct', 'Activa'),
--(4, 'Open Source', 'FREE-LICENSE-VSCODE', 999, '2023-01-01', NULL, 'GitHub', 'Activa'),
--(5, 'Enterprise', 'SQL-SRV-ENT-2022-X1', 5, '2022-05-20', NULL, 'Dell Technologies', 'Activa'),
--(6, 'Corporativa', 'KASP-SEC-CORP-5544', 150, '2023-06-12', '2024-06-12', 'Kaspersky Lab', 'Activa'),
--(7, 'Freeware', 'GOOGLE-CHROME-FREE', 999, '2023-01-01', NULL, 'Google Inc', 'Activa'),
--(8, 'Perpetua', 'ACAD-2024-8899-7722', 15, '2023-11-05', NULL, 'Autodesk Store', 'Activa'),
--(9, 'Standard', 'SLACK-PRO-PLAN-01', 50, '2024-01-20', '2025-01-20', 'Slack Technologies', 'Activa'),
--(10, 'Retail', 'WINRAR-624-X86-X64', 20, '2023-08-15', NULL, 'RARLAB', 'Activa');
--GO

--USE [ControlHardwareSoftware]
--GO

--INSERT INTO [dbo].[Software_Instalado] 
--([id_equipo], [id_software], [id_licencia], [version_instalada], [fecha_instalacion], [estado], [requiere_actualizacion])
--VALUES 
--(1, 1, 1, '21H2', '2023-01-20', 'Activo', 1), -- Windows 11 en Laptop Dell
--(1, 2, 2, '16.0', '2023-01-21', 'Activo', 0), -- Office en Laptop Dell
--(2, 1, 1, '22H2', '2022-11-25', 'Activo', 0), -- Windows 11 en Desktop HP
--(3, 4, 4, '1.80', '2023-05-15', 'Activo', 1), -- VS Code en Lenovo
--(4, 5, 5, '19.0', '2021-08-20', 'Activo', 0), -- SQL Server en Servidor Dell
--(5, 3, 3, '2023', '2023-09-05', 'Activo', 1), -- Photoshop en MacBook
--(7, 8, 8, '2023', '2023-03-01', 'Activo', 0), -- AutoCAD en Workstation
--(8, 7, 7, '115.0', '2023-06-25', 'Activo', 1),-- Chrome en Tablet
--(10, 6, 6, '12.1', '2021-06-01', 'Activo', 0),-- Kaspersky en Servidor HP
--(2, 9, 9, '4.30', '2022-11-26', 'Activo', 1); -- Slack en Desktop HP
--GO


--USE [ControlHardwareSoftware]
--GO

--INSERT INTO [dbo].[Actualizacion_Software] 
--([id_software_instalado], [version_anterior], [version_nueva], [fecha_actualizacion], [responsable], [observaciones])
--VALUES 
--(1, '21H1', '21H2', '2023-06-15', 'Carlos Ruiz', 'Actualización de seguridad semestral'),
--(4, '1.75', '1.80', '2023-08-10', 'Ricardo Torres', 'Mejora en plugins de desarrollo'),
--(8, '110.0', '115.0', '2023-09-12', 'Soporte Externo', 'Parche crítico de vulnerabilidad zero-day'),
--(10, '4.20', '4.30', '2023-02-14', 'Carlos Ruiz', 'Nuevas funciones de videollamada habilitadas');
--GO


--USE [ControlHardwareSoftware]
--GO

--INSERT INTO [dbo].[Mantenimiento] 
--([id_equipo], [tipo_mantenimiento], [descripcion_problema], [solucion], [tecnico], [costo], [fecha_mantenimiento], [estado])
--VALUES 
--(1, 'Preventivo', 'Limpieza general y cambio de pasta térmica', 'Se sopleteó y se aplicó MX-4', 'Carlos Ruiz', 25.00, '2023-07-10', 'Completado'),
--(2, 'Correctivo', 'Equipo no enciende', 'Cambio de fuente de poder dañada por picos de voltaje', 'Soporte Externo', 85.50, '2023-03-05', 'Completado'),
--(4, 'Preventivo', 'Revisión de arreglos de discos RAID', 'Todo en orden, se actualizaron firmwares', 'Admin Sistema', 0.00, '2023-01-12', 'Completado'),
--(7, 'Mejora', 'Lentitud en renderizado', 'Instalación de 16GB RAM adicionales', 'Carlos Ruiz', 120.00, '2023-09-20', 'Completado'),
--(9, 'Diagnóstico', 'Pantallazos azules constantes', 'Se detectó falla en sectores del SSD', 'Ricardo Torres', 15.00, '2024-01-05', 'En Proceso'),
--(3, 'Preventivo', 'Limpieza de teclado y pantalla', 'Mantenimiento estético', 'Carlos Ruiz', 10.00, '2023-11-15', 'Completado');
--GO
