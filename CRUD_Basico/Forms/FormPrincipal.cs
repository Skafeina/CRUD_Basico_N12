using CRUD_Basico.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Basico
{
    public partial class FormPrincipal : Form
    {
        private List<Aluno> _alunos;
        private Aluno _alunoSelecionado;

        public FormPrincipal()
        {
            InitializeComponent();
            _alunos = new Aluno().ObterAlunos();
        }

        private void ConfiguraDgvAluno()
        {
            DgvAlunos.Columns.Add("Id", "Código");
            DgvAlunos.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DgvAlunos.Columns["Id"].Visible = false;

            DgvAlunos.Columns.Add("Nome", "Nome do Aluno");
            DgvAlunos.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DgvAlunos.Columns.Add("DtNasc", "Data de Nascimento");
            DgvAlunos.Columns["DtNasc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        private void CarregaDgvAluno()
        {
            DgvAlunos.Rows.Clear();

            //Ordenando a lista de alunos pelo Nome (ordem alfabética)
            _alunos = _alunos.OrderBy(a => a.Nome).ToList();

            foreach (Aluno aluno in _alunos)
            {
                DgvAlunos.Rows.Add(aluno.Id, aluno.Nome, aluno.DtNascimento.ToString("dd/MM/yyyy"));
            }

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                //List<Aluno> alunos = new Aluno().ObterAlunos();
                //DgvAlunos.DataSource = alunos.Where(a => a.Ativo).ToList();

                ConfiguraDgvAluno();
                CarregaDgvAluno();
                ConfiguraBotoesECampos(1);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _alunoSelecionado = _alunos.Find(a => a.Id == (int)DgvAlunos.Rows[e.RowIndex].Cells["Id"].Value);

            TxbNome.Text = _alunoSelecionado.Nome;
            DtpDtNascimento.Value = _alunoSelecionado.DtNascimento;
            CkbAtivo.Checked = _alunoSelecionado.Ativo;

            ConfiguraBotoesECampos(3);

        }

        private void ConfiguraBotoesECampos(int estilo)
        {
            if (estilo == 1)
            {
                TsbNovo.Enabled = true;
                TsbSalvar.Enabled = false;
                TsbEditar.Enabled = false;
                TsbExcluir.Enabled = false;

                TxbNome.Clear();
                TxbNome.Enabled = true;
                CkbAtivo.Enabled = true;
                CkbAtivo.Checked = true;
                DtpDtNascimento.Enabled = true;

                _alunoSelecionado = null;
            }
            else if (estilo == 2)
            {
                TsbNovo.Enabled = true;
                TsbSalvar.Enabled = true;
                TsbEditar.Enabled = false;
                TsbExcluir.Enabled = false;
            }
            else if (estilo == 3)
            {
                TsbNovo.Enabled = true;
                TsbSalvar.Enabled = false;
                TsbEditar.Enabled = true;
                TsbExcluir.Enabled = false;

                TxbNome.Enabled = false;
                DtpDtNascimento.Enabled = false;
                CkbAtivo.Enabled = false;
            }
            else if (estilo == 4)
            {
                TsbNovo.Enabled = true;
                TsbSalvar.Enabled = true;
                TsbEditar.Enabled = false;
                TsbExcluir.Enabled = true;

                TxbNome.Enabled = true;
                DtpDtNascimento.Enabled = true;
                CkbAtivo.Enabled = true;
            }

        }

        private void TsbNovo_Click(object sender, EventArgs e)
        {
            ConfiguraBotoesECampos(1);
        }

        private void TxbNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (TxbNome.Text.Trim().Length >= 2)
            {
                ConfiguraBotoesECampos(2);
            }
        }

        private void TsbEditar_Click(object sender, EventArgs e)
        {
            ConfiguraBotoesECampos(4);
        }

        private void TsbSalvar_Click(object sender, EventArgs e)
        {
            
            if (_alunoSelecionado == null)
            {
                //Cadastrar aluno novo
                try
                {
                    //Alimenta um novo objeto do tipo Aluno via construtor com as informações fornecidas pelo usuário
                    Aluno novoAluno = new Aluno(TxbNome.Text, DtpDtNascimento.Value, CkbAtivo.Checked);

                    //Cadastra o aluno no banco de dados
                    novoAluno.Cadastrar();
                    //Adiciona este novo aluno na lista de alunos
                    _alunos.Add(novoAluno);
                    //Recarrega o DataGriView aluno
                    CarregaDgvAluno();
                    //Configura os botões e campos como se tivesse clicado no botão "Novo" (parâmetro 1)
                    ConfiguraBotoesECampos(1);
                    MessageBox.Show($"Aluno cadastrado com sucesso:\n {novoAluno.Nome}\nId inserido pelo banco: {novoAluno.Id}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //Remover o aluno selecionado da lista de alunos
                _alunos.Remove(_alunoSelecionado);
                
                //Alterar um aluno existente
                _alunoSelecionado.Nome = TxbNome.Text;
                _alunoSelecionado.DtNascimento = DtpDtNascimento.Value;
                _alunoSelecionado.Ativo = CkbAtivo.Checked;

                try
                {
                    string retornoBD = _alunoSelecionado.Atualizar();
                    _alunos.Add(_alunoSelecionado);
                    CarregaDgvAluno();
                    ConfiguraBotoesECampos(1);
                    MessageBox.Show(retornoBD);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }

        private void TsbExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //Remover o aluno selecionado do banco e o retorno da frase sendo armazenado na variável
                string retornoBD = _alunoSelecionado.Excluir();
                //Remover o aluno da lista que está em memória
                _alunos.Remove(_alunoSelecionado);
                CarregaDgvAluno();
                ConfiguraBotoesECampos(1);
                MessageBox.Show(retornoBD);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
