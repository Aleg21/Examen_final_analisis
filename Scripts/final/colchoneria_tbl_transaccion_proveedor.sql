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
-- Table structure for table `tbl_transaccion_proveedor`
--

DROP TABLE IF EXISTS `tbl_transaccion_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_transaccion_proveedor` (
  `Pk_id_transaccion` int(11) NOT NULL AUTO_INCREMENT,
  `Fk_id_proveedor` int(11) NOT NULL,
  `Fk_id_pais` int(11) NOT NULL,
  `fecha_transaccion` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `tansaccion_cuenta` varchar(150) COLLATE utf8mb4_general_ci NOT NULL,
  `tansaccion_cuotas` varchar(2) COLLATE utf8mb4_general_ci NOT NULL,
  `transaccion_monto` decimal(10,2) DEFAULT NULL,
  `Fk_id_pago` int(11) NOT NULL,
  `transaccion_tipo_moneda` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `transaccion_serie` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `transaccion_estado` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Pk_id_transaccion`),
  KEY `Fk_id_proveedor` (`Fk_id_proveedor`),
  KEY `Fk_id_pago` (`Fk_id_pago`),
  KEY `Fk_id_pais` (`Fk_id_pais`),
  CONSTRAINT `tbl_transaccion_proveedor_ibfk_1` FOREIGN KEY (`Fk_id_proveedor`) REFERENCES `tbl_proveedores` (`pk_prov_id`),
  CONSTRAINT `tbl_transaccion_proveedor_ibfk_2` FOREIGN KEY (`Fk_id_pago`) REFERENCES `tbl_formadepago` (`pk_id_pago`),
  CONSTRAINT `tbl_transaccion_proveedor_ibfk_3` FOREIGN KEY (`Fk_id_pais`) REFERENCES `tbl_paises` (`pk_id_pais`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_transaccion_proveedor`
--

LOCK TABLES `tbl_transaccion_proveedor` WRITE;
/*!40000 ALTER TABLE `tbl_transaccion_proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_transaccion_proveedor` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-11 11:00:19
