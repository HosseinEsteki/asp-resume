-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               8.0.30 - MySQL Community Server - GPL
-- Server OS:                    Win64
-- HeidiSQL Version:             12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping structure for table rezome.users
CREATE TABLE IF NOT EXISTS `users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `IsAdmin` tinyint(1) NOT NULL,
  `Image` longtext COLLATE utf8mb3_persian_ci,
  `Password` varchar(50) COLLATE utf8mb3_persian_ci NOT NULL,
  `Email` varchar(50) COLLATE utf8mb3_persian_ci NOT NULL,
  `FirstName` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `LastName` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Biography` varchar(300) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_persian_ci;

-- Dumping data for table rezome.users: ~2 rows (approximately)
INSERT INTO `users` (`Id`, `IsAdmin`, `Image`, `Password`, `Email`, `FirstName`, `LastName`, `Biography`) VALUES
	(1, 1, '1.jpg', '1234', 'Sadeghi@gmail.com', 'محمد', 'صادقی', 'انسانی خلاق و کنجکاو برای رسیدن به موفقیت'),
	(2, 0, '2.jpg', '1234', 'Alireza@gmail.com', 'علیرضا', 'کمالی', 'انسانی خلاق و کنجکاو برای رسیدن به موفقیت'),
	(3, 0, '3.jpg', '1234', 'Ahmad@gmail.com', 'احمد', 'ترکاشوند', 'انسانی خلاق و کنجکاو برای رسیدن به موفقیت');

-- Dumping structure for table rezome.posts
CREATE TABLE IF NOT EXISTS `posts` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` int NOT NULL,
  `Image` longtext COLLATE utf8mb3_persian_ci NOT NULL,
  `Title` varchar(50) COLLATE utf8mb3_persian_ci NOT NULL,
  `ShortDiscription` varchar(300) COLLATE utf8mb3_persian_ci NOT NULL,
  `Description` longtext COLLATE utf8mb3_persian_ci NOT NULL,
  `Updated_At` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Posts_UserId` (`UserId`),
  CONSTRAINT `FK_Posts_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_persian_ci;

-- Dumping data for table rezome.posts: ~1 rows (approximately)
INSERT INTO `posts` (`Id`, `UserId`, `Image`, `Title`, `ShortDiscription`, `Description`, `Updated_At`) VALUES
	(1, 1, 'Dream_House_Ultra_HD_Wallpaper_for_4K_UHD_Widescre.jpg', 'بهترین مکان برای سفر کجاست؟', 'در این مقاله قصد داریم مکان های خوب برای سفر را به شما معرفی کنیم', '<p>&nbsp;</p>\r\n<p style="direction: rtl;">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد. در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها و شرایط سخت تایپ به پایان رسد وزمان مورد نیاز شامل حروفچینی دستاوردهای اصلی و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.</p>\r\n<p style="direction: rtl;">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد. در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها و شرایط سخت تایپ به پایان رسد وزمان مورد نیاز شامل حروفچینی دستاوردهای اصلی و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.</p>\r\n<p style="direction: rtl;">لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است و برای شرایط فعلی تکنولوژی مورد نیاز و کاربردهای متنوع با هدف بهبود ابزارهای کاربردی می باشد. کتابهای زیادی در شصت و سه درصد گذشته، حال و آینده شناخت فراوان جامعه و متخصصان را می طلبد تا با نرم افزارها شناخت بیشتری را برای طراحان رایانه ای علی الخصوص طراحان خلاقی و فرهنگ پیشرو در زبان فارسی ایجاد کرد. در این صورت می توان امید داشت که تمام و دشواری موجود در ارائه راهکارها و شرایط سخت تایپ به پایان رسد وزمان مورد نیاز شامل حروفچینی دستاوردهای اصلی و جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.</p>\r\n<p>&nbsp;</p>', '2023-02-01 12:20:56.698106');

-- Dumping structure for table rezome.properties
CREATE TABLE IF NOT EXISTS `properties` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` int NOT NULL,
  `Title` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Phone` varchar(15) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Gender` longtext COLLATE utf8mb3_persian_ci,
  `Marry` longtext COLLATE utf8mb3_persian_ci,
  `Birth` longtext COLLATE utf8mb3_persian_ci,
  `Sarbaz` longtext COLLATE utf8mb3_persian_ci,
  `City` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Address` varchar(300) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Maghta1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Reshte1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Uni1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `UniStart1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `UniEnd1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Maghta2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Reshte2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Uni2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `UniStart2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `UniEnd2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Job1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Company1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `City1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `JobStart1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `JobEnd1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Job2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Company2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `City2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `JobStart2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `JobEnd2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Project1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Karfarma1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Link1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `ProjectStart1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `ProjectEnd1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Project2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Karfarma2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Link2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `ProjectStart2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `ProjectEnd2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Article1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Nasher1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Mortabet1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `ArticleStart1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `ArticleEnd1` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Article2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Nasher2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `Mortabet2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `ArticleStart2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  `ArticleEnd2` varchar(50) COLLATE utf8mb3_persian_ci DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_Properties_UserId` (`UserId`),
  CONSTRAINT `FK_Properties_Users_UserId` FOREIGN KEY (`UserId`) REFERENCES `users` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_persian_ci;

-- Dumping data for table rezome.properties: ~2 rows (approximately)
INSERT INTO `properties` (`Id`, `UserId`, `Title`, `Phone`, `Gender`, `Marry`, `Birth`, `Sarbaz`, `City`, `Address`, `Maghta1`, `Reshte1`, `Uni1`, `UniStart1`, `UniEnd1`, `Maghta2`, `Reshte2`, `Uni2`, `UniStart2`, `UniEnd2`, `Job1`, `Company1`, `City1`, `JobStart1`, `JobEnd1`, `Job2`, `Company2`, `City2`, `JobStart2`, `JobEnd2`, `Project1`, `Karfarma1`, `Link1`, `ProjectStart1`, `ProjectEnd1`, `Project2`, `Karfarma2`, `Link2`, `ProjectStart2`, `ProjectEnd2`, `Article1`, `Nasher1`, `Mortabet1`, `ArticleStart1`, `ArticleEnd1`, `Article2`, `Nasher2`, `Mortabet2`, `ArticleStart2`, `ArticleEnd2`) VALUES
	(1, 1, 'شغل1', '0215462741', 'مذکر', 'متاهل', '1372/04/03', 'مشغول به خدمت', 'آذربایجان', 'شهر کیان', 'سیکل', 'بی رشته', 'انقلاب', '1355', '1357', 'دیپلم', 'کامپیوتر', 'انقلاب', '1357', '1360', 'کارمند', 'بانک رفاه', 'استانبول', '1389', '1399', 'کارمند 2', 'شرکت نفت', 'ایلام', '1350', '1380', 'دانشکده سروش', 'ریاست دانشگاه سروش', 'https://soroush.net', '1395', '1396', 'دانشکده صیرفیان', 'ریاست دانشگاه', 'https://soroush.com', '1397', '1398', 'مقاله ی انقلاب', 'جنگل', 'https://soroush.net', '1372', '1373', 'مقاله ی اسلامی', 'گلشیفته', 'https://soroush.net', '1357', '1367'),
	(2, 2, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL),
	(3, 3, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL);


-- Dumping structure for table rezome.__efmigrationshistory
CREATE TABLE IF NOT EXISTS `__efmigrationshistory` (
  `MigrationId` varchar(150) COLLATE utf8mb3_persian_ci NOT NULL,
  `ProductVersion` varchar(32) COLLATE utf8mb3_persian_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3 COLLATE=utf8mb3_persian_ci;

-- Dumping data for table rezome.__efmigrationshistory: ~1 rows (approximately)
INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
	('20230201081643_1', '7.0.2');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
