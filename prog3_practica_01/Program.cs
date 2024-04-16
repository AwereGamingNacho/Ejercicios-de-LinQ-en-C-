using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // EJERCICIO NRO. 1--

            //List<Persona> personas = new List<Persona>
            //{
            //    new Persona { nombre = "Juan", edad = 25, ciudad = "Lima" },
            //    new Persona { nombre = "Maria", edad = 30, ciudad = "Bogota" },
            //    new Persona { nombre  = "Pedro", edad = 35, ciudad = "Madrid" },
            //    new Persona { nombre = "Ana", edad = 20, ciudad = "Lima" },
            //    new Persona { nombre = "Jose", edad = 40, ciudad = "Buenos Aires"}
            //};

            //personas.Where(x => x.edad >= 30 && x.ciudad == "Bogota").ToList().ForEach(x => Console.WriteLine("Nombre: " + x.nombre + " / Ciudad: " + x.ciudad));
            //Console.WriteLine();
            //personas.Where(x => x.edad >= 25 && x.edad <= 35).ToList().OrderBy(x => x.edad).ToList().ForEach(x => Console.WriteLine("Nombre: " + x.nombre + " / Edad: " + x.edad));

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // EJERCICIO NRO. 2--

            //ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();

            //Console.WriteLine("Promedios por empresas\n************************************");
            //ce.getPromedioSalario();
            //Console.WriteLine();

            //Console.WriteLine("Peces gordos\n************************************");
            //ce.getCeo("CEO");
            //Console.WriteLine();

            //Console.WriteLine("Plantilla\n************************************");
            //ce.getEmpleadosOrdenados();
            //Console.WriteLine();
            //Console.WriteLine("Plantilla ordenada por salario\n************************************");
            //ce.getEmpleadosOrdenadosPorSalario();
            //Console.WriteLine();

            //Console.WriteLine("Ingrese la empresa: (enterio 1 a 3)\n1 para IAlpha\n2 para UdelaR\n3 para SpaceZ");
            //string id = Console.ReadLine();
            //try
            //{
            //    int empresaId = Int32.Parse(id);
            //    ce.getEmpleadosEmpresa(empresaId);
            //}
            //catch
            //{
            //    Console.WriteLine("Ha introducido un ID erroneo. Debe ingresar un numero entero");
            //}

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // EJERCICIO NRO. 3--

            // La complejidad cognitiva del codigo mostrado en el PDF es de un nivel de 3. +1 por el FOREACH, +2 por el IF, llegando al TOTAL de 3.

            //List<int> valores = new List<int>() { 6, 2, 5, 3, 1, 4, 7, 9, 8 };

            //valores.Order().ToList().ForEach(i => { Console.WriteLine(i); });

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // EJERCICIO NRO. 4--
            // Apartado: A--

            //List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int total = 0;

            //valores.ForEach(x => total += x);
            //Console.WriteLine($"La suma total es: {total}");

            // Apartado: B--

            //List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int totalPares = 0;

            //valores.Where(x => x%2==0).ToList().ForEach(x => totalPares += x);
            //Console.WriteLine($"La suma total de los valores pares es: {totalPares}");

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // EJERCICIO NRO. 5--
            // APARTADO: A--

            //List<int> valores = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            //int totalValoresParesMayorAOcho = 0;
            //int totalValoresParesMenorAOcho = 0;

            //foreach (int n in valores) //+1
            //{
            //    if (n % 2 == 0 && n > 8)//+2
            //    {
            //        totalValoresParesMayorAOcho += n;
            //    }
            //    if (n % 2 == 0 && n < 8)//+2
            //    {
            //        totalValoresParesMenorAOcho += n;
            //    }
            //}
            //// 2 PUNTOS DE COMPLEJIDAD MENOS QUE EL EJERCICIO EN EL PDF

            //Console.WriteLine($"La suma total de los valores para mayores a ocho es: {totalValoresParesMayorAOcho}");
            //Console.WriteLine($"La suma total de los valores para menores a ocho es: {totalValoresParesMenorAOcho}");

            //// APARTADO: B--

            //int linqTotalValoresParesMayorAOcho = 0;
            //int linqTotalValoresParesMenorAOcho = 0;

            //valores.Where(x => x % 2 == 0 && x > 8).ToList().ForEach(x => linqTotalValoresParesMayorAOcho+=x);
            //valores.Where(x => x % 2 == 0 && x < 8).ToList().ForEach(x => linqTotalValoresParesMenorAOcho += x);

            //Console.WriteLine($"La suma total de los valores para mayores a ocho es: {linqTotalValoresParesMayorAOcho}");
            //Console.WriteLine($"La suma total de los valores para menores a ocho es: {linqTotalValoresParesMenorAOcho}");

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // EJERCICIO NRO. 6--
            // APARTADO: A--

            // La complejidad del codigo absurdo presentado en el pdf es de un total de 6. +1 por cada if que hay que en total son, 6.

            // APARTADO: B--
            // SwitchCase existe.

            Console.WriteLine("Ingrese una letra minuscula (desde a hasta f) para saber cual es la siguiente letra del abecedario!");
            string? letra = Console.ReadLine();

            switch (letra.ToLower()) //+1
            {
                case "a":
                    Console.WriteLine("La siguiente letra del abecedario es B!");
                    break;
                case "b":
                    Console.WriteLine("La siguiente letra del abecedario es C!");
                    break;
                case "c":
                    Console.WriteLine("La siguiente letra del abecedario es D!");
                    break;
                case "d":
                    Console.WriteLine("La siguiente letra del abecedario es E!");
                    break;
                case "e":
                    Console.WriteLine("La siguiente letra del abecedario es F!");
                    break;
                case "f":
                    Console.WriteLine("La siguiente letra del abecedario es G!");
                    break;
            }

            //Ahora tenemos una complejidad cognita de solo 1.
        }
    }
    internal class Persona
    {
        public int edad { get; set; }
        public string nombre { get; set; }
        public string ciudad { get; set; }
    }

    internal class Empleado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string cargo { get; set; }
        public int salario { get; set; }
        public int empresaId { get; set; }

        public void datosEmpleado()
        {
            Console.WriteLine($"Empleado {nombre} con ID {id}, cargo {cargo} y salario de {salario} pertenece a la empresa {empresaId}.");
        }
    }

    internal class Empresa
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public void datosEmpresa()
        {
            Console.WriteLine($"Empresa {nombre} con ID {id}.");
        }
    }

    internal class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados()
        {
            listaEmpresas = new List<Empresa>
            {
                new Empresa { id = 1, nombre = "IAlpha" },
                new Empresa { id = 2, nombre = "Udelar" },
                new Empresa { id = 3, nombre = "SpaceZ" }
            };

            listaEmpleados = new List<Empleado>
            {
                new Empleado { id = 1, nombre = "Gonzalo", cargo = "CEO", empresaId = 1, salario = 3000 },
                new Empleado { id = 2, nombre = "JuanC", cargo = "Desarrollador", empresaId = 1, salario = 2000 },
                new Empleado { id = 3, nombre = "JuanR", cargo = "Desarrollador", empresaId = 1, salario = 2000 },
                new Empleado { id = 4, nombre = "Daniel", cargo = "Desarrollador", empresaId = 1, salario = 2000 },
                new Empleado { id = 5, nombre = "GonzaloT", cargo = "CEO", empresaId = 2, salario = 2000 },
                new Empleado { id = 6, nombre = "Leonardo", cargo = "CEO", empresaId = 1, salario = 3000 },
                new Empleado { id = 7, nombre = "Pedro", cargo = "CEO", empresaId = 3, salario = 3000 },
                new Empleado { id = 8, nombre = "Hank", cargo = "CEO", empresaId = 3, salario = 3000}
            };
        }

        public void getCeo(string cargo)
        {
            listaEmpleados.Where(x => x.cargo == cargo).ToList().ForEach(x => x.datosEmpleado());
        }
        public void getEmpleadosOrdenados()
        {
            listaEmpleados.OrderBy(x => x.nombre).ToList().ForEach(x => x.datosEmpleado());
        }
        public void getEmpleadosOrdenadosPorSalario()
        {
            listaEmpleados.OrderBy(x => x.salario).ToList().ForEach(x => x.datosEmpleado());
        }
        public void getEmpleadosEmpresa(int idEmpresa)
        {
            listaEmpleados.Where(x => x.empresaId == idEmpresa).ToList().ForEach(x => x.datosEmpleado());
        }
        public void getPromedioSalario()
        {
            listaEmpresas.ForEach(x => Console.WriteLine($"Empresa {x.nombre} - Promedio de salario: {listaEmpleados.Where(a => a.empresaId == x.id).ToList().Average(b => b.salario)}"));
        }
        public void cantidadDeEmpleadosPorCargo(int empresaId,string cargo)
        {
            Console.WriteLine($"Cantidad de empleados en empresa con ID {empresaId} y cargo {cargo}: {listaEmpleados.Where(x => x.empresaId == empresaId && x.cargo == cargo).ToList().Count}");
        }
        public void empleadoConMayorSalario()
        {
            Console.WriteLine($"El empleado que gana mas es: {listaEmpleados.MaxBy(x => x.salario).nombre} con un salario de {listaEmpleados.MaxBy(x => x.salario).salario}");
        }
        public void empleadosQueGananMas()
        {
            listaEmpleados.Where(x => x.salario > 2200).ToList().ForEach(x => x.datosEmpleado());
        }
        public void empleadoQueGanaMasPorCargo(string cargo)
        {
            listaEmpleados.Where(x => x.cargo == cargo).ToList().MaxBy(x => x.salario).datosEmpleado();
        }
        public void empleadoQueGanaMasPorEmpresa()
        {
            listaEmpleados.Where(x => x.empresaId == 1).ToList().MaxBy(x => x.salario).datosEmpleado();
            listaEmpleados.Where(x => x.empresaId == 2).ToList().MaxBy(x => x.salario).datosEmpleado();
            listaEmpleados.Where(x => x.empresaId == 3).ToList().MaxBy(x => x.salario).datosEmpleado();
        }
    }
    
    
}
