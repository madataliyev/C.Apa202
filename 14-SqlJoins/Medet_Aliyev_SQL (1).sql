create database Company
use Company 

create table Countries(
Id int primary key identity,
[Name] nvarchar(50) not null,
)

create table Cities(
Id int primary key identity,
[Name] nvarchar(50) not null,
CountriesId int foreign key references Countries(Id)
)

create table Employees(
Id int primary key identity,
[Name] nvarchar(50) not null,
Surname nvarchar(50) not null,
Age int,
Salary decimal(6,2),
Position nvarchar(50),
IsDeleted bit default 0,
CityId int foreign key references Cities(Id)
)

insert into Countries (Name) 
values
(N'Azerbaycan'), 
(N'Turkiye'), 
(N'Almaniya'), 
(N'Fransa'), 
(N'Yaponiya'), 
(N'Italiya')

insert into Cities (Name, CountriesId) 
values 
(N'Madrid', 1),
(N'Hamburg', 3),
(N'Istanbul', 2),
(N'Rome', 6),
(N'Marseille', 4),
(N'Osaka', 5),
(N'Izmir', 2),
(N'Nagoya', 5),
(N'Munich', 3),

insert into Employees (Name, Surname, Age, Salary, Position, IsDeleted, CityId) 
values 
(N'Carlos', N'Garcia', 27, 7777.77, N'Developer', 0, 1),
(N'Hans', N'Muller', 40, 3500.99, N'Reception', 0, 4),
(N'Mehmet', N'Yilmaz', 35, 2100.67, N'Manager', 0, 2),
(N'Luca', N'Rossi', 31, 4500.54, N'Developer', 0, 9),
(N'Pierre', N'Dubois', 36, 6800.73, N'Reception', 0, 3),
(N'Ahmet', N'Demir', 21, 6000.98, N'Manager', 0, 10),
(N'Takashi', N'Sato', 25, 5000.35, N'Developer', 1, 5),
(N'Mustafa', N'Kaya', 29, 3200.78, N'Reception', 0, 7)

select e.Name as EmployeesName, e.Surname as Surname, ci.Name as City, co.Name as Country from Employees as e
left join Cities as ci 
on e.CityId = ci.Id
left join Countries as co 
on ci.CountriesId = co.Id


select e.Name, co.Name as Country from Employees as e
inner join Cities as ci
on e.CityId = ci.Id
inner join Countries as co
on ci.CountriesId = co.Id
where e.Salary > 2000


select ci.Name as City, co.Name as Country from Cities as ci
left join Countries as co 
on ci.CountriesId = co.Id


select e.Name, e.Surname, e.Age, e.Salary, e.Position, e.IsDeleted,ci.Name as CityName, co.Name as CountryName 
from Employees as e
left join Cities as ci on e.CityId = ci.Id
left join Countries as co on ci.CountriesId = co.Id
where e.Position = 'Reception'


select  e.Name, e.Surname, ci.Name as City, co.Name as Country from Employees as e
inner join Cities as ci on e.CityId = ci.Id
inner join Countries as co on ci.CountriesId = co.Id
where e.IsDeleted = 1