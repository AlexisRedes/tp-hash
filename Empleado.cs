namespace tp4_hash {

    public class Empleado{
        private string _nombre;
        private int _numeroEmpleado;
        private int _dni;

        public Empleado(string nombre, int numeroEmpleado, int dni){
            this._nombre=nombre;
            this._numeroEmpleado=numeroEmpleado;
            this._dni=dni;
        }

        public int getDni(){
            return this._dni;
        }

        public override string ToString()
        {
            return _nombre.ToString()+" " + _numeroEmpleado.ToString()+" "+_dni.ToString();
        }
    }
}