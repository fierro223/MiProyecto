namespace APPEstacion
{
    using Claseslibres;
    
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var listEmpleado = new List<Empleado>()
            {
                new Empleado(1,"54dfdef","Playero","12345678","Pedro", "Sena", "43054768", "Zeballo5747"),
                new Empleado(2,"54361fd","Gerente","35750441", "Julio","Andres","47500456","Lugano705"),
                new Empleado(3,"5725ddd","Cajero","30444271","Migel","Zandro","415641204","Lujan705")
            };


            var listTanque = new List<Tanque>()
            {
                new Tanque(){IdTanque=1,Capacidad=20000,Disponible=20000,
                    Producto=new Producto(){IdProducto=1,NombreProducto="Premiun",Precio=145.55}},
                new Tanque(){IdTanque=2,Capacidad=20000, Disponible=20000,
                    Producto=new Producto(){IdProducto=2, NombreProducto="Disel",Precio=150.70}},
                new Tanque(){IdTanque=3,Capacidad=20000, Disponible=20000,
                    Producto=new Producto(){IdProducto=3, NombreProducto="Super",Precio=160.70}}
            };


            var listMaquinas = new List<Surtidora>()
            {
               new Surtidora(){ IdSurtidor=1,
                     LitrosSurtido=0,
                     MontoSurtido=0,
                     TipoDeTanque=listTanque[0]},
                    new Surtidora(){ IdSurtidor=2,
                     LitrosSurtido=0,
                     MontoSurtido=0,
                     TipoDeTanque=listTanque[1]},
                    new Surtidora(){ IdSurtidor=3,
                     LitrosSurtido=0,
                     MontoSurtido=0,
                     TipoDeTanque=listTanque[2]}
            };

            //Aca creamos la instancia de la estacion con todos los componetes nesesarios para poder tranajar
            Establecimiento estacion = new Establecimiento()
            {
                IdEstablecimiento = 1,
                Nombre = "GAS Tuni",
                Cuit = "30125541262",
                Direcion = "Av Independencia545",
                Telefono = "47533145",
                Desde = DateTime.Now,
                Hasta = DateTime.Now,
                Tanques = listTanque,
                Surtidora = listMaquinas
               
            };
            
            Application.Run(new MenuGNS(estacion));
        }
    }
}