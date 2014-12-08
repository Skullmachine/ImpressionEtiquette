Imports System.IO

Module m1_procedure_impression

    Sub ecriture(reference_finale As Object, format As Integer, fileName As String)
        Dim objStreamReader As StreamReader
        Dim strLine, lol As String
        Dim monTableau(10000) As Object, i, j As Long

        'Pass the file path and the file name to the StreamReader constructor.
        objStreamReader = New StreamReader(fileName)

        'Read the first line of text.
        strLine = objStreamReader.ReadLine

        i = 0

        'Continue to read until you reach the end of the file.
        Do While Not strLine Is Nothing

            'Si Code 128 Equipement sélectionné on modifie la ligne 30 du fichier texte D:\Etiquettes\code_128_equipement
            If format = 1 Then

                If i = 31 Then

                    strLine = "PP 50,109:DIR 1:BT ""CODE128"":BM 3:BH 76:PB """ & reference_finale & """"

                End If
                'Si Code 128 Consommable sélectionné on modifie la ligne 30 du fichier texte D:\Etiquettes\code_128_consommable
            ElseIf format = 2 Then

                If i = 11 Then

                    strLine = "PP 120,22:DIR 1:BT ""CODE128"":BM 1:BH 31:PB """ & reference_finale & """"

                End If

                'Si Data Matrix Consommable sélectionné on modifie la ligne 7 et 8 du fichier texte D:\Etiquettes\datamatrix_consommable.prn
            ElseIf format = 3 Then

                If i = 7 Then

                    strLine = "B1.6,1.5,0,DATAMATRIX,0.33; " & reference_finale & ""

                ElseIf i = 8 Then

                    strLine = "T0.5,7.5,0,596,1.25,q101,b; " & reference_finale & ""

                End If

            End If

            'On insére chaque ligne du fichier texte dans une case du tableau
            monTableau(i) = strLine

            'Read the next line.
            strLine = objStreamReader.ReadLine

            i = i + 1
        Loop
        i = i - 1

        'Close the file.
        objStreamReader.Close()

        Dim objStreamWriter As StreamWriter

        'Open the file.
        objStreamWriter = New StreamWriter(fileName)

        'Write out the numbers 1 through 10 on the same line.
        For j = 0 To i
            objStreamWriter.WriteLine(monTableau(j))
            lol = monTableau(j)
        Next j

        'Close the file.
        objStreamWriter.Close()

    End Sub

End Module
