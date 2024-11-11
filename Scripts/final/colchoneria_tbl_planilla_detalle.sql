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
-- Table structure for table `tbl_planilla_detalle`
--

DROP TABLE IF EXISTS `tbl_planilla_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_planilla_detalle` (
  `pk_registro_planilla_Detalle` int(11) NOT NULL AUTO_INCREMENT,
  `detalle_total_Percepciones` decimal(10,2) DEFAULT NULL,
  `detalle_total_Deducciones` decimal(10,2) DEFAULT NULL,
  `detalle_total_liquido` decimal(10,2) DEFAULT NULL,
  `fk_clave_empleado` int(11) NOT NULL,
  `fk_id_contrato` int(11) NOT NULL,
  `fk_id_registro_planilla_Encabezado` int(11) NOT NULL,
  `estado` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`pk_registro_planilla_Detalle`),
  KEY `fk_clave_empleado` (`fk_clave_empleado`),
  KEY `fk_id_contrato` (`fk_id_contrato`),
  KEY `fk_id_registro_planilla_Encabezado` (`fk_id_registro_planilla_Encabezado`),
  CONSTRAINT `tbl_planilla_detalle_ibfk_1` FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
  CONSTRAINT `tbl_planilla_detalle_ibfk_2` FOREIGN KEY (`fk_id_contrato`) REFERENCES `tbl_contratos` (`pk_id_contrato`),
  CONSTRAINT `tbl_planilla_detalle_ibfk_3` FOREIGN KEY (`fk_id_registro_planilla_Encabezado`) REFERENCES `tbl_planilla_encabezado` (`pk_registro_planilla_encabezado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_planilla_detalle`
--

LOCK TABLES `tbl_planilla_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_planilla_detalle` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_planilla_detalle` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-11 11:00:15
