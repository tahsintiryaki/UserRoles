using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UserRoles.DB.Entities
{
    public partial class RoleGroups
    {
        public RoleGroups()
        {
            Roles = new HashSet<Roles>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int Id { get; set; }
        public string GroupName { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Roles> Roles { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
