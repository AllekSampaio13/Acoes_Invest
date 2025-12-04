namespace AcoesInvest.Domain.Models;

public class Usuarios
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }

    public Usuarios(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }

    public void Atualizar(string nome, string email)
    {
        Nome = nome;
        Email = email;
    }


}
