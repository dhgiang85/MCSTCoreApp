using System;
using System.Collections.Generic;
using System.Text;
using MCSTCoreApp.Data.Entities;
using MCSTCoreApp.Data.IRepositories;

namespace MCSTCoreApp.Data.EF.Repositories
{
    public class PermissionRepository : EFRepository<Permission, int>, IPermissionRepository
    {
        public PermissionRepository(AppDbContext context) : base(context)
        {
        }
    }
}
