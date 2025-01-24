create database Medical_Store_Management;

use Medical_Store_Management;

create table users(

id int identity(1,1) primary key,
userRole varchar(50) not null,
name varchar(250) not null,
dob varchar(250) not null,
mobile bigint not null,
email varchar(250) not null,
username varchar(250) unique not null,
pass varchar(250) not null
)

--userRole,name,dob,mobile,email,username,pass

select * from users;


create table medic(
id int identity(1,1) primary key,
mid varchar(250) not null,
mname varchar(250) not null,
mnumber varchar(250) not null,
MFGdate varchar(250) not null,
EXPdate varchar(250) not null,
quantity bigint not null,
perunit bigint not null
);

--mid,mname,mnumber,MFGdate,EXPdate,quantity,perunit

select * from medic;

select count(mname) from medic where EXPdate >= getdate(); --cant compare sting values to date time

select count(mname) from medic where CONVERT(DATE,SUBSTRING(EXPdate,CHARINDEX(' ', EXPdate) + 1, LEN(EXPdate)),106) >= CONVERT(DATE, GETDATE(),106);



create table cust(
id int identity(1,1) primary key,
cname varchar(250) not null,
dop varchar(250) not null,
items varchar(250) not null,
priceperunit varchar(250) not null,
numberofitems varchar(250) not null,
totalprice bigint  not null

);

select * from cust;

