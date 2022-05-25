create database Student;

use [Student]
GO

create table StudentInfo
(Student_Id int not null Primary Key identity(1,1),
First_Name varchar(50) not null,
Last_Name varchar(50),
Birth_Date date, 
Age int, check(Age>=18),
EmailAddress varchar(60) not null Unique,
Course varchar(30) Default 'Null',
CreatedBy varchar(20) not null,
CreatedAt datetime not null,
UpdatedBy varchar(20),
UpdatedAt datetime 
)
Insert into StudentInfo (First_Name,Last_Name,Birth_Date,Age,EmailAddress,Course,CreatedBy,CreatedAt)
Values
('Mahek' ,'Garg','2001-12-18',20,'mahek@g.com','CSE','Mahek Garg','2022-05-24 18:54:32'),
('Riya','Nara','2002-1-11',20,'riya@n.com','B.Com','Mahek Garg','2022-05-24 18:54:32'),
('Varnika' ,'Sharma','2002-05-22',21,'varnika@s.com','EE','Mahek Garg','2022-05-24 18:54:32'),
('Aayushi' ,'Agarwal','2000-10-29',22,'aayushi@a.com','ME','Mahek Garg','2022-05-24 18:54:32'),
('Ankit' ,'Bhasin','2001-02-13',21,'ankit@b.com','BA','Mahek Garg','2022-05-24 18:54:32'),
('Diksha' ,null,'2000-09-20',22,'diksha@n.com','B.Des','Mahek Garg','2022-05-24 18:54:32'),
('Priyanka' ,null,'2001-11-30',21,'priyanka@n.com','CSE','Mahek Garg','2022-05-24 18:54:32');
truncate table StudentInfo;