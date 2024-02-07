﻿using Microsoft.EntityFrameworkCore;
using WAbeta.Server.Data;
using WAbeta.Server.Interfaces;

namespace WAbeta.Server.Services
{
    public class TenantFinderService : ITenantFinderInterface
    {
        public async Task<Guid> GetTenantId(string userEmail, ApplicationDbContext dbContext)
        {
            Guid tenantId = Guid.Empty;
            if(string.IsNullOrWhiteSpace(userEmail))
            {
                return tenantId;
            }
            var user = await dbContext.Users.FirstOrDefaultAsync(x => x.Email.Equals(userEmail));

            if(user == null || user.TenantId == default)
            {
                return tenantId;
            }
            return user.TenantId;
        }
    }
}
