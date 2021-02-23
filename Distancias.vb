Public Class frmDistancias
    'LOAD
    Private Sub frmDistancias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Al cargar el formulario en el combobox aparece marcado Metros por defecto
        comUnidades.SelectedIndex = 0
    End Sub
    'CALCULAR
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Calcular()
    End Sub
#Region "Procedimiento"
    Private Sub Calcular()
        'declaramos una variable de tipo decimal
        Dim valor As Single

        'si el valor introducido contiene "." como separador decimal muestra un mensaje
        If txtValor.Text.Contains(".") Then
            MessageBox.Show("el separador decimal debe ser la coma", "formato decimal incorrecto")
        Else
            Try
                'pasamos el valor introducido a formato decimal
                valor = Single.Parse(txtValor.Text)

                'conversiones
                'restringimos a 5 decimales
                Select Case comUnidades.SelectedIndex
                    Case 0
                        'valor introducido en METROS
                        txtMetros.Text = Math.Round(valor, 5)
                        txtPulgadas.Text = Math.Round(valor / 0.0254, 5)
                        txtPies.Text = Math.Round(valor / 0.0254 / 12, 5)
                        txtYardas.Text = Math.Round(valor / 0.0254 / 12 / 3, 5)
                        txtMillas.Text = Math.Round(valor / 0.0254 / 12 / 3 / 1760, 5)
                    Case 1
                        'valor introducido en PULGADAS
                        txtMetros.Text = Math.Round(valor * 0.0254, 5)
                        txtPulgadas.Text = Math.Round(valor, 5)
                        txtPies.Text = Math.Round(valor / 12, 5)
                        txtYardas.Text = Math.Round(valor / 12 / 3, 5)
                        txtMillas.Text = Math.Round(valor / 12 / 3 / 1760, 5)
                    Case 2
                        'valor introducido en PIES
                        txtMetros.Text = Math.Round(valor * 12 * 0.0254, 5)
                        txtPulgadas.Text = Math.Round(valor * 12, 5)
                        txtPies.Text = Math.Round(valor, 5)
                        txtYardas.Text = Math.Round(valor / 3, 5)
                        txtMillas.Text = Math.Round(valor / 3 / 1760, 5)
                    Case 3
                        'valor introducido en YARDAS
                        txtMetros.Text = Math.Round(valor * 3 * 12 * 0.0254, 5)
                        txtPulgadas.Text = Math.Round(valor * 12 * 3, 5)
                        txtPies.Text = Math.Round(valor * 3, 5)
                        txtYardas.Text = Math.Round(valor, 5)
                        txtMillas.Text = Math.Round(valor / 1760, 5)
                    Case 4
                        'valor introducido en MILLAS
                        txtMetros.Text = Math.Round(valor * 1760 * 3 * 12 * 0.0254, 5)
                        txtPulgadas.Text = Math.Round(valor * 1760 * 12 * 3, 5)
                        txtPies.Text = Math.Round(valor * 1760 * 3, 5)
                        txtYardas.Text = Math.Round(valor * 1760, 5)
                        txtMillas.Text = Math.Round(valor, 5)
                End Select
            Catch ex As Exception
                MessageBox.Show("El valor introducido no es correcto!!!", "Valor incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
#End Region


End Class
