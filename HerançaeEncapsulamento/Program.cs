using System;
using System.Collections.Generic;

namespace DiegoB

{
    class Program
    {


       //LISTA DE FIGURAS GEOMÉTRICAS
        static List<object> _Figuras;


        //=========================
        //MÉTODO PARA ACESSAR O OBJETO E PEGAR O NOME DA PROPRIEDADE DERIVADA DA CLASSE "FIGURA" (NOME, AREA, PERIMETRO)
        static private string GetProperty(Object obj, string PropertyName)
        {
             var propertyInfo = obj.GetType().GetProperty(PropertyName);
             var perimetro = propertyInfo.GetValue(obj, null);
             return perimetro.ToString();
        }
       //=========================


        static void Main(string[] args)
        {
              
            //=========================
            _Figuras = new List<Object>();
        
            _Figuras.Add(new Circulo(raio: 3));
         
            _Figuras.Add(new Retangulo(altura: 10, largura:20 ) );

            _Figuras.Add(new Trapezio 
            (            
               baseMaior : 8,
               baseMenor : 3,
               altura : 5,
               lado1 : 3,
               lado2 : 2  
            ));
             //=========================



            //MÉTODO PARA ACESSAR A LISTA DE FIGURAS, PEGAR TODOS OS OBJETOS E SEPARAR POR ATRIBUTOS DE FORMA DINAMICA
            foreach (Object p in _Figuras)
            {     
            Console.WriteLine("");
            Console.WriteLine("Nome:{0}", GetProperty(p,"Nome"));
            Console.WriteLine("Area:{0}", GetProperty(p,"Area"));
            Console.WriteLine("Perimetro:{0}", GetProperty(p,"Perimetro"));
            Console.WriteLine("");
            
            }

  
        


        }
    }
}
