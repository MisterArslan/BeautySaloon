USE [Master]
GO
CREATE DATABASE beauty_saloon;
GO
USE beauty_saloon;
GO
CREATE TABLE employees
(  
   employeeID int IDENTITY (1,1) NOT NULL,
   surname varchar(50) NOT NULL,
   name varchar(50) NOT NULL,
   lastname varchar(50) NOT NULL,
   phone_number varchar(20) NOT NULL,
   address varchar(50) NOT NULL,
   specialization varchar(100) NOT NULL,
   start_date date NOT NULL,
   CONSTRAINT PK_employees_employeeID PRIMARY KEY CLUSTERED (employeeID)
);
CREATE TABLE services
(  
   serviceID int IDENTITY (1,1) NOT NULL,
   name varchar(50) NOT NULL,
   price int NOT NULL,
   comment text,
   CONSTRAINT PK_services_serviceID PRIMARY KEY CLUSTERED (serviceID)
);
CREATE TABLE clients
(  
   clientID int IDENTITY (1,1) NOT NULL,
   surname varchar(50),
   name varchar(50) NOT NULL,
   phone_number varchar(20) NOT NULL,
   CONSTRAINT PK_clients_clientID PRIMARY KEY CLUSTERED (clientID)
);
CREATE TABLE records
(  
   recordID int IDENTITY (1,1) NOT NULL,
   client_id int FOREIGN KEY REFERENCES clients(clientID) NOT NULL,
   employee_id int FOREIGN KEY REFERENCES employees(employeeID) NOT NULL,
   service_id int FOREIGN KEY REFERENCES services(serviceID) NOT NULL,
   date date NOT NULL,
   time time NOT NULL,
   comment text,
   CONSTRAINT PK_records_recordID PRIMARY KEY CLUSTERED (recordID)
);
CREATE TABLE shares
(  
   shareID int IDENTITY (1,1) NOT NULL,
   name varchar(100) NOT NULL,
   start_date date NOT NULL,
   expiration_date date,
   CONSTRAINT PK_shares_shareID PRIMARY KEY CLUSTERED (shareID)
);
CREATE TABLE discounts
(  
   discountID int IDENTITY (1,1) NOT NULL,
   share_id int FOREIGN KEY REFERENCES shares(shareID) NOT NULL,
   service_id int FOREIGN KEY REFERENCES services(serviceID) NOT NULL,
   value int NOT NULL,
   CONSTRAINT PK_discounts_discountID PRIMARY KEY CLUSTERED (discountID)
);
/*employees*/
INSERT INTO employees VALUES('Александрова', 'Александра', 'Александровна', '+79875554141', 'Татарстан, Казань', 'Специалист по мужским стрижкам', '2018-01-01');
INSERT INTO employees VALUES('Бирушина', 'Соня', 'Самуиловна', '+79875554141', 'Татарстан, Казань', 'Специалист по окрашиванию волос', '2018-02-03');
INSERT INTO employees VALUES('Мозайкина', 'Татьяна', 'Борисовна', '+79875554141', 'Татарстан, Казань', 'Специалист по женским стрижкам', '2017-12-15');
INSERT INTO employees VALUES('Ульянова', 'Мария', 'Алексеевна', '+79875554141', 'Татарстан, Казань', 'Специалист по женским и мужским стрижкам', '2018-01-09');
INSERT INTO employees VALUES('Шарафина', 'Марина', 'Дмитриевна', '+79875554141', 'Татарстан, Казань', 'Специалист по мэйкапу', '2018-01-06');
INSERT INTO employees VALUES('Осипова', 'Надежда', 'Евдосеевна', '+79875554141', 'Татарстан, Казань', 'Специалист по маникюру', '2018-02-04');
INSERT INTO employees VALUES('Пирогова', 'Ксения', 'Константиновна', '+79875554141', 'Татарстан, Казань', 'Специалист по мэйкапу', '2018-01-24');
INSERT INTO employees VALUES('Дебошина', 'Варвара', 'Евгеньевна', '+79875554141', 'Татарстан, Казань', 'Специалист по окрашиванию волос', '2018-01-18');
INSERT INTO employees VALUES('Каморина', 'Дарья', 'Ульяновна', '+79875554141', 'Татарстан, Казань', 'Администратор', '2017-12-25');
INSERT INTO employees VALUES('Хасанова', 'Юлия', 'Леонидовна', '+79875554141', 'Татарстан, Казань', 'Специалист по маникюру', '2017-12-10');
/*services*/
INSERT INTO services VALUES('Женская стрижка', 500, 'Цена варьируется от 400 до 600 в зависимости от количества работы специалиста');
INSERT INTO services VALUES('Мужская стрижка', 300, 'Цена варьируется от 200 до 400 в зависимости от количества работы специалиста');
INSERT INTO services VALUES('Маникюр', 500, '');
INSERT INTO services VALUES('Мэйкап', 200, 'Цена варьируется от 200 до 400 в зависимости от количества используемой косметики');
INSERT INTO services VALUES('Окрашивание волос', 300, '');
/*clients*/
INSERT INTO clients VALUES('Аистов', 'Кирилл', '+79875554141');
INSERT INTO clients VALUES('Аллаяров', 'Руслан', '+79875554141');
INSERT INTO clients VALUES('Анисеня', 'Иван', '+79875554141');
INSERT INTO clients VALUES('Байдин', 'Никита', '+79875554141');
INSERT INTO clients VALUES('Басова', 'Александра', '+79875554141');
INSERT INTO clients VALUES('Воротников', 'Алексей', '+79875554141');
INSERT INTO clients VALUES('Гордеева', 'Ангелина', '+79875554141');
INSERT INTO clients VALUES('Горелова', 'Анна', '+79875554141');
INSERT INTO clients VALUES('Демидова', 'Анна', '+79875554141');
INSERT INTO clients VALUES('Кондратенков', 'Борис', '+79875554141');
INSERT INTO clients VALUES('Корчагин', 'Никита', '+79875554141');
INSERT INTO clients VALUES('Манкевич', 'Павел', '+79875554141');
INSERT INTO clients VALUES('Нерсисян', 'Степан', '+79875554141');
INSERT INTO clients VALUES('Новосад', 'Виктор', '+79875554141');
INSERT INTO clients VALUES('Петрова', 'Александра', '+79875554141');
INSERT INTO clients VALUES('Попов', 'Юрий', '+79875554141');
INSERT INTO clients VALUES('Рыхова', 'Александра', '+79875554141');
INSERT INTO clients VALUES('Дергач', 'Петр', '+79875554141');
INSERT INTO clients VALUES('Алешин', 'Антон', '+79875554141');
INSERT INTO clients VALUES('Алексеев', 'Александр', '+79875554141');
/*records*/
INSERT INTO records VALUES(5, 2, 5, '2017-03-01', '11:30', '');
INSERT INTO records VALUES(1, 1, 2, '2017-03-01', '12:30', 'Может опоздать на 10-15 минут');
INSERT INTO records VALUES(16, 2, 1, '2017-03-01', '13:30', '');
INSERT INTO records VALUES(6, 4, 4, '2017-03-02', '10:30', '');
INSERT INTO records VALUES(7, 5, 3, '2017-03-01', '14:30', 'Заросший(ая)');
INSERT INTO records VALUES(9, 8, 5, '2017-03-01', '15:30', 'Странный человек, оплату брать заранее');
INSERT INTO records VALUES(19, 7, 1, '2017-03-02', '11:30', '');
INSERT INTO records VALUES(3, 6, 3, '2017-03-02', '12:30', '');
INSERT INTO records VALUES(12, 2, 4, '2017-03-02', '13:30', 'Друг подруги, относиться бережно');
INSERT INTO records VALUES(10, 1, 2, '2017-03-02', '14:30', '');
/*shares*/
INSERT INTO shares VALUES('Семейная среда', '2017-01-01', '');
INSERT INTO shares VALUES('Возраст не помеха', '2017-02-01', '2018-05-01');
INSERT INTO shares VALUES('Дети - радость жизни', '2017-02-01', '2018-05-01');
INSERT INTO shares VALUES('Лысый, не горюй', '2017-01-01', '2018-12-31');
/*discounts*/
INSERT INTO discounts VALUES(4, 1, 70);
INSERT INTO discounts VALUES(4, 2, 70);
INSERT INTO discounts VALUES(1, 1, 15);
INSERT INTO discounts VALUES(1, 2, 15);
INSERT INTO discounts VALUES(2, 1, 30);
INSERT INTO discounts VALUES(2, 2, 30);
INSERT INTO discounts VALUES(2, 4, 30);
INSERT INTO discounts VALUES(2, 5, 30);
INSERT INTO discounts VALUES(3, 1, 10);
INSERT INTO discounts VALUES(3, 2, 10);
INSERT INTO discounts VALUES(3, 5, 10);