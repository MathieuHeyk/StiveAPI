using Microsoft.AspNetCore.Mvc;
using StiveAPI.Helpers;
using StiveAPI.Models;
using System.Xml.Linq;

namespace StiveAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]

    public class RoleController
    {
        [HttpPost(Name = "AddRole")]

        public void AddRole( string libelle)
        {
           using StiveController context = new();

           Role role = new();
            role.Libelle= libelle;

            context.Add(role);
            context.SaveChanges();
           
        }
        [HttpPut(Name = "EditRole")]
        public void EditRole(int id, string libelle)
        {
            using StiveController context = new();

            Role role = context.Roles.Where(c => c.Id_role == id).First();

            role.Libelle = libelle;

            context.Update(role);
            context.SaveChanges();

        }
        [HttpDelete(Name = "DeleteRole")]
	    public void DeleteRole(int id)
        { 
            using StiveController context = new();
            Role role = context.Roles.Where(c => c.Id_role == id).First();

            context.Remove(role);
            context.SaveChanges();

        }

        [HttpGet(Name = "GetAllRoles")]
        public List<Role> GetAllRoles()
        {
            using StiveController context = new();

            List<Role> roles = context.Roles.ToList();
            return roles;
        }
        [HttpGet(Name = "GetRoledById")]
        public Role GetRoleById(int id)
        {
            using StiveController context = new();

            Role role = context.Roles.Where(c => c.Id_role == id).First();
            return role;
        }
    }
}