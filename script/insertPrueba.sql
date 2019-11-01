/*Seguridad*/
INSERT INTO TBL_MODULO VALUES (1, 'MDI', 'na', 1);
INSERT INTO TBL_MODULO VALUES (2, 'Seguridad', 'na', 1);
INSERT INTO TBL_APLICACION VALUES (1, 2, 'BITACORA', 'na', 1);
/*Configuracion carpeta*/
/*INSERT INTO TBL_CONFIGURACION_RPT VALUES (0, 'DMZ', 'usuarioftp', 'ftp', '22', 'compartido\\', 1);*/
INSERT INTO TBL_CONFIGURACION_RPT VALUES (1, 'plantillas', 'C:\\\\Reportes\\\\recursos\\\\', 1);
INSERT INTO TBL_CONFIGURACION_RPT VALUES (2, 'MDI', 'C:\\\\Reportes\\\\MDI\\\\', 1);
INSERT INTO TBL_CONFIGURACION_RPT VALUES (3, 'mdlSeguridad', 'C:\\\\Reportes\\\\Seguridad\\\\', 1);
/*Reportes*/
/*INSERT INTO TBL_REPORTE VALUES (0, 1, 'Prueba', 1, 'Prueba.rpt');*/
INSERT INTO TBL_CARPETA_MDL VALUES (2, 1, 1);
INSERT INTO TBL_CARPETA_MDL VALUES (3, 2, 1);

COMMIT;
