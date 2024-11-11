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
-- Table structure for table `tbl_pedido_encabezado`
--

DROP TABLE IF EXISTS `tbl_pedido_encabezado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_pedido_encabezado` (
  `Pk_id_PedidoEnc` int(11) NOT NULL,
  `Fk_id_cliente` int(11) NOT NULL,
  `Fk_id_vendedor` int(11) NOT NULL,
  `PedidoEncfecha` date NOT NULL,
  `PedidoEnc_total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`Pk_id_PedidoEnc`),
  KEY `Fk_id_cliente` (`Fk_id_cliente`),
  KEY `Fk_id_vendedor` (`Fk_id_vendedor`),
  CONSTRAINT `tbl_pedido_encabezado_ibfk_1` FOREIGN KEY (`Fk_id_cliente`) REFERENCES `tbl_clientes` (`pk_id_cliente`),
  CONSTRAINT `tbl_pedido_encabezado_ibfk_2` FOREIGN KEY (`Fk_id_vendedor`) REFERENCES `tbl_vendedores` (`pk_id_vendedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_pedido_encabezado`
--

LOCK TABLES `tbl_pedido_encabezado` WRITE;
/*!40000 ALTER TABLE `tbl_pedido_encabezado` DISABLE KEYS */;
INSERT INTO `tbl_pedido_encabezado` VALUES (1,1,1,'2024-11-11',3600.00);
/*!40000 ALTER TABLE `tbl_pedido_encabezado` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-11 11:00:09
