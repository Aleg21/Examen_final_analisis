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
-- Table structure for table `tbl_dedu_perp`
--

DROP TABLE IF EXISTS `tbl_dedu_perp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_dedu_perp` (
  `pk_dedu_perp` int(11) NOT NULL AUTO_INCREMENT,
  `dedu_perp_clase` varchar(25) DEFAULT NULL,
  `dedu_perp_concepto` varchar(25) DEFAULT NULL,
  `dedu_perp_tipo` varchar(25) DEFAULT NULL,
  `dedu_perp_aplicacion` varchar(25) DEFAULT NULL,
  `dedu_perp_excepcion` tinyint(1) DEFAULT NULL,
  `dedu_perp_monto` float DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`pk_dedu_perp`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_dedu_perp`
--

LOCK TABLES `tbl_dedu_perp` WRITE;
/*!40000 ALTER TABLE `tbl_dedu_perp` DISABLE KEYS */;
INSERT INTO `tbl_dedu_perp` VALUES (1,'Deduccion','Faltas','Porcentaje','Todos',0,20,1),(2,'Percepcion','Anticipo','Monto','Todos',0,1,1),(3,'Percepcion','Horas Extras','Monto','Todos',0,1,1),(4,'Bono 14','Bono 14','Porcentaje','Todos',0,0.0833,1),(5,'Aguinaldo','Aguinaldo','Porcentaje','Todos',0,0.0833,1),(6,'Vacaciones','Vacaciones','Porcentaje','Todos',0,0.0575,1);
/*!40000 ALTER TABLE `tbl_dedu_perp` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-11 11:00:29
