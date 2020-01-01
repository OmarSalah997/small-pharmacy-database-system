-------------Database creation-------------

create database pharmacies
Go
use pharmacies;

------------Table Creation-----------------
create table Pharmacy
(
Name varchar(50) not null,
Code varchar(4) not null,
Loc varchar(50) not null, 
Email varchar(20),
OpenTime time,
CloseTime time,
Rating int,
primary key (Code)
)

create table Client
(
Name varchar(50) not null,
UserName varchar(50) not null,
Pass varchar(50) not null,
Phone int ,
Addr varchar(50) not null,
Email varchar(20),
ID int not null,
primary key (ID)
)

create table Patient
(
Name varchar(50) not null,
UserName varchar(50) not null,
Pass varchar(50) not null,
Phone int ,
Addr varchar(50) not null,
Email varchar(20),
ID int not null,
Illness varchar(50),
primary key (ID)
)


create table Donor
(
Name varchar(50) not null,
UserName varchar(50) not null,
Pass varchar(50) not null,
Phone int ,
Email varchar(20),
ID int not null,
primary key (ID)
)

create table Employee
(
Name varchar(50) not null,
UserName varchar(50) not null,
Pass varchar(50) not null,
Phone int ,
Addr varchar(50) not null,
Email varchar(20),
SSN int not null,
Salary int,
Job varchar(50),
Age int,
PhCode varchar(4) not null,
primary key (SSN),
foreign key (PhCode) references Pharmacy
)

create table Manager
(
Name varchar(50) not null,
UserName varchar(50) not null,
pass varchar(50) not null,
Phone int ,
Addr varchar(50) not null,
Email varchar(20),
SSN int not null,
Salary int,
Job varchar(50),
Age int,
PhCode varchar(4) not null,
ExpYears int,
primary key (SSN),
foreign key (PhCode) references Pharmacy
)


create table Applicant
(
Name varchar(50) not null,
Phone int ,
Addr varchar(50) not null,
Email varchar(20),
SSN int not null,
Job varchar(50),
Gender varchar(50),
Age int,
PhCode varchar(4) not null,
Degree varchar(50) not null,
College varchar(50),
primary key (Email),
foreign key (PhCode) references Pharmacy
)

create table DegreeApplicant
(
Degree varchar(50),
Email varchar(20),
foreign key (Email)references  Applicant,


)


create table Supplier
(
Name varchar(50) not null,
Phone int ,
Email varchar(20),
ID int not null,
primary key (ID)
)

create table Drug
(
Name varchar(50) not null,
Type varchar(50),
Price int,
ExpDate date,
primary key (Name)
)

create table Instrument
(
Name varchar(50) not null,
Category varchar(50),
Type varchar(50),
ID int not null,
PhCode varchar (4),
primary key (ID),
foreign key (PhCode) references Pharmacy
)


create table Sales
(
Date date not null,
NumSold int,
Profit int,
losses int,
PhCode varchar (4),
primary key (Date),
foreign key(PhCode) references Pharmacy
)


create table contain
(
DrugName varchar(50),
PhCode varchar(4)
foreign key(PhCode) references Pharmacy,
foreign key(DrugName) references Drug
)

create table Request
(
ClientID int,
PhCode varchar(4),
DrugName varchar(50),
foreign key(PhCode) references Pharmacy,
foreign key(DrugName) references Drug,
foreign key(ClientId) references Client
)

create table Donate
(
DonorID int,
PatientID int,
DrugName varchar(50),
money int,
foreign key(DrugName) references Drug,
foreign key(PatientID) references Patient,
foreign key(DonorID) references Donor,

)


create table Supply
(
SupplierID int,
PhCode varchar(4),
DrugName varchar(50),
foreign key(PhCode) references Pharmacy,
foreign key(DrugName) references Drug,
foreign key(SupplierID) references Supplier
)

create table Users_basic
(
username varchar(50),
password varchar(50),
priv int
)


