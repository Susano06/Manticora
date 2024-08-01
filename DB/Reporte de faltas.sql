SELECT 
    employee_id,
    SUM(CASE WHEN absence_type_id = 2 THEN 1 ELSE 0 END) AS NUM_OF_ABSENCE_TYPE_2,
    SUM(CASE WHEN absence_type_id = 2 THEN num_of_hours ELSE NULL END) AS NUM_OF_HOURS,
    SUM(CASE WHEN absence_type_id = 3 THEN 1 ELSE 0 END) AS NUM_OF_ABSENCE_TYPE_3,
    SUM(CASE WHEN absence_type_id = 3 THEN num_of_hours ELSE NULL END) AS NUM_OF_HOURS,
    SUM(CASE WHEN absence_type_id = 8 THEN 1 ELSE 0 END) AS NUM_OF_ABSENCE_TYPE_8,
    SUM(CASE WHEN absence_type_id = 8 THEN num_of_hours ELSE NULL END) AS NUM_OF_HOURS
FROM 
    absence
GROUP BY 
    employee_id;
