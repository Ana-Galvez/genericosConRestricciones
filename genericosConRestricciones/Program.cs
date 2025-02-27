using System;

namespace genericosConRestricciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleados<Director> listaDirectores = new Empleados<Director>(2);
            Empleados<Secretaria> listaSecretarias = new Empleados<Secretaria>(2);
            Empleados<Electricista> listaElectricistas = new Empleados<Electricista>(2);

        }
    }

    class Empleados<T> where T : ISueldoEmpleados 
    {
        private int contador = 0;
        private T[] listaEmpleados;

        public Empleados(int i)
        {
            listaEmpleados = new T[i];
        }

        public void AgregarEmpleado(T empleado)
        {
            listaEmpleados[contador] = empleado;
            contador++;
        }

        public T GetEmpleado(int contador)
        {
            return listaEmpleados[contador];
        }
    }

    class jubilado
    {
        private int pension;
        public jubilado(int pension)
        {
            this.pension = pension;
        }   
    }

    class Director : ISueldoEmpleados
    {
        private double salario;
        public Director(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario;
        }
    }

    class Secretaria : ISueldoEmpleados
    {
        private double salario;
        public Secretaria(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return (double)salario;
        }


    }

    class Electricista : ISueldoEmpleados
    {
        private double salario;
        public Electricista(double salario)
        {
            this.salario = salario;
        }

        public double GetSalario()
        {
            return this.salario;
        }

    }

    interface ISueldoEmpleados
    {
        double GetSalario();
    }
}
