CREATE TABLE Employee (
    employee_id INT,
    first_name NVARCHAR(50),
    last_name NVARCHAR(50),
    manager_id INT
);

INSERT INTO Employee (employee_id, first_name, last_name, manager_id)
VALUES
    (1, 'Alvin', 'Smith', NULL),
    (2, 'Jose', 'Jones', 1),
    (3, 'Amado', 'Taylor', 1),
    (4, 'Stuart', 'Williams', 2),
    (5, 'Demarcus', 'Brown', 2),
    (6, 'Mark', 'Davies', 2),
    (7, 'Merlin', 'Evans', 2),
    (8, 'Elroy', 'Wilson', 7),
    (9, 'Charles', 'Thomas', 7),
    (10, 'Rudolph', 'Roberts', 7);
