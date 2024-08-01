WITH EmployeeCTE AS (
    -- Miembro ancla: Comienza con el empleado especificado
    SELECT 
        employee_id, 
        first_name, 
        last_name, 
        manager_id
    FROM 
        Employee
    WHERE 
        employee_id = 10
    
    UNION ALL
    
    -- Miembro recursivo: Unir con la tabla de Empleados para encontrar al gerente
    SELECT 
        e.employee_id, 
        e.first_name, 
        e.last_name, 
        e.manager_id
    FROM 
        Employee e
    INNER JOIN 
        EmployeeCTE ecte ON e.employee_id = ecte.manager_id
)
SELECT 
    employee_id, 
    first_name, 
    last_name, 
    manager_id
FROM 
    EmployeeCTE;