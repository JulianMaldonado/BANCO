--------------------------------------------------------
-- Archivo creado  - lunes-octubre-21-2013   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Sequence SEQ_IDBANCO
--------------------------------------------------------

   CREATE SEQUENCE  SEQ_IDBANCO  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_IDCAJERO
--------------------------------------------------------

   CREATE SEQUENCE  SEQ_IDCAJERO  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_IDTIPO
--------------------------------------------------------

   CREATE SEQUENCE  SEQ_IDTIPO  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_IDTRANSACCION
--------------------------------------------------------

   CREATE SEQUENCE  SEQ_IDTRANSACCION  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Sequence SEQ_IDUSUARIO
--------------------------------------------------------

   CREATE SEQUENCE  SEQ_IDUSUARIO  MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 NOCACHE  ORDER  NOCYCLE ;
--------------------------------------------------------
--  DDL for Table BANCO
--------------------------------------------------------

  CREATE TABLE BANCO 
   (	IDBANCO NUMBER(38,0), 
	NOMBRE VARCHAR2(200 BYTE), 
	DIRECCION VARCHAR2(200 BYTE), 
	TELEFONO VARCHAR2(200 BYTE), 
	CONN VARCHAR2(300 BYTE), 
	RANGOI NUMBER(38,0), 
	RANGOF NUMBER(38,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE SYSTEM ;
--------------------------------------------------------
--  DDL for Table CAJERO
--------------------------------------------------------

  CREATE TABLE CAJERO 
   (	IDCAJERO NUMBER(38,0), 
	NOMBRE VARCHAR2(200 BYTE), 
	DIRECCION VARCHAR2(200 BYTE), 
	ESTADO VARCHAR2(50 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE SYSTEM ;
--------------------------------------------------------
--  DDL for Table TIPO
--------------------------------------------------------

  CREATE TABLE TIPO 
   (	IDTIPO NUMBER(38,0), 
	DETALLE VARCHAR2(100 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE SYSTEM ;
--------------------------------------------------------
--  DDL for Table TRANSACCION
--------------------------------------------------------

  CREATE TABLE TRANSACCION 
   (	IDBANCO NUMBER(38,0), 
	IDCAJERO NUMBER(38,0), 
	IDTRANSACCION NUMBER(38,0), 
	NOTARJETA NUMBER(38,0), 
	TIPO NUMBER(38,0), 
	MONTO NUMBER(38,2), 
	ESTADO VARCHAR2(50 BYTE), 
	FECHA DATE, 
	RECIBO VARCHAR2(1 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE SYSTEM ;
--------------------------------------------------------
--  DDL for Table USUARIO
--------------------------------------------------------

  CREATE TABLE USUARIO 
   (	ID NUMBER(38,0), 
	USUARIO VARCHAR2(100 BYTE), 
	PASS VARCHAR2(200 BYTE), 
	IDBANCO NUMBER(38,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE SYSTEM ;
REM INSERTING into BANCO
SET DEFINE OFF;
REM INSERTING into CAJERO
SET DEFINE OFF;
REM INSERTING into TIPO
SET DEFINE OFF;
REM INSERTING into TRANSACCION
SET DEFINE OFF;
REM INSERTING into USUARIO
SET DEFINE OFF;
--------------------------------------------------------
--  Constraints for Table USUARIO
--------------------------------------------------------

  ALTER TABLE USUARIO ADD PRIMARY KEY (ID)
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE SYSTEM  ENABLE;
--------------------------------------------------------
--  Constraints for Table BANCO
--------------------------------------------------------

  ALTER TABLE BANCO ADD PRIMARY KEY (IDBANCO)
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE SYSTEM  ENABLE;
--------------------------------------------------------
--  Constraints for Table TRANSACCION
--------------------------------------------------------

  ALTER TABLE TRANSACCION ADD PRIMARY KEY (IDBANCO, IDCAJERO, IDTRANSACCION)
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE SYSTEM  ENABLE;
--------------------------------------------------------
--  Constraints for Table TIPO
--------------------------------------------------------

  ALTER TABLE TIPO ADD PRIMARY KEY (IDTIPO)
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE SYSTEM  ENABLE;
--------------------------------------------------------
--  Constraints for Table CAJERO
--------------------------------------------------------

  ALTER TABLE CAJERO ADD PRIMARY KEY (IDCAJERO)
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE SYSTEM  ENABLE;



--------------------------------------------------------
--  Ref Constraints for Table TRANSACCION
--------------------------------------------------------

  ALTER TABLE TRANSACCION ADD CONSTRAINT FK_TRANSACCION_BANCO_1 FOREIGN KEY (IDBANCO)
	  REFERENCES BANCO (IDBANCO) ENABLE;
  ALTER TABLE TRANSACCION ADD CONSTRAINT FK_TRANSACCION_CAJERO_1 FOREIGN KEY (IDCAJERO)
	  REFERENCES CAJERO (IDCAJERO) ENABLE;
  ALTER TABLE TRANSACCION ADD CONSTRAINT FK_TRANSACCION_TIPO_1 FOREIGN KEY (TIPO)
	  REFERENCES TIPO (IDTIPO) ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table USUARIO
--------------------------------------------------------

  ALTER TABLE USUARIO ADD CONSTRAINT FK_USUARIO_BANCO_1 FOREIGN KEY (IDBANCO)
	  REFERENCES BANCO (IDBANCO) ENABLE;
