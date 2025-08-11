# Avaliação Técnica - Paradigma

Este repositório contém a solução para a avaliação técnica da Paradigma, que consiste em duas tarefas:

## Tarefa 1 - SQL Query

Consulta SQL para encontrar os colaboradores com maior salário em cada departamento.

Para testar a query:

1. Acesse [SQLite Online](https://sqliteonline.com/)
2. Execute os seguintes comandos para criar as tabelas:

```sql
CREATE TABLE Departamento (
    Id INT PRIMARY KEY,
    Nome VARCHAR(100)
);

CREATE TABLE Pessoa (
    Id INT PRIMARY KEY,
    Nome VARCHAR(100),
    Salario DECIMAL(10,2),
    DeptId INT,
    FOREIGN KEY (DeptId) REFERENCES Departamento(Id)
);

-- Insira os dados de exemplo
INSERT INTO Departamento VALUES (1, 'TI');
INSERT INTO Departamento VALUES (2, 'Vendas');

INSERT INTO Pessoa VALUES (1, 'Joe', 70000, 1);
INSERT INTO Pessoa VALUES (2, 'Henry', 80000, 2);
INSERT INTO Pessoa VALUES (3, 'Sam', 60000, 2);
INSERT INTO Pessoa VALUES (4, 'Max', 90000, 1);
```

3. Execute a query da Tarefa1.sql

## Tarefa 2 - Construção de Árvore

Implementação em C# de um algoritmo para construir uma árvore seguindo regras específicas:

- A raiz deve ser o maior valor do array
- Galhos da esquerda devem ser compostos somente por números à esquerda do valor raiz, na ordem decrescente
- Galhos da direita devem ser compostos somente por números à direita do valor raiz, na ordem decrescente

Para testar o código:

1. Acesse [.NET Fiddle](https://dotnetfiddle.net/)
2. Copie o conteúdo de Tarefa2.cs
3. Execute o código para ver a construção das árvores com os arrays de exemplo

### Exemplos implementados:

**Cenário 1:**

- Array de entrada: [3, 2, 1, 6, 0, 5]
- Visualização da árvore construída conforme as regras

**Cenário 2:**

- Array de entrada: [7, 5, 13, 9, 1, 6, 4]
- Visualização da árvore construída conforme as regras

## Tecnologias Utilizadas

- SQL
- C# (.NET)

## Autor

Para mais informações sobre o autor e sua maneira de codar, visite seu perfil no GitHub.
