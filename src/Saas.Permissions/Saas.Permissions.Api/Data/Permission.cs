﻿namespace Saas.Permissions.Api.Data
{
    public class Permission
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string TenantId { get; set; }
        public string Role { get; set; }

    }
}
