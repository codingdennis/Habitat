namespace Sitecore.Feature.Accounts.Services
{
    using System;
    using System.Net.Mail;
    using Sitecore.Configuration;
    using Sitecore.Data;
    using Sitecore.Data.Fields;
    using Sitecore.Data.Items;
    using Sitecore.Diagnostics;
    using Sitecore.Exceptions;
    using Sitecore.Foundation.SitecoreExtensions.Extensions;
    using Fortis.Foundation.CodeGen.Templates.Feature.Accounts;

    public class AccountsSettingsService : IAccountsSettingsService
    {
        public static readonly string PageNotFoundUrl = Settings.GetSetting("Sitecore.Feature.Accounts.PageNotFoundUrl", "/404");
        public static AccountsSettingsService Instance => new AccountsSettingsService();

        public virtual string GetPageLink(Item contextItem, ID fieldID)
        {
            var item = this.GetAccountsSettingsItem(contextItem);
            if (item == null)
            {
                throw new Exception("Page with accounts settings isn't specified");
            }

            InternalLinkField link = item.Fields[fieldID];
            if (link.TargetItem == null)
            {
                throw new Exception($"{link.InnerField.Name} link isn't set");
            }

            return link.TargetItem.Url();
        }


        public virtual string GetPageLinkOrDefault(Item contextItem, ID field, Item defaultItem = null)
        {
            try
            {
                return this.GetPageLink(contextItem, field);
            }
            catch (Exception ex)
            {
                Log.Warn(ex.Message, ex, this);
                return defaultItem?.Url() ?? PageNotFoundUrl;
            }
        }

        public virtual ID GetRegistrationOutcome(Item contextItem)
        {
            var item = this.GetAccountsSettingsItem(contextItem);

            if (item == null)
            {
                throw new ItemNotFoundException("Page with accounts settings isn't specified");
            }

            ReferenceField field = item.Fields[AccountsSettingsItemConstants.Fields.RegisterOutcome.ID];
            return field?.TargetID;
        }

        public MailMessage GetForgotPasswordMailTemplate()
        {
            var settingsItem = this.GetAccountsSettingsItem(null);
            InternalLinkField link = settingsItem.Fields[AccountsSettingsItemConstants.Fields.ForgotPasswordMailTemplate.ID];
            var mailTemplateItem = link.TargetItem;

            if (mailTemplateItem == null)
            {
                throw new ItemNotFoundException($"Could not find mail template item with {link.TargetID} ID");
            }

            var fromMail = mailTemplateItem.Fields[MailTemplateItemConstants.Fields.From.ID];

            if (string.IsNullOrEmpty(fromMail.Value))
            {
                throw new InvalidValueException("'From' field in mail template should be set");
            }

            var body = mailTemplateItem.Fields[MailTemplateItemConstants.Fields.Body.ID];
            var subject = mailTemplateItem.Fields[MailTemplateItemConstants.Fields.Subject.ID];

            return new MailMessage
            {
                From = new MailAddress(fromMail.Value),
                Body = body.Value,
                Subject = subject.Value
            };
        }

        public virtual Item GetAccountsSettingsItem(Item contextItem)
        {
            Item item = null;

            if (contextItem != null)
            {
                item = contextItem.GetAncestorOrSelfOfTemplate(AccountsSettingsItemConstants.TemplateID);
            }
            item = item ?? Context.Site.GetContextItem(AccountsSettingsItemConstants.TemplateID);

            return item;
        }
    }
}