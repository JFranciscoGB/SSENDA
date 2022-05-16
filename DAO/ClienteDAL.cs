using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DAO
{
    public class ClienteDAL
    {
        //variables de conexion
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());
        SqlCommand cmd = new SqlCommand();


        //lista de clientes 
        public List<ClienteSofCom> ListadoClientes()
        {
            String sql, Salida = "";
            List<ClienteSofCom> listado = new List<ClienteSofCom>();
            try
            {
                cn.Open();
                sql = "select TOP 500 CL_CCODCLI,CL_CNOMCLI from FT0020CLIE where CL_CESTADO ='V' ";
                cmd = new SqlCommand(sql, cn);

                //cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ClienteSofCom cliente = new ClienteSofCom();
                    cliente.ruc = dr["CL_CCODCLI"].ToString();
                    //cliente.ruc = Convert.ToChar(dr["CL_CCODCLI"].ToString());
                   
                    cliente.razonsocial = dr["CL_CNOMCLI"].ToString();
                   

                    listado.Add(cliente);
                }
            }
            catch (Exception E)
            {
                throw;
            }
            return listado;

        }


    }
}
