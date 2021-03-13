using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace UserRoles.DB.Entities
{
    public partial class Roles
    {
        public int Id { get; set; }
        public long? RoleId { get; set; }
        public string RoleName { get; set; }
        public int? GroupId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual RoleGroups Group { get; set; }
    }
}
