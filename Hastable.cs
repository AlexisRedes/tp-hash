using System;
using System.Collections;
using System.Collections.Generic;

namespace tp4_hash{
    public class HashTable{
        private int _tamaño;
        private ArrayList[] _tabla;

        public HashTable(int tamaño){
            this._tamaño=tamaño;
            this._tabla = new ArrayList[tamaño];
        }
        public void agregar(Empleado empleado){
            int key=0;
            int numero = Math.Abs(empleado.getDni());
            key= numero%this._tamaño;
            if (this._tabla[key]==null){
                this._tabla[key]=new ArrayList();
            }
            this._tabla[key].Add(empleado);
        }
        public void mostrar(){
            int contador=0;
            foreach(ArrayList elemento in this._tabla){
                if(elemento!=null){
                    Console.WriteLine("Posicion "+contador.ToString()+":");
                    foreach(var i in elemento){
                        Console.WriteLine(i);
                    }
                }
                contador=contador+1;
            }
        }

    }
}