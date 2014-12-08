Imports System.IO

Module m2_procedure_verification

    'Fonction permettant de récupérer la dernière référence imprimée
    Function verification(format)

        Dim objStreamReader2 As StreamReader
        Dim strLine2 As String
        Dim monTableau(10000) As Object, k As Long

        If (format = 1 Or format = 3) Then

            'On vient lire le fichier references_equipements.txt
            objStreamReader2 = New StreamReader("D:\Etiquettes\references_equipements.txt")
        Else
            'On vient lire le fichier references_equipements.txt
            objStreamReader2 = New StreamReader("D:\Etiquettes\references_consommables.txt")

        End If

        k = 0
        strLine2 = 0

        'On lit chaque ligne jusqu'à la fin du fichier
        Do While Not strLine2 Is Nothing

            'On insére chaque ligne du fichier texte dans une case du tableau
            monTableau(k) = strLine2

            'Read the next line.
            strLine2 = objStreamReader2.ReadLine

            k = k + 1
        Loop

        k = k - 1

        'Close the file.
        objStreamReader2.Close()

        Return monTableau(k)

    End Function

End Module
