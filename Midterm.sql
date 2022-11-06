create database forlogin;
use forlogin;
create table users(
id int identity primary key ,
username nvarchar(50) not null ,
passwordd nvarchar(50) not null ,
loginType int not null 
);
insert into users(username , passwordd, loginType)values('nizam' ,'1234', 1), ('mira' , '1234', 2);
create table crud(
id int  primary key ,
kat nvarchar(50) not null ,
xwardn nvarchar(50) not null ,
);
select * from crud;
create table crud(
id int  primary key ,
username nvarchar(50) not null ,
gender nvarchar(50) not null ,
fav nvarchar(50) not null ,
birth nvarchar(50) not null ,
lang nvarchar(50) not null ,
);