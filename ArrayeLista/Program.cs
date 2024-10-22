int[] arrayDeInteiros = new int [3];

arrayDeInteiros[0] = 1;
arrayDeInteiros[1] = 2;
arrayDeInteiros[2] = 3;

// Contador com For
for(int contador = 0; contador < arrayDeInteiros.Length; contador++){
    Console.WriteLine($"Posição {contador}: {arrayDeInteiros[contador]}");
}

// Redimensionando um Array 
Array.Resize(ref arrayDeInteiros, arrayDeInteiros.Length * 2);

// Contador com Foreach e manipulando a posição 
int contadorForEach = 0;

foreach (int valor in arrayDeInteiros)
{
    Console.WriteLine($"Na posição {contadorForEach}: {valor}");
    contadorForEach++;
}


