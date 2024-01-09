-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 09, 2024 at 04:47 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sales_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_produk`
--

CREATE TABLE `tbl_produk` (
  `id` int(11) NOT NULL,
  `produk_id` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nama` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `harga` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `jumlah` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tbl_produk`
--

INSERT INTO `tbl_produk` (`id`, `produk_id`, `nama`, `harga`, `jumlah`) VALUES
(9, 'F001', 'Nuggets', '30000', 20),
(10, 'F002', 'Chicken', '20000', 0),
(14, 'F004', 'Beef', '70000', 4),
(15, 'D005', 'Soda', '10000', 0),
(16, 'D001', 'Orange', '10000', 0),
(17, 'D002', 'Chocolate Caramel', '15000', 0),
(18, 'D003', 'Chocolate Milk', '15000', 6),
(19, 'D004', 'Thai Tea', '13000', 5),
(20, 'F005', 'Salmon', '20000', 3);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaksi`
--

CREATE TABLE `tbl_transaksi` (
  `id` int(11) NOT NULL,
  `no_transaksi` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `produk_id` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `nama_produk` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `harga_produk` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `kuantitas_produk` int(11) NOT NULL,
  `total_harga` int(11) NOT NULL,
  `created_at` date NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data for table `tbl_transaksi`
--

INSERT INTO `tbl_transaksi` (`id`, `no_transaksi`, `produk_id`, `nama_produk`, `harga_produk`, `kuantitas_produk`, `total_harga`, `created_at`) VALUES
(1, 'POS08JAN0000', 'F004', 'Beef', '70000', 1, 70000, '2024-01-08'),
(2, 'POS08JAN0000', 'D002', 'Chocolate Caramel', '15000', 1, 15000, '2024-01-08'),
(3, 'POS08JAN0001', 'F004', 'Beef', '70000', 2, 140000, '2024-01-08'),
(4, 'POS08JAN0001', 'D002', 'Chocolate Caramel', '15000', 1, 15000, '2024-01-08'),
(5, 'POS09JAN0000', 'F004', 'Beef', '70000', 1, 70000, '2024-01-09'),
(6, 'POS09JAN0000', 'D002', 'Chocolate Caramel', '15000', 1, 15000, '2024-01-09');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_produk`
--
ALTER TABLE `tbl_produk`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_produk`
--
ALTER TABLE `tbl_produk`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `tbl_transaksi`
--
ALTER TABLE `tbl_transaksi`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
