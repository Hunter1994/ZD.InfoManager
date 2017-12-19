using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Runtime.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZD.InfoManager.Core.SecurityInfos
{
    public class SecurityInfo: FullAuditedEntity, IMustHaveTenant
    {
        [Required]
        public string Title { get; private set; }

        public string UserName { get; private set; }

        public string Password { get; private set; }

        public string Content { get; private set; }

        public int TenantId { get; set; }

        public SecurityInfo(string title, string username, string password, string content)
        {
            this.Title = SimpleStringCipher.Instance.Encrypt(title);
            this.UserName = SimpleStringCipher.Instance.Encrypt(username);
            this.Password = SimpleStringCipher.Instance.Encrypt(password);
            this.Content = SimpleStringCipher.Instance.Encrypt(content);
        }

        public string GetTitle() {
            return SimpleStringCipher.Instance.Decrypt(this.Title);
        }
        public string GetUserName()
        {
            return SimpleStringCipher.Instance.Decrypt(this.UserName);
        }

        public string GetPassword()
        {
            return SimpleStringCipher.Instance.Decrypt(this.Password);
        }
        public string GetContent()
        {
            return SimpleStringCipher.Instance.Decrypt(this.Content);
        }

        public void SetTitle(string title)
        {
            this.Title = SimpleStringCipher.Instance.Encrypt(title);
        }
        public void SetUserName(string username)
        {
            this.UserName = SimpleStringCipher.Instance.Encrypt(username);
        }

        public void SetPassword(string password)
        {
            this.Password = SimpleStringCipher.Instance.Encrypt(password);
        }
        public void SetContent(string content)
        {
            this.Content = SimpleStringCipher.Instance.Encrypt(content);
        }
    }
}
