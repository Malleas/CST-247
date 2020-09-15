select * from dbo.Users;

insert into dbo.Users(USERNAME, PASSWORD) values('test', 'test');

select * from dbo.Users where USERNAME = 'test';