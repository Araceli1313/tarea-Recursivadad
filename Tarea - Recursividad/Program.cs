using System;

class Program
{
    
    static bool ResolverLaberinto(int[][] laberinto, int fila, int col, int filaFinal, int colFinal)
    {
      
        if (fila < 0 || col < 0 || fila >= laberinto.Length || col >= laberinto[0].Length || laberinto[fila][col] == 1)
        {
            return false;  
        }

       
        if (fila == filaFinal && col == colFinal)
        {
            return true;  
        }

        
        laberinto[fila][col] = 1;


        if (ResolverLaberinto(laberinto, fila - 1, col, filaFinal, colFinal)) return true;  
        if (ResolverLaberinto(laberinto, fila + 1, col, filaFinal, colFinal)) return true; 
        if (ResolverLaberinto(laberinto, fila, col - 1, filaFinal, colFinal)) return true;  
        if (ResolverLaberinto(laberinto, fila, col + 1, filaFinal, colFinal)) return true;  

        
        laberinto[fila][col] = 0;

        return false;  
    }

    static void Main(string[] args)
    {
     
        int[][] laberinto = new int[][] {
            new int[] { 0, 1, 0, 0 },
            new int[] { 0, 1, 0, 1 },
            new int[] { 0, 0, 0, 0 }
        };

        int filaInicial = 0, columnaInicial = 0;
        int filaFinal = 2, columnaFinal = 3;

        
        bool resultado = ResolverLaberinto(laberinto, filaInicial, columnaInicial, filaFinal, columnaFinal);

       
        if (resultado)
        {
            Console.WriteLine("¡Hay un camino para salir del laberinto!");
        }
        else
        {
            Console.WriteLine("No hay camino para salir del laberinto.");
        }
    }
}