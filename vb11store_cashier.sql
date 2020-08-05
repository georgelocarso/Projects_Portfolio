-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 05, 2020 at 06:33 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vb11store_cashier`
--

-- --------------------------------------------------------

--
-- Table structure for table `cashier_account`
--

CREATE TABLE `cashier_account` (
  `id_cashier` varchar(20) NOT NULL,
  `password` varchar(50) NOT NULL,
  `datecreated` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cashier_account`
--

INSERT INTO `cashier_account` (`id_cashier`, `password`, `datecreated`) VALUES
('a', 'a', '2020-06-17 17:00:00'),
('C01', '123', '2020-05-31 17:00:00');

-- --------------------------------------------------------

--
-- Table structure for table `cashier_attendance`
--

CREATE TABLE `cashier_attendance` (
  `id` varchar(20) NOT NULL,
  `id_cashier` varchar(20) NOT NULL,
  `start_time` timestamp NULL DEFAULT NULL,
  `finish_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `cashier_attendance`
--

INSERT INTO `cashier_attendance` (`id`, `id_cashier`, `start_time`, `finish_time`) VALUES
('a0', 'a', '2020-06-28 10:54:08', NULL),
('a1', 'a', '2020-06-28 11:10:48', '2020-06-28 18:10:50'),
('a2', 'a', '2020-06-28 11:10:58', '2020-06-28 18:11:02'),
('a3', 'a', '2020-06-28 11:11:05', NULL),
('a4', 'a', '2020-06-28 11:12:05', NULL),
('a5', 'a', '2020-06-28 11:12:20', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `product_code` varchar(256) NOT NULL,
  `product_name` varchar(60) NOT NULL,
  `price` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`product_code`, `product_name`, `price`) VALUES
('1131', 'Pempek Kapal Selam', 15000),
('123456', 'Mie Sedap', 2100),
('1313', 'Taylor Swift Album', 2500000),
('3216547894562154656969', 'Too Long ID', 5000);

-- --------------------------------------------------------

--
-- Table structure for table `transaction`
--

CREATE TABLE `transaction` (
  `date_entry` datetime NOT NULL,
  `str_product_qty` varchar(250) NOT NULL,
  `total_amount` int(11) NOT NULL,
  `received_amount` int(11) NOT NULL,
  `changes_amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `transaction`
--

INSERT INTO `transaction` (`date_entry`, `str_product_qty`, `total_amount`, `received_amount`, `changes_amount`) VALUES
('2020-06-16 17:57:50', '(123456,1)', 2100, 5000, 2900),
('2020-06-26 17:53:43', '(1313,1)', 2500000, 2500000, 0),
('2020-06-27 18:27:58', '(123456,1)', 2100, 3000, 900),
('2020-06-27 18:29:07', '(123456,1)', 2100, 3000, 900),
('2020-06-28 19:11:48', '(123456,1)', 2100, 2500, 400),
('2020-06-28 20:03:17', '(1313,1),(123456,1),(1131,1)', 2517100, 2600000, 82900),
('2020-06-29 22:01:55', '(1313,13)', 32500000, 33000000, 500000),
('2020-06-29 22:04:45', '(1131,5)', 75000, 80000, 5000),
('2020-06-29 22:05:36', '(123456,1)', 2100, 3000, 900),
('2020-06-29 22:06:03', '(1131,1)', 15000, 17000, 2000),
('2020-06-29 22:08:59', '(1313,1),(123456,6),(1131,1)', 2527600, 123132, -2404468),
('2020-06-29 22:10:33', '(3216547894562154656969,12)', 60000, 60000, 0),
('2020-06-29 22:11:20', '(3216547894562154656969,100),(123456,1),(1131,1),(1313,1)', 3017100, 3100000, 82900),
('2020-06-30 21:20:04', '(123456,1)', 2100, 3000, 900),
('2020-07-10 23:36:37', '(123456,1)', 2100, 3000, 900),
('2020-08-05 11:28:40', '(123456,1)', 2100, 5000, 2900),
('2020-08-05 11:29:23', '(1313,1)', 2500000, 3000000, 500000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cashier_account`
--
ALTER TABLE `cashier_account`
  ADD PRIMARY KEY (`id_cashier`);

--
-- Indexes for table `cashier_attendance`
--
ALTER TABLE `cashier_attendance`
  ADD PRIMARY KEY (`id`,`id_cashier`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`product_code`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`date_entry`,`str_product_qty`,`total_amount`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
