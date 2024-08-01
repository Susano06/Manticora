SELECT 
    a.AuthorName, 
    d.DoctorName, 
    COUNT(e.EpisodeId) AS Episodes
FROM 
    tblEpisode e
JOIN 
    tblAuthor a ON e.AuthorId = a.AuthorId
JOIN 
    tblDoctor d ON e.DoctorId = d.DoctorId
GROUP BY 
    a.AuthorName, 
    d.DoctorName
ORDER BY 
    a.AuthorName, 
    d.DoctorName;