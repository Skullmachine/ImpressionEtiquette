Imports System.IO

Module m3_procedure_stockage

    'Fonction d'écriture des références imprimées dans un fichier
    Sub stock_ref(reference_finale As String, format As Integer)

        Dim objStreamReader3 As StreamReader
        Dim strLine3, arborescence As String
        Dim monTableau(10000) As Object, k, i As Long
        Dim objStreamWriter As StreamWriter

        If (format = 1 Or 3) Then

            'On vient lire le fichier references_equipements.txt
            arborescence = "D:\Etiquettes\references_equipements.txt"

        Else
            'On vient lire le fichier references_consommables.txt
            arborescence = "D:\Etiquettes\references_consommables.txt"

        End If

        objStreamReader3 = New StreamReader(arborescence)

        k = 0
        strLine3 = 0

        'On lit chaque ligne jusqu'à la fin du fichier
        Do While Not strLine3 Is Nothing

            'On insére chaque ligne du fichier texte dans une case du tableau
            monTableau(k) = strLine3

            'Read the next line.
            strLine3 = objStreamReader3.ReadLine

            k = k + 1
        Loop

        k = k - 1

        'Close the file.
        objStreamReader3.Close()

    'Open the file.
        objStreamWriter = New StreamWriter("D:\Etiquettes\references_equipements.txt")

        For j = 0 To i
            objStreamWriter.WriteLine(monTableau(k))
        Next j

        'Close the file.
        objStreamWriter.Close()

    End Sub

    'Fonction d'écriture des références imprimées dans un fichier
    Sub stock_ref_consommable(reference_finale As Object)

        Dim objStreamWriter As StreamWriter

        'Open the file.
        objStreamWriter = New StreamWriter("D:\Etiquettes\references_consommables.txt")


        objStreamWriter.WriteLine(reference_finale)


        'Close the file.
        objStreamWriter.Close()

    End Sub

End Module
