CREATE PROCEDURE SP_ExcluirAluno
	@Id	INT
AS
BEGIN
	-- Declara��o de uma vari�vel
	DECLARE @NomeAluno VARCHAR(200)

	-- Armazenando o nome do aluno na vari�vel
	SELECT @NomeAluno = Nome 
	FROM Aluno 
	WHERE Id = @Id

	-- Deletando o aluno do banco
	DELETE 
	FROM Aluno 
	WHERE Id = @Id

	-- Retornando a frase de sucesso
	SELECT CONCAT('O(a) Aluno(a) ', @NomeAluno, ', foi exclu�do com sucesso!')
END