CREATE PROCEDURE SP_ExcluirAluno
	@Id	INT
AS
BEGIN
	-- Declaração de uma variável
	DECLARE @NomeAluno VARCHAR(200)

	-- Armazenando o nome do aluno na variável
	SELECT @NomeAluno = Nome 
	FROM Aluno 
	WHERE Id = @Id

	-- Deletando o aluno do banco
	DELETE 
	FROM Aluno 
	WHERE Id = @Id

	-- Retornando a frase de sucesso
	SELECT CONCAT('O(a) Aluno(a) ', @NomeAluno, ', foi excluído com sucesso!')
END