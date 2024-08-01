WITH CharacterCTE AS (
    SELECT SUBSTRING(stringValue, n, 1) AS letter
    FROM (
        SELECT 'hello world' AS stringValue
    ) AS Data
    JOIN (
        SELECT TOP (LEN('hello world'))
        ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS n
        FROM sys.objects
    ) AS Numbers ON n <= LEN(stringValue)
)
SELECT letter, COUNT(*) AS CountLetters
FROM CharacterCTE
WHERE letter != ' '
GROUP BY letter
ORDER BY letter;
