USE moduloseguridad;

CREATE TABLE TBL_CONFIGURACION_RPT(
 ID_CONFIGURACION INT(12) NOT NULL,
 NOMBRE VARCHAR(50) NOT NULL,
 USER VARCHAR(50) DEFAULT NULL,
 PASSWORD VARCHAR(100) DEFAULT NULL,
 PUERTO VARCHAR(3) DEFAULT NULL,
 RUTA VARCHAR(100) NOT NULL,
 ESTADO INT(2) DEFAULT 1
);
ALTER TABLE TBL_CONFIGURACION_RPT ADD CONSTRAINT PRIMARY KEY (ID_CONFIGURACION);

CREATE TABLE TBL_REPORTE(
 ID_REPORTE INT(12) NOT NULL,
 ID_CONFIGURACION INT(12) NOT NULL,
 NOMBRE VARCHAR(50) NOT NULL, 
 FILENAME VARCHAR(100) NOT NULL,
 ESTADO INT(2) NOT NULL
);
ALTER TABLE TBL_REPORTE ADD CONSTRAINT PK_REPORTE PRIMARY KEY (ID_REPORTE);
ALTER TABLE TBL_REPORTE ADD CONSTRAINT FK_RPT_CONFIGURACION FOREIGN KEY (ID_CONFIGURACION)
REFERENCES TBL_CONFIGURACION_RPT (ID_CONFIGURACION);

CREATE TABLE TBL_RPT_APP(
 ID_REPORTE INT(12) NOT NULL,
 ID_APLICACION INT(11) NOT NULL,
 ID_MODULO INT(11) NOT NULL,
 ESTADO INT(2) NOT NULL
);
ALTER TABLE TBL_RPT_APP ADD CONSTRAINT PK_RPT_APP PRIMARY KEY (ID_REPORTE, ID_APLICACION, ID_MODULO);
ALTER TABLE TBL_RPT_APP ADD CONSTRAINT FK_RPT_APP_REPORTE FOREIGN KEY (ID_REPORTE)
REFERENCES TBL_REPORTE (ID_REPORTE);
ALTER TABLE TBL_RPT_APP ADD CONSTRAINT FK_RPT_APP_APLICACION FOREIGN KEY (ID_APLICACION)
REFERENCES TBL_APLICACION (PK_ID_APLICACION);
ALTER TABLE TBL_RPT_APP ADD CONSTRAINT FK_RPT_APP_MODULO FOREIGN KEY (ID_MODULO)
REFERENCES TBL_MODULO (PK_ID_MODULO);

CREATE TABLE TBL_RPT_MDL(
 ID_REPORTE INT(12) NOT NULL,
 ID_MODULO INT(11) NOT NULL,
 ESTADO INT(2) NOT NULL
);
ALTER TABLE TBL_RPT_MDL ADD CONSTRAINT PK_RPT_MDL PRIMARY KEY (ID_REPORTE, ID_MODULO);
ALTER TABLE TBL_RPT_MDL ADD CONSTRAINT FK_RPT_MDL_REPORTE FOREIGN KEY (ID_REPORTE)
REFERENCES TBL_REPORTE (ID_REPORTE);
ALTER TABLE TBL_RPT_MDL ADD CONSTRAINT FK_RPT_MDL_MODULO FOREIGN KEY (ID_MODULO)
REFERENCES TBL_MODULO (PK_ID_MODULO);