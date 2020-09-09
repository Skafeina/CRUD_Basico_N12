CREATE PROCEDURE SP_AtualizaAluno
	@Nome			VARCHAR(200),
	@DtNascimento	DATETIME,
	@Ativo			BIT,
	@Id				INT
AS
BEGIN
	UPDATE Aluno
	SET Nome = @Nome,
		DtNascimento = @DtNascimento,
		Ativo = @Ativo
	WHERE Id = @Id

	SELECT CONCAT('O(a) Aluno(a) de Id ', @Id, ', foi alterado com sucesso!')
END