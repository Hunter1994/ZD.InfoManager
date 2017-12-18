using System;
using Abp.Authorization.Users;
using Abp.Extensions;
using Microsoft.AspNet.Identity;
using Abp.UI;

namespace ZD.InfoManager.Core.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

        public string AvatarPath { get; set; }

        public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress, string password)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress,
                Password = new PasswordHasher().HashPassword(password)
            };

            return user;
        }

        public void SetNewPassword(string oldPassword,string newPassword)
        {
            var validResult= new PasswordHasher().VerifyHashedPassword(this.Password, oldPassword);
            if(validResult==PasswordVerificationResult.Failed) throw new UserFriendlyException("密码不正确");
            var passwordHash = new PasswordHasher().HashPassword(newPassword);
            this.Password = passwordHash;
        }

    }
}