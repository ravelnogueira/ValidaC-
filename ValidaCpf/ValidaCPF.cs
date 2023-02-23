using System;

class CPFValidator
{
    public bool ValidaCPF(string cpf)
    {
        cpf = cpf.Replace(".", "").Replace("-", ""); // remove caracteres especiais

        if (cpf.Length != 11) // verifica se o CPF tem 11 dígitos
        {
            return false;
        }

        // calcula o primeiro dígito verificador
        int soma = 0;
        for (int i = 0; i < 9; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (10 - i);
        }
        int resto = soma % 11;
        int digito1 = resto < 2 ? 0 : 11 - resto;

        if (int.Parse(cpf[9].ToString()) != digito1) // verifica se o primeiro dígito está correto
        {
            return false;
        }

        // calcula o segundo dígito verificador
        soma = 0;
        for (int i = 0; i < 10; i++)
        {
            soma += int.Parse(cpf[i].ToString()) * (11 - i);
        }
        resto = soma % 11;
        int digito2 = resto < 2 ? 0 : 11 - resto;

        if (int.Parse(cpf[10].ToString()) != digito2) // verifica se o segundo dígito está correto
        {
            return false;
        }

        return true;
    }
}