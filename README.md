# Check Telefono

-Per prima cosa dobbiamo scaricare il file da classroom e rinominarlo\
-Poi dobbiamo aprire la cartella su visual studio code\
-Dopo inizia il vero programma\

-Prima di tutto dobbiamo scorrere ogni elemento dentro all'array usando un foreach:\
###
    foreach (var num in vettore){}
###
-Dentro a questo vettore richiamiamo il metotodo IsnumeroTelefonoItaliano e controlliamo che "num" sia valido:\
###
     if (IsnumeroTelefonoItaliano(num))
            {
                return num;
            }   
###

-Ora creiamo un metodo che verifchi le varie caratteristiche che deve avere il numero di telefono\

-In questo modo verifichiamo lunghezza della stringa e i prefissi se ritorna "true" vuol dire che è valida:\
###
    if (num.Length == 13 && (num.StartsWith("+39"))
        {
            return true;
        }
###
-Di seguito gli altri 2 metodi per verificare se sono giuste ma con caratteristiche diverse:\
###
            if (num.Length == 14 && num.StartsWith("0039"))
        {
            return true;
        }
###
-Ed ecco l'ultimo:\
###
        if (num.Length == 10 && num.StartsWith("3"))
        {
            return true;
        }
###

-Se la stringa non soddisfa le condizioni il programma ritorna "false" e quindi il numero risulta non valido.


-Per ora il codice finisce così in caso di nuovi aggiornamenti verranno caricati nuovamente
