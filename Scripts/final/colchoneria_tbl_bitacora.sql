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
-- Table structure for table `tbl_bitacora`
--

DROP TABLE IF EXISTS `tbl_bitacora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_bitacora` (
  `Pk_id_bitacora` int(11) NOT NULL AUTO_INCREMENT,
  `Fk_id_usuario` int(11) NOT NULL,
  `Fk_id_aplicacion` int(11) NOT NULL,
  `fecha_bitacora` date NOT NULL,
  `hora_bitacora` time NOT NULL,
  `host_bitacora` varchar(45) NOT NULL,
  `ip_bitacora` varchar(100) NOT NULL,
  `accion_bitacora` varchar(200) NOT NULL,
  `tabla` varchar(50) NOT NULL,
  PRIMARY KEY (`Pk_id_bitacora`),
  KEY `Fk_id_usuario` (`Fk_id_usuario`),
  KEY `Fk_id_aplicacion` (`Fk_id_aplicacion`),
  CONSTRAINT `tbl_bitacora_ibfk_1` FOREIGN KEY (`Fk_id_usuario`) REFERENCES `tbl_usuarios` (`pk_id_usuario`),
  CONSTRAINT `tbl_bitacora_ibfk_2` FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `tbl_aplicaciones` (`pk_id_aplicacion`)
) ENGINE=InnoDB AUTO_INCREMENT=227 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_bitacora`
--

LOCK TABLES `tbl_bitacora` WRITE;
/*!40000 ALTER TABLE `tbl_bitacora` DISABLE KEYS */;
INSERT INTO `tbl_bitacora` VALUES (200,1,1000,'2024-11-07','14:22:40','LAPTOP-VMUT9969','192.168.1.36','Se logeo al sistema','Login'),(201,1,1000,'2024-11-07','14:24:23','LAPTOP-VMUT9969','192.168.1.36','Se logeo al sistema','Login'),(202,1,1000,'2024-11-07','14:25:38','LAPTOP-VMUT9969','192.168.1.36','Se logeo al sistema','Login'),(203,1,1000,'2024-11-07','14:30:53','LAPTOP-VMUT9969','192.168.1.36','Se logeo al sistema','Login'),(204,1,1000,'2024-11-07','14:31:15','LAPTOP-VMUT9969','192.168.1.36','Se logeo al sistema','Login'),(205,1,1000,'2024-11-07','14:34:53','LAPTOP-VMUT9969','192.168.1.36','Se logeo al sistema','Login'),(206,1,1000,'2024-11-07','14:37:57','LAPTOP-VMUT9969','192.168.1.36','Se logeo al sistema','Login'),(207,1,1000,'2024-11-07','14:59:30','LAPTOP-VMUT9969','192.168.1.36','Se logeo al sistema','Login'),(208,1,1000,'2024-11-07','21:53:14','LAPTOP-VMUT9969','192.168.1.36','Se logeo al sistema','Login'),(209,1,1000,'2024-11-07','21:57:29','LAPTOP-VMUT9969','192.168.1.36','Se logeo al sistema','Login'),(210,1,6005,'2024-11-07','21:57:51','LAPTOP-VMUT9969','192.168.1.36','Se consulto deducciones y no se encontraron datos','tbl_dedu_perp_emp'),(211,1,6005,'2024-11-07','21:57:57','LAPTOP-VMUT9969','192.168.1.36','Se consulto percepciones y no se encontraron datos','tbl_dedu_perp_emp'),(212,1,1000,'2024-11-07','21:59:15','LAPTOP-VMUT9969','192.168.1.36','Se logeo al sistema','Login'),(213,1,1000,'2024-11-07','22:01:26','LAPTOP-VMUT9969','192.168.1.36','Se logeo al sistema','Login'),(214,1,1000,'2024-11-07','22:01:38','LAPTOP-VMUT9969','192.168.1.36','Se presionó el botón cancelar en tbl_control_faltas','tbl_control_faltas'),(215,1,1000,'2024-11-07','22:01:44','LAPTOP-VMUT9969','192.168.1.36','Entro a consultas','consultas'),(216,1,1000,'2024-11-07','22:02:16','LAPTOP-VMUT9969','192.168.1.36','Se logeo al sistema','Login'),(217,1,1000,'2024-11-07','22:03:12','LAPTOP-VMUT9969','192.168.1.36','Se presionó el botón cancelar en tbl_control_faltas','tbl_control_faltas'),(218,1,1000,'2024-11-07','22:03:34','LAPTOP-VMUT9969','192.168.1.36','Vio un reporte','tbl_control_faltas'),(219,1,1000,'2024-11-11','08:51:11','LAPTOP-VMUT9969','192.168.251.158','Se logeo al sistema','Login'),(220,1,1000,'2024-11-11','08:52:11','LAPTOP-VMUT9969','192.168.251.158','Se logeo al sistema','Login'),(221,1,1000,'2024-11-11','09:02:49','LAPTOP-VMUT9969','192.168.251.158','Se logeo al sistema','Login'),(222,1,1000,'2024-11-11','09:45:29','LAPTOP-VMUT9969','192.168.251.158','Se logeo al sistema','Login'),(223,1,1000,'2024-11-11','09:45:42','LAPTOP-VMUT9969','192.168.251.158','Se logeo al sistema','Login'),(224,3,1000,'2024-11-11','09:53:25','LAPTOP-VMUT9969','192.168.251.158','Se logeo al sistema','Login'),(225,3,1000,'2024-11-11','10:04:44','LAPTOP-VMUT9969','192.168.251.158','Se logeo al sistema','Login'),(226,1,1000,'2024-11-11','10:06:41','LAPTOP-VMUT9969','192.168.251.158','Se logeo al sistema','Login');
/*!40000 ALTER TABLE `tbl_bitacora` ENABLE KEYS */;
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
