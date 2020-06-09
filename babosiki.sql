-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Июн 10 2020 г., 01:33
-- Версия сервера: 10.3.13-MariaDB-log
-- Версия PHP: 7.1.32

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `babosiki`
--

-- --------------------------------------------------------

--
-- Структура таблицы `branch_office`
--

CREATE TABLE `branch_office` (
  `BRANCH_ID` int(11) UNSIGNED NOT NULL,
  `BRANCH_NAME` varchar(250) NOT NULL,
  `CITY_OFFICE` int(11) NOT NULL,
  `NUMBER_OF_EMPLOYEES` int(11) NOT NULL,
  `PROFIT` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `branch_office`
--

INSERT INTO `branch_office` (`BRANCH_ID`, `BRANCH_NAME`, `CITY_OFFICE`, `NUMBER_OF_EMPLOYEES`, `PROFIT`) VALUES
(1, 'Бабосики-Николаевка', 1, 500, 2050000),
(2, 'Бабосики-Яренск', 2, 450, 1750000),
(3, 'Бабосики-Барнаул', 3, 600, 3000000),
(4, 'Бабосики-Мышкин', 4, 400, 1500000),
(5, 'Бабосики-Хоринск', 5, 700, 4500000),
(6, 'Бабосики-Перелюб', 6, 300, 1200000),
(7, 'Бабосики-Абдулино', 7, 500, 2100000),
(8, 'Бабосики-Ува', 8, 700, 4500000),
(9, 'Бабосики-Александровское', 9, 1000, 10000000),
(10, 'Бабосики-Сосновый Бор', 10, 600, 3500000),
(11, 'Бабосики-Акъяр', 11, 550, 2750000),
(12, 'Бабосики-Богатые Сабы', 12, 3000, 15000000);

-- --------------------------------------------------------

--
-- Структура таблицы `city`
--

CREATE TABLE `city` (
  `CITY_ID` int(11) NOT NULL,
  `CYTY_NAME` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `city`
--

INSERT INTO `city` (`CITY_ID`, `CYTY_NAME`) VALUES
(1, 'г.Николаевка'),
(2, 'г.Яренск'),
(3, 'г.Барнаул'),
(4, 'г.Мышкин'),
(5, 'г.Хоринск'),
(6, 'г.Перелюб'),
(7, 'г.Абдулино'),
(8, 'г.Ува'),
(9, 'г.Александровское'),
(10, 'г.Сосновый Бор'),
(11, 'г.Акъяр'),
(12, 'г.Богатые Сабы');

-- --------------------------------------------------------

--
-- Структура таблицы `client`
--

CREATE TABLE `client` (
  `CLIENT_ID` int(11) NOT NULL,
  `CLIENT_NAME` varchar(255) NOT NULL,
  `BIRTHDATE` date NOT NULL,
  `GENDER` varchar(10) NOT NULL,
  `MOBILE_PHONE` varchar(20) NOT NULL,
  `ADDRESS` varchar(255) NOT NULL,
  `CONTRACTER` int(11) UNSIGNED NOT NULL,
  `TYPE_LOAN` int(11) NOT NULL,
  `DATA_AGR` date NOT NULL,
  `WAGES` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `client`
--

INSERT INTO `client` (`CLIENT_ID`, `CLIENT_NAME`, `BIRTHDATE`, `GENDER`, `MOBILE_PHONE`, `ADDRESS`, `CONTRACTER`, `TYPE_LOAN`, `DATA_AGR`, `WAGES`) VALUES
(1, 'Прокофьев Захар Матвеевич', '1982-11-17', 'муж', '8 (508) 502-90-72', 'ул. Садовая, дом 80, квартира 136', 1, 2, '2020-05-05', 50000);

-- --------------------------------------------------------

--
-- Структура таблицы `employes`
--

CREATE TABLE `employes` (
  `EMPLOYEE_ID` int(11) UNSIGNED NOT NULL,
  `EMPLOYEE_NAME` varchar(200) NOT NULL,
  `BIRTHDATE` date NOT NULL,
  `GENDER` varchar(10) NOT NULL,
  `MOBILE_PHONE` varchar(50) NOT NULL,
  `ADDRESS` varchar(50) NOT NULL,
  `POSITION` varchar(50) NOT NULL,
  `WAGES` int(8) NOT NULL,
  `WORKPLACE` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `employes`
--

INSERT INTO `employes` (`EMPLOYEE_ID`, `EMPLOYEE_NAME`, `BIRTHDATE`, `GENDER`, `MOBILE_PHONE`, `ADDRESS`, `POSITION`, `WAGES`, `WORKPLACE`) VALUES
(1, 'Сорокин Олег Святославович', '1981-09-08', 'муж', '8 (323) 851-53-95', 'ул. Заречная, дом 42, квартира 110', 'Менеджер', 45000, 1),
(3, 'Киселёв Кондрат Степанович', '1977-05-04', 'муж', '8 (754) 220-67-22', 'ул. Театральная, дом 3, квартира 35', 'Менеджер', 60000, 2),
(4, 'Жуков Трофим Артемович', '1978-05-07', 'муж', '8 (136) 740-21-69', 'ул. Ленинградская, дом 62, квартира 262', 'Менеджер', 45000, 3),
(5, 'Баранов Матвей Егорович', '1989-08-16', 'муж', '8 (576) 443-44-49', 'ул. Хрущёва, дом 48, квартира 180', 'Менеджер', 49000, 4),
(6, 'Лебедев Борис Иванович', '1971-07-20', 'муж', '8 (687) 214-85-17', 'ул. Садовая, дом 95, квартира 150', 'Менеджер', 55000, 5),
(7, 'Константинов Карл Рудольфович', '1992-07-19', 'муж', '8 (310) 740-29-23', 'ул. Достоевского, дом 39, квартира 218', 'Менеджер', 75000, 6),
(8, 'Федотов Рудольф Иосифович', '1982-03-09', 'муж', '8 (432) 183-15-24', 'ул. Хрущёва, дом 72, квартира 62', 'Менеджер', 45000, 7),
(9, 'Фомин Вячеслав Робертович', '1989-06-25', 'муж', '8 (707) 658-14-70', 'ул. Советская, дом 74, квартира 15', 'Менеджер', 25000, 8),
(10, 'Репина Яссения Леонидовна', '1980-11-20', 'жен', '+7 (903) 320-98-42', 'ул. Короленко, дом 85, квартира 312', 'Менеджер', 62000, 9),
(11, 'Киселёва Малохат Игоревна', '2000-11-19', 'жен', '8 (982) 505-51-10', 'ул. Лесная  (Приморский), дом 96, квартира 355', 'Младший менеджер', 30000, 10),
(12, 'Мамедова Ислям Матвеевна', '1990-05-20', 'жен', '8 (951) 391-62-77', 'ул. Монтажная, дом 26, квартира 127', 'Старший менеджер', 70000, 11),
(13, 'Ларина Анниета Эдуардовна', '1998-11-11', 'жен', '8  (987) 261-67-60', 'ул. Северный проезд, дом 45, квартира 122', 'Менеджер', 100000, 12);

-- --------------------------------------------------------

--
-- Структура таблицы `type_loan`
--

CREATE TABLE `type_loan` (
  `LOAN_ID` int(11) NOT NULL,
  `LOAN_NAME` varchar(100) NOT NULL,
  `MARKET_RATE` varchar(10) NOT NULL,
  `LOAN_PERIOD` varchar(20) NOT NULL,
  `MAX_LOAN_AMOUNT` int(9) NOT NULL,
  `DOWNPAYMENT` int(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `type_loan`
--

INSERT INTO `type_loan` (`LOAN_ID`, `LOAN_NAME`, `MARKET_RATE`, `LOAN_PERIOD`, `MAX_LOAN_AMOUNT`, `DOWNPAYMENT`) VALUES
(1, 'ДЛЯ ПРЕДПРИНИМАТЕЛЕЙ', '48%', 'На 1 год', 900000, 400000),
(2, 'ПОТРЕБИТЕЛЬСКИЙ', '15%', 'На 6 месяцев', 500000, 200000),
(3, 'ЭКСПРЕСС', '1%', 'На месяц', 40000, 15000);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `branch_office`
--
ALTER TABLE `branch_office`
  ADD PRIMARY KEY (`BRANCH_ID`),
  ADD KEY `CITY_OFFICE` (`CITY_OFFICE`);

--
-- Индексы таблицы `city`
--
ALTER TABLE `city`
  ADD PRIMARY KEY (`CITY_ID`);

--
-- Индексы таблицы `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`CLIENT_ID`),
  ADD KEY `CONTRACTER` (`CONTRACTER`,`TYPE_LOAN`),
  ADD KEY `TYPE_LOAN` (`TYPE_LOAN`);

--
-- Индексы таблицы `employes`
--
ALTER TABLE `employes`
  ADD PRIMARY KEY (`EMPLOYEE_ID`),
  ADD KEY `WORKPLACE` (`WORKPLACE`);

--
-- Индексы таблицы `type_loan`
--
ALTER TABLE `type_loan`
  ADD PRIMARY KEY (`LOAN_ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `branch_office`
--
ALTER TABLE `branch_office`
  MODIFY `BRANCH_ID` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT для таблицы `city`
--
ALTER TABLE `city`
  MODIFY `CITY_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT для таблицы `client`
--
ALTER TABLE `client`
  MODIFY `CLIENT_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `employes`
--
ALTER TABLE `employes`
  MODIFY `EMPLOYEE_ID` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `branch_office`
--
ALTER TABLE `branch_office`
  ADD CONSTRAINT `branch_office_ibfk_3` FOREIGN KEY (`CITY_OFFICE`) REFERENCES `city` (`CITY_ID`);

--
-- Ограничения внешнего ключа таблицы `client`
--
ALTER TABLE `client`
  ADD CONSTRAINT `client_ibfk_1` FOREIGN KEY (`CONTRACTER`) REFERENCES `employes` (`EMPLOYEE_ID`),
  ADD CONSTRAINT `client_ibfk_2` FOREIGN KEY (`TYPE_LOAN`) REFERENCES `type_loan` (`LOAN_ID`);

--
-- Ограничения внешнего ключа таблицы `employes`
--
ALTER TABLE `employes`
  ADD CONSTRAINT `employes_ibfk_1` FOREIGN KEY (`WORKPLACE`) REFERENCES `branch_office` (`BRANCH_ID`);

--
-- Ограничения внешнего ключа таблицы `type_loan`
--
ALTER TABLE `type_loan`
  ADD CONSTRAINT `type_loan_ibfk_1` FOREIGN KEY (`LOAN_ID`) REFERENCES `clients` (`TYPE_LOAN`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
