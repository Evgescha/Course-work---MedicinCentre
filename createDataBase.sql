DROP SCHEMA IF EXISTS medicincentre ;
CREATE SCHEMA IF NOT EXISTS medicincentre DEFAULT CHARACTER SET utf8 ;
USE medicincentre;

CREATE TABLE role (
	id INT AUTO_INCREMENT  unique,
    PRIMARY KEY(id) ,
	name VARCHAR(50) 
);
INSERT INTO role(id, name) VALUES (1, "Клиент");
INSERT INTO role(id, name) VALUES (2, "Сотрудник");

CREATE TABLE users(
	id INT AUTO_INCREMENT  unique PRIMARY KEY,
	fio VARCHAR(50),
	adres VARCHAR(50),
	phone VARCHAR(50),
	login VARCHAR(50),
	password VARCHAR(50),
	role INT(10),
    FOREIGN KEY (role) REFERENCES role(id)
);
INSERT INTO users(id, fio,adres,phone,login,password,role) VALUES (1,"Гусаков Андрей Иванович","Минск 12","88005553535","client1","client1",1);
INSERT INTO users(id, fio,adres,phone,login,password,role) VALUES (2,"Петров Иван Андреевич","Питерский 23","375254547818","client2","client2",1);
INSERT INTO users(id, fio,adres,phone,login,password,role) VALUES (3,"Король Потап Васильевич","Питерский 25","375442134585","user1","user1",2);
INSERT INTO users(id, fio,adres,phone,login,password,role) VALUES (4,"Тигрова Зинаида Михайловна","Ошанский 12а","375335487914","user2","user2",2);

CREATE TABLE medicin (
	id INT AUTO_INCREMENT  unique PRIMARY KEY,
	name VARCHAR(50),
    price FLOAT(16)
);
INSERT INTO medicin (id,name,price) VALUES(1,"Гидробеверин",100);
INSERT INTO medicin (id,name,price) VALUES(2,"Аспирин",3);
INSERT INTO medicin (id,name,price) VALUES(3,"Капл для линз",26);

CREATE TABLE delivery(
	id INT AUTO_INCREMENT  unique PRIMARY KEY,
    what INT(10),
    whenD DATE,
    count INT(10),
    FOREIGN KEY(what) REFERENCES medicin(id)
);
INSERT INTO delivery(id, what,whenD,count) VALUES(1,2,'2020-10-25',10);
INSERT INTO delivery(id, what,whenD,count) VALUES(2,3,'2020-11-04',20);
INSERT INTO delivery(id, what,whenD,count) VALUES(3,1,'2020-12-09',30);


CREATE TABLE warehouse(
	id INT AUTO_INCREMENT  unique PRIMARY KEY,
    what INT(10) unique,
    count INT(10),
    FOREIGN KEY(what) REFERENCES medicin(id)
);
INSERT INTO warehouse(id, what,count) VALUES(1,3,30);

CREATE TABLE sell(
	id INT AUTO_INCREMENT  unique PRIMARY KEY,
    who INT(10),
    toWho INT(10),
    what INT(10),
    whenD DATE,
    count INT(10),
    FOREIGN KEY(who) REFERENCES users(id),
    FOREIGN KEY(toWho) REFERENCES users(id),
    FOREIGN KEY(what) REFERENCES medicin(id)
);
INSERT INTO sell(id, who, toWho, what,whenD,count)  VALUES(1,1,2,3,'2020-12-01',5);
INSERT INTO sell(id, who, toWho, what,whenD,count)  VALUES(2,2,2,2,'2020-12-03',7);
INSERT INTO sell(id, who, toWho, what,whenD,count)  VALUES(3,1,1,2,'2020-12-03',9);
UPDATE warehouse SET count=count-5 WHERE what=3;
