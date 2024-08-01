CREATE TABLE Absence (
    employee_id INT,
    absence_type_id INT,
    num_of_hours INT,
    absence_date DATE
);

INSERT INTO Absence (employee_id, absence_type_id, num_of_hours, absence_date)
VALUES
    (5, 2, 9, '2017-01-02'),
    (5, 2, 9, '2017-01-08'),
    (5, 3, 6, '2017-01-05'),
    (6, 2, 6, '2017-01-02'),
    (6, 3, 6, '2017-01-05'),
    (6, 8, 9, '2017-01-08'),
    (7, 2, 2, '2017-12-07'),
    (7, 8, 5, '2017-12-13'),
    (7, 8, 1, '2017-12-08'),
    (7, 8, 9, '2017-12-07'),
    (8, 2, 3, '2017-09-14'),
    (8, 3, 2, '2017-09-15'),
	(8, 8, 9, '2017-09-18');
