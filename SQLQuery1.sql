create database bloodbank;
use bloodbank;
create table newDonor
(
did int NOT NULL IDENTITY(1,1) primary key,
dname varchar(250) NOT NULL,
fname varchar(250) NOT NULL,
dob varchar(50) NOT NULL,
mobile bigint NOT NULL,
gender varchar(25) NOT NULL,
email varchar(250) NOT NULL,
blood varchar(250) NOT NULL,
city varchar(150) NOT NULL,
daddress varchar(250) NOT NULL,
)

select max(did) from newDonor;

select * from newDonor
INSERT INTO newDonor (dname,fname,dob,mobile,gender,email,blood,city,daddress) VALUES('fahad','asghar','1/2/2022','0312221313','male','fahad@gmail.com','A+','Lahore','Johar Town');
INSERT INTO newDonor 
VALUES (1);

create table stocks(
bid int NOT NULL IDENTITY(1,1) primary key,
blood varchar(50) not null,
quantity varchar(50) not null
)

insert into stocks (blood,quantity) values ('A+',100);
insert into stocks (blood,quantity) values ('O+',100);
insert into stocks (blood,quantity) values ('B+',100);
insert into stocks (blood,quantity) values ('AB+',100);
insert into stocks (blood,quantity) values ('A-',100);

select * from stocks;