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
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venta` (
  `id_venta` int(11) NOT NULL AUTO_INCREMENT,
  `monto` int(11) NOT NULL,
  `nombre_cliente` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `nombre_empleado` varchar(50) COLLATE utf8mb4_general_ci NOT NULL,
  `estado` tinyint(4) NOT NULL DEFAULT '1',
  PRIMARY KEY (`id_venta`)
) ENGINE=InnoDB AUTO_INCREMENT=39 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
INSERT INTO `venta` VALUES (1,111,'Josue','David',1),(2,222,'Fernando','David',1),(3,100,'Josue David','Joel Lopez',1),(4,400,'Sebastian','Victor',1),(5,555,'Brayan','Daniel',1),(6,8888,'pedro','perez',1),(7,555,'roro','pablo',1),(8,444,'shiro','rodolfo',1),(9,999,'Brayan','Daniel',1),(10,111,'shiro','sh',1),(11,88,'lol','lol',1),(12,1111,'lll','lll',1),(13,1111,'www','www',1),(14,56456,'wwww','qqq',1),(15,111223,'hola','hol',1),(16,2222,'yy','yyy',1),(17,555,'ggg','ggg',1),(18,100,'ahora','ddd',1),(19,100,'pedro','lucas',1),(20,555,'cliente','empleado',1),(21,200,'cliente','empleado',1),(22,200,'rrr','www',1),(23,333,'www','qqq',1),(24,33,'eee','xxx',1),(25,600,'ññ','lll',1),(26,6456,'qqq','fff',1),(27,555,'ddd','aaa',1),(28,666,'qqq','aaa',1),(29,666,'cliente','empleado',1),(30,888,'Cliente1','Empleado122',1),(31,6666,'ClientePrueba','EmpleadoPrueba',1),(32,6666,'qq','qqq',1),(33,999,'cliente','emple',1),(34,333,'cli','emp',1),(35,65,'pedro','juan',1),(36,65656,'djf','kjk',1),(37,0,'','',1),(38,0,'','',1);
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
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
