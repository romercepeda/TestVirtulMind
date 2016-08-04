using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Web.Http;
using System.Xml.Serialization;
using Users;
namespace RestFullApp.Controllers
{
    public class UserController : ApiController
    {
        /// <summary>
        /// Es el metodo para exponer los usuarios serializados a json, segun la estructura del DTO
        /// </summary>
        /// <returns></returns>
        public List<string> GetAll()
        {
            UserWork uw = new UserWork();
            
            List<string> user = new List<string>();
            foreach (var item in uw.ListAllUser().ToList())
	        {
                MemoryStream stream1 = new MemoryStream();
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(DtoUser));
                ser.WriteObject(stream1, item);
                stream1.Position = 0;
                StreamReader sr = new StreamReader(stream1);           
		        user.Add(sr.ReadToEnd());
	        }

            return user;
        }
    }
}
