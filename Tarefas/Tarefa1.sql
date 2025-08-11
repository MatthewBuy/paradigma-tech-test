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