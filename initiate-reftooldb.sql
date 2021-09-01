CREATE DATABASE reftooldb;

CREATE TABLE Teams (
    ID int IDENTITY(1,1) PRIMARY KEY,
    TeamName varchar(MAX) NOT NULL
);

CREATE TABLE Players (
    ID int IDENTITY(1,1) PRIMARY KEY,
    FirstName varchar(MAX),
    LastName varchar(MAX),
    Number int,
    TeamId int NOT NULL FOREIGN KEY REFERENCES Teams(ID),
);

INSERT INTO Teams(TeamName) VALUES ('Chicago Bulls');
INSERT INTO Teams(TeamName) VALUES ('Milwaukee Bucks');

DECLARE @PlayerTeamId AS int;
SELECT @PlayerTeamId = [ID] FROM Teams WHERE TeamName='Chicago Bulls';

INSERT INTO Players(FirstName, LastName, Number, TeamId) VALUES
    ('Lonzo', 'Ball', 2, @PlayerTeamId),
    ('Alex', 'Caruso', 4, @PlayerTeamId),
    ('Zach', 'Lavine', 8, @PlayerTeamId),
    ('Lauri', 'Markkanen', 24, @PlayerTeamId),
    ('Ryan', 'Arcidiacono', 51, @PlayerTeamId),
    ('Nikola', 'Vucevic', 9, @PlayerTeamId),
    ('Coby', 'White', 0, @PlayerTeamId),
    ('Patrick', 'Williams', 44, @PlayerTeamId);

SELECT @PlayerTeamId = [ID] FROM Teams WHERE TeamName='Milwaukee Bucks';

INSERT INTO Players(FirstName, LastName, Number, TeamId) VALUES
    ('Giannis', 'Antetokounmpo', 34, @PlayerTeamId),
    ('Thanasis', 'Antetokounmpo', 43, @PlayerTeamId),
    ('Pat','Connaughton', 24, @PlayerTeamId),
    ('Donte', 'DiVincenzo', 0, @PlayerTeamId),
    ('George', 'Hill', 33, @PlayerTeamId),
    ('Jrue', 'Holiday', 21, @PlayerTeamId),
    ('Justin', 'Jackson', 44, @PlayerTeamId),
    ('Khris', 'Middleton', 22, @PlayerTeamId),
    ('Brook', 'Lopez', 11, @PlayerTeamId);