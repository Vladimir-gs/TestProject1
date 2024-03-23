namespace TestProject1;

public class UnitTest1
{
    [Fact]

    public void Mas_de_8_Caracteres()
    {
        var Prueba = new Contrase�as();

        bool result = Prueba.Contrase�aSegura("12345678");

        Assert.False(result);
    }
    [Fact]
    public void Contiene_Mayusculas()
    {
        var Prueba = new Contrase�as();

        bool result = Prueba.ContieneMayusculas("Vladimir123");

        Assert.True(result);
    }
    [Fact]
    public void Contiene_Simbolos()
    {
        var Prueba = new Contrase�as();

        bool result = Prueba.ContieneSimbolos("#Vladi112312");

        Assert.True(result);
    }
}
public class Contrase�as
{
    public bool Contrase�aSegura(string contrase�a)
    {
        if (contrase�a.Length >= 8)
        {
            return false;
        }
        return true;
    }

    public bool ContieneMayusculas(string contrase�a)
    {
        return contrase�a.Any(c => char.IsLetter(c) && char.IsUpper(c));
    }

    public bool ContieneSimbolos(string contrase�a)
    {
        return contrase�a.Any(c => char.IsSymbol(c) || !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));
    }
}
