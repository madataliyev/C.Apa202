create database  CompanyMM
use CompanyMM
create table Employees(
EmployeeId int  primary key identity,
FirstName nvarchar (50) not null,
LastName nvarchar(50) not null ,
BirthDate Date not null,
Email varchar (50) unique
)


INSERT INTO Employees (FirstName, LastName, BirthDate, Email)
VALUES 
('Ali', 'Aliyev', '1990-05-15', 'ali@mail.com'),
('Leyla', 'Mammadova', '1995-08-20', 'leyla@mail.com'),
('Anar', 'Hasanov', '1988-12-10', 'anar@mail.com'),
('Gunel', 'Isayeva', '1992-03-05', 'gunel@mail.com'),
('Vugar', 'Rzayev', '1991-07-25', 'vugar@mail.com')


create table Projects (
ProjectId int primary key identity,
ProjectName nvarchar(50) not null,
StartDate Date not null,
EndDAte DAte null
)

INSERT INTO Projects (ProjectName, StartDate, EndDate)
VALUES 
('E-Commerce App', '2024-01-01', '2024-12-31'),
('Bank System Update', '2024-02-15', NULL),
('Mobile UI Design', '2024-05-01', '2024-08-01')
 

create table EmployeeProjects(
EmployeeID int foreign key  references Employees(EmployeeId),
ProjectId int foreign key  references Projects(ProjectId),
AssignedDate Date ,
Primary key (EmployeeId,ProjectId)
)

INSERT INTO EmployeeProjects(EmployeeID, ProjectID, AssignedDate)
VALUES 
(1, 1, '2024-01-05'), 
(1, 2, '2024-02-20'), 
(2, 1, '2024-01-10'),
(3, 2, '2024-03-01'),
(4, 3, '2024-05-05'),
(5, 3, '2024-05-10')

select* from Employees
select * from Projects


select e.FirstName,e.LastName,p.ProjectName from Employees as e
join EmployeeProjects as ep 
on e.EmployeeId=ep.EmployeeID
join Projects as p
on ep.ProjectId=p.ProjectId

select Count(e.EmployeeId) as EmployeeCount ,p.ProjectName from Employees as e
join EmployeeProjects as ep 
on e.EmployeeId=ep.EmployeeID
join Projects as p
on ep.ProjectId=p.ProjectId
group by  p.ProjectName
having Count(e.EmployeeId)>2


create view EmployeeProjectView
as
select e.EmployeeId, e.FirstName +''+e.LastName as FullName, p.ProjectId, p.ProjectName,ep.AssignedDate from Employees as e
join EmployeeProjects as ep 
on e.EmployeeId=ep.EmployeeID
join Projects as p
on ep.ProjectId=p.ProjectId


select * from EmployeeProjectView where EmployeeId=1




create procedure sp_AssignEmployeeToProject (@empId int,@projId int)
as
begin
    IF NOT EXISTS (select 1 from EmployeeProjects where EmployeeID = @empId and ProjectID = @projId)
    begin
        insert into EmployeeProjects (EmployeeID, ProjectID)
        values (@empId, @projId);
    end
end




create function fn_GetProjectCount(@empId int) 
returns int
as
begin
    declare @p_count int;
    select @p_count = Count(*) from EmployeeProjects where EmployeeID = @empId;
    return @p_count;
end




select FirstName, LastName, dbo.fn_GetProjectCount(EmployeeID) as TotalProjects 
from Employees

exec sp_AssignEmployeeToProject @empId = 2, @projId = 2

delete from EmployeeProjects where EmployeeID = 5

select * from EmployeeProjectView