Module Module1

    Sub Main()

        Dim valores(14) As Integer
        Dim suma As Integer
        Dim media As Double
        Dim opc As Integer

        'Console.WriteLine("")
        Console.WriteLine("        MENÚ DEL PROGRAMA")
        Console.WriteLine("")
        Console.WriteLine("1. Calcular la media aritmética.")
        Console.WriteLine("2. Obtener la moda.")
        Console.WriteLine("3. Calcular la mediana. ")
        Console.WriteLine("4. Seleccionar el número menor y mayor.")
        Console.WriteLine("")
        Console.WriteLine("Elija una opción <1-4>: ")
        opc = Console.ReadLine()

        If (opc = 1) Then
            For i = 0 To 14 Step 1
                Console.WriteLine("Ingrese el valor: " & i + 1)
                valores(i) = Console.ReadLine()
                suma += valores(i)
            Next
            media = suma / valores.Length
            Console.WriteLine("")
            Console.WriteLine("La media aritmética es: " & media)
            Console.WriteLine("Pulse ENTER")
            Console.ReadLine()

        ElseIf (opc = 2) Then

            Dim numeros(0 To 14) As Integer
            Dim auxiliar(0 To 14) As Integer
            Dim posicion As Integer = 0
            Dim numero As Integer = 0
            Dim contador2 As Integer = 0
            Dim mayor As Integer = 0
            Dim posicionmayor As Integer = 0

            For contador = 0 To 14
                Console.WriteLine("Ingrese el valor: " & contador + 1)
                numeros(contador) = Integer.Parse(Console.ReadLine())

            Next
            Console.WriteLine("" & vbLf & "Los valores son: ")
            For contador = 0 To 14
                Console.Write(" {0}", numeros(contador))

            Next
            For contador = 0 To 14
                auxiliar(contador) = 0

            Next
            For contador = 0 To 14
                numero = numeros(contador)
                posicion = contador
                For contador2 = contador To 14
                    If (numeros(contador2) = numero) Then auxiliar(posicion) += 1

                Next

            Next
            mayor = auxiliar(0)
            posicionmayor = 0
            For contador = 0 To 14
                If auxiliar(contador) > mayor Then
                    posicionmayor = contador
                    mayor = auxiliar(contador)
                End If

            Next
            Console.WriteLine("" & vbLf & "El valor de la moda es: {0}", numeros(posicionmayor))
            Console.WriteLine("Pulse ENTER")
            Console.ReadLine()


        ElseIf (opc = 3) Then
            Console.WriteLine("")


        ElseIf (opc = 4) Then

            For i = 0 To 14 Step 1
                Console.WriteLine("Ingrese el valor: " & i + 1)
                valores(i) = Console.ReadLine()
                suma += valores(i)
            Next

            Array.Sort(valores)
            Console.WriteLine("")
            Console.WriteLine("Número menor: " & valores(valores.Length = 0))
            Console.WriteLine("Número mayor: " & valores(valores.Length - 1))
            Console.WriteLine("Pulse ENTER")
            Console.ReadLine()

        End If

    End Sub

End Module
