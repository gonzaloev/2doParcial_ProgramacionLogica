using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsteaTVInternetCompany
{
    public static class BaseDeDatos
    {
        //Ingreso
        public static List<Usuario> Usuarios = new List<Usuario>();

        //Titular tiene dentro Contacto domicilio y plan
        public static List<Cliente> Clientes = new List<Cliente>();

        //Gestion de Plan VER COMO METER PRECIO
        public static List<Plan> Planes = new List<Plan>();

        //Gestion de progamacion
        public static List<Canal> Canales = new List<Canal>();

        public static List<Pelicula> peliculas = new List<Pelicula>();


        public static void CargarUsuarios()
        {
            Usuario cl = new Usuario()
            {
                Nombre = "istea",
                Clave = "12345",
                Pregunta = "De que color era el caballo blanco de San Martin",
                Respuesta = "Blanco"
            };

            Usuarios.Add(cl);

            cl = new Usuario()
            {
                Nombre = "martitab",
                Clave = "holasi123",
                Pregunta = "La respuesta es 123",
                Respuesta = "123"
            };

            Usuarios.Add(cl);
        }


        // Detalle de cliente y Gestion 


        public static void CargarClientes()
        {

            Cliente pepito = new Cliente()
            {
                Nombre = "Daniel",
                Nro = "123",
                DNI = "14516413",
                Estatus = true,
                Contacto = new Contacto()
                {
                    email = "tronchatoro@algo.com",
                    telefono = "4564123"
                },
                Domicilio = new Domicilio()
                {
                    Direccion = "calle falsa 123",
                    Localidad = "Pilar",
                    Provincia = "Buenos Aires"

                },
                Plan = Planes[0]
                //TPlan = new Plan()
                //{
                //    Nombre = "Super Basico",
                //    Tv = "Marvel",
                //    Internet = "30Meg",
                //    Precio = 30
                //} 
            };

            Clientes.Add(pepito);

            pepito = new Cliente()
            {
                Nombre = "Daniel",
                Nro = "123",
                DNI = "14516413",
                Estatus = true,
                Contacto = new Contacto()
                {
                    email = "tronchatoro@algo.com",
                    telefono = "4564123"
                },
                Domicilio = new Domicilio()
                {
                    Direccion = "calle falsa 123",
                    Localidad = "Pilar",
                    Provincia = "Buenos Aires"
                },
                Plan = Planes[1]
                /*TPlan = new Plan()
                {
                    Nombre = "Super Basico",
                    Tv = "Telefe",
                    Internet = "30Meg",
                    Precio = 45
                }*/
            };

            Clientes.Add(pepito);
            pepito = new Cliente()
            {
                Nombre = "Marcos",
                Nro = "123",
                DNI = "14516413",
                Estatus = true,
                Contacto = new Contacto()
                {
                    email = "tronchatoro@algo.com",
                    telefono = "4564123"
                },
                Domicilio = new Domicilio()
                {
                    Direccion = "calle falsa 123",
                    Localidad = "Pilar",
                    Provincia = "Buenos Aires"
                },
                Plan = Planes[2]
                /*TPlan = new Plan()
                {
                    Nombre = "Super Basico",
                    Tv = "TyC Sports",
                    Internet = "30Meg",
                    Precio = 90
                }  */
            };
            Clientes.Add(pepito);
        }


        public static void CargarPlanes()
        {
            Plan Plan1 = new Plan()
            {
                Nombre = "Super Basico",
                Tv = "HD",
                Internet = "30Meg",
                Precio = 80
            };
            Planes.Add(Plan1);
            Plan Plan2 = new Plan()
            {
                Nombre = "Basico",
                Tv = "HD",
                Internet = "50Meg",
                Precio = 80
            };
            Planes.Add(Plan2);
            Plan Plan3 = new Plan()
            {
                Nombre = "Mediano",
                Tv = "Basico",
                Internet = "70Meg",
                Precio = 80
            };
            Planes.Add(Plan3);
            Plan Plan4 = new Plan()
            {
                Nombre = "Super",
                Tv = "Basico",
                Internet = "100Meg",
                Precio = 80
            };
            Planes.Add(Plan4);
            Plan Plan5 = new Plan()
            {
                Nombre = "Platino",
                Tv = "4k",
                Internet = "130Meg",
                Precio = 80
            };
            Planes.Add(Plan5);
            Plan Plan6 = new Plan()
            {
                Nombre = "Diamante",
                Tv = "4k",
                Internet = "150Meg",
                Precio = 80
            };
            Planes.Add(Plan6);
        }



        public static void CargarCanales()
        {

            Canal t = new Canal()
            {
                Nombre = "Telefe",
                Nro = 12,
                CPelicula = new Pelicula()
                {
                    Nombre = "Xmen",
                    Duracion = "128",
                    HHHorario = new DateTime(year: 2021, month: 1, day: 1, hour: 22, minute: 54, second: 00)

                }
            };

            Canal e = new Canal()
            {
                Nombre = "El Trece",
                Nro = 13,
                CPelicula = new Pelicula()
                {
                    Nombre = "Vengadores",
                    Duracion = "128",
                    HHHorario = new DateTime(year: 2021, month: 1, day: 1, hour: 8, minute: 30, second: 00)

                }
            };

            Canal n = new Canal()
            {
                Nombre = "Nueve",
                Nro = 9,
                CPelicula = new Pelicula()
                {
                    Nombre = "Titanic",
                    Duracion = "28",
                    HHHorario = new DateTime(year: 2021, month: 1, day: 1, hour: 9, minute: 00, second: 00)

                }
            };

            Canal p = new Canal()
            {
                Nombre = "Tv Publica",
                Nro = 11,
                CPelicula = new Pelicula()
                {
                    Nombre = "El niño de Pijama a Rayas",
                    Duracion = "128",
                    HHHorario = new DateTime(year: 2021, month: 1, day: 1, hour: 7, minute: 00, second: 00)

                }
            };

            Canal s = new Canal()
            {
                Nombre = "Espn",
                Nro = 22,
                CPelicula = new Pelicula()
                {
                    Nombre = "Tiburon 4 ",
                    Duracion = "128",
                    HHHorario = new DateTime(year: 2021, month: 1, day: 1, hour: 12, minute: 00, second: 00)

                }
            };

            Canal a = new Canal()
            {
                Nombre = "America",
                Nro = 8,
                CPelicula = new Pelicula()
                {
                    Nombre = "Tiburon 2 ",
                    Duracion = "128",
                    HHHorario = new DateTime(year: 2021, month: 1, day: 1, hour: 12, minute: 30, second: 00)

                }
            };

            Canales.Add(t);
            Canales.Add(e);
            Canales.Add(n);
            Canales.Add(p);
            Canales.Add(s);
            Canales.Add(a);
        }

        public static void CargarPeliculas()
        {
            Pelicula peliculas1 = new Pelicula()
            {
                Nombre = "Xmen",
                Duracion = "128",
                HHHorario = new DateTime(year: 2021, month: 1, day: 1, hour: 22, minute: 54, second: 00)

            };

            Pelicula peliculas2 = new Pelicula()
            {
                Nombre = "Vengadores",
                Duracion = "128",
                HHHorario = new DateTime(year: 2021, month: 1, day: 1, hour: 8, minute: 30, second: 00)
            };

            Pelicula peliculas3 = new Pelicula()
            {
                Nombre = "Titanic",
                Duracion = "128",
                HHHorario = new DateTime(year: 2021, month: 1, day: 1, hour: 9, minute: 00, second: 00)
            };

            Pelicula peliculas4 = new Pelicula()
            {
                Nombre = "El niño de Pijama a Rayas",
                Duracion = "128",
                HHHorario = new DateTime(year: 2021, month: 1, day: 1, hour: 7, minute: 00, second: 00)
            };

            Pelicula peliculas5 = new Pelicula()
            {
                Nombre = "Tiburon 4 ",
                Duracion = "128",
                HHHorario = new DateTime(year: 2021, month: 1, day: 1, hour: 12, minute: 00, second: 00)
            };

            Pelicula peliculas6 = new Pelicula()
            {
                Nombre = "Shrek",
                Duracion = "128",
                HHHorario = new DateTime(year: 2021, month: 1, day: 1, hour: 12, minute: 30, second: 00)
            };

            peliculas.Add(peliculas1);
            peliculas.Add(peliculas2);
            peliculas.Add(peliculas3);
            peliculas.Add(peliculas4);
            peliculas.Add(peliculas5);
            peliculas.Add(peliculas6);
        }


        public static void CargarDatos()
        {
            CargarUsuarios();
            CargarPlanes();
            CargarClientes();
            CargarCanales();
            CargarPeliculas();
        }






        /*
         * Al final no los usamos.
         * 
        public static List<Contacto> Contactos = new List<Contacto>();
        public static void CargarContacto()
        {
            Contacto cn = new Contacto()
            {
                email = "Email@Gmail.com",
                telefono = "1233456"
            };
            Contactos.Add(cn);
        
            cn = new Contacto()
            {
                email = "hola@Gmail.com",
                telefono = "64512378"
            };
            Contactos.Add(cn);
        
            cn = new Contacto()
            {
                email = "como@Gmail.com",
                telefono = "9874456123"
            };
            Contactos.Add(cn);
        
            cn = new Contacto()
            {
                email = "estas@Gmail.com",
                telefono = "321654987"
            };
            Contactos.Add(cn);
        
        }
        
        public static List<Domicilio> Domicilios = new List<Domicilio>();
        public static void CargarDomicilio()
        {
            Domicilio dm = new Domicilio()
            {
                Direccion = "calle falsa 123",
                Localidad = "Pilar",
                Provincia = "Buenos Aires"
            };
            Domicilios.Add(dm);
        
            dm = new Domicilio()
            {
                Direccion = "calle falsa 1234",
                Localidad = "Pilar",
                Provincia = "Buenos Aires"
            };
            Domicilios.Add(dm);
        
            dm = new Domicilio()
            {
                Direccion = "calle falsa 12223",
                Localidad = "Pilar",
                Provincia = "Buenos Aires"
            };
            Domicilios.Add(dm);
        
            dm = new Domicilio()
            {
                Direccion = "calle falsa 154523",
                Localidad = "Pilar",
                Provincia = "Buenos Aires"
            };
            Domicilios.Add(dm);
        
            dm = new Domicilio()
            {
                Direccion = "calle falsa 6543",
                Localidad = "Pilar",
                Provincia = "Buenos Aires"
            };
            Domicilios.Add(dm);
        
        
        }*/
    }
}
