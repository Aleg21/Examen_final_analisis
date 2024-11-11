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
-- Table structure for table `tbl_historial_servicio`
--

DROP TABLE IF EXISTS `tbl_historial_servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_historial_servicio` (
  `Pk_Id_HistorialServicio` int(11) NOT NULL AUTO_INCREMENT,
  `Pk_Id_ActivoFijo` int(11) NOT NULL,
  `Compania_Asegurada` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Agente_Seguro` varchar(100) COLLATE utf8mb4_general_ci NOT NULL,
  `Tel_Siniestro` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `Tipo_Cobertura` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `Monto_Asegurado` decimal(10,2) NOT NULL,
  `Prima_Total` decimal(10,2) NOT NULL,
  `Deducible` decimal(10,2) NOT NULL,
  `Vigencia` date NOT NULL,
  `Fecha_Util` date NOT NULL,
  `Costo_Servicio` decimal(10,2) NOT NULL,
  `Periodo_Servicio` int(11) NOT NULL,
  `Prox_Servicio` date NOT NULL,
  `Estado` tinyint(4) NOT NULL,
  PRIMARY KEY (`Pk_Id_HistorialServicio`),
  KEY `Fk_ActivoFijo` (`Pk_Id_ActivoFijo`),
  CONSTRAINT `Fk_ActivoFijo_HistorialServicio` FOREIGN KEY (`Pk_Id_ActivoFijo`) REFERENCES `tbl_activofijo` (`pk_id_activofijo`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_historial_servicio`
--

LOCK TABLES `tbl_historial_servicio` WRITE;
/*!40000 ALTER TABLE `tbl_historial_servicio` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_historial_servicio` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-11 11:00:33
