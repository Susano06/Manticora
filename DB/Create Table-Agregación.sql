CREATE TABLE tblAuthor (
    AuthorId INT PRIMARY KEY,
    AuthorName NVARCHAR(100)
);

CREATE TABLE tblDoctor (
    DoctorId INT PRIMARY KEY,
    DoctorNumber INT,
    DoctorName NVARCHAR(100),
    BirthDate DATE,
    FirstEpisodeDate DATE,
    LastEpisodeDate DATE
);

CREATE TABLE tblEpisode (
    EpisodeId INT PRIMARY KEY,
    SeriesNumber INT,
    EpisodeNumber INT,
    EpisodeType NVARCHAR(50),
    Title NVARCHAR(200),
    EpisodeDate DATE,
    AuthorId INT,
    DoctorId INT,
    Notes NVARCHAR(MAX),
    FOREIGN KEY (AuthorId) REFERENCES tblAuthor(AuthorId),
    FOREIGN KEY (DoctorId) REFERENCES tblDoctor(DoctorId)
);

-- Insertar datos en tblAuthor
INSERT INTO tblAuthor (AuthorId, AuthorName) VALUES
(1, 'Russell T. Davies'),
(2, 'Steven Moffat');

-- Insertar datos en tblDoctor
INSERT INTO tblDoctor (DoctorId, DoctorNumber, DoctorName, BirthDate, FirstEpisodeDate, LastEpisodeDate) VALUES
(1, 10, 'David Tennant', '1971-04-18', '2005-12-25', '2010-01-01'),
(2, 11, 'Matt Smith', '1982-10-28', '2010-04-03', '2013-12-25'),
(3, 9, 'Christopher Eccleston', '1964-02-16', '2005-03-26', '2005-06-18'),
(4, 12, 'Peter Capaldi', '1958-04-14', '2013-12-25', '2017-12-25');

-- Insertar datos en tblEpisode
INSERT INTO tblEpisode (EpisodeId, SeriesNumber, EpisodeNumber, EpisodeType, Title, EpisodeDate, AuthorId, DoctorId, Notes) VALUES
(1, 1, 1, 'Type1', 'Title1', '2005-03-26', 1, 1, 'Notes1'),
(2, 1, 2, 'Type1', 'Title2', '2005-04-02', 1, 1, 'Notes2'),
(3, 1, 3, 'Type1', 'Title3', '2005-04-09', 1, 1, 'Notes3'),
(4, 1, 4, 'Type1', 'Title4', '2005-04-16', 1, 1, 'Notes4'),
(5, 2, 1, 'Type1', 'Title5', '2010-04-03', 2, 2, 'Notes5'),
(6, 2, 2, 'Type1', 'Title6', '2010-04-10', 2, 2, 'Notes6'),
(7, 2, 3, 'Type1', 'Title7', '2010-04-17', 1, 3, 'Notes7'),
(8, 3, 1, 'Type1', 'Title8', '2013-12-25', 2, 4, 'Notes8'),
(9, 3, 2, 'Type1', 'Title9', '2014-01-01', 2, 4, 'Notes9'),
(10, 3, 3, 'Type1', 'Title10', '2014-01-08', 2, 4, 'Notes10'),
(11, 3, 4, 'Type1', 'Title11', '2014-01-15', 2, 4, 'Notes11');
