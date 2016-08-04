using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
namespace Users
{
    public class UserWork
    { 
        /// <summary>
        /// Consulta y retorna todos los usuatios de la BD. 
        /// Transformando los dato en un DTO como buena practica para que los mismos sean mas livianos.
        /// </summary>
        /// <returns></returns>
        public IList<DtoUser> ListAllUser()
        {
            ModelEContainer e = new ModelEContainer();
            var users = e.User.Select(x=> new 
            DtoUser { Id = x.Id, Name = x.Name, LastName = x.LastName, Email = x.Email , Password = x.Password});
            return users.ToList();
        }
    }
}
