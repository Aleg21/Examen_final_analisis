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
-- Table structure for table `tbl_activofijo`
--

DROP TABLE IF EXISTS `tbl_activofijo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_activofijo` (
  `Pk_Id_ActivoFijo` int(11) NOT NULL AUTO_INCREMENT,
  `Codigo_Activo` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Pk_Id_TipoActivoFijo` int(11) DEFAULT NULL,
  `Descripcion` varchar(255) COLLATE utf8mb4_general_ci NOT NULL,
  `Pk_Id_Identidad` int(11) DEFAULT NULL,
  `Modelo` varchar(100) COLLATE utf8mb4_general_ci DEFAULT NULL,
  `Fecha_Adquisicion` date DEFAULT NULL,
  `Costo_Adquisicion` decimal(10,2) DEFAULT NULL,
  `Vida_Util` decimal(5,2) DEFAULT NULL,
  `Valor_Residual` decimal(10,2) DEFAULT NULL,
  `Estado` tinyint(4) DEFAULT NULL,
  `Pk_Id_Cuenta` int(11) NOT NULL,
  PRIMARY KEY (`Pk_Id_ActivoFijo`),
  UNIQUE KEY `Codigo_Activo` (`Codigo_Activo`),
  KEY `Fk_TipoActivoFijo` (`Pk_Id_TipoActivoFijo`),
  KEY `Fk_Identidad` (`Pk_Id_Identidad`),
  KEY `Fk_Cuenta` (`Pk_Id_Cuenta`),
  CONSTRAINT `Fk_Cuenta_New` FOREIGN KEY (`Pk_Id_Cuenta`) REFERENCES `tbl_cuentas` (`pk_id_cuenta`) ON DELETE CASCADE,
  CONSTRAINT `Fk_Identidad_New` FOREIGN KEY (`Pk_Id_Identidad`) REFERENCES `tbl_identidadactivo` (`pk_id_identidad`) ON DELETE SET NULL,
  CONSTRAINT `Fk_TipoActivoFijo_New` FOREIGN KEY (`Pk_Id_TipoActivoFijo`) REFERENCES `tbl_tipoactivofijo` (`pk_id_tipoactivofijo`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_activofijo`
--

LOCK TABLES `tbl_activofijo` WRITE;
/*!40000 ALTER TABLE `tbl_activofijo` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_activofijo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-11 11:00:20
