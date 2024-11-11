CREATE DATABASE  IF NOT EXISTS `colchoneria` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `colchoneria`;
-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: colchoneria
-- ------------------------------------------------------
-- Server version	8.0.3-rc-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_aplicaciones`
--

DROP TABLE IF EXISTS `tbl_aplicaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_aplicaciones` (
  `Pk_id_aplicacion` int(11) NOT NULL,
  `nombre_aplicacion` varchar(50) NOT NULL,
  `descripcion_aplicacion` varchar(150) NOT NULL,
  `estado_aplicacion` tinyint(4) DEFAULT '0',
  PRIMARY KEY (`Pk_id_aplicacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_aplicaciones`
--

LOCK TABLES `tbl_aplicaciones` WRITE;
/*!40000 ALTER TABLE `tbl_aplicaciones` DISABLE KEYS */;
INSERT INTO `tbl_aplicaciones` VALUES (1000,'MDI SEGURIDAD','PARA SEGURIDAD',1),(1001,'Mant. Usuario','PARA SEGURIDAD',1),(1002,'Mant. Aplicación','PARA SEGURIDAD',1),(1003,'Mant. Modulo','PARA SEGURIDAD',1),(1004,'Mant. Perfil','PARA SEGURIDAD',1),(1101,'Asign. Modulo Aplicacion','PARA SEGURIDAD',1),(1102,'Asign. Aplicacion Perfil','PARA SEGURIDAD',1),(1103,'Asign. Perfil Usuario','PARA SEGURIDAD',1),(1201,'Pcs. Cambio Contraseña','PARA SEGURIDAD',1),(1301,'Pcs. BITACORA','PARA SEGURIDAD',1),(2000,'MDI LOGISTICA','PARA LOGISTICA',1),(3000,'MDI COMPRAS Y VENTAS','PARA COMPRAS Y VENTAS',1),(5000,'MDI PRODUCCIÓN','PARA PRODUCCIÓN',1),(6000,'MDI NOMINAS','PARA NOMINAS',1),(6001,'Mant. Trabajadores','PARA NOMINAS',1),(6002,'Mant. Puestos de Trabajo','PARA NOMINAS',1),(6003,'Mant. Departamentos','PARA NOMINAS',1),(6004,'Mant. Contratos','PARA NOMINAS',1),(6005,'Mant. Percepciones','PARA NOMINAS',1),(6006,'Mant. Horas Extras','PARA NOMINAS',1),(6007,'Mant. Faltas','PARA NOMINAS',1),(6008,'Mant. Anticipos','PARA NOMINAS',1),(6101,'Asgn. Puesto - Depto.','PARA NOMINAS',1),(6102,'Asgn. Puesto - Trabajador','PARA NOMINAS',1),(6103,'Asgn. Contrato Trabajador','PARA NOMINAS',1),(6104,'Asgn. Prestaciones Contrato','PARA NOMINAS',1),(6105,'Asgn. Prestaciones Individual','PARA NOMINAS',1),(6106,'Prcs. Nomina','PARA NOMINAS',1),(6107,'Cálculo liquidaciones','PARA NÓMINAS',1),(6201,'Rpt. Planillas','PARA NOMINAS',1),(6202,'Rpt. Contratos','PARA NOMINAS',1),(6203,'Rpt. Trabajadores','PARA NOMINAS',1),(6301,'ACCESO SEGURIDAD','PARA NOMINAS',1),(7000,'MDI BANCOS','PARA BANCOS',1),(8000,'MDI CONTRABILIDAD','PARA CONTRABILIDAD',1);
/*!40000 ALTER TABLE `tbl_aplicaciones` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-11 10:59:54
