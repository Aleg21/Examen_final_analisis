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
-- Table structure for table `tbl_movimiento_de_inventario`
--

DROP TABLE IF EXISTS `tbl_movimiento_de_inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_movimiento_de_inventario` (
  `Pk_id_movimiento` int(11) NOT NULL AUTO_INCREMENT,
  `estado` tinyint(4) NOT NULL DEFAULT '1',
  `Fk_id_producto` int(11) NOT NULL,
  `Fk_id_stock` int(11) NOT NULL,
  `Fk_ID_LOCALES` int(11) NOT NULL,
  PRIMARY KEY (`Pk_id_movimiento`),
  KEY `Fk_id_producto` (`Fk_id_producto`),
  KEY `Fk_id_stock` (`Fk_id_stock`),
  KEY `FK_EXISTENCIA_LOCAL` (`Fk_ID_LOCALES`),
  CONSTRAINT `FK_EXISTENCIA_LOCAL` FOREIGN KEY (`Fk_ID_LOCALES`) REFERENCES `tbl_locales` (`pk_id_local`),
  CONSTRAINT `tbl_movimiento_de_inventario_ibfk_1` FOREIGN KEY (`Fk_id_producto`) REFERENCES `tbl_productos` (`pk_id_producto`),
  CONSTRAINT `tbl_movimiento_de_inventario_ibfk_2` FOREIGN KEY (`Fk_id_stock`) REFERENCES `tbl_trasladoproductos` (`pk_id_trasladoproductos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_movimiento_de_inventario`
--

LOCK TABLES `tbl_movimiento_de_inventario` WRITE;
/*!40000 ALTER TABLE `tbl_movimiento_de_inventario` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_movimiento_de_inventario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-11 11:00:17
