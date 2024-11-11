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
-- Table structure for table `tbl_auditorias`
--

DROP TABLE IF EXISTS `tbl_auditorias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_auditorias` (
  `Pk_ID_AUDITORIA` int(11) NOT NULL AUTO_INCREMENT,
  `Fk_ID_BODEGA` int(11) NOT NULL,
  `Fk_ID_PRODUCTO` int(11) NOT NULL,
  `FECHA_AUDITORIA` date DEFAULT NULL,
  `DISCREPANCIA_DETECTADA` tinyint(1) DEFAULT '0',
  `CANTIDAD_REGISTRADA` int(11) NOT NULL,
  `CANTIDAD_FISICA` int(11) NOT NULL,
  `OBSERVACIONES` text,
  PRIMARY KEY (`Pk_ID_AUDITORIA`),
  KEY `Fk_ID_BODEGA` (`Fk_ID_BODEGA`),
  KEY `Fk_ID_PRODUCTO` (`Fk_ID_PRODUCTO`),
  CONSTRAINT `tbl_auditorias_ibfk_1` FOREIGN KEY (`Fk_ID_BODEGA`) REFERENCES `tbl_bodegas` (`pk_id_bodega`),
  CONSTRAINT `tbl_auditorias_ibfk_2` FOREIGN KEY (`Fk_ID_PRODUCTO`) REFERENCES `tbl_productos` (`pk_id_producto`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_auditorias`
--

LOCK TABLES `tbl_auditorias` WRITE;
/*!40000 ALTER TABLE `tbl_auditorias` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_auditorias` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-11 11:00:12
