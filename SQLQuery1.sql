create table billTable ( NAME varchar(50), ROOM varchar(10), RATE float, TIME float);

insert into billTable (NAME, ROOM, RATE, TIME) values ('Room1Light1', 'Room1', 15, 0)
insert into billTable (NAME, ROOM, RATE, TIME) values ('Room1Light2', 'Room1', 30, 0)
insert into billTable (NAME, ROOM, RATE, TIME) values ('Room1Light3', 'Room1', 45, 0)

insert into billTable (NAME, ROOM, RATE, TIME) values ('Room2Light1', 'Room2', 15, 0)
insert into billTable (NAME, ROOM, RATE, TIME) values ('Room2Light2', 'Room2', 30, 0)
insert into billTable (NAME, ROOM, RATE, TIME) values ('Room2Light3', 'Room2', 45, 0)

insert into billTable (NAME, ROOM, RATE, TIME) values ('Room3Light1', 'Room3', 15, 0)
insert into billTable (NAME, ROOM, RATE, TIME) values ('Room3Light2', 'Room3', 30, 0)
insert into billTable (NAME, ROOM, RATE, TIME) values ('Room3Light3', 'Room3', 45, 0)

insert into billTable (NAME, ROOM, RATE, TIME) values ('Room4Light1', 'Room4', 15, 0)
insert into billTable (NAME, ROOM, RATE, TIME) values ('Room4Light2', 'Room4', 30, 0)
insert into billTable (NAME, ROOM, RATE, TIME) values ('Room4Light3', 'Room4', 45, 0)

insert into billTable (NAME, ROOM, RATE, TIME) values ('Room5Light1', 'Room5', 15, 0)
insert into billTable (NAME, ROOM, RATE, TIME) values ('Room5Light2', 'Room5', 30, 0)
insert into billTable (NAME, ROOM, RATE, TIME) values ('Room5Light3', 'Room5', 45, 0)

insert into billTable (NAME, ROOM, RATE, TIME) values ('Room6Light1', 'Room6', 15, 0)
insert into billTable (NAME, ROOM, RATE, TIME) values ('Room6Light2', 'Room6', 30, 0)
insert into billTable (NAME, ROOM, RATE, TIME) values ('Room6Light3', 'Room6', 45, 0)

/* delete the table */
drop table billTable

/* display all intems */
select * from billTable

/* display time */
select TIME from billTable

/*
server name : (localdb)\mssqllocaldb
database name : mylocalDB
*/
