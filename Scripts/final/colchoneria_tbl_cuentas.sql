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
-- Table structure for table `tbl_cuentas`
--

DROP TABLE IF EXISTS `tbl_cuentas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_cuentas` (
  `Pk_id_cuenta` int(11) NOT NULL,
  `Pk_id_tipocuenta` int(11) NOT NULL,
  `Pk_id_encabezadocuenta` int(11) NOT NULL,
  `nombre_cuenta` varchar(50) NOT NULL,
  `cargo_mes` float DEFAULT '0',
  `abono_mes` float DEFAULT '0',
  `saldo_ant` float DEFAULT '0',
  `saldo_act` float DEFAULT '0',
  `cargo_acumulado` float DEFAULT '0',
  `abono_acumulado` float DEFAULT '0',
  `Pk_id_cuenta_enlace` int(11) DEFAULT NULL,
  `estado` tinyint(4) NOT NULL,
  PRIMARY KEY (`Pk_id_cuenta`,`Pk_id_tipocuenta`,`Pk_id_encabezadocuenta`),
  UNIQUE KEY `Pk_id_cuenta` (`Pk_id_cuenta`),
  KEY `Pk_id_tipocuenta` (`Pk_id_tipocuenta`),
  KEY `Pk_id_encabezadocuenta` (`Pk_id_encabezadocuenta`),
  KEY `Pk_id_cuenta_enlace` (`Pk_id_cuenta_enlace`),
  CONSTRAINT `tbl_cuentas_ibfk_1` FOREIGN KEY (`Pk_id_tipocuenta`) REFERENCES `tbl_tipocuenta` (`pk_id_tipocuenta`),
  CONSTRAINT `tbl_cuentas_ibfk_2` FOREIGN KEY (`Pk_id_encabezadocuenta`) REFERENCES `tbl_encabezadoclasecuenta` (`pk_id_encabezadocuenta`),
  CONSTRAINT `tbl_cuentas_ibfk_3` FOREIGN KEY (`Pk_id_cuenta_enlace`) REFERENCES `tbl_cuentas` (`pk_id_cuenta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_cuentas`
--

LOCK TABLES `tbl_cuentas` WRITE;
/*!40000 ALTER TABLE `tbl_cuentas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_cuentas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-11 11:00:11
