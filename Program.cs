using System;

internal class Program
{
    private static Random random = new Random();
    public static string method2(int length)
    {
        const string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(characters, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
    private static void Main(string[] args)
    {
        string usuario = "", contraseña = "", auxusuario = "", auxcontraseña = "";
        string[] prueba;
        int ingreso = 0;

        /*1*/
        int opProveedor = 0;
        int x;
        string nitp, namep, direcciónp, telefonop;
        string[] proveedorestemporal = new string[4];

        List<string[]> proveedores = new List<string[]>();

        /*2*/
        int opcion_inicial = 0;
        double inter = 0, s = 0;
        int articulos = 0;
        double descuento = 0, compratotal = 0, mouse = 0, teclado = 0, monitor = 0, impresora = 0, audifonos = 0, pagofinal = 0;
        string NIT2 = "", NOMBRE2 = "", APELL = "", namepro = "";

        /*3*/
        string finalString = method2(8);

        string date = DateTime.UtcNow.ToString("MM-dd-yyyy");
        string time = DateTime.Now.ToString("h:mm tt");

        int op = 0, op2 = 0, op3 = 0, op4 = 0, op5 = 0, op6 = 0;

        int precio = 0, precio2 = 0, precio3 = 0, precio4 = 0, precio5 = 0;
        string name = "", nit = "", lastname = "";
        decimal desc = 0, totfinal = 0, total = 0;
        string producto = "", p1 = "", p2 = "", p3 = "", p4 = "", p5 = "";
        int cant = 0;
        string combo = "";

        Console.WriteLine("");

        do
        {

            Console.Clear();
            Console.WriteLine("\t =========================================");
            Console.WriteLine("\t |                                       |");
            Console.WriteLine("\t |                BIENVENIDO             |");
            Console.WriteLine("\t |               HPC ADVANCED            |");
            Console.WriteLine("\t |           www.venta/hpccui.com        |");
            Console.WriteLine("\t |                                       |");
            Console.WriteLine("\t =========================================");
            Console.WriteLine("\t |                                       |");
            Console.WriteLine("\t |     1. YA TENGO USUARIO               |");
            Console.WriteLine("\t |     2. CREAR NUEVO USUARIO            |");
            Console.WriteLine("\t |                                       |");
            Console.WriteLine("\t =========================================");
            Console.WriteLine("");
            Console.WriteLine("Seleccione una opción");
            ingreso = int.Parse(Console.ReadLine());        

            switch (ingreso)
            {
                case 1:

                    Console.Clear();
                    Console.WriteLine("==============  --LOGIN--  ===============");
                    Console.WriteLine("");
                    Console.WriteLine(" INGRESE SU USUARIO: ");
                    usuario = (Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine(" INGRESE SU CONTRASEÑA: ");
                    contraseña = (Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("ENTER para aceptar...");
                    Console.ReadKey();

                    if (usuario == auxusuario && contraseña == auxcontraseña)
                    {

                        do
                        {
                            Console.Clear();
                            Console.WriteLine("\t============== >>MENÚ<<  ===============");
                            Console.WriteLine("");
                            Console.WriteLine("\t1. INGRESO DE PROVEEDORES");
                            Console.WriteLine("\t2. COMPRA DE UN ARTÍCULO");
                            Console.WriteLine("\t3. COMPRA DE ARTÍCULOS POR COMBOS");
                            Console.WriteLine("\t4. SALIR");
                            Console.WriteLine("");
                            Console.WriteLine("\t============== >>MENÚ<<  ===============");
                            Console.WriteLine("");
                            Console.WriteLine("\tELIGA UNA OPCIÓN: ");
                            opcion_inicial = int.Parse(Console.ReadLine());                         

                            switch (opcion_inicial)
                            {

                                case 1:

                                    while (opProveedor != 5)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\t============== >>PROVEEDORES<<  ===============");
                                        Console.WriteLine("");
                                        Console.WriteLine("\t 1. Ingresar nuevo proveedor.");
                                        Console.WriteLine("\t 2. Mostrar proveedores.");
                                        Console.WriteLine("\t 3. Editar proveedor.");
                                        Console.WriteLine("\t 4. Eliminar proveedor.");
                                        Console.WriteLine("\t 5. Salir.");
                                        Console.WriteLine("");
                                        Console.WriteLine("\t================================================");
                                        Console.WriteLine("");
                                        Console.WriteLine("Ingrese una opción:");

                                        string opcionSeleccionadaTem = Console.ReadLine();

                                        if (int.TryParse(opcionSeleccionadaTem, out x))
                                        {
                                            opProveedor = int.Parse(opcionSeleccionadaTem);

                                            switch (opProveedor)
                                            {
                                                case 1:

                                                    Console.Clear();
                                                    Console.WriteLine("\t====== >>INGRESO PROVEEDOR<< ======");
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Ingrese el NIT:");
                                                    nitp = Console.ReadLine();
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Ingrese el nombre:");
                                                    namep = Console.ReadLine();
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Ingrese la dirección:");
                                                    direcciónp = Console.ReadLine();
                                                    Console.WriteLine("");
                                                    Console.WriteLine("Ingrese el número de télefono:");
                                                    telefonop = Console.ReadLine();

                                                    proveedorestemporal = new string[4];

                                                    proveedorestemporal[0] = nitp;
                                                    proveedorestemporal[1] = namep;
                                                    proveedorestemporal[2] = direcciónp;
                                                    proveedorestemporal[3] = telefonop;

                                                    proveedores.Add(proveedorestemporal);

                                                    Console.ReadKey();
                                                    break;

                                                case 2:

                                                    Console.Clear();
                                                    Console.WriteLine("\t====== >>REPORTE DE PROVEEDORES<< ======");
                                                    Console.WriteLine("");
                                                    foreach (string[] item in proveedores)
                                                    {
                                                        Console.WriteLine(item[0] + " " + item[1] + " " + item[2] + " " + item[3]);
                                                    }
                                                    Console.WriteLine("");
                                                    Console.WriteLine("ENTER para continuar");
                                                    Console.ReadKey();
                                                    break;

                                                case 3:

                                                    Console.Clear();
                                                    Console.WriteLine("\t====== >>LISTADO DE PROVEEDORES<< ======");
                                                    Console.WriteLine("");
                                                    for (int ip = 0; ip < proveedores.Count; ip++)
                                                    {
                                                        Console.WriteLine(ip + " = " + proveedores[ip][0] + " - " + proveedores[ip][1] + " - " + proveedores[ip][2] + " - " + proveedores[ip][3]);
                                                    }

                                                    Console.WriteLine("Número de proveedor que desea editar");
                                                    string posicionProveedorTemp = Console.ReadLine();
                                                    Console.WriteLine("");
                                                    if (int.TryParse(posicionProveedorTemp, out x))
                                                    {
                                                        int posicionProveedor = int.Parse(posicionProveedorTemp);

                                                        if (proveedores.Count <= posicionProveedor || posicionProveedor < 0)
                                                        {
                                                            Console.WriteLine("Este proveedor no existe");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("\t====== >>INGRESO PROVEEDOR<< ======");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Ingrese el nuevo NIT:");
                                                            nitp = Console.ReadLine();
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Ingrese el nuevo nombre:");
                                                            namep = Console.ReadLine();
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Ingrese el nuevo Dirección:");
                                                            direcciónp = Console.ReadLine();
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Ingrese el nuevo número de télefono:");
                                                            telefonop = Console.ReadLine();


                                                            proveedores[posicionProveedor][0] = nitp;
                                                            proveedores[posicionProveedor][1] = namep;
                                                            proveedores[posicionProveedor][2] = direcciónp;
                                                            proveedores[posicionProveedor][3] = telefonop;
                                                            Console.WriteLine("");
                                                            Console.WriteLine("Modificación actualizada...");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("ENTER para continuar");
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("El dato ingresado es incorrecto");
                                                        Console.WriteLine("Intentelo de nuevo");
                                                    }

                                                    Console.ReadKey();
                                                    break;

                                                case 4:

                                                    Console.Clear();
                                                    Console.WriteLine("\t====== >>LISTADO DE PROVEEDORES<< ======");
                                                    Console.WriteLine("");

                                                    for (int ip = 0; ip < proveedores.Count; ip++)
                                                    {
                                                        Console.WriteLine(ip + "  = "+" - " + proveedores[ip][0] + " - " + proveedores[ip][1] + " - " + proveedores[ip][2] + " - " + proveedores[ip][3]);
                                                    }

                                                    Console.WriteLine("Ingresar el número de proveedor que desea eliminar");
                                                    string posicionProveedorTempEliminar = Console.ReadLine();

                                                    if (int.TryParse(posicionProveedorTempEliminar, out x))
                                                    {
                                                        int posicionProveedor = int.Parse(posicionProveedorTempEliminar);

                                                        if (proveedores.Count <= posicionProveedor || posicionProveedor < 0)
                                                        {
                                                            Console.WriteLine("");
                                                            Console.WriteLine("La opción ingresada no coincide con ningún");
                                                            Console.WriteLine("proveedor existente...");
                                                        }
                                                        else
                                                        {
                                                            proveedores.RemoveAt(posicionProveedor);

                                                            Console.WriteLine("Registro eliminado con exito...");
                                                            Console.WriteLine("");
                                                            Console.WriteLine("ENTER para continuar");
                                                        }

                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("El dato ingresado es incorrecto");
                                                        Console.WriteLine("Intentelo de nuevo"); 
                                                    }

                                                    Console.ReadKey();
                                                    break;
                                            }
                                        }
                                    }

                                    break;

                                case 2:

                                    Console.Clear();
                                    Console.WriteLine("Ingrese su NIT");
                                    NIT2 = (Console.ReadLine());
                                    Console.WriteLine("Ingrese su nombre");
                                    NOMBRE2 = Console.ReadLine();
                                    Console.WriteLine("Ingrese su apellido");
                                    APELL = Console.ReadLine();
                                    Console.Clear();                                  
                                    Console.WriteLine("\t Por la compra de 12 articulos o más%");
                                    Console.WriteLine("\t obtiene un 5% en su total");
                                    Console.WriteLine("");
                                    Console.WriteLine("\t-----------------------------------------");
                                    Console.WriteLine("");
                                    Console.WriteLine("\t ARTICULOS DISPONIBLES");
                                    Console.WriteLine("");
                                    Console.WriteLine("\t=========================================");
                                    Console.WriteLine("\t 1. MOUSE       Q. 450.00");
                                    Console.WriteLine("\t 2. TECLADO     Q. 800.00");
                                    Console.WriteLine("\t 3. MONITOR     Q. 3000.00");
                                    Console.WriteLine("\t 4. IMPRESORA   Q. 1500.00");
                                    Console.WriteLine("\t 5. AUDIFONOS   Q. 500.00");
                                    Console.WriteLine("\t 6. REGRESAR");
                                    Console.WriteLine("");
                                    Console.WriteLine("\t=========================================");
                                    Console.WriteLine("");
                                    Console.WriteLine("SELECCIONE UNA OPCION");                                  
                                    articulos = int.Parse(Console.ReadLine());

                                    switch (articulos)
                                    {
                                        case 1:
                                          
                                            Console.WriteLine("Cuantos articulos desea comprar");
                                            mouse = int.Parse(Console.ReadLine());
                                            namepro = "Mouse(s) de Q. 450.00";

                                            if (mouse > 0)
                                            {
                                                compratotal = mouse * 450;
                                                descuento = 0;
                                                pagofinal = compratotal - descuento;
                                                if (mouse >= 12)
                                                {
                                                    descuento = compratotal * 0.05;
                                                    pagofinal = compratotal - descuento;
                                                }

                                                Console.Clear();
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t                VENTA ACCESORIOS DE COMPUTACIÓN                ");
                                                Console.WriteLine("\t\t\t                         HPC ADVANCED                          ");
                                                Console.WriteLine("\t\t\t                      CUILAPA SANTA ROSA                       ");
                                                Console.WriteLine("\t\t\t                     TELÉFONO  - 36695683                      ");
                                                Console.WriteLine("\t\t\t                     www.venta/hpccui.com                      ");
                                                Console.WriteLine("\t\t\t============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Código FAC:\t" + finalString);
                                                Console.WriteLine("\t\t\t Fecha emisión:\t{0}", date);
                                                Console.WriteLine("\t\t\t Hora emisión:\t{0}", time);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Cliente:\t" + NOMBRE2 + "\t" + APELL);
                                                Console.WriteLine("\t\t\t NIT:\t\t" + NIT2);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Cant. productos");
                                                Console.WriteLine("\t\t\t adquiridos:\t " + mouse);
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Descripción:");
                                                Console.WriteLine("\t\t\t " + namepro);
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t             Monto gastado: Q" + compratotal);
                                                Console.WriteLine("\t\t\t             Descuento:     Q" + descuento);
                                                Console.WriteLine("\t\t\t                           -------");
                                                Console.WriteLine("\t\t\t             Total a pagar: Q" + pagofinal);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");

                                            }
                                            else
                                            {

                                                Console.WriteLine("Opcion incorrecta");
                                            }

                                            Console.ReadKey();
                                            break;

                                        case 2:
                                            Console.WriteLine("Cuantos articulos desea comprar");
                                            teclado = int.Parse(Console.ReadLine());
                                            namepro = "Teclado(s) de Q. 800.00";
                                            if (teclado > 0)
                                            {
                                                compratotal = teclado * 800;
                                                descuento = 0;
                                                pagofinal = compratotal - descuento;

                                                if (teclado >= 12)
                                                {
                                                    descuento = compratotal * 0.05;
                                                    pagofinal = compratotal - descuento;
                                                }

                                                Console.Clear();
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t                VENTA ACCESORIOS DE COMPUTACIÓN                ");
                                                Console.WriteLine("\t\t\t                         HPC ADVANCED                          ");
                                                Console.WriteLine("\t\t\t                      CUILAPA SANTA ROSA                       ");
                                                Console.WriteLine("\t\t\t                     TELÉFONO  - 36695683                      ");
                                                Console.WriteLine("\t\t\t                     www.venta/hpccui.com                      ");
                                                Console.WriteLine("\t\t\t============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Código FAC:\t" + finalString);
                                                Console.WriteLine("\t\t\t Fecha emisión:\t{0}", date);
                                                Console.WriteLine("\t\t\t Hora emisión:\t{0}", time);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Cliente:\t" + NOMBRE2 + "\t" + APELL);
                                                Console.WriteLine("\t\t\t NIT:\t\t" + NIT2);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Cant. productos");
                                                Console.WriteLine("\t\t\t adquiridos:\t " + teclado);
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Descripción:");
                                                Console.WriteLine("\t\t\t " + namepro);
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t             Monto gastado: Q" + compratotal);
                                                Console.WriteLine("\t\t\t             Descuento:     Q" + descuento);
                                                Console.WriteLine("\t\t\t                           -------");
                                                Console.WriteLine("\t\t\t             Total a pagar: Q" + pagofinal);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                            }
                                            else
                                            {

                                                Console.WriteLine("Opcion incorrecta");
                                            }

                                            Console.ReadKey();
                                            break;

                                        case 3:                                         
                                            Console.WriteLine("Cuantos articulos desea comprar");
                                            monitor = int.Parse(Console.ReadLine());
                                            namepro = "Monitor(s) de Q. 3000.00";

                                            if (monitor > 0)
                                            {
                                                compratotal = monitor * 3000;
                                                descuento = 0;
                                                pagofinal = compratotal - descuento;

                                                if (monitor >= 12)
                                                {
                                                    descuento = compratotal * 0.05;
                                                    pagofinal = compratotal - descuento;
                                                }

                                                Console.Clear();
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t                VENTA ACCESORIOS DE COMPUTACIÓN                ");
                                                Console.WriteLine("\t\t\t                         HPC ADVANCED                          ");
                                                Console.WriteLine("\t\t\t                      CUILAPA SANTA ROSA                       ");
                                                Console.WriteLine("\t\t\t                     TELÉFONO  - 36695683                      ");
                                                Console.WriteLine("\t\t\t                     www.venta/hpccui.com                      ");
                                                Console.WriteLine("\t\t\t============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Código FAC:\t" + finalString);
                                                Console.WriteLine("\t\t\t Fecha emisión:\t{0}", date);
                                                Console.WriteLine("\t\t\t Hora emisión:\t{0}", time);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Cliente:\t" + NOMBRE2 + "\t" + APELL);
                                                Console.WriteLine("\t\t\t NIT:\t\t" + NIT2);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Cant. productos");
                                                Console.WriteLine("\t\t\t adquiridos:\t " + monitor);
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Descripción:");
                                                Console.WriteLine("\t\t\t " + namepro);
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t             Monto gastado: Q" + compratotal);
                                                Console.WriteLine("\t\t\t             Descuento:     Q" + descuento);
                                                Console.WriteLine("\t\t\t                           -------");
                                                Console.WriteLine("\t\t\t             Total a pagar: Q" + pagofinal);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                            }
                                            else
                                            {

                                                Console.WriteLine("Opcion incorrecta");
                                            }

                                            Console.ReadKey();
                                            break;


                                        case 4:                                         
                                            Console.WriteLine("Cuantos articulos desea comprar");
                                            impresora = int.Parse(Console.ReadLine());
                                            namepro = "Impresora(s) de Q. 1500.00";

                                            if (impresora > 0)
                                            {
                                                compratotal = impresora * 1500;
                                                descuento = 0;
                                                pagofinal = compratotal - descuento;

                                                if (impresora >= 12)
                                                {
                                                    descuento = compratotal * 0.05;
                                                    pagofinal = compratotal - descuento;
                                                }

                                                Console.Clear();
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t                VENTA ACCESORIOS DE COMPUTACIÓN                ");
                                                Console.WriteLine("\t\t\t                         HPC ADVANCED                          ");
                                                Console.WriteLine("\t\t\t                      CUILAPA SANTA ROSA                       ");
                                                Console.WriteLine("\t\t\t                     TELÉFONO  - 36695683                      ");
                                                Console.WriteLine("\t\t\t                     www.venta/hpccui.com                      ");
                                                Console.WriteLine("\t\t\t============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Código FAC:\t" + finalString);
                                                Console.WriteLine("\t\t\t Fecha emisión:\t{0}", date);
                                                Console.WriteLine("\t\t\t Hora emisión:\t{0}", time);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Cliente:\t" + NOMBRE2 + "\t" + APELL);
                                                Console.WriteLine("\t\t\t NIT:\t\t" + NIT2);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Cant. productos");
                                                Console.WriteLine("\t\t\t adquiridos:\t " + impresora);
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Descripción:");
                                                Console.WriteLine("\t\t\t " + namepro);
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t             Monto gastado: Q" + compratotal);
                                                Console.WriteLine("\t\t\t             Descuento:     Q" + descuento);
                                                Console.WriteLine("\t\t\t                           -------");
                                                Console.WriteLine("\t\t\t             Total a pagar: Q" + pagofinal);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                            }
                                            else
                                            {

                                                Console.WriteLine("Opcion incorrecta");
                                            }

                                            Console.ReadKey();
                                            break;


                                        case 5:                                         
                                            Console.WriteLine("Cuantos articulos desea comprar");
                                            audifonos = int.Parse(Console.ReadLine());
                                            namepro = "Audifonos(s) de Q. 500.00";

                                            if (audifonos > 0)
                                            {
                                                compratotal = audifonos * 500;
                                                descuento = 0;
                                                pagofinal = compratotal - descuento;
                                                if (audifonos >= 12)
                                                {
                                                    descuento = compratotal * 0.05;
                                                    pagofinal = compratotal - descuento;
                                                }

                                                Console.Clear();
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t                VENTA ACCESORIOS DE COMPUTACIÓN                ");
                                                Console.WriteLine("\t\t\t                         HPC ADVANCED                          ");
                                                Console.WriteLine("\t\t\t                      CUILAPA SANTA ROSA                       ");
                                                Console.WriteLine("\t\t\t                     TELÉFONO  - 36695683                      ");
                                                Console.WriteLine("\t\t\t                     www.venta/hpccui.com                      ");
                                                Console.WriteLine("\t\t\t============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Código FAC:\t" + finalString);
                                                Console.WriteLine("\t\t\t Fecha emisión:\t{0}", date);
                                                Console.WriteLine("\t\t\t Hora emisión:\t{0}", time);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Cliente:\t" + NOMBRE2 + "\t" + APELL);
                                                Console.WriteLine("\t\t\t NIT:\t\t" + NIT2);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Cant. productos");
                                                Console.WriteLine("\t\t\t adquiridos:\t " + audifonos);
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t Descripción:");
                                                Console.WriteLine("\t\t\t " + namepro);
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t             Monto gastado: Q" + compratotal);
                                                Console.WriteLine("\t\t\t             Descuento:     Q" + descuento);
                                                Console.WriteLine("\t\t\t                           -------");
                                                Console.WriteLine("\t\t\t             Total a pagar: Q" + pagofinal);
                                                Console.WriteLine("");
                                                Console.WriteLine("\t\t\t=============================================================");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");
                                                Console.WriteLine("");

                                            }
                                            else
                                            {

                                                Console.WriteLine("Opcion incorrecta");
                                            }

                                            Console.ReadKey();
                                            break;
                                    }

                                    Console.ReadKey();
                                    break;

                                case 3:

                                    Console.Clear();
                                    Console.WriteLine("Ingrese su nombre");
                                    name = Console.ReadLine();
                                    Console.WriteLine("Ingrese su apellido");
                                    lastname = Console.ReadLine();
                                    Console.WriteLine("Ingrese su NIT");
                                    nit = Console.ReadLine();
                                    Console.Clear();


                                    Console.WriteLine("SELECCIONE LA OFERTA QUE DESEA ADQUIRIR");
                                    Console.WriteLine("");
                                    Console.WriteLine("1.) Dos articulos 5% de descuento sobre el total");
                                    Console.WriteLine("2.) Tres articulos 10% de descuento sobre el total");
                                    Console.WriteLine("3.) Cuatro articulos 15% de descuento sobre el total");
                                    Console.WriteLine("4.) Cinco articulos 20% de descuento sobre el total");
                                    op = int.Parse(Console.ReadLine());
                                    Console.Clear();


                                    if (op >= 0 && op <= 4)
                                    {
                                        switch (op)

                                        {
                                            case 1:
                                                Console.WriteLine("Seleccione el primer producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op2 = int.Parse(Console.ReadLine());


                                                if (op2 > 0 && op2 <= 5)
                                                {
                                                    switch (op2)
                                                    {
                                                        case 1:
                                                            precio = (int)(450);
                                                            p1 = "1 Mouse - ";
                                                            break;

                                                        case 2:
                                                            precio = (int)(800);
                                                            p1 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio = (int)(3000);
                                                            p1 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio = (int)(1500);
                                                            p1 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio = (int)(500);
                                                            p1 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }
                                                Console.WriteLine("");
                                                Console.WriteLine("Seleccione el segundo producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op3 = int.Parse(Console.ReadLine());

                                                if (op3 > 0 && op2 <= 5)
                                                {
                                                    switch (op3)
                                                    {
                                                        case 1:
                                                            precio2 = (int)(450);
                                                            p2 = "1 mouse - ";
                                                            break;

                                                        case 2:

                                                            precio2 = (int)(800);
                                                            p2 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio2 = (int)(3000);
                                                            p2 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio2 = (int)(1500);
                                                            p2 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio2 = (int)(500);
                                                            p2 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }

                                                if (op2 > 0 && op2 <= 5 && op3 > 0 && op3 <= 5)
                                                {

                                                    total = precio + precio2;
                                                    producto = p1 + p2;
                                                }
                                                break;

                                            case 2:
                                                Console.WriteLine("");
                                                Console.WriteLine("Seleccione el primer producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op2 = int.Parse(Console.ReadLine());


                                                if (op2 > 0 && op2 <= 5)
                                                {
                                                    switch (op2)
                                                    {
                                                        case 1:
                                                            precio = (int)(450);
                                                            p1 = "1 Mouse - ";
                                                            break;

                                                        case 2:
                                                            precio = (int)(800);
                                                            p1 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio = (int)(3000);
                                                            p1 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio = (int)(1500);
                                                            p1 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio = (int)(500);
                                                            p1 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }
                                                Console.WriteLine("");
                                                Console.WriteLine("Seleccione el segundo producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op3 = int.Parse(Console.ReadLine());


                                                if (op3 > 0 && op3 <= 5)
                                                {
                                                    switch (op3)
                                                    {
                                                        case 1:
                                                            precio2 = (int)(450);
                                                            p2 = "1 Mouse - ";
                                                            break;

                                                        case 2:
                                                            precio2 = (int)(800);
                                                            p2 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio2 = (int)(3000);
                                                            p2 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio2 = (int)(1500);
                                                            p2 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio2 = (int)(500);
                                                            p2 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }
                                                Console.WriteLine("");
                                                Console.WriteLine("Seleccione el tercer producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op4 = int.Parse(Console.ReadLine());

                                                if (op4 > 0 && op4 <= 5)
                                                {
                                                    switch (op4)
                                                    {
                                                        case 1:
                                                            precio3 = (int)(450);
                                                            p3 = "1 Mouse - ";
                                                            break;

                                                        case 2:
                                                            precio3 = (int)(800);
                                                            p3 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio3 = (int)(3000);
                                                            p3 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio3 = (int)(1500);
                                                            p3 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio3 = (int)(500);
                                                            p3 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }

                                                if (op2 > 0 && op2 <= 5 && op3 > 0 && op3 <= 5 && op4 > 0 && op4 <= 5)
                                                {
                                                    total = precio + precio2 + precio3;
                                                    producto = p1 + p2 + p3;
                                                }
                                                break;

                                            case 3:

                                                Console.Clear();
                                                Console.WriteLine("");
                                                Console.WriteLine("Seleccione el primer producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op2 = int.Parse(Console.ReadLine());

                                                if (op2 > 0 && op2 <= 5)
                                                {
                                                    switch (op2)
                                                    {
                                                        case 1:
                                                            precio = (int)(450);
                                                            p1 = "1 Mouse - ";
                                                            break;

                                                        case 2:
                                                            precio = (int)(800);
                                                            p1 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio = (int)(3000);
                                                            p1 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio = (int)(1500);
                                                            p1 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio = (int)(500);
                                                            p1 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }
                                                Console.WriteLine("");
                                                Console.WriteLine("Seleccione el segundo producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op3 = int.Parse(Console.ReadLine());

                                                if (op3 > 0 && op3 <= 5)
                                                {
                                                    switch (op3)
                                                    {
                                                        case 1:
                                                            precio2 = (int)(450);
                                                            p2 = "1 Mouse - ";
                                                            break;

                                                        case 2:
                                                            precio2 = (int)(800);
                                                            p2 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio2 = (int)(3000);
                                                            p2 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio2 = (int)(1500);
                                                            p2 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio2 = (int)(500);
                                                            p2 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }
                                                Console.WriteLine("");
                                                Console.WriteLine("Seleccione el tercer producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op4 = int.Parse(Console.ReadLine());

                                                if (op4 > 0 && op4 <= 5)
                                                {
                                                    switch (op4)
                                                    {
                                                        case 1:
                                                            precio3 = (int)(450);
                                                            p3 = "1 Mouse - ";
                                                            break;

                                                        case 2:
                                                            precio3 = (int)(800);
                                                            p3 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio3 = (int)(3000);
                                                            p3 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio3 = (int)(1500);
                                                            p3 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio3 = (int)(500);
                                                            p3 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }
                                                Console.WriteLine("");
                                                Console.WriteLine("Seleccione el cuarto producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op5 = int.Parse(Console.ReadLine());

                                                if (op5 > 0 && op5 <= 5)
                                                {
                                                    switch (op5)
                                                    {
                                                        case 1:
                                                            precio4 = (int)(450);
                                                            p4 = "1 Mouse - ";
                                                            break;

                                                        case 2:

                                                            precio4 = (int)(800);
                                                            p4 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio4 = (int)(3000);
                                                            p4 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio4 = (int)(1500);
                                                            p4 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio4 = (int)(500);
                                                            p4 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }

                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }

                                                if (op2 > 0 && op2 <= 5 && op3 > 0 && op3 <= 5 && op4 > 0 && op4 <= 5 && op5 > 0 && op5 <= 5)
                                                {

                                                    total = precio + precio2 + precio3 + precio4;
                                                    producto = p1 + p2 + p3 + p4;
                                                }
                                                break;


                                            case 4:
                                                Console.WriteLine("");
                                                Console.WriteLine("Seleccione el primer producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op2 = int.Parse(Console.ReadLine());

                                                if (op2 > 0 && op2 <= 5)
                                                {

                                                    switch (op2)
                                                    {
                                                        case 1:
                                                            precio = (int)(450);
                                                            p1 = "1 Mouse - ";
                                                            break;

                                                        case 2:
                                                            precio = (int)(800);
                                                            p1 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio = (int)(3000);
                                                            p1 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio = (int)(1500);
                                                            p1 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio = (int)(500);
                                                            p1 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }
                                                Console.WriteLine("");
                                                Console.WriteLine("Seleccione el segundo producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op3 = int.Parse(Console.ReadLine());

                                                if (op3 > 0 && op3 <= 5)
                                                {
                                                    switch (op3)
                                                    {
                                                        case 1:
                                                            precio2 = (int)(450);
                                                            p2 = "1 Mouse - ";
                                                            break;

                                                        case 2:
                                                            precio2 = (int)(800);
                                                            p2 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio2 = (int)(3000);
                                                            p2 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio2 = (int)(1500);
                                                            p2 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio2 = (int)(500);
                                                            p2 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }
                                                Console.WriteLine("");
                                                Console.WriteLine("Seleccione el tercer producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op4 = int.Parse(Console.ReadLine());

                                                if (op4 > 0 && op4 <= 5)
                                                {

                                                    switch (op4)
                                                    {
                                                        case 1:
                                                            precio3 = (int)(450);
                                                            p3 = "1 Mouse - ";
                                                            break;

                                                        case 2:
                                                            precio3 = (int)(800);
                                                            p3 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio3 = (int)(3000);
                                                            p3 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio3 = (int)(1500);
                                                            p3 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio3 = (int)(500);
                                                            p3 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }
                                                Console.WriteLine("");
                                                Console.WriteLine("Seleccione el cuarto producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op5 = int.Parse(Console.ReadLine());

                                                if (op5 > 0 && op5 <= 5)
                                                {
                                                    switch (op5)
                                                    {
                                                        case 1:
                                                            precio4 = (int)(450);
                                                            p4 = "1 Mouse - ";
                                                            break;

                                                        case 2:

                                                            precio4 = (int)(800);
                                                            p4 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio4 = (int)(3000);
                                                            p4 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio4 = (int)(1500);
                                                            p4 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio4 = (int)(500);
                                                            p4 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }
                                                Console.WriteLine("");
                                                Console.WriteLine("Seleccione el quinto producto");
                                                Console.WriteLine("1.Mouse Q450.00");
                                                Console.WriteLine("2.Teclado Q800.00");
                                                Console.WriteLine("3.Monitor Q3000.00");
                                                Console.WriteLine("4.Impresora Q1500.00");
                                                Console.WriteLine("5.Audifonos Q500.00");
                                                op6 = int.Parse(Console.ReadLine());

                                                if (op6 > 0 && op6 <= 5)
                                                {
                                                    switch (op6)
                                                    {
                                                        case 1:
                                                            precio5 = (int)(450);
                                                            p5 = "1 Mouse - ";
                                                            break;

                                                        case 2:

                                                            precio5 = (int)(800);
                                                            p5 = " 1 Teclado - ";
                                                            break;
                                                        case 3:
                                                            precio5 = (int)(3000);
                                                            p5 = "1 Monitor - ";
                                                            break;
                                                        case 4:
                                                            precio5 = (int)(1500);
                                                            p5 = "1 Impresora - ";
                                                            break;
                                                        case 5:
                                                            precio5 = (int)(500);
                                                            p5 = "1 Audifonos - ";
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("INGRESO UNA OPCION INVALIDA");
                                                    Console.WriteLine("INTENTELO DE NUEVO");
                                                    Console.WriteLine("");
                                                }

                                                if (op2 > 0 && op2 <= 5 && op3 > 0 && op3 <= 5 && op4 > 0 && op4 <= 5 && op5 > 0 && op5 <= 5 && op6 > 0 && op6 <= 5)
                                                {
                                                    total = precio + precio2 + precio3 + precio4 + precio5;
                                                    producto = p1 + p2 + p3 + p4 + p5;
                                                }
                                                break;
                                        }


                                        if (op == 1)
                                        {
                                            desc = total * 0.07M;
                                            totfinal = total - desc;
                                            cant = 2;
                                            combo = "5%";
                                        }
                                        else if (op == 2)
                                        {
                                            desc = total * 0.10M;
                                            totfinal = total - desc;
                                            cant = 3;
                                            combo = "10%";
                                        }
                                        else if (op == 3)
                                        {
                                            desc = total * 0.15M;
                                            totfinal = total - desc;
                                            cant = 4;
                                            combo = "15%";
                                        }
                                        else if (op == 4)
                                        {
                                            desc = total * 0.20M;
                                            totfinal = total - desc;
                                            cant = 5;
                                            combo = "20%";
                                        }


                                        if (op2 >= 1 | op2 <= 5 | op3 >= 1 | op3 <= 5 | op4 >= 1 | op4 <= 5 | op5 >= 1 | op5 <= 5 | op6 >= 1 | op6 <= 5)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("\t\t\t                 VENTA HERRAMIENTAS DE COMPUTO                 ");
                                            Console.WriteLine("\t\t\t                     CUILAPA SANTA ROSA                        ");
                                            Console.WriteLine("\t\t\t                    TELÉFONO  - 36695683                       ");
                                            Console.WriteLine("\t\t\t                   www.venta/computocui.com                    ");
                                            Console.WriteLine("\t\t\t============================================================");
                                            Console.WriteLine("");
                                            Console.WriteLine("\t\t\t Código FAC:\t" + finalString);
                                            Console.WriteLine("\t\t\t Fecha emisión:\t{0}", date);
                                            Console.WriteLine("\t\t\t Hora emisión:\t{0}", time);
                                            Console.WriteLine("");
                                            Console.WriteLine("\t\t\t=============================================================");
                                            Console.WriteLine("");
                                            Console.WriteLine("\t\t\t Cliente:\t" + name + "\t" + lastname);
                                            Console.WriteLine("\t\t\t NIT:\t\t" + nit);
                                            Console.WriteLine("");
                                            Console.WriteLine("\t\t\t=============================================================");
                                            Console.WriteLine("");
                                            Console.WriteLine("\t\t\t Cant. productos");
                                            Console.WriteLine("\t\t\t adquiridos:\t " + cant);
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("\t\t\t Descripción:");
                                            Console.WriteLine("\t\t\t " + producto);
                                            Console.WriteLine("");
                                            Console.WriteLine("\t\t\t Descuento agregado del  " + combo);
                                            Console.WriteLine("");
                                            Console.WriteLine("\t\t\t             Monto gastado: Q" + total);
                                            Console.WriteLine("\t\t\t             Descuento:     Q" + desc);
                                            Console.WriteLine("\t\t\t                           -------");
                                            Console.WriteLine("\t\t\t             Total a pagar: Q" + totfinal);
                                            Console.WriteLine("");
                                            Console.WriteLine("\t\t\t=============================================================");
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                            Console.WriteLine("");
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("OCURRIÓ UN ERROR (X)");
                                            Console.WriteLine("Verifique que todos los datos estén correctos");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Ingresó una opción incorrecta (x)");
                                    }

                            Console.ReadKey();
                                    break;

                                case 4:

                                    Console.Clear();
                                    Console.WriteLine("Saliendo del programa");
                                    Console.ReadKey();

                                    break;

                                default:

                                    Console.WriteLine("Opcion incorrecta");
                                    Console.ReadKey();
                                    break;
                            }
                        } while (opcion_inicial != 4);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("¡LO SENTIMOS!"); 
                        Console.WriteLine("NO EXISTE REGISTRO DE LOS DATOS INGRESADOS ");
                        Console.WriteLine("PORFAVOR INTENTELO DE NUEVO");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("ENTER para aceptar...");
                    }

                    Console.ReadKey();
                    break;

                case 2:

                    prueba = new string[5];
                   
                    Console.Clear();
                    Console.WriteLine("==========    -- REGISTRO --  ============");
                    Console.WriteLine("");
                    Console.WriteLine(" INGRESE NOMBRE DE USUARIO: ");
                    auxusuario = (Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine(" INGRESE SU CONTRASEÑA: ");
                    auxcontraseña = (Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("ENTER para guardar...");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("¡Su usuario y contraseña se han guardado con exito!");
                    Console.WriteLine("");
                    Console.WriteLine("ENTER para continuar...");                 
                    Console.ReadKey();
                    break;
                   
                    

                default:

                    Console.WriteLine("OPCION INCORRECTA");
                    Console.ReadKey();
                    break;
            }

        } while (ingreso != 1);
    }
}