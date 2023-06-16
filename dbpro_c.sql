create table Admins(
ID numeric(10),
A_Name varchar(20),
Email varchar(30),
A_Password varchar(30),
primary key (ID)
)

create table executive_student(
ROLL_NO varchar(10),
First_Name varchar(20),
Last_Name varchar(20),
S_Role varchar(15),
Email varchar (30),
S_Password varchar(30),
primary key (ROLL_NO)
)

create table Faculty_Mentors(
Mentor_ID numeric(10),
F_Name varchar(20),
Email varchar(30),
F_Password varchar(30),
primary key (Mentor_ID)
)

create table category(
Cat_ID numeric(10),
Secretary_ID varchar(10),
Mentor_ID numeric(10),
C_Name varchar(20),
primary key (cat_ID),
foreign key(Secretary_ID) references Executive_student(ROLL_NO),
foreign key(Mentor_ID) references  Faculty_Mentors(Mentor_ID)
)

create table sponsors(
Representative_CNIC varchar(20),
Representatvie_Name varchar(20),
Company_Name varchar(30),
Cat_ID numeric(10),
Package varchar(30),
Amount numeric (10),
primary key(Company_Name),
foreign key(cat_ID) references  category(cat_ID)
)

create table Eventss(
Event_ID numeric(10),
Event_Date Date,
Event_NAME varchar(20),
No_of_Participants numeric(5),
Price numeric(10),
Venue  varchar(20),
Timing  varchar(15),
HOE_ID  varchar(10),
Mentors_ID numeric(10),
CategoryID numeric(10),
primary key(event_id),
foreign key(hoe_ID) references  executive_student(ROLL_NO),
foreign key(Mentors_ID) references  Faculty_Mentors(Mentor_ID),
foreign key(CategoryID) references Category(Cat_ID)
)

create table participating_team(
Team_ID numeric(10),
Team_Name varchar(20),
Ambassador_Name varchar(20),
Ambassador_Contact varchar(20),
event_id numeric(10), 
primary key(team_id),
foreign key(event_ID) references  eventss(EVENT_ID) on delete cascade
)

create table participant(
PID numeric(5),
Cnic numeric(10),
P_Name varchar(20),
Email varchar(20),
Contact varchar(20),
institute_name varchar(20),
food_registration varchar(80),
team_id numeric(10),
event_id numeric(10), 
foreign key(team_ID) references  participating_team(team_ID),
foreign key(event_ID) references  eventss(EVENT_ID) on delete cascade,
primary key (PID)
)

select * from executive_student;
select * from Faculty_Mentors;
select * from category;
select * from Eventss;
select * from sponsors;
select * from participant;
select * from Admins;
select * from participating_team;

select PID from participant order by PID desc;
Select cat_ID from sponsors where Representative_CNIC = '12';

insert into participating_team values(1,'Team1','Ambasaador1','123456',1);

Select First_Name, Last_Name, S_Role, Email from executive_student where ROLL_NO = '1231';

insert into participant values(6,78126324,'Calveenee','ceke@gmail.com','24781','CEKE','1 burger, fries and 1 drink for Rs 500',1,1);

update Eventss set HOE_ID = NULL where HOE_ID = '1231';

select PID,Cnic,P_Name,Email,Contact,institute_name,food_registration,Team_Name from participant full outer join participating_team on participant.event_id = participating_team.event_id;

select sum(Amount) from sponsors;

select Faculty_Mentors.F_Name,Faculty_Mentors.Email,Faculty_Mentors.Mentor_ID from Faculty_Mentors where Faculty_Mentors.Mentor_ID in (select Eventss.Mentors_ID from Eventss where Eventss.CategoryID = 3) or Faculty_Mentors.Mentor_ID in (select category.Mentor_ID from category where Cat_ID = 3);

select executive_student.ROLL_NO,executive_student.Email,executive_student.First_Name,executive_student.Last_Name,executive_student.S_Role,Eventss.Event_NAME from executive_student inner join Eventss on executive_student.ROLL_NO = Eventss.HOE_ID;

select executive_student.ROLL_NO,executive_student.Email,executive_student.First_Name,executive_student.Last_Name,executive_student.S_Role from executive_student where executive_student.ROLL_NO in (select Eventss.HOE_ID from Eventss inner join category on Eventss.CategoryID = category.Cat_ID) or executive_student.ROLL_NO in (select category.Secretary_ID from category);

select executive_student.ROLL_NO,executive_student.Email,executive_student.First_Name,executive_student.Last_Name,executive_student.S_Role from executive_student order by executive_student.S_Role;

select * from participant where P_Name = 'LOKI';

select PID,P_Name,food_registration from participant order by food_registration;

select count(participant.event_id) from participant inner join Eventss on Eventss.Event_ID = participant.event_id where Eventss.Event_NAME = 'aero waRS';

select Eventss.*,Faculty_Mentors.F_Name as 'Mentor Name',executive_student.First_Name + executive_student.Last_Name as 'Event Head Name' from (Eventss full outer join Faculty_Mentors on Eventss.Mentors_ID = Faculty_Mentors.Mentor_ID) inner join executive_student on executive_student.ROLL_NO = Eventss.HOE_ID where Eventss.Event_NAME = 'ad-maniac';

select PID,P_Name,food_registration from participant inner join eventss on eventss.event_id = participant.event_id where eventss.categoryid = 3 order by food_registration