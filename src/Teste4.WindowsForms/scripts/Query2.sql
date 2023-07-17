SELECT 
	nome as 'Nome do Aluno', 
	sum(notaPrimeiroSemestre) as 'Nota do Primeiro Semestre', 
    sum(notaSegundoSemestre) as 'Nota do Segundo Semestre', 
    avg(notaPrimeiroSemestre + notaSegundoSemestre) as media_anual,
    ano as 'Ano',
    CASE
		WHEN avg(notaPrimeiroSemestre + notaSegundoSemestre) < 6.5 THEN  'Reprovado'
        ELSE 'Aprovado'
	END as Status
FROM escola.alunos 
GROUP BY nome, ano
HAVING media_anual > 6;