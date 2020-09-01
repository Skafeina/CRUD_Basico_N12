CREATE PROCEDURE SP_InsereAluno 
	@nome VARCHAR(200), 
	@dtNasc DATETIME, 
	@ativo BIT
AS
BEGIN
	INSERT INTO Aluno
	VALUES (@nome, @dtNasc, @ativo)

	SELECT SCOPE_IDENTITY()
END