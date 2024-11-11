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
-- Table structure for table `tbl_lista_detalle`
--

DROP TABLE IF EXISTS `tbl_lista_detalle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_lista_detalle` (
  `Pk_id_lista_detalle` int(11) NOT NULL,
  `Fk_id_lista_Encabezado` int(11) NOT NULL,
  `Fk_id_Producto` int(11) NOT NULL,
  `ListDetalle_preVenta` decimal(10,2) DEFAULT NULL,
  `ListDetalle_descuento` decimal(10,2) DEFAULT NULL,
  `ListDetalle_impuesto` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_lista_detalle`),
  KEY `Fk_id_lista_Encabezado` (`Fk_id_lista_Encabezado`),
  KEY `Fk_id_Producto` (`Fk_id_Producto`),
  CONSTRAINT `tbl_lista_detalle_ibfk_1` FOREIGN KEY (`Fk_id_lista_Encabezado`) REFERENCES `tbl_lista_encabezado` (`pk_id_lista_encabezado`),
  CONSTRAINT `tbl_lista_detalle_ibfk_2` FOREIGN KEY (`Fk_id_Producto`) REFERENCES `tbl_productos` (`pk_id_producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_lista_detalle`
--

LOCK TABLES `tbl_lista_detalle` WRITE;
/*!40000 ALTER TABLE `tbl_lista_detalle` DISABLE KEYS */;
INSERT INTO `tbl_lista_detalle` VALUES (1,1,1,100.00,10.00,5.00),(2,1,2,120.00,15.00,6.00),(3,1,3,130.00,12.00,7.00),(4,1,4,110.00,20.00,8.00),(5,2,1,140.00,5.00,3.00),(6,2,2,150.00,10.00,4.00),(7,2,3,160.00,0.00,2.00),(8,2,4,170.00,25.00,1.00),(9,3,1,180.00,7.50,3.50),(10,3,2,190.00,9.00,4.50),(11,3,3,200.00,11.00,5.50),(12,3,4,210.00,13.00,6.50),(13,4,1,220.00,15.00,4.00),(14,4,2,230.00,18.00,3.00),(15,4,3,240.00,20.00,2.00),(16,4,4,250.00,25.00,1.00);
/*!40000 ALTER TABLE `tbl_lista_detalle` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-11 10:59:53
