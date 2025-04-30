using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySQL.Data.MySqlClient;
using System.Collections;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProyectoHotelSol
{
    internal class BDcs : IDisposable
    {
        private MySqlConnection Conexion;
        private MySqlCommand Consulta;
        private string CadenaConexion;
        private bool disposed = false;

        public BDcs()
        {
            CadenaConexion = "Server=localhost;Database=HotelSol;Uid=root;Pwd=;";
        }

        public bool Conectar()
        {
            try
            {
                Conexion = new MySqlConnection(CadenaConexion);
                Conexion.Open();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public void Desconectar()
        {
            if(Conexion != null && Conexion.State == System.Data.ConnectionState.Open)
            {
                Conexion.Close();
            }
        }

        public bool GuardarCliente(Cliente mCliente)
        {
            string textocomando = "insert into Cliente (id_cliente, Nombre, Ap_paterno, Ap_materno, Edad, RFC) values (" +
                mCliente.id_cliente + "," +
                "\"" + mCliente.Nombre + "\"," +
                "\"" + mCliente.Ap_paterno + "\"," +
                "\"" + mCliente.Ap_materno + "\"," +
                mCliente.Edad + "," +
                mCliente.RFC + ");";

            try
            {
                Consulta = new MySqlCommand(textocomando, Conexion);
                Consulta.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
