using PrimeiroProjeto.Common;
using PrimeiroProjeto.Entities;
using PrimeiroProjeto.Models;
using PrimeiroProjeto.Repositories;

namespace PrimeiroProjeto.Services
{
    public class UsuarioService
    {
        private string _connectionString;
        public UsuarioService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public LoginResult Login(string email, string senha)
        {
            var result = new LoginResult();

            var usuarioRepository = new UsuarioRepository(_connectionString);

            var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

            if (usuario != null)
            {
                //usuario existe
                if (usuario.Senha == senha)
                {
                    //senha válida
                    result.sucesso = true;
                    result.usuarioGuid = usuario.UsuarioGuid;
                }
                else
                {
                    //senha inválida
                    result.sucesso = false;
                    result.mensagem = "Usuário ou senha inválidos";
                }
            }

            else
            {
                //usuario não existe
                result.sucesso = false;
                result.mensagem = "Usuário ou senha inválidos";
            }

            return result;
        }

        public CadastroResult Cadastro(string nome,
            string sobrenome,
            string telefone,
            string genero,
            string email,
            string senha)
        {
            var result = new CadastroResult();

            var usuarioRepository = new UsuarioRepository(_connectionString);

            var usuarioExistente = usuarioRepository.ObterUsuarioPorEmail(email);
            if (usuarioExistente != null)
            {
                //usuário já existe
                result.sucesso = false;
                result.mensagem = "Usuário já existe no sistema";
            }
            else
            {
                //usuário não existe
                var usuario = new Entities.Usuario();

                usuario.Nome = nome;
                usuario.Sobrenome = sobrenome;
                usuario.Telefone = telefone;
                usuario.Email = email;
                usuario.Genero = genero;
                usuario.Senha = senha;
                usuario.UsuarioGuid = Guid.NewGuid();

                var affectedRows = usuarioRepository.Inserir(usuario);

                if (affectedRows > 0)
                {
                    //inseriu com sucesso
                    result.sucesso = true;
                    result.usuarioGuid = usuario.UsuarioGuid;
                }
                else
                {
                    //erro ao inserir
                    result.sucesso = false;
                    result.mensagem = "Erro ao inserir usuário. Tente novamente";
                }

            }

            return result;
        }

        public EsqueceuSenhaResult EsqueceuSenha(string email)
        {
            var result = new EsqueceuSenhaResult();

            var usuarioRepository = new UsuarioRepository(_connectionString);

            var usuario = usuarioRepository.ObterUsuarioPorEmail(email);

            if (usuario == null)
            {
                //não existe
                result.sucesso = false;
                result.mensagem = "Usuário não existe";

            }
            else
            {
                //usuário existe

                var assunto = "Recuperação de Senha";
                var corpo = "Sua senha é " + usuario.Senha;

                var emailSender = new EmailSender();
                emailSender.Enviar(assunto, corpo, usuario.Email);

            }

            return result;
        }

        public Usuario ObterUsuario(Guid usuarioGuid)
        {
            var usuario = new UsuarioRepository(_connectionString).ObterPorGuid(usuarioGuid);

            return usuario;
        }
    }
}
