using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDAD;
using DAO;
namespace LN
{
    public class ClienteSofconLN
    {
        ClienteDAL clienteDAL = new ClienteDAL();

        public List<ClienteSofCom> ListadoClientes()
        {
            return clienteDAL.ListadoClientes();

        }
    }
}
