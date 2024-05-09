-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 20, 2023 at 04:17 PM
-- Server version: 10.4.20-MariaDB
-- PHP Version: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gym_management`
--

-- --------------------------------------------------------

--
-- Table structure for table `billing_table`
--

CREATE TABLE `billing_table` (
  `BillID` int(11) NOT NULL,
  `Member` varchar(100) NOT NULL,
  `Period` date NOT NULL,
  `BillingDate` date NOT NULL,
  `Amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `billing_table`
--

INSERT INTO `billing_table` (`BillID`, `Member`, `Period`, `BillingDate`, `Amount`) VALUES
(1, 'Chamika', '2024-12-01', '2023-11-20', 30000);

-- --------------------------------------------------------

--
-- Table structure for table `coach_table`
--

CREATE TABLE `coach_table` (
  `CoachID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `DOB` date NOT NULL,
  `Phone` varchar(50) NOT NULL,
  `Experience` int(50) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `coach_table`
--

INSERT INTO `coach_table` (`CoachID`, `Name`, `Gender`, `DOB`, `Phone`, `Experience`, `Address`, `Password`) VALUES
(11, 'Weerasinghe', 'Male', '1990-06-13', '0772221133', 6, 'Matara', '3456'),
(12, 'Shara', 'Female', '2000-01-03', '0773331122', 2, 'Colombo', '4455'),
(15, 'Chathu', 'Female', '1996-08-12', '0779991122', 5, 'Badulla', '6181'),
(16, 'Meena', 'Female', '1991-03-14', '0778907733', 3, 'Gampaha', '0000');

-- --------------------------------------------------------

--
-- Table structure for table `login_table`
--

CREATE TABLE `login_table` (
  `UserName` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login_table`
--

INSERT INTO `login_table` (`UserName`, `Password`) VALUES
('Meena', '0000'),
('Shanika', '1234'),
('Kasun', ''),
('Kasun', '1020'),
('Chathu', '6181'),
('Chamika', '0099'),
('Firza', '7799'),
('Sam', '5544');

-- --------------------------------------------------------

--
-- Table structure for table `memberships_table`
--

CREATE TABLE `memberships_table` (
  `Name` varchar(100) NOT NULL,
  `Duration` int(11) NOT NULL,
  `Goal` varchar(100) NOT NULL,
  `Cost` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `memberships_table`
--

INSERT INTO `memberships_table` (`Name`, `Duration`, `Goal`, `Cost`) VALUES
('Chamika', 1, 'Maintain', 2000),
('Madushi', 2, 'Maintain', 3000);

-- --------------------------------------------------------

--
-- Table structure for table `members_table`
--

CREATE TABLE `members_table` (
  `MemberID` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `DOB` date NOT NULL,
  `JoinDate` date NOT NULL,
  `Memberships` varchar(50) NOT NULL,
  `Phone` varchar(50) NOT NULL,
  `Timing` varchar(50) NOT NULL,
  `Status` varchar(50) NOT NULL,
  `Coach` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `members_table`
--

INSERT INTO `members_table` (`MemberID`, `Name`, `Gender`, `DOB`, `JoinDate`, `Memberships`, `Phone`, `Timing`, `Status`, `Coach`) VALUES
(1, 'Chamika', 'Male', '2004-06-08', '2023-11-20', 'Premium Package', '0779994411', '8 AM-10 AM', 'Pending', 'Kasun'),
(3, 'Shani', 'Female', '1995-07-16', '2023-11-20', 'Standard Package', '0712349900', '1 PM-3 PM', 'Pending', 'Chathu');

-- --------------------------------------------------------

--
-- Table structure for table `receptionists_table`
--

CREATE TABLE `receptionists_table` (
  `RecepID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Gender` varchar(50) NOT NULL,
  `DOB` date NOT NULL,
  `Phone` varchar(20) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `receptionists_table`
--

INSERT INTO `receptionists_table` (`RecepID`, `Name`, `Gender`, `DOB`, `Phone`, `Address`, `Password`) VALUES
(2, 'Saman', 'Male', '2001-03-08', '0773331188', 'Galle', '1188'),
(3, 'Tharindu', 'Male', '1994-12-21', '0714567213', 'Badulla', '9077');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `billing_table`
--
ALTER TABLE `billing_table`
  ADD PRIMARY KEY (`BillID`);

--
-- Indexes for table `coach_table`
--
ALTER TABLE `coach_table`
  ADD PRIMARY KEY (`CoachID`),
  ADD UNIQUE KEY `Password` (`Password`);

--
-- Indexes for table `members_table`
--
ALTER TABLE `members_table`
  ADD PRIMARY KEY (`MemberID`);

--
-- Indexes for table `receptionists_table`
--
ALTER TABLE `receptionists_table`
  ADD PRIMARY KEY (`RecepID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `billing_table`
--
ALTER TABLE `billing_table`
  MODIFY `BillID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `coach_table`
--
ALTER TABLE `coach_table`
  MODIFY `CoachID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `members_table`
--
ALTER TABLE `members_table`
  MODIFY `MemberID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `receptionists_table`
--
ALTER TABLE `receptionists_table`
  MODIFY `RecepID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
