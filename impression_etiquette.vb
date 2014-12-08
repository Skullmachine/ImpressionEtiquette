Public Class fenetre

    Public format As Integer
    Public fileName, arborescence_bat, verif As String

    Private Sub ref_box1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ref_box1.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then e.Handled = True
        If Char.IsSymbol(e.KeyChar) = True Then e.Handled = True
        If Char.IsWhiteSpace(e.KeyChar) = True Then e.Handled = True
        If Char.IsSeparator(e.KeyChar) = True Then e.Handled = True
        If Char.IsPunctuation(e.KeyChar) = True Then e.Handled = True
    End Sub

    Private Sub ref_box2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ref_box2.KeyPress
        If Char.IsLetter(e.KeyChar) = True Then e.Handled = True
        If Char.IsSymbol(e.KeyChar) = True Then e.Handled = True
        If Char.IsWhiteSpace(e.KeyChar) = True Then e.Handled = True
        If Char.IsSeparator(e.KeyChar) = True Then e.Handled = True
        If Char.IsPunctuation(e.KeyChar) = True Then e.Handled = True
    End Sub

    Private Sub code_128_grand_CheckedChanged(sender As Object, e As EventArgs) Handles code_128_grand.CheckedChanged
        code_128_petit.Checked = False
        datamatrix.Checked = False

        If (Me.code_128_grand.Checked = True) Then

            fileName = "D:\Etiquettes\code_128_equipement"                         'arborescence du fichier envoyé à l'imprimante

            arborescence_bat = "D:\Etiquettes\code_128_equipement.bat"             'arborescence du fichier .bat

            format = 1                                                              'format de l'étiquette

            If (Me.mode_manuel.Checked = False) Then

                verif = verification(format)
                verif = Strings.Right(verif, 6)
                Me.ref_box1.Text = verif

            Else

                Me.ref_box1.Text = ""

            End If

        End If

    End Sub

    Private Sub code_128_petit_CheckedChanged(sender As Object, e As EventArgs) Handles code_128_petit.CheckedChanged
        code_128_grand.Checked = False
        datamatrix.Checked = False

        If (Me.code_128_petit.Checked = True) Then

            fileName = "D:\Etiquettes\code_128_consommable"

            arborescence_bat = "D:\Etiquettes\code_128_consommable.bat"

            format = 2

            If (Me.mode_manuel.Checked = False) Then

                verif = verification(format)
                verif = Strings.Right(verif, 6)
                Me.ref_box1.Text = verif

            Else

                Me.ref_box1.Text = ""

            End If
        End If

    End Sub

    Private Sub datamatrix_CheckedChanged(sender As Object, e As EventArgs) Handles datamatrix.CheckedChanged
        code_128_petit.Checked = False
        code_128_grand.Checked = False

        If (Me.datamatrix.Checked = True) Then

            fileName = "D:\Etiquettes\datamatrix_consommable.prn"

            arborescence_bat = "D:\Etiquettes\datamatrix_consommable.bat"

            format = 3

            If (Me.mode_manuel.Checked = False) Then

                verif = verification(format)
                verif = Strings.Right(verif, 6)
                Me.ref_box1.Text = verif

            Else

                Me.ref_box1.Text = ""

            End If

        End If

    End Sub

    Private Sub bouton_impression_Click(sender As Object, e As EventArgs) Handles bouton_impression.Click


        Dim reference_finale, reference As String

        Dim j, reference_integer, digit As Integer

        'Ne rien faire tant que les champs ne sont pas rempli
        If (Me.code_128_petit.Checked Or Me.code_128_grand.Checked Or Me.datamatrix.Checked) And Not (ref_box1.Text = "") And Not (ref_box2.Text = "") = True Then
            If (ref_box1.Text <= ref_box2.Text) Then
                Dim compteur As Long

                j = 0


                'Pour chaque référence, on imprime une étiquette
                For compteur = Me.ref_box1.Text To Me.ref_box2.Text Step 1


                    'Traitement des 0 possibles de la chaîne de caractère
                    reference_integer = Me.ref_box1.Text + j

                    digit = Len(Me.ref_box1.Text)
                    reference = ""

                    Select Case digit
                        Case 1
                            reference = "00000" & reference_integer & ""
                        Case 2
                            reference = "0000" & reference_integer & ""
                        Case 3
                            reference = "000" & reference_integer & ""
                        Case 4
                            reference = "00" & reference_integer & ""
                        Case 5
                            reference = "0" & reference_integer & ""
                        Case 6
                            reference = reference_integer
                    End Select

                    If (format = (1 Or 3)) Then
                        reference_finale = "TST" & reference & ""       'ajout de "TST" pour les équipements
                    Else
                        reference_finale = "TSTC" & reference & ""       'ajout de "TSTC" pour les consommables
                    End If

                    'stock_ref(reference_finale, format)
                    System.Threading.Thread.Sleep(1000)
                    ecriture(reference_finale, format, fileName)      'procédure écriture de la référence dans le fichier
                    System.Threading.Thread.Sleep(1000)
                    Shell(arborescence_bat)                         'exécution de la commande .bat permettant l'envoie du fichier vers l'imprimante par le port série
                    j = j + 1
                Next
            Else
                MessageBox.Show(String.Format("Erreur : Votre première valeur est supérieure à la deuxième!"))
            End If

        Else
            MessageBox.Show(String.Format("Remplissez tous les champs avant de poursuivre"))
        End If

    End Sub

    Private Sub ref_box1_TextChanged(sender As Object, e As EventArgs) Handles ref_box1.TextChanged

    End Sub

    Private Sub fenetre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        format = 1
        verif = verification(format)
        verif = Strings.Right(verif, 6)

        Me.ref_box1.Enabled = False
        Me.ref_box1.Text = verif
        code_128_grand.Checked = True

    End Sub

    Private Sub mode_manuel_CheckedChanged(sender As Object, e As EventArgs) Handles mode_manuel.CheckedChanged

        Dim Msg As String



        If (Me.mode_manuel.Checked) Then

            Me.ref_box1.Enabled = True

            'On affiche un avertissement
            Msg = "Attention ! Vous êtes en mode manuel, des doublons d'étiquettes sont possibles !"
            MsgBox(Msg)

        Else

            Me.ref_box1.Enabled = False
            verif = verification(format)
            verif = Strings.Right(verif, 6)

        End If
    End Sub

End Class
