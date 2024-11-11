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
-- Table structure for table `tbl_detalle_comisiones`
--

DROP TABLE IF EXISTS `tbl_detalle_comisiones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_detalle_comisiones` (
  `Pk_id_detalle_comision` int(11) NOT NULL,
  `Fk_id_comisionEnc` int(11) NOT NULL,
  `Fk_id_factura` int(11) NOT NULL,
  `Comisiones_porcentaje` decimal(5,2) NOT NULL,
  `Comisiones_monto_venta` decimal(10,2) NOT NULL,
  `Comisiones_monto_comision` decimal(10,2) NOT NULL,
  PRIMARY KEY (`Pk_id_detalle_comision`),
  KEY `Fk_id_comisionEnc` (`Fk_id_comisionEnc`),
  KEY `Fk_id_factura` (`Fk_id_factura`),
  CONSTRAINT `tbl_detalle_comisiones_ibfk_1` FOREIGN KEY (`Fk_id_comisionEnc`) REFERENCES `tbl_comisiones_encabezado` (`pk_id_comisionenc`),
  CONSTRAINT `tbl_detalle_comisiones_ibfk_2` FOREIGN KEY (`Fk_id_factura`) REFERENCES `tbl_factura` (`pk_id_factura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_detalle_comisiones`
--

LOCK TABLES `tbl_detalle_comisiones` WRITE;
/*!40000 ALTER TABLE `tbl_detalle_comisiones` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_detalle_comisiones` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-11 11:00:07
