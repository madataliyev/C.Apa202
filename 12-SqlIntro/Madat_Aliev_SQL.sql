create database Company
use Company
create table Employees(
EmployeeId int ,
FirstName nvarchar(50),
LastName nvarchar(50),
Email varchar(100),
PhoneNumber varchar(20),
HireDate date,
JobTitle nvarchar(100),
Salary decimal (10,2),
Department nvarchar(50)
)
insert into Employees(EmployeeId,FirstName,LastName,Email,PhoneNumber,HireDate,JobTitle,Salary,Department)
values
(1,N'Əli', N'Məmmədov', 'ali.m@edu.az', '+994501234567', '2023-01-15', N'Baş Proqramçı', 3500.50, N'İT'),
(2,N'Lalə', N'Həsənova', 'lala.h@aztu.com', '+994552345678', '2022-05-20', N'Analitik', 100.500, N'Data'),
(3,N'Leyla', N'Həsənova', 'leyla.h@company.az', '+994703456789', '2021-11-10', N'Menecer', 4200.75, N'Satış'),
(4,N'Günay', N'Bağırova', 'gunay.b@company.com', '+994504567890', '2023-03-01', N'Dizayner', 1900.00, N'Marketinq'),
(5,N'Fuad', N'Əliyev', 'fuad.a@company.az', '+994995678901', '2020-08-12', N'Mütəxəssis', 2150.25, N'Maliyyə')

select* from Employees
select * from Employees where salary>2000
select * from Employees where Department=N'IT'
select * from Employees order by salary desc
select FirstName,Salary from Employees
select*from Employees where HireDate>'2020'
select * from Employees where Email Like'%company.az'

select max(Salary) as MaxSalary from Employees 
select min (Salary) as MinSalary from Employees
select avg(Salary) as AvgSalary from Employees
select count (*) as EmpCount from Employees
select sum(Salary)  as SumSalary from Employees 

select Department , count(*) as CountDepartment from Employees group by Department
select Department , avg(Salary) as AvgSalaryDepartment from Employees group by Department
select Department , max(Salary) as MaxSalaryDepartment from Employees group by Department


update Employees set Salary=2800 where EmployeeId=1
update Employees set Salary=Salary*1.1 where Department=N'IT'
update Employees set JobTitle=N'HR Menecer ' where FirstName=N'Leyla' and LastName=N'Həsənova'


delete from Employees where EmployeeId=5
delete  from Employees where Salary<1500

select * from Employees where FirstName Like '%a%'
select* from Employees where Salary Between 2000 and 2500
select * from Employees where Department In (N'Maliyyə', N'IT')