-- Para cada departamento, pega o funcionário com maior salário
SELECT 
    d.Nome AS Departamento,
    p.Nome AS Pessoa,
    p.Salario
FROM Departamento d
CROSS APPLY (
    SELECT TOP 1 Nome, Salario
    FROM Pessoa
    WHERE DeptId = d.Id
    ORDER BY Salario DESC, Id ASC
) p;

-- Alternativa usando JOIN e subconsulta

SELECT 
    d.Nome AS Departamento,
    p.Nome AS Nome,
    p.Salario AS Salario
FROM Pessoa p
JOIN Departamento d 
    ON p.DeptId = d.Id
JOIN (
    SELECT 
        DeptId, 
        MAX(Salario) AS MaxSalario
    FROM Pessoa
    GROUP BY DeptId
) m 
    ON p.DeptId = m.DeptId 
    AND p.Salario = m.MaxSalario
ORDER BY 
    d.Nome, 
    p.Nome;