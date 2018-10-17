using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class ClientesBL
    {
       public BindingList<Cliente> ListaClientes { get; set; }
        public ClientesBL()
        {
            ListaClientes = new BindingList<Cliente>();

            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Bruno Jose Diaz";
            cliente1.Telefono = "98786534";
            cliente1.Correo = "Bruno_Diaz@hotmail.com";
            cliente1.Direccion = "Col.Rivera Hernandes,Casa 2345,Calle 24 y 3 avenida";
            cliente1.Activo = true;

            ListaClientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Kevin Mitnick";
            cliente2.Telefono = "513456789";
            cliente2.Correo = "kevin_hack1@hotmail.com";
            cliente2.Direccion = "California";
            cliente2.Activo = true;

            ListaClientes.Add(cliente2);

            var cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Jonathan James";
            cliente3.Telefono = "518459604";
            cliente3.Correo = "Jonathan_c0mrade@hotmail.com";
            cliente3.Direccion = "Col.Guadalupe ";
            cliente3.Activo = true;

            ListaClientes.Add(cliente3);

            var cliente4 = new Cliente();
            cliente4.Id = 4;
            cliente4.Nombre = "Adrian Lamo";
            cliente4.Telefono = "511234567";
            cliente4.Correo = "Adrian_Hackersinhogar@hotmail.com";
            cliente4.Direccion = "Las Vegas ";
            cliente4.Activo = true;

            ListaClientes.Add(cliente4);

            var cliente5 = new Cliente();
            cliente5.Id = 5;
            cliente5.Nombre = "George Hotz";
            cliente5.Telefono = "511235277";
            cliente5.Correo = "George_geohot@hotmail.com";
            cliente5.Direccion = "Col.Carmen";
            cliente5.Activo = true;

            ListaClientes.Add(cliente5);
        }
        
        public BindingList<Cliente> obtenerProductos()
        {
            return ListaClientes;
        }

        public Resultado2 GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            if (cliente.Nombre == "")
            {
                resultado.Mensaje = "Ingrese Nombres y Apellidos";
                resultado.Exitoso = false;
            }

            if (cliente.Id == 0)
            {
                cliente.Id = ListaClientes.Max(item => item.Id) + 1;
            }
            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCliente()
        {
            var nuevocliente = new Cliente();
            ListaClientes.Add(nuevocliente);
        }

        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    return true;
                }
            }

            return false;
        }
         
        private Resultado2 Validar(Cliente cliente)
        {
            var resultado = new Resultado2();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(cliente.Nombre) == true )
            {
                resultado.Mensaje = "Ingrese Nombres y Apellidos";
                resultado.Exitoso = false;
            }
                        
            if (string.IsNullOrEmpty(cliente.Direccion) == true)
            {
                resultado.Mensaje = "Ingrese Direccion Completa";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.Telefono) == true)
            {
                resultado.Mensaje = "Ingrese el numero de Telefono";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.Correo) == true)
            {
                resultado.Mensaje = "Ingrese el Correo electronico";
                resultado.Exitoso = false;
            }

            

            return resultado;
        }

    }
        public class Cliente
    {
        public int Id { get; set; }
        public string Nombre  { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

    }

    public class Resultado2
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
        }
