using System;
using System.Linq;

public static class Telefono
{
    // Questo metodo verifica un array di stringhe numeri di telefono e restituisce il primo numero di telefono italiano valido trovato.
    public static string Check(string[] vettore)
    {
        // Itera attraverso ogni numero di telefono nell'array di input.
        foreach (var num in vettore)
        {
            // Verifica se il numero di telefono corrente è un numero di telefono italiano valido.
            if (IsnumeroTelefonoItaliano(num))
            {
                // Se viene trovato un numero di telefono italiano valido, lo restituisce.
                return num;
            }
        }

        // Se non viene trovato alcun numero di telefono italiano valido, restituisce una stringa vuota.
        return "";
    }

    // Questo metodo verifica se una data stringa rappresenta un numero di telefono italiano valido.
    private static bool IsnumeroTelefonoItaliano(string num)
    {
        // Verifica se la stringa ha una lunghezza di 13 e inizia con "+39" o "0039".
        if (num.Length == 13 && (num.StartsWith("+39") || num.StartsWith("0039")))
        {
            return true;
        }
        // Verifica se la stringa ha una lunghezza di 14 e inizia con "0039".
        else if (num.Length == 14 && num.StartsWith("0039"))
        {
            return true;
        }
        // Verifica se la stringa ha una lunghezza di 10 e inizia con "3".
        else if (num.Length == 10 && num.StartsWith("3"))
        {
            return true;
        }

        // Se nessuna delle condizioni sopra elencate è soddisfatta, la stringa non rappresenta un numero di telefono italiano valido.
        return false;
    }
}
