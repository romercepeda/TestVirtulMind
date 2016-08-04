using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Users
{
    /// <summary>
    /// Una clase dto para emcapsular al usuario. y hacer mas liviana la transferencia de datos.
    /// </summary>
    [DataContract]
    public class DtoUser
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}
