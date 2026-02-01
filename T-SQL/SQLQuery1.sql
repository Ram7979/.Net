use LPU_DB

Select * from StudentInfo

Alter Table StudentInfo Add PhoneNo varchar(10)
Alter Table StudentInfo Add SchoolName varchar(10) default 'RKVM'

USE LPU_DB;

INSERT INTO StudentInfo (RollNo, Name, Age, LocalAddr, PreAddr, PhoneNo)
VALUES (45, 'Sai', 21, 'Punjab', 'Hyderabad', '9876543210');

UPDATE StudentInfo
SET Name = 'Teja',
    PhoneNo = '4561237890'
WHERE RollNo = 45;



create Table StudentMarks(srNO int identity(1000,1),
                                                    RollNo int References dbo.StudentInfo(RollNo), 
                                                    Phy int not null,
                                                    Chem int not null,
                                                    Maths int not null,
                                                    TotalMarks as (Phy+Chem+Maths),
                                                    Perc as ((Phy+Chem+Maths)/3)
                                                    )

Insert into StudentMarks(RollNo, Phy,Chem,Maths)values(45,80,85,65)
select * from StudentMarks