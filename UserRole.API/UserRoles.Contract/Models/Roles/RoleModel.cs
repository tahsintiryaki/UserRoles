﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UserRoles.Contract.Models.Roles
{
    public class RoleModel
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int RoleGroupID { get; set; } //Controller
        public Int64 RoleID { get; set; } //Action
        public string GroupName { get; set; }
        public string RoleName { get; set; }
    }
}
