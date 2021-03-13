﻿using System;
using System.Collections.Generic;
using System.Text;
using UserRoles.Contract.Models.Roles;

namespace UserRoles.Service.Abstract
{
    public interface IRoleService
    {
        public IServiceResponse<RoleModel> GetRoleById(int userId, int roleGroupID, Int64 roleID);
        public IServiceResponse<RoleModel> GetRoleListByGroupId(int userId, int roleGroupID);
    }
}
