using Microsoft.AspNetCore.Mvc;
using StiveAPI.Helpers;
using StiveAPI.Models;

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

        [HttpGet(Name = "GetAllRole")]
        public List<Role> GetAllRole()
        {
            using StiveController context = new();

            List<Role> roles = context.Roles.ToList();
            return roles;
        }

        [HttpGet(Name = "GetRoleById")]
        public Role GetRoleById(int id)
        {
            using StiveController context = new();

            Role role = context.Roles.Where(c => c.Id_role == id).First();
            return role;
        }
    }
}
