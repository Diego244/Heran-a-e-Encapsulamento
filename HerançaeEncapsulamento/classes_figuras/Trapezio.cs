using System;

namespace DiegoB
{
        public class Trapezio : Figura 
        {
            private double _baseMaior;
            private double _baseMenor;
            private double _altura;
            private double _lado1;
            private double _lado2;


           //=================================
            public Trapezio
            (              
                    double baseMaior, 
                    double baseMenor, 
                    double altura,
                    double lado1,
                    double lado2                                  
            )  
            //=================================
            {       
                 this._name = "Trapézio";

                 this._baseMaior  = baseMaior; 
                 this._baseMenor = baseMenor;  
                 this._altura = altura;    
                 this._lado1 = lado1;
                 this._lado2 = lado2;

                 this.AtualizarArea();
                 this.AtualizarPerimetro();       
           }
         //=================================




            private void AtualizarArea() 
            { 
            
                this._area = ( (this._baseMaior + this._baseMenor) / 2 ) * this._altura;

            }  
            private void AtualizarPerimetro() 
            {           
                this._perimetro = this._baseMaior + this._baseMenor + this._lado1 + this._lado2;
            }
        
            
        }
}
