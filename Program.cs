using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            string sair="";
            do
            {  
               Console.Clear();
               int Idade=0;            
               Box("Doador de sangue",4,15,10,0);
               print("Qual sua idade?",15,0,0,4);
               Idade = Convert.ToInt32(Console.ReadLine());

               if (Idade < 18 || Idade >67) {print("-- NÃO PODE DOAR SANGUE --\n",0,6,0,4);}
                 else {print("-- PODE SER DOADOR --\n",0,4,0,4);}
               
               Console.Write("\n(N)ovamente ?");
               sair=Console.ReadLine().ToUpper();
            } while (sair =="N");
               Console.Clear();                  
       } 

       static void Box( String S2,int Cor_Caixa, int Cor_Letra, int X, int Y)//  Texto dentro da caixa    
        {
         int tamanho = S2.Length; 
         Console.SetCursorPosition(X, Y);
         string lin = new string('*', tamanho+4); 
         string vazio = new string(' ',tamanho+2);
           // imprime Caixa
         ConsoleColor CorCaixa = (ConsoleColor)Cor_Caixa;
         Console.ForegroundColor = CorCaixa;
         Console.SetCursorPosition(X, Y);Console.WriteLine(lin);         
         Console.SetCursorPosition(X, Y+1);Console.Write($"*{vazio}*");         
         Console.SetCursorPosition(X, Y+2);Console.Write(lin);   
          // imprime Titulo
         ConsoleColor CorLetra = (ConsoleColor)Cor_Letra;
         Console.ForegroundColor = CorLetra;
         Console.SetCursorPosition(X+2, Y+1);
         Console.WriteLine(S2);
         //proxima coordenadas        
         Console.ResetColor();  
         Console.SetCursorPosition(0, Y+4);
        }// Fecha Box

       static void print(String S, int COR_Caracter,int COR_Fundo, int X,int Y)
        {
         ConsoleColor CorC = (ConsoleColor)COR_Caracter;
         ConsoleColor CorF = (ConsoleColor)COR_Fundo;
         Console.ForegroundColor = CorC;
         Console.BackgroundColor = CorF;
         Console.SetCursorPosition(X, Y);
         Console.Write(S);
         Console.ResetColor();
        }//fecha print
    }
}
