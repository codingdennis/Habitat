
/*
 * Fortis Template Models for Habitat, based on Unicorn serialization.
 * Generated at 04/22/2017 15:04:43
 *
 * To regenerate after template changes, right-click on CodeGen.tt and select Run Custom Tool.
 */

using System;
using System.Diagnostics;
using System.Collections.Generic;
using Sitecore.Data;
using Sitecore.Data.Items;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq.Common;

namespace Fortis.Foundation.CodeGen.Templates
{
#region _UserProfile (/sitecore/templates/Feature/Accounts/_UserProfile)
namespace Feature.Accounts
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _UserProfile</para>
    /// <para>ID: {696d276b-786a-4d1e-b8bb-8e139db7be7c}</para>
    /// <para>Path: /sitecore/templates/Feature/Accounts/_UserProfile</para>
    /// </summary>
    [TemplateMapping("{696D276B-786A-4D1E-B8BB-8E139DB7BE7C}", "InterfaceMap")]
    public partial interface IUserProfile : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: FirstName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("firstname")]
        ITextFieldWrapper FirstName { get; }

        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: FirstName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("firstname")]
        string FirstNameValue { get; }

        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: Interest</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("interest")]
        ITextFieldWrapper Interest { get; }

        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: Interest</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("interest")]
        string InterestValue { get; }

        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: LastName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("lastname")]
        ITextFieldWrapper LastName { get; }

        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: LastName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("lastname")]
        string LastNameValue { get; }

        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: Phone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("phone")]
        ITextFieldWrapper Phone { get; }

        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: Phone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("phone")]
        string PhoneValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Accounts/_UserProfile</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{696D276B-786A-4D1E-B8BB-8E139DB7BE7C}", typeof(Guid))]
    [TemplateMapping("{696D276B-786A-4D1E-B8BB-8E139DB7BE7C}", "")]
    internal partial class UserProfileItem : CustomItemWrapper, IUserProfile
    {
        private Item _item = null;
        public UserProfileItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public UserProfileItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public UserProfileItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public UserProfileItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: FirstName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("firstname")]
        public virtual ITextFieldWrapper FirstName
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("FirstName", "firstname"); }
        }

        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: FirstName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("firstname")]
        public string FirstNameValue
        {
            [DebuggerStepThrough]
            get { return this.FirstName.Value; }
        }
        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: Interest</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("interest")]
        public virtual ITextFieldWrapper Interest
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Interest", "interest"); }
        }

        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: Interest</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("interest")]
        public string InterestValue
        {
            [DebuggerStepThrough]
            get { return this.Interest.Value; }
        }
        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: LastName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("lastname")]
        public virtual ITextFieldWrapper LastName
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("LastName", "lastname"); }
        }

        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: LastName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("lastname")]
        public string LastNameValue
        {
            [DebuggerStepThrough]
            get { return this.LastName.Value; }
        }
        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: Phone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("phone")]
        public virtual ITextFieldWrapper Phone
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Phone", "phone"); }
        }

        /// <summary>
        /// <para>Template: _UserProfile</para>
        /// <para>Field: Phone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("phone")]
        public string PhoneValue
        {
            [DebuggerStepThrough]
            get { return this.Phone.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Accounts/_UserProfile</para>
    /// <summary>
    public static class UserProfileConstants
    {
        public static readonly ID TemplateID = new ID("{696D276B-786A-4D1E-B8BB-8E139DB7BE7C}");
        public const string TemplateName = "_UserProfile";

        public struct Fields
        {
            public struct FirstName
            {
                public static readonly ID ID = new ID("{E7BC8A3E-3201-4556-B2FF-FF4DB04DB081}");
                public const string FieldName = "FirstName";
            }
            public struct Interest
            {
                public static readonly ID ID = new ID("{A5D0B0AD-CE4E-4E06-B821-F30416B7DEC9}");
                public const string FieldName = "Interest";
            }
            public struct LastName
            {
                public static readonly ID ID = new ID("{EE21278F-4F83-4A10-8890-66B957F3D312}");
                public const string FieldName = "LastName";
            }
            public struct Phone
            {
                public static readonly ID ID = new ID("{F7A1605F-7BBB-4BC7-BBB4-9E0546648E1D}");
                public const string FieldName = "Phone";
            }
        }
    }
    
}
#endregion

#region _AccountsSettings (/sitecore/templates/Feature/Accounts/_AccountsSettings)
namespace Feature.Accounts
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _AccountsSettings</para>
    /// <para>ID: {59d216d1-035c-4497-97b4-e3c5e9f1c06b}</para>
    /// <para>Path: /sitecore/templates/Feature/Accounts/_AccountsSettings</para>
    /// </summary>
    [TemplateMapping("{59D216D1-035C-4497-97B4-E3C5E9F1C06B}", "InterfaceMap")]
    public partial interface IAccountsSettings : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: AccountsDetailsPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        ITextFieldWrapper AccountsDetailsPage { get; }

        string AccountsDetailsPageValue { get; }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: AfterLoginPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        ITextFieldWrapper AfterLoginPage { get; }

        string AfterLoginPageValue { get; }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: ForgotPasswordMailTemplate</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        ITextFieldWrapper ForgotPasswordMailTemplate { get; }

        string ForgotPasswordMailTemplateValue { get; }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: ForgotPasswordPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        ITextFieldWrapper ForgotPasswordPage { get; }

        string ForgotPasswordPageValue { get; }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: LoginPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        ITextFieldWrapper LoginPage { get; }

        string LoginPageValue { get; }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: RegisterOutcome</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("register_outcome")]
        ILinkFieldWrapper RegisterOutcome { get; }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: RegisterOutcome</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("register_outcome")]
        Guid RegisterOutcomeValue { get; }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: RegisterPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        ITextFieldWrapper RegisterPage { get; }

        string RegisterPageValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Accounts/_AccountsSettings</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{59D216D1-035C-4497-97B4-E3C5E9F1C06B}", typeof(Guid))]
    [TemplateMapping("{59D216D1-035C-4497-97B4-E3C5E9F1C06B}", "")]
    internal partial class AccountsSettingsItem : CustomItemWrapper, IAccountsSettings
    {
        private Item _item = null;
        public AccountsSettingsItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public AccountsSettingsItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public AccountsSettingsItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public AccountsSettingsItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: AccountsDetailsPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper AccountsDetailsPage
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Accounts Details Page"); }
        }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: AccountsDetailsPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string AccountsDetailsPageValue
        {
            [DebuggerStepThrough]
            get { return this.AccountsDetailsPage.Value; }
        }
        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: AfterLoginPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper AfterLoginPage
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("After Login Page"); }
        }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: AfterLoginPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string AfterLoginPageValue
        {
            [DebuggerStepThrough]
            get { return this.AfterLoginPage.Value; }
        }
        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: ForgotPasswordMailTemplate</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper ForgotPasswordMailTemplate
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Forgot Password Mail Template"); }
        }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: ForgotPasswordMailTemplate</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string ForgotPasswordMailTemplateValue
        {
            [DebuggerStepThrough]
            get { return this.ForgotPasswordMailTemplate.Value; }
        }
        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: ForgotPasswordPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper ForgotPasswordPage
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Forgot Password Page"); }
        }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: ForgotPasswordPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string ForgotPasswordPageValue
        {
            [DebuggerStepThrough]
            get { return this.ForgotPasswordPage.Value; }
        }
        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: LoginPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper LoginPage
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Login Page"); }
        }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: LoginPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string LoginPageValue
        {
            [DebuggerStepThrough]
            get { return this.LoginPage.Value; }
        }
        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: RegisterOutcome</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("register_outcome")]
        public virtual ILinkFieldWrapper RegisterOutcome
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Register Outcome", "register_outcome"); }
        }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: RegisterOutcome</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("register_outcome")]
        public Guid RegisterOutcomeValue
        {
            [DebuggerStepThrough]
            get { return this.RegisterOutcome.Value; }
        }
        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: RegisterPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper RegisterPage
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Register Page"); }
        }

        /// <summary>
        /// <para>Template: _AccountsSettings</para>
        /// <para>Field: RegisterPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string RegisterPageValue
        {
            [DebuggerStepThrough]
            get { return this.RegisterPage.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Accounts/_AccountsSettings</para>
    /// <summary>
    public static class AccountsSettingsConstants
    {
        public static readonly ID TemplateID = new ID("{59D216D1-035C-4497-97B4-E3C5E9F1C06B}");
        public const string TemplateName = "_AccountsSettings";

        public struct Fields
        {
            public struct AccountsDetailsPage
            {
                public static readonly ID ID = new ID("{ED71D374-8C33-4561-991D-77482AE01330}");
                public const string FieldName = "Accounts Details Page";
            }
            public struct AfterLoginPage
            {
                public static readonly ID ID = new ID("{B128E2B3-3865-4F1C-A147-5F248676D3F5}");
                public const string FieldName = "After Login Page";
            }
            public struct ForgotPasswordMailTemplate
            {
                public static readonly ID ID = new ID("{365254C4-1C1C-493A-9710-671574717898}");
                public const string FieldName = "Forgot Password Mail Template";
            }
            public struct ForgotPasswordPage
            {
                public static readonly ID ID = new ID("{F3CD2BB8-472B-4DF0-87C0-A13098E391CA}");
                public const string FieldName = "Forgot Password Page";
            }
            public struct LoginPage
            {
                public static readonly ID ID = new ID("{60745023-FFD5-400E-8F80-4BCA9F2ABB29}");
                public const string FieldName = "Login Page";
            }
            public struct RegisterOutcome
            {
                public static readonly ID ID = new ID("{835FA523-D28A-46A2-A589-6AA4A5BF0846}");
                public const string FieldName = "Register Outcome";
            }
            public struct RegisterPage
            {
                public static readonly ID ID = new ID("{71962360-10D8-4B98-BB8D-57660CE11127}");
                public const string FieldName = "Register Page";
            }
        }
    }
    
}
#endregion

#region _Interest (/sitecore/templates/Feature/Accounts/_Interest)
namespace Feature.Accounts
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _Interest</para>
    /// <para>ID: {c9b1855e-ca80-4414-b5ba-956cb67dc5a9}</para>
    /// <para>Path: /sitecore/templates/Feature/Accounts/_Interest</para>
    /// </summary>
    [TemplateMapping("{C9B1855E-CA80-4414-B5BA-956CB67DC5A9}", "InterfaceMap")]
    public partial interface IInterest : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _Interest</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        ITextFieldWrapper Title { get; }

        /// <summary>
        /// <para>Template: _Interest</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        string TitleValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Accounts/_Interest</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{C9B1855E-CA80-4414-B5BA-956CB67DC5A9}", typeof(Guid))]
    [TemplateMapping("{C9B1855E-CA80-4414-B5BA-956CB67DC5A9}", "")]
    internal partial class InterestItem : CustomItemWrapper, IInterest
    {
        private Item _item = null;
        public InterestItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public InterestItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public InterestItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public InterestItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _Interest</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: _Interest</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Accounts/_Interest</para>
    /// <summary>
    public static class InterestConstants
    {
        public static readonly ID TemplateID = new ID("{C9B1855E-CA80-4414-B5BA-956CB67DC5A9}");
        public const string TemplateName = "_Interest";

        public struct Fields
        {
            public struct Title
            {
                public static readonly ID ID = new ID("{1FBE5200-2C62-4A32-BA84-CFFE3CF665D3}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region _LoginTeaser (/sitecore/templates/Feature/Accounts/_LoginTeaser)
namespace Feature.Accounts
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _LoginTeaser</para>
    /// <para>ID: {ef38d9e6-313c-491c-8648-79436d10091c}</para>
    /// <para>Path: /sitecore/templates/Feature/Accounts/_LoginTeaser</para>
    /// </summary>
    [TemplateMapping("{EF38D9E6-313C-491C-8648-79436D10091C}", "InterfaceMap")]
    public partial interface ILoginTeaser : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: LoggedInSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("logged_in_summary")]
        ITextFieldWrapper LoggedInSummary { get; }

        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: LoggedInSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("logged_in_summary")]
        string LoggedInSummaryValue { get; }

        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: LoggedInTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("logged_in_title")]
        ITextFieldWrapper LoggedInTitle { get; }

        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: LoggedInTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("logged_in_title")]
        string LoggedInTitleValue { get; }

        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        ITextFieldWrapper Summary { get; }

        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        string SummaryValue { get; }

        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        ITextFieldWrapper Title { get; }

        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        string TitleValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Accounts/_LoginTeaser</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{EF38D9E6-313C-491C-8648-79436D10091C}", typeof(Guid))]
    [TemplateMapping("{EF38D9E6-313C-491C-8648-79436D10091C}", "")]
    internal partial class LoginTeaserItem : CustomItemWrapper, ILoginTeaser
    {
        private Item _item = null;
        public LoginTeaserItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public LoginTeaserItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public LoginTeaserItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public LoginTeaserItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: LoggedInSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("logged_in_summary")]
        public virtual ITextFieldWrapper LoggedInSummary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Logged In Summary", "logged_in_summary"); }
        }

        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: LoggedInSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("logged_in_summary")]
        public string LoggedInSummaryValue
        {
            [DebuggerStepThrough]
            get { return this.LoggedInSummary.Value; }
        }
        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: LoggedInTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("logged_in_title")]
        public virtual ITextFieldWrapper LoggedInTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Logged In Title", "logged_in_title"); }
        }

        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: LoggedInTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("logged_in_title")]
        public string LoggedInTitleValue
        {
            [DebuggerStepThrough]
            get { return this.LoggedInTitle.Value; }
        }
        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual ITextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: _LoginTeaser</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Accounts/_LoginTeaser</para>
    /// <summary>
    public static class LoginTeaserConstants
    {
        public static readonly ID TemplateID = new ID("{EF38D9E6-313C-491C-8648-79436D10091C}");
        public const string TemplateName = "_LoginTeaser";

        public struct Fields
        {
            public struct LoggedInSummary
            {
                public static readonly ID ID = new ID("{76183BC1-755C-428B-A35A-1425309990BE}");
                public const string FieldName = "Logged In Summary";
            }
            public struct LoggedInTitle
            {
                public static readonly ID ID = new ID("{39AABCF6-426C-4AD1-8B3D-A5135F219455}");
                public const string FieldName = "Logged In Title";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{FFAB401B-8D7C-4172-A82A-AE32B7D2C6C1}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{D9843186-ED10-47D8-8CC7-511AC670B6B4}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region _MailTemplate (/sitecore/templates/Feature/Accounts/_MailTemplate)
namespace Feature.Accounts
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _MailTemplate</para>
    /// <para>ID: {26df8f38-7e1b-43d2-85dd-68df05fa276b}</para>
    /// <para>Path: /sitecore/templates/Feature/Accounts/_MailTemplate</para>
    /// </summary>
    [TemplateMapping("{26DF8F38-7E1B-43D2-85DD-68DF05FA276B}", "InterfaceMap")]
    public partial interface IMailTemplate : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _MailTemplate</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        IRichTextFieldWrapper Body { get; }

        /// <summary>
        /// <para>Template: _MailTemplate</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        string BodyValue { get; }

        /// <summary>
        /// <para>Template: _MailTemplate</para>
        /// <para>Field: From</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("from")]
        ITextFieldWrapper From { get; }

        /// <summary>
        /// <para>Template: _MailTemplate</para>
        /// <para>Field: From</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("from")]
        string FromValue { get; }

        /// <summary>
        /// <para>Template: _MailTemplate</para>
        /// <para>Field: Subject</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("subject")]
        ITextFieldWrapper Subject { get; }

        /// <summary>
        /// <para>Template: _MailTemplate</para>
        /// <para>Field: Subject</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("subject")]
        string SubjectValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Accounts/_MailTemplate</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{26DF8F38-7E1B-43D2-85DD-68DF05FA276B}", typeof(Guid))]
    [TemplateMapping("{26DF8F38-7E1B-43D2-85DD-68DF05FA276B}", "")]
    internal partial class MailTemplateItem : CustomItemWrapper, IMailTemplate
    {
        private Item _item = null;
        public MailTemplateItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public MailTemplateItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public MailTemplateItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public MailTemplateItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _MailTemplate</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public virtual IRichTextFieldWrapper Body
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Body", "body"); }
        }

        /// <summary>
        /// <para>Template: _MailTemplate</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public string BodyValue
        {
            [DebuggerStepThrough]
            get { return this.Body.Value; }
        }
        /// <summary>
        /// <para>Template: _MailTemplate</para>
        /// <para>Field: From</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("from")]
        public virtual ITextFieldWrapper From
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("From", "from"); }
        }

        /// <summary>
        /// <para>Template: _MailTemplate</para>
        /// <para>Field: From</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("from")]
        public string FromValue
        {
            [DebuggerStepThrough]
            get { return this.From.Value; }
        }
        /// <summary>
        /// <para>Template: _MailTemplate</para>
        /// <para>Field: Subject</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("subject")]
        public virtual ITextFieldWrapper Subject
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Subject", "subject"); }
        }

        /// <summary>
        /// <para>Template: _MailTemplate</para>
        /// <para>Field: Subject</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("subject")]
        public string SubjectValue
        {
            [DebuggerStepThrough]
            get { return this.Subject.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Accounts/_MailTemplate</para>
    /// <summary>
    public static class MailTemplateConstants
    {
        public static readonly ID TemplateID = new ID("{26DF8F38-7E1B-43D2-85DD-68DF05FA276B}");
        public const string TemplateName = "_MailTemplate";

        public struct Fields
        {
            public struct Body
            {
                public static readonly ID ID = new ID("{1519CCAD-ED26-4F60-82CA-22079AF44D16}");
                public const string FieldName = "Body";
            }
            public struct From
            {
                public static readonly ID ID = new ID("{8605948C-60FB-46B8-8AAA-4C52561B53BC}");
                public const string FieldName = "From";
            }
            public struct Subject
            {
                public static readonly ID ID = new ID("{0F45DF05-546F-462D-97C0-BA4FB2B02564}");
                public const string FieldName = "Subject";
            }
        }
    }
    
}
#endregion

#region _ProfileSettings (/sitecore/templates/Feature/Accounts/_ProfileSettings)
namespace Feature.Accounts
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _ProfileSettings</para>
    /// <para>ID: {2d9aa1e4-3359-4f02-9eaa-5cf972fd990d}</para>
    /// <para>Path: /sitecore/templates/Feature/Accounts/_ProfileSettings</para>
    /// </summary>
    [TemplateMapping("{2D9AA1E4-3359-4F02-9EAA-5CF972FD990D}", "InterfaceMap")]
    public partial interface IProfileSettings : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _ProfileSettings</para>
        /// <para>Field: InterestsFolder</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("interests_folder")]
        ILinkFieldWrapper InterestsFolder { get; }

        /// <summary>
        /// <para>Template: _ProfileSettings</para>
        /// <para>Field: InterestsFolder</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("interests_folder")]
        Guid InterestsFolderValue { get; }

        /// <summary>
        /// <para>Template: _ProfileSettings</para>
        /// <para>Field: UserProfile</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("user_profile")]
        ILinkFieldWrapper UserProfile { get; }

        /// <summary>
        /// <para>Template: _ProfileSettings</para>
        /// <para>Field: UserProfile</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("user_profile")]
        Guid UserProfileValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Accounts/_ProfileSettings</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{2D9AA1E4-3359-4F02-9EAA-5CF972FD990D}", typeof(Guid))]
    [TemplateMapping("{2D9AA1E4-3359-4F02-9EAA-5CF972FD990D}", "")]
    internal partial class ProfileSettingsItem : CustomItemWrapper, IProfileSettings
    {
        private Item _item = null;
        public ProfileSettingsItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public ProfileSettingsItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public ProfileSettingsItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public ProfileSettingsItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _ProfileSettings</para>
        /// <para>Field: InterestsFolder</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("interests_folder")]
        public virtual ILinkFieldWrapper InterestsFolder
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Interests Folder", "interests_folder"); }
        }

        /// <summary>
        /// <para>Template: _ProfileSettings</para>
        /// <para>Field: InterestsFolder</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("interests_folder")]
        public Guid InterestsFolderValue
        {
            [DebuggerStepThrough]
            get { return this.InterestsFolder.Value; }
        }
        /// <summary>
        /// <para>Template: _ProfileSettings</para>
        /// <para>Field: UserProfile</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("user_profile")]
        public virtual ILinkFieldWrapper UserProfile
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("User Profile", "user_profile"); }
        }

        /// <summary>
        /// <para>Template: _ProfileSettings</para>
        /// <para>Field: UserProfile</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("user_profile")]
        public Guid UserProfileValue
        {
            [DebuggerStepThrough]
            get { return this.UserProfile.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Accounts/_ProfileSettings</para>
    /// <summary>
    public static class ProfileSettingsConstants
    {
        public static readonly ID TemplateID = new ID("{2D9AA1E4-3359-4F02-9EAA-5CF972FD990D}");
        public const string TemplateName = "_ProfileSettings";

        public struct Fields
        {
            public struct InterestsFolder
            {
                public static readonly ID ID = new ID("{021AA3F7-206F-4ACC-9538-F6D7FE86B168}");
                public const string FieldName = "Interests Folder";
            }
            public struct UserProfile
            {
                public static readonly ID ID = new ID("{378B7D87-5775-4EB6-86B7-282D5359B1C6}");
                public const string FieldName = "User Profile";
            }
        }
    }
    
}
#endregion

#region _CampaignToken (/sitecore/templates/Feature/Demo/_CampaignToken)
namespace Feature.Demo
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _CampaignToken</para>
    /// <para>ID: {01628dcb-611f-495e-a1da-e89027ab7035}</para>
    /// <para>Path: /sitecore/templates/Feature/Demo/_CampaignToken</para>
    /// </summary>
    [TemplateMapping("{01628DCB-611F-495E-A1DA-E89027AB7035}", "InterfaceMap")]
    public partial interface ICampaignToken : ICustomItemWrapper, Feature.Demo.IToken
    {
        /// <summary>
        /// <para>Template: _CampaignToken</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("token_value")]
        ILinkFieldWrapper TokenValue { get; }

        /// <summary>
        /// <para>Template: _CampaignToken</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("token_value")]
        Guid TokenValueValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Demo/_CampaignToken</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{01628DCB-611F-495E-A1DA-E89027AB7035}", typeof(Guid))]
    [TemplateMapping("{01628DCB-611F-495E-A1DA-E89027AB7035}", "")]
    internal partial class CampaignTokenItem : CustomItemWrapper, ICampaignToken
    {
        private Item _item = null;
        public CampaignTokenItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public CampaignTokenItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public CampaignTokenItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public CampaignTokenItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _CampaignToken</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("token_value")]
        public virtual ILinkFieldWrapper TokenValue
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Token Value", "token_value"); }
        }

        /// <summary>
        /// <para>Template: _CampaignToken</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("token_value")]
        public Guid TokenValueValue
        {
            [DebuggerStepThrough]
            get { return this.TokenValue.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Demo/_CampaignToken</para>
    /// <summary>
    public static class CampaignTokenConstants
    {
        public static readonly ID TemplateID = new ID("{01628DCB-611F-495E-A1DA-E89027AB7035}");
        public const string TemplateName = "_CampaignToken";

        public struct Fields
        {
            public struct TokenValue
            {
                public static readonly ID ID = new ID("{3B485BD9-DEAE-4AAF-9C32-4106C4214162}");
                public const string FieldName = "Token Value";
            }
        }
    }
    
}
#endregion

#region _DemoContent (/sitecore/templates/Feature/Demo/_DemoContent)
namespace Feature.Demo
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _DemoContent</para>
    /// <para>ID: {1224b40e-7b6c-42b3-a6d0-c40a6c61345c}</para>
    /// <para>Path: /sitecore/templates/Feature/Demo/_DemoContent</para>
    /// </summary>
    [TemplateMapping("{1224B40E-7B6C-42B3-A6D0-C40A6C61345C}", "InterfaceMap")]
    public partial interface IDemoContent : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _DemoContent</para>
        /// <para>Field: HTMLContent</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("html_content")]
        ITextFieldWrapper HTMLContent { get; }

        /// <summary>
        /// <para>Template: _DemoContent</para>
        /// <para>Field: HTMLContent</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("html_content")]
        string HTMLContentValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Demo/_DemoContent</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{1224B40E-7B6C-42B3-A6D0-C40A6C61345C}", typeof(Guid))]
    [TemplateMapping("{1224B40E-7B6C-42B3-A6D0-C40A6C61345C}", "")]
    internal partial class DemoContentItem : CustomItemWrapper, IDemoContent
    {
        private Item _item = null;
        public DemoContentItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public DemoContentItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public DemoContentItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public DemoContentItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _DemoContent</para>
        /// <para>Field: HTMLContent</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("html_content")]
        public virtual ITextFieldWrapper HTMLContent
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("HTML Content", "html_content"); }
        }

        /// <summary>
        /// <para>Template: _DemoContent</para>
        /// <para>Field: HTMLContent</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("html_content")]
        public string HTMLContentValue
        {
            [DebuggerStepThrough]
            get { return this.HTMLContent.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Demo/_DemoContent</para>
    /// <summary>
    public static class DemoContentConstants
    {
        public static readonly ID TemplateID = new ID("{1224B40E-7B6C-42B3-A6D0-C40A6C61345C}");
        public const string TemplateName = "_DemoContent";

        public struct Fields
        {
            public struct HTMLContent
            {
                public static readonly ID ID = new ID("{0BC0AEDF-A6D0-4F74-933C-BD1779CD40B2}");
                public const string FieldName = "HTML Content";
            }
        }
    }
    
}
#endregion

#region _LinkToken (/sitecore/templates/Feature/Demo/_LinkToken)
namespace Feature.Demo
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _LinkToken</para>
    /// <para>ID: {359ad0b9-20b5-49e7-a430-891d6e67bc5c}</para>
    /// <para>Path: /sitecore/templates/Feature/Demo/_LinkToken</para>
    /// </summary>
    [TemplateMapping("{359AD0B9-20B5-49E7-A430-891D6E67BC5C}", "InterfaceMap")]
    public partial interface ILinkToken : ICustomItemWrapper, Feature.Demo.IToken
    {
        /// <summary>
        /// <para>Template: _LinkToken</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("token_value")]
        ICustomGeneralLinkFieldWrapper TokenValue { get; }

        /// <summary>
        /// <para>Template: _LinkToken</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("token_value")]
        string TokenValueValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Demo/_LinkToken</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{359AD0B9-20B5-49E7-A430-891D6E67BC5C}", typeof(Guid))]
    [TemplateMapping("{359AD0B9-20B5-49E7-A430-891D6E67BC5C}", "")]
    internal partial class LinkTokenItem : CustomItemWrapper, ILinkToken
    {
        private Item _item = null;
        public LinkTokenItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public LinkTokenItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public LinkTokenItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public LinkTokenItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _LinkToken</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("token_value")]
        public virtual ICustomGeneralLinkFieldWrapper TokenValue
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("Token Value", "token_value"); }
        }

        /// <summary>
        /// <para>Template: _LinkToken</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("token_value")]
        public string TokenValueValue
        {
            [DebuggerStepThrough]
            get { return this.TokenValue.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Demo/_LinkToken</para>
    /// <summary>
    public static class LinkTokenConstants
    {
        public static readonly ID TemplateID = new ID("{359AD0B9-20B5-49E7-A430-891D6E67BC5C}");
        public const string TemplateName = "_LinkToken";

        public struct Fields
        {
            public struct TokenValue
            {
                public static readonly ID ID = new ID("{4A27A4AA-9201-4D1D-B612-F45DDA086C4C}");
                public const string FieldName = "Token Value";
            }
        }
    }
    
}
#endregion

#region _ProfilingSettings (/sitecore/templates/Feature/Demo/_ProfilingSettings)
namespace Feature.Demo
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _ProfilingSettings</para>
    /// <para>ID: {c6d4ddd5-b912-4c1a-a3a3-e1d90e4d0939}</para>
    /// <para>Path: /sitecore/templates/Feature/Demo/_ProfilingSettings</para>
    /// </summary>
    [TemplateMapping("{C6D4DDD5-B912-4C1A-A3A3-E1D90E4D0939}", "InterfaceMap")]
    public partial interface IProfilingSettings : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _ProfilingSettings</para>
        /// <para>Field: SiteProfiles</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("siteprofiles")]
        IListFieldWrapper SiteProfiles { get; }

        /// <summary>
        /// <para>Template: _ProfilingSettings</para>
        /// <para>Field: SiteProfiles</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("siteprofiles")]
        IEnumerable<Guid> SiteProfilesValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Demo/_ProfilingSettings</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{C6D4DDD5-B912-4C1A-A3A3-E1D90E4D0939}", typeof(Guid))]
    [TemplateMapping("{C6D4DDD5-B912-4C1A-A3A3-E1D90E4D0939}", "")]
    internal partial class ProfilingSettingsItem : CustomItemWrapper, IProfilingSettings
    {
        private Item _item = null;
        public ProfilingSettingsItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public ProfilingSettingsItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public ProfilingSettingsItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public ProfilingSettingsItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _ProfilingSettings</para>
        /// <para>Field: SiteProfiles</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("siteprofiles")]
        public virtual IListFieldWrapper SiteProfiles
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("SiteProfiles", "siteprofiles"); }
        }

        /// <summary>
        /// <para>Template: _ProfilingSettings</para>
        /// <para>Field: SiteProfiles</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("siteprofiles")]
        public IEnumerable<Guid> SiteProfilesValue
        {
            [DebuggerStepThrough]
            get { return this.SiteProfiles.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Demo/_ProfilingSettings</para>
    /// <summary>
    public static class ProfilingSettingsConstants
    {
        public static readonly ID TemplateID = new ID("{C6D4DDD5-B912-4C1A-A3A3-E1D90E4D0939}");
        public const string TemplateName = "_ProfilingSettings";

        public struct Fields
        {
            public struct SiteProfiles
            {
                public static readonly ID ID = new ID("{2A84ECA4-68BB-4451-B4AC-98EA71A5A3DC}");
                public const string FieldName = "SiteProfiles";
            }
        }
    }
    
}
#endregion

#region _TextToken (/sitecore/templates/Feature/Demo/_TextToken)
namespace Feature.Demo
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _TextToken</para>
    /// <para>ID: {327d6873-a384-435a-be87-7e869782b243}</para>
    /// <para>Path: /sitecore/templates/Feature/Demo/_TextToken</para>
    /// </summary>
    [TemplateMapping("{327D6873-A384-435A-BE87-7E869782B243}", "InterfaceMap")]
    public partial interface ITextToken : ICustomItemWrapper, Feature.Demo.IToken
    {
        /// <summary>
        /// <para>Template: _TextToken</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("token_value")]
        ITextFieldWrapper TokenValue { get; }

        /// <summary>
        /// <para>Template: _TextToken</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("token_value")]
        string TokenValueValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Demo/_TextToken</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{327D6873-A384-435A-BE87-7E869782B243}", typeof(Guid))]
    [TemplateMapping("{327D6873-A384-435A-BE87-7E869782B243}", "")]
    internal partial class TextTokenItem : CustomItemWrapper, ITextToken
    {
        private Item _item = null;
        public TextTokenItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public TextTokenItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public TextTokenItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public TextTokenItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _TextToken</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("token_value")]
        public virtual ITextFieldWrapper TokenValue
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Token Value", "token_value"); }
        }

        /// <summary>
        /// <para>Template: _TextToken</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("token_value")]
        public string TokenValueValue
        {
            [DebuggerStepThrough]
            get { return this.TokenValue.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Demo/_TextToken</para>
    /// <summary>
    public static class TextTokenConstants
    {
        public static readonly ID TemplateID = new ID("{327D6873-A384-435A-BE87-7E869782B243}");
        public const string TemplateName = "_TextToken";

        public struct Fields
        {
            public struct TokenValue
            {
                public static readonly ID ID = new ID("{7B9F4FE3-6285-4969-9784-B96D49973161}");
                public const string FieldName = "Token Value";
            }
        }
    }
    
}
#endregion

#region _Token (/sitecore/templates/Feature/Demo/_Token)
namespace Feature.Demo
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _Token</para>
    /// <para>ID: {a7ebf38a-5f66-4579-92d1-568a8ba50293}</para>
    /// <para>Path: /sitecore/templates/Feature/Demo/_Token</para>
    /// </summary>
    [TemplateMapping("{A7EBF38A-5F66-4579-92D1-568A8BA50293}", "InterfaceMap")]
    public partial interface IToken : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Demo/_Token</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{A7EBF38A-5F66-4579-92D1-568A8BA50293}", typeof(Guid))]
    [TemplateMapping("{A7EBF38A-5F66-4579-92D1-568A8BA50293}", "")]
    internal partial class TokenItem : CustomItemWrapper, IToken
    {
        private Item _item = null;
        public TokenItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public TokenItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public TokenItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public TokenItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Demo/_Token</para>
    /// <summary>
    public static class TokenConstants
    {
        public static readonly ID TemplateID = new ID("{A7EBF38A-5F66-4579-92D1-568A8BA50293}");
        public const string TemplateName = "_Token";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region _FAQ Group (/sitecore/templates/Feature/FAQ/_FAQ Group)
namespace Feature.FAQ
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _FAQ Group</para>
    /// <para>ID: {3af7db6c-a602-4abc-8d63-19e2d2c6726b}</para>
    /// <para>Path: /sitecore/templates/Feature/FAQ/_FAQ Group</para>
    /// </summary>
    [TemplateMapping("{3AF7DB6C-A602-4ABC-8D63-19E2D2C6726B}", "InterfaceMap")]
    public partial interface IFAQGroup : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _FAQ Group</para>
        /// <para>Field: GroupMember</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("group_member")]
        IListFieldWrapper GroupMember { get; }

        /// <summary>
        /// <para>Template: _FAQ Group</para>
        /// <para>Field: GroupMember</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("group_member")]
        IEnumerable<Guid> GroupMemberValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/FAQ/_FAQ Group</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{3AF7DB6C-A602-4ABC-8D63-19E2D2C6726B}", typeof(Guid))]
    [TemplateMapping("{3AF7DB6C-A602-4ABC-8D63-19E2D2C6726B}", "")]
    internal partial class FAQGroupItem : CustomItemWrapper, IFAQGroup
    {
        private Item _item = null;
        public FAQGroupItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public FAQGroupItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public FAQGroupItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public FAQGroupItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _FAQ Group</para>
        /// <para>Field: GroupMember</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("group_member")]
        public virtual IListFieldWrapper GroupMember
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("Group Member", "group_member"); }
        }

        /// <summary>
        /// <para>Template: _FAQ Group</para>
        /// <para>Field: GroupMember</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("group_member")]
        public IEnumerable<Guid> GroupMemberValue
        {
            [DebuggerStepThrough]
            get { return this.GroupMember.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/FAQ/_FAQ Group</para>
    /// <summary>
    public static class FAQGroupConstants
    {
        public static readonly ID TemplateID = new ID("{3AF7DB6C-A602-4ABC-8D63-19E2D2C6726B}");
        public const string TemplateName = "_FAQ Group";

        public struct Fields
        {
            public struct GroupMember
            {
                public static readonly ID ID = new ID("{631DA648-E2A5-4E3B-9733-C9C066C41EAE}");
                public const string FieldName = "Group Member";
            }
        }
    }
    
}
#endregion

#region _FAQ (/sitecore/templates/Feature/FAQ/_FAQ)
namespace Feature.FAQ
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _FAQ</para>
    /// <para>ID: {9544f0b3-fd5e-4301-9dde-9e73d2c3f7ba}</para>
    /// <para>Path: /sitecore/templates/Feature/FAQ/_FAQ</para>
    /// </summary>
    [TemplateMapping("{9544F0B3-FD5E-4301-9DDE-9E73D2C3F7BA}", "InterfaceMap")]
    public partial interface IFAQ : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _FAQ</para>
        /// <para>Field: Answer</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("answer")]
        IRichTextFieldWrapper Answer { get; }

        /// <summary>
        /// <para>Template: _FAQ</para>
        /// <para>Field: Answer</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("answer")]
        string AnswerValue { get; }

        /// <summary>
        /// <para>Template: _FAQ</para>
        /// <para>Field: Question</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("question")]
        ITextFieldWrapper Question { get; }

        /// <summary>
        /// <para>Template: _FAQ</para>
        /// <para>Field: Question</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("question")]
        string QuestionValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/FAQ/_FAQ</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{9544F0B3-FD5E-4301-9DDE-9E73D2C3F7BA}", typeof(Guid))]
    [TemplateMapping("{9544F0B3-FD5E-4301-9DDE-9E73D2C3F7BA}", "")]
    internal partial class FAQItem : CustomItemWrapper, IFAQ
    {
        private Item _item = null;
        public FAQItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public FAQItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public FAQItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public FAQItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _FAQ</para>
        /// <para>Field: Answer</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("answer")]
        public virtual IRichTextFieldWrapper Answer
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Answer", "answer"); }
        }

        /// <summary>
        /// <para>Template: _FAQ</para>
        /// <para>Field: Answer</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("answer")]
        public string AnswerValue
        {
            [DebuggerStepThrough]
            get { return this.Answer.Value; }
        }
        /// <summary>
        /// <para>Template: _FAQ</para>
        /// <para>Field: Question</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("question")]
        public virtual ITextFieldWrapper Question
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Question", "question"); }
        }

        /// <summary>
        /// <para>Template: _FAQ</para>
        /// <para>Field: Question</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("question")]
        public string QuestionValue
        {
            [DebuggerStepThrough]
            get { return this.Question.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/FAQ/_FAQ</para>
    /// <summary>
    public static class FAQConstants
    {
        public static readonly ID TemplateID = new ID("{9544F0B3-FD5E-4301-9DDE-9E73D2C3F7BA}");
        public const string TemplateName = "_FAQ";

        public struct Fields
        {
            public struct Answer
            {
                public static readonly ID ID = new ID("{57F39C75-51F0-4888-903E-724DFDCC8A38}");
                public const string FieldName = "Answer";
            }
            public struct Question
            {
                public static readonly ID ID = new ID("{9588B6D5-3E6A-4C16-BD37-98DA6F1DDE52}");
                public const string FieldName = "Question";
            }
        }
    }
    
}
#endregion

#region _Identity (/sitecore/templates/Feature/Identity/_Identity)
namespace Feature.Identity
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _Identity</para>
    /// <para>ID: {fa8de5b9-d5d8-40a7-866a-23af4f5a9629}</para>
    /// <para>Path: /sitecore/templates/Feature/Identity/_Identity</para>
    /// </summary>
    [TemplateMapping("{FA8DE5B9-D5D8-40A7-866A-23AF4F5A9629}", "InterfaceMap")]
    public partial interface IIdentity : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: Copyright</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("copyright")]
        IRichTextFieldWrapper Copyright { get; }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: Copyright</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("copyright")]
        string CopyrightValue { get; }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: Logo</para>
        /// <para>Data type: Image</para>
        /// </summary>
        ICustomImageFieldWrapper Logo { get; }

        string LogoValue { get; }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: LogoTagline</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("logo_tagline")]
        ITextFieldWrapper LogoTagline { get; }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: LogoTagline</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("logo_tagline")]
        string LogoTaglineValue { get; }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("organisationaddress")]
        ITextFieldWrapper OrganisationAddress { get; }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("organisationaddress")]
        string OrganisationAddressValue { get; }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationEmail</para>
        /// <para>Data type: link</para>
        /// </summary>
        ICustomGeneralLinkFieldWrapper OrganisationEmail { get; }

        string OrganisationEmailValue { get; }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("organisationname")]
        ITextFieldWrapper OrganisationName { get; }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("organisationname")]
        string OrganisationNameValue { get; }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationPhone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("organisationphone")]
        ITextFieldWrapper OrganisationPhone { get; }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationPhone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("organisationphone")]
        string OrganisationPhoneValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Identity/_Identity</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{FA8DE5B9-D5D8-40A7-866A-23AF4F5A9629}", typeof(Guid))]
    [TemplateMapping("{FA8DE5B9-D5D8-40A7-866A-23AF4F5A9629}", "")]
    internal partial class IdentityItem : CustomItemWrapper, IIdentity
    {
        private Item _item = null;
        public IdentityItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public IdentityItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public IdentityItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public IdentityItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: Copyright</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("copyright")]
        public virtual IRichTextFieldWrapper Copyright
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Copyright", "copyright"); }
        }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: Copyright</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("copyright")]
        public string CopyrightValue
        {
            [DebuggerStepThrough]
            get { return this.Copyright.Value; }
        }
        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: Logo</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Logo
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Logo"); }
        }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: Logo</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string LogoValue
        {
            [DebuggerStepThrough]
            get { return this.Logo.Value; }
        }
        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: LogoTagline</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("logo_tagline")]
        public virtual ITextFieldWrapper LogoTagline
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Logo Tagline", "logo_tagline"); }
        }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: LogoTagline</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("logo_tagline")]
        public string LogoTaglineValue
        {
            [DebuggerStepThrough]
            get { return this.LogoTagline.Value; }
        }
        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("organisationaddress")]
        public virtual ITextFieldWrapper OrganisationAddress
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OrganisationAddress", "organisationaddress"); }
        }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("organisationaddress")]
        public string OrganisationAddressValue
        {
            [DebuggerStepThrough]
            get { return this.OrganisationAddress.Value; }
        }
        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationEmail</para>
        /// <para>Data type: link</para>
        /// </summary>
        public virtual ICustomGeneralLinkFieldWrapper OrganisationEmail
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("OrganisationEmail"); }
        }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationEmail</para>
        /// <para>Data type: link</para>
        /// </summary>
        public string OrganisationEmailValue
        {
            [DebuggerStepThrough]
            get { return this.OrganisationEmail.Value; }
        }
        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("organisationname")]
        public virtual ITextFieldWrapper OrganisationName
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OrganisationName", "organisationname"); }
        }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("organisationname")]
        public string OrganisationNameValue
        {
            [DebuggerStepThrough]
            get { return this.OrganisationName.Value; }
        }
        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationPhone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("organisationphone")]
        public virtual ITextFieldWrapper OrganisationPhone
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OrganisationPhone", "organisationphone"); }
        }

        /// <summary>
        /// <para>Template: _Identity</para>
        /// <para>Field: OrganisationPhone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("organisationphone")]
        public string OrganisationPhoneValue
        {
            [DebuggerStepThrough]
            get { return this.OrganisationPhone.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Identity/_Identity</para>
    /// <summary>
    public static class IdentityConstants
    {
        public static readonly ID TemplateID = new ID("{FA8DE5B9-D5D8-40A7-866A-23AF4F5A9629}");
        public const string TemplateName = "_Identity";

        public struct Fields
        {
            public struct Copyright
            {
                public static readonly ID ID = new ID("{02115632-FE1E-4B3D-9AD4-A4DDF1F782F0}");
                public const string FieldName = "Copyright";
            }
            public struct Logo
            {
                public static readonly ID ID = new ID("{E748D808-64C1-4DEC-9718-F35CF9689E4B}");
                public const string FieldName = "Logo";
            }
            public struct LogoTagline
            {
                public static readonly ID ID = new ID("{31D027BB-FAB5-4E1A-A66D-9F5B0FD4F005}");
                public const string FieldName = "Logo Tagline";
            }
            public struct OrganisationAddress
            {
                public static readonly ID ID = new ID("{A24DF48F-C8A3-4163-966C-8C24BD8760B2}");
                public const string FieldName = "OrganisationAddress";
            }
            public struct OrganisationEmail
            {
                public static readonly ID ID = new ID("{9C428556-5D7B-46AC-B0BB-B06A4F4C9591}");
                public const string FieldName = "OrganisationEmail";
            }
            public struct OrganisationName
            {
                public static readonly ID ID = new ID("{EFD4980A-030C-497C-8880-40B6030AC28B}");
                public const string FieldName = "OrganisationName";
            }
            public struct OrganisationPhone
            {
                public static readonly ID ID = new ID("{005ED83C-2D2F-4D07-A7A9-EB64D873DE46}");
                public const string FieldName = "OrganisationPhone";
            }
        }
    }
    
}
#endregion

#region _LanguageSettings (/sitecore/templates/Feature/Language/_LanguageSettings)
namespace Feature.Language
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _LanguageSettings</para>
    /// <para>ID: {748eba96-3f0c-4f45-8afb-de8dcc707b84}</para>
    /// <para>Path: /sitecore/templates/Feature/Language/_LanguageSettings</para>
    /// </summary>
    [TemplateMapping("{748EBA96-3F0C-4F45-8AFB-DE8DCC707B84}", "InterfaceMap")]
    public partial interface ILanguageSettings : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _LanguageSettings</para>
        /// <para>Field: SupportedLanguages</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("supportedlanguages")]
        IListFieldWrapper SupportedLanguages { get; }

        /// <summary>
        /// <para>Template: _LanguageSettings</para>
        /// <para>Field: SupportedLanguages</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("supportedlanguages")]
        IEnumerable<Guid> SupportedLanguagesValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Language/_LanguageSettings</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{748EBA96-3F0C-4F45-8AFB-DE8DCC707B84}", typeof(Guid))]
    [TemplateMapping("{748EBA96-3F0C-4F45-8AFB-DE8DCC707B84}", "")]
    internal partial class LanguageSettingsItem : CustomItemWrapper, ILanguageSettings
    {
        private Item _item = null;
        public LanguageSettingsItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public LanguageSettingsItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public LanguageSettingsItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public LanguageSettingsItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _LanguageSettings</para>
        /// <para>Field: SupportedLanguages</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("supportedlanguages")]
        public virtual IListFieldWrapper SupportedLanguages
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("SupportedLanguages", "supportedlanguages"); }
        }

        /// <summary>
        /// <para>Template: _LanguageSettings</para>
        /// <para>Field: SupportedLanguages</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("supportedlanguages")]
        public IEnumerable<Guid> SupportedLanguagesValue
        {
            [DebuggerStepThrough]
            get { return this.SupportedLanguages.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Language/_LanguageSettings</para>
    /// <summary>
    public static class LanguageSettingsConstants
    {
        public static readonly ID TemplateID = new ID("{748EBA96-3F0C-4F45-8AFB-DE8DCC707B84}");
        public const string TemplateName = "_LanguageSettings";

        public struct Fields
        {
            public struct SupportedLanguages
            {
                public static readonly ID ID = new ID("{5F115B6D-6052-4C7E-B442-AE923A7E9BD2}");
                public const string FieldName = "SupportedLanguages";
            }
        }
    }
    
}
#endregion

#region Map Type (/sitecore/templates/Feature/Maps/Map Type)
namespace Feature.Maps
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Map Type</para>
    /// <para>ID: {04c34cf5-b7ea-4408-88e8-5fc851173dbd}</para>
    /// <para>Path: /sitecore/templates/Feature/Maps/Map Type</para>
    /// </summary>
    [TemplateMapping("{04C34CF5-B7EA-4408-88E8-5FC851173DBD}", "InterfaceMap")]
    public partial interface IMapType : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: Map Type</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        ITextFieldWrapper Name { get; }

        /// <summary>
        /// <para>Template: Map Type</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        string NameValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Maps/Map Type</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{04C34CF5-B7EA-4408-88E8-5FC851173DBD}", typeof(Guid))]
    [TemplateMapping("{04C34CF5-B7EA-4408-88E8-5FC851173DBD}", "")]
    internal partial class MapTypeItem : CustomItemWrapper, IMapType
    {
        private Item _item = null;
        public MapTypeItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public MapTypeItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public MapTypeItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public MapTypeItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Map Type</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public virtual ITextFieldWrapper Name
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Name", "name"); }
        }

        /// <summary>
        /// <para>Template: Map Type</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public string NameValue
        {
            [DebuggerStepThrough]
            get { return this.Name.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Maps/Map Type</para>
    /// <summary>
    public static class MapTypeConstants
    {
        public static readonly ID TemplateID = new ID("{04C34CF5-B7EA-4408-88E8-5FC851173DBD}");
        public const string TemplateName = "Map Type";

        public struct Fields
        {
            public struct Name
            {
                public static readonly ID ID = new ID("{4A724065-E4CA-4CDD-9027-F56CEEF1B082}");
                public const string FieldName = "Name";
            }
        }
    }
    
}
#endregion

#region _MapPoint (/sitecore/templates/Feature/Maps/_MapPoint)
namespace Feature.Maps
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _MapPoint</para>
    /// <para>ID: {1e6a8c8c-6646-4776-8ab4-615265669633}</para>
    /// <para>Path: /sitecore/templates/Feature/Maps/_MapPoint</para>
    /// </summary>
    [TemplateMapping("{1E6A8C8C-6646-4776-8AB4-615265669633}", "InterfaceMap")]
    public partial interface IMapPoint : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _MapPoint</para>
        /// <para>Field: MapPointAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("mappointaddress")]
        ITextFieldWrapper MapPointAddress { get; }

        /// <summary>
        /// <para>Template: _MapPoint</para>
        /// <para>Field: MapPointAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("mappointaddress")]
        string MapPointAddressValue { get; }

        /// <summary>
        /// <para>Template: _MapPoint</para>
        /// <para>Field: MapPointLocation</para>
        /// <para>Data type: Map Field</para>
        /// </summary>
        ITextFieldWrapper MapPointLocation { get; }

        string MapPointLocationValue { get; }

        /// <summary>
        /// <para>Template: _MapPoint</para>
        /// <para>Field: MapPointName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mappointname")]
        ITextFieldWrapper MapPointName { get; }

        /// <summary>
        /// <para>Template: _MapPoint</para>
        /// <para>Field: MapPointName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mappointname")]
        string MapPointNameValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Maps/_MapPoint</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{1E6A8C8C-6646-4776-8AB4-615265669633}", typeof(Guid))]
    [TemplateMapping("{1E6A8C8C-6646-4776-8AB4-615265669633}", "")]
    internal partial class MapPointItem : CustomItemWrapper, IMapPoint
    {
        private Item _item = null;
        public MapPointItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public MapPointItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public MapPointItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public MapPointItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _MapPoint</para>
        /// <para>Field: MapPointAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("mappointaddress")]
        public virtual ITextFieldWrapper MapPointAddress
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MapPointAddress", "mappointaddress"); }
        }

        /// <summary>
        /// <para>Template: _MapPoint</para>
        /// <para>Field: MapPointAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("mappointaddress")]
        public string MapPointAddressValue
        {
            [DebuggerStepThrough]
            get { return this.MapPointAddress.Value; }
        }
        /// <summary>
        /// <para>Template: _MapPoint</para>
        /// <para>Field: MapPointLocation</para>
        /// <para>Data type: Map Field</para>
        /// </summary>
        public virtual ITextFieldWrapper MapPointLocation
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MapPointLocation"); }
        }

        /// <summary>
        /// <para>Template: _MapPoint</para>
        /// <para>Field: MapPointLocation</para>
        /// <para>Data type: Map Field</para>
        /// </summary>
        public string MapPointLocationValue
        {
            [DebuggerStepThrough]
            get { return this.MapPointLocation.Value; }
        }
        /// <summary>
        /// <para>Template: _MapPoint</para>
        /// <para>Field: MapPointName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mappointname")]
        public virtual ITextFieldWrapper MapPointName
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MapPointName", "mappointname"); }
        }

        /// <summary>
        /// <para>Template: _MapPoint</para>
        /// <para>Field: MapPointName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mappointname")]
        public string MapPointNameValue
        {
            [DebuggerStepThrough]
            get { return this.MapPointName.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Maps/_MapPoint</para>
    /// <summary>
    public static class MapPointConstants
    {
        public static readonly ID TemplateID = new ID("{1E6A8C8C-6646-4776-8AB4-615265669633}");
        public const string TemplateName = "_MapPoint";

        public struct Fields
        {
            public struct MapPointAddress
            {
                public static readonly ID ID = new ID("{0295C01D-214C-4C23-AFC2-3F0B4E88B643}");
                public const string FieldName = "MapPointAddress";
            }
            public struct MapPointLocation
            {
                public static readonly ID ID = new ID("{F686AC8E-1D33-45DB-8E1A-1B40CD491E7A}");
                public const string FieldName = "MapPointLocation";
            }
            public struct MapPointName
            {
                public static readonly ID ID = new ID("{F12C22BB-E57D-4FAB-96E1-1229E4E7FF0E}");
                public const string FieldName = "MapPointName";
            }
        }
    }
    
}
#endregion

#region _MapPoints Folder (/sitecore/templates/Feature/Maps/_MapPoints Folder)
namespace Feature.Maps
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _MapPoints Folder</para>
    /// <para>ID: {31713995-c6bf-4ccb-8807-198493508afa}</para>
    /// <para>Path: /sitecore/templates/Feature/Maps/_MapPoints Folder</para>
    /// </summary>
    [TemplateMapping("{31713995-C6BF-4CCB-8807-198493508AFA}", "InterfaceMap")]
    public partial interface IMapPointsFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Maps/_MapPoints Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{31713995-C6BF-4CCB-8807-198493508AFA}", typeof(Guid))]
    [TemplateMapping("{31713995-C6BF-4CCB-8807-198493508AFA}", "")]
    internal partial class MapPointsFolderItem : CustomItemWrapper, IMapPointsFolder
    {
        private Item _item = null;
        public MapPointsFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public MapPointsFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public MapPointsFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public MapPointsFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Maps/_MapPoints Folder</para>
    /// <summary>
    public static class MapPointsFolderConstants
    {
        public static readonly ID TemplateID = new ID("{31713995-C6BF-4CCB-8807-198493508AFA}");
        public const string TemplateName = "_MapPoints Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region _MapRenderingParameters (/sitecore/templates/Feature/Maps/_MapRenderingParameters)
namespace Feature.Maps
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    using Fortis.Model.RenderingParameters;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _MapRenderingParameters</para>
    /// <para>ID: {d77856c3-8a5e-452c-8854-f2965edf25e0}</para>
    /// <para>Path: /sitecore/templates/Feature/Maps/_MapRenderingParameters</para>
    /// </summary>
    [TemplateMapping("{D77856C3-8A5E-452C-8854-F2965EDF25E0}", "InterfaceRenderingParameter")]
    public partial interface IMapRenderingParameters : IRenderingParameterWrapper
    {
        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: CenterLocation</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        ITextFieldWrapper CenterLocation { get; }

        string CenterLocationValue { get; }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableCenterMapControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        IBooleanFieldWrapper EnableCenterMapControl { get; }

        bool EnableCenterMapControlValue { get; }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableMapTypeControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        IBooleanFieldWrapper EnableMapTypeControl { get; }

        bool EnableMapTypeControlValue { get; }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableRotateControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        IBooleanFieldWrapper EnableRotateControl { get; }

        bool EnableRotateControlValue { get; }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableScaleControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        IBooleanFieldWrapper EnableScaleControl { get; }

        bool EnableScaleControlValue { get; }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableStreetViewControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        IBooleanFieldWrapper EnableStreetViewControl { get; }

        bool EnableStreetViewControlValue { get; }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableZoomControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        IBooleanFieldWrapper EnableZoomControl { get; }

        bool EnableZoomControlValue { get; }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: MapType</para>
        /// <para>Data type: Droplist</para>
        /// </summary>
        ITextFieldWrapper MapType { get; }

        string MapTypeValue { get; }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: ZoomLevel</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        ITextFieldWrapper ZoomLevel { get; }

        string ZoomLevelValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Maps/_MapRenderingParameters</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{D77856C3-8A5E-452C-8854-F2965EDF25E0}", typeof(Guid))]
    [TemplateMapping("{D77856C3-8A5E-452C-8854-F2965EDF25E0}", "RenderingParameter")]
    internal partial class MapRenderingParametersItem : CustomRenderingParameterWrapper, IMapRenderingParameters
    {
        public MapRenderingParametersItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: CenterLocation</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        public virtual ITextFieldWrapper CenterLocation
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.TextFieldWrapper)GetField("CenterLocation", "single-line text"); }
        }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: CenterLocation</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        public string CenterLocationValue
        {
            [DebuggerStepThrough]
            get { return this.CenterLocation.Value; }
        }
        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableCenterMapControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public virtual IBooleanFieldWrapper EnableCenterMapControl
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.BooleanFieldWrapper)GetField("EnableCenterMapControl", "checkbox"); }
        }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableCenterMapControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public bool EnableCenterMapControlValue
        {
            [DebuggerStepThrough]
            get { return this.EnableCenterMapControl.Value; }
        }
        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableMapTypeControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public virtual IBooleanFieldWrapper EnableMapTypeControl
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.BooleanFieldWrapper)GetField("EnableMapTypeControl", "checkbox"); }
        }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableMapTypeControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public bool EnableMapTypeControlValue
        {
            [DebuggerStepThrough]
            get { return this.EnableMapTypeControl.Value; }
        }
        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableRotateControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public virtual IBooleanFieldWrapper EnableRotateControl
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.BooleanFieldWrapper)GetField("EnableRotateControl", "checkbox"); }
        }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableRotateControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public bool EnableRotateControlValue
        {
            [DebuggerStepThrough]
            get { return this.EnableRotateControl.Value; }
        }
        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableScaleControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public virtual IBooleanFieldWrapper EnableScaleControl
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.BooleanFieldWrapper)GetField("EnableScaleControl", "checkbox"); }
        }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableScaleControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public bool EnableScaleControlValue
        {
            [DebuggerStepThrough]
            get { return this.EnableScaleControl.Value; }
        }
        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableStreetViewControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public virtual IBooleanFieldWrapper EnableStreetViewControl
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.BooleanFieldWrapper)GetField("EnableStreetViewControl", "checkbox"); }
        }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableStreetViewControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public bool EnableStreetViewControlValue
        {
            [DebuggerStepThrough]
            get { return this.EnableStreetViewControl.Value; }
        }
        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableZoomControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public virtual IBooleanFieldWrapper EnableZoomControl
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.BooleanFieldWrapper)GetField("EnableZoomControl", "checkbox"); }
        }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: EnableZoomControl</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public bool EnableZoomControlValue
        {
            [DebuggerStepThrough]
            get { return this.EnableZoomControl.Value; }
        }
        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: MapType</para>
        /// <para>Data type: Droplist</para>
        /// </summary>
        public virtual ITextFieldWrapper MapType
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.TextFieldWrapper)GetField("MapType", "droplist"); }
        }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: MapType</para>
        /// <para>Data type: Droplist</para>
        /// </summary>
        public string MapTypeValue
        {
            [DebuggerStepThrough]
            get { return this.MapType.Value; }
        }
        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: ZoomLevel</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        public virtual ITextFieldWrapper ZoomLevel
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.TextFieldWrapper)GetField("ZoomLevel", "single-line text"); }
        }

        /// <summary>
        /// <para>Template: _MapRenderingParameters</para>
        /// <para>Field: ZoomLevel</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        public string ZoomLevelValue
        {
            [DebuggerStepThrough]
            get { return this.ZoomLevel.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Maps/_MapRenderingParameters</para>
    /// <summary>
    public static class MapRenderingParametersConstants
    {
        public static readonly ID TemplateID = new ID("{D77856C3-8A5E-452C-8854-F2965EDF25E0}");
        public const string TemplateName = "_MapRenderingParameters";

        public struct Fields
        {
            public struct CenterLocation
            {
                public static readonly ID ID = new ID("{3016477A-1DAC-460C-A3E2-0E8834E685BD}");
                public const string FieldName = "CenterLocation";
            }
            public struct EnableCenterMapControl
            {
                public static readonly ID ID = new ID("{35F8D3E6-887E-4E54-B715-B81459846CBB}");
                public const string FieldName = "EnableCenterMapControl";
            }
            public struct EnableMapTypeControl
            {
                public static readonly ID ID = new ID("{3FDDA0EA-96EF-4533-B658-E071A2A8E052}");
                public const string FieldName = "EnableMapTypeControl";
            }
            public struct EnableRotateControl
            {
                public static readonly ID ID = new ID("{FD762E2F-71F8-44AC-AE55-22CDB29CDBA2}");
                public const string FieldName = "EnableRotateControl";
            }
            public struct EnableScaleControl
            {
                public static readonly ID ID = new ID("{92514B1F-0F21-4A91-AF7F-852E283E1019}");
                public const string FieldName = "EnableScaleControl";
            }
            public struct EnableStreetViewControl
            {
                public static readonly ID ID = new ID("{A7862BD0-2DDC-4745-9A03-31D297C12BCD}");
                public const string FieldName = "EnableStreetViewControl";
            }
            public struct EnableZoomControl
            {
                public static readonly ID ID = new ID("{C77614FB-8EF2-4418-A486-6CF014B70F22}");
                public const string FieldName = "EnableZoomControl";
            }
            public struct MapType
            {
                public static readonly ID ID = new ID("{90D0BBDC-EA74-4D9A-A570-DAFD6EDC5F92}");
                public const string FieldName = "MapType";
            }
            public struct ZoomLevel
            {
                public static readonly ID ID = new ID("{405A9441-2F1C-4278-A3DD-3D9F818227BE}");
                public const string FieldName = "ZoomLevel";
            }
        }
    }
    
}
#endregion

#region Background Type Folder (/sitecore/templates/Feature/Media/Background Type Folder)
namespace Feature.Media
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Background Type Folder</para>
    /// <para>ID: {1fd75c49-f524-4c15-9f82-dcb2d4cf2fa9}</para>
    /// <para>Path: /sitecore/templates/Feature/Media/Background Type Folder</para>
    /// </summary>
    [TemplateMapping("{1FD75C49-F524-4C15-9F82-DCB2D4CF2FA9}", "InterfaceMap")]
    public partial interface IBackgroundTypeFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Media/Background Type Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{1FD75C49-F524-4C15-9F82-DCB2D4CF2FA9}", typeof(Guid))]
    [TemplateMapping("{1FD75C49-F524-4C15-9F82-DCB2D4CF2FA9}", "")]
    internal partial class BackgroundTypeFolderItem : CustomItemWrapper, IBackgroundTypeFolder
    {
        private Item _item = null;
        public BackgroundTypeFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public BackgroundTypeFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public BackgroundTypeFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public BackgroundTypeFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Media/Background Type Folder</para>
    /// <summary>
    public static class BackgroundTypeFolderConstants
    {
        public static readonly ID TemplateID = new ID("{1FD75C49-F524-4C15-9F82-DCB2D4CF2FA9}");
        public const string TemplateName = "Background Type Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Background Type (/sitecore/templates/Feature/Media/Background Type)
namespace Feature.Media
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Background Type</para>
    /// <para>ID: {55a5bdad-eb69-40f5-8195-cda182e48ee4}</para>
    /// <para>Path: /sitecore/templates/Feature/Media/Background Type</para>
    /// </summary>
    [TemplateMapping("{55A5BDAD-EB69-40F5-8195-CDA182E48EE4}", "InterfaceMap")]
    public partial interface IBackgroundType : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: Background Type</para>
        /// <para>Field: Class</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("class")]
        ITextFieldWrapper Class { get; }

        /// <summary>
        /// <para>Template: Background Type</para>
        /// <para>Field: Class</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("class")]
        string ClassValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Media/Background Type</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{55A5BDAD-EB69-40F5-8195-CDA182E48EE4}", typeof(Guid))]
    [TemplateMapping("{55A5BDAD-EB69-40F5-8195-CDA182E48EE4}", "")]
    internal partial class BackgroundTypeItem : CustomItemWrapper, IBackgroundType
    {
        private Item _item = null;
        public BackgroundTypeItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public BackgroundTypeItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public BackgroundTypeItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public BackgroundTypeItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Background Type</para>
        /// <para>Field: Class</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("class")]
        public virtual ITextFieldWrapper Class
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Class", "class"); }
        }

        /// <summary>
        /// <para>Template: Background Type</para>
        /// <para>Field: Class</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("class")]
        public string ClassValue
        {
            [DebuggerStepThrough]
            get { return this.Class.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Media/Background Type</para>
    /// <summary>
    public static class BackgroundTypeConstants
    {
        public static readonly ID TemplateID = new ID("{55A5BDAD-EB69-40F5-8195-CDA182E48EE4}");
        public const string TemplateName = "Background Type";

        public struct Fields
        {
            public struct Class
            {
                public static readonly ID ID = new ID("{AF6B8E5C-10A2-46BE-8310-407434EC1055}");
                public const string FieldName = "Class";
            }
        }
    }
    
}
#endregion

#region ParametersTemplate_SectionBackground (/sitecore/templates/Feature/Media/ParametersTemplates/ParametersTemplate_SectionBackground)
namespace Feature.Media.ParametersTemplates
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    using Fortis.Model.RenderingParameters;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: ParametersTemplate_SectionBackground</para>
    /// <para>ID: {b962a806-d708-4001-b0a3-3fa31f2263c5}</para>
    /// <para>Path: /sitecore/templates/Feature/Media/ParametersTemplates/ParametersTemplate_SectionBackground</para>
    /// </summary>
    [TemplateMapping("{B962A806-D708-4001-B0A3-3FA31F2263C5}", "InterfaceRenderingParameter")]
    public partial interface IParametersTemplateSectionBackground : IRenderingParameterWrapper, Foundation.SitecoreExtensions.IParametersTemplateHasDynamicPlaceholder
    {
        /// <summary>
        /// <para>Template: ParametersTemplate_SectionBackground</para>
        /// <para>Field: Media</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        ILinkFieldWrapper Media { get; }

        Guid MediaValue { get; }

        /// <summary>
        /// <para>Template: ParametersTemplate_SectionBackground</para>
        /// <para>Field: Parallax</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        IBooleanFieldWrapper Parallax { get; }

        bool ParallaxValue { get; }

        /// <summary>
        /// <para>Template: ParametersTemplate_SectionBackground</para>
        /// <para>Field: Type</para>
        /// <para>Data type: Droplist</para>
        /// </summary>
        ITextFieldWrapper Type { get; }

        string TypeValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Media/ParametersTemplates/ParametersTemplate_SectionBackground</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{B962A806-D708-4001-B0A3-3FA31F2263C5}", typeof(Guid))]
    [TemplateMapping("{B962A806-D708-4001-B0A3-3FA31F2263C5}", "RenderingParameter")]
    internal partial class ParametersTemplateSectionBackgroundItem : CustomRenderingParameterWrapper, IParametersTemplateSectionBackground
    {
        public ParametersTemplateSectionBackgroundItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_SectionBackground</para>
        /// <para>Field: Media</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        public virtual ILinkFieldWrapper Media
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Media", "droptree"); }
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_SectionBackground</para>
        /// <para>Field: Media</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        public Guid MediaValue
        {
            [DebuggerStepThrough]
            get { return this.Media.Value; }
        }
        /// <summary>
        /// <para>Template: ParametersTemplate_SectionBackground</para>
        /// <para>Field: Parallax</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public virtual IBooleanFieldWrapper Parallax
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.BooleanFieldWrapper)GetField("Parallax", "checkbox"); }
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_SectionBackground</para>
        /// <para>Field: Parallax</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public bool ParallaxValue
        {
            [DebuggerStepThrough]
            get { return this.Parallax.Value; }
        }
        /// <summary>
        /// <para>Template: ParametersTemplate_SectionBackground</para>
        /// <para>Field: Type</para>
        /// <para>Data type: Droplist</para>
        /// </summary>
        public virtual ITextFieldWrapper Type
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.TextFieldWrapper)GetField("Type", "droplist"); }
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_SectionBackground</para>
        /// <para>Field: Type</para>
        /// <para>Data type: Droplist</para>
        /// </summary>
        public string TypeValue
        {
            [DebuggerStepThrough]
            get { return this.Type.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Media/ParametersTemplates/ParametersTemplate_SectionBackground</para>
    /// <summary>
    public static class ParametersTemplateSectionBackgroundConstants
    {
        public static readonly ID TemplateID = new ID("{B962A806-D708-4001-B0A3-3FA31F2263C5}");
        public const string TemplateName = "ParametersTemplate_SectionBackground";

        public struct Fields
        {
            public struct Media
            {
                public static readonly ID ID = new ID("{73D4BA11-BC5C-44DB-B184-8FD59857C8DB}");
                public const string FieldName = "Media";
            }
            public struct Parallax
            {
                public static readonly ID ID = new ID("{D598D6DD-3B61-47C3-B84B-8C73211FEF04}");
                public const string FieldName = "Parallax";
            }
            public struct Type
            {
                public static readonly ID ID = new ID("{F9588BB9-013E-4C21-B339-5ED379252CDE}");
                public const string FieldName = "Type";
            }
        }
    }
    
}
#endregion

#region _MediaParameters (/sitecore/templates/Feature/Media/ParametersTemplates/_MediaParameters)
namespace Feature.Media.ParametersTemplates
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    using Fortis.Model.RenderingParameters;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _MediaParameters</para>
    /// <para>ID: {5df30dc0-e2fc-4921-b8f2-c54fac1bd03e}</para>
    /// <para>Path: /sitecore/templates/Feature/Media/ParametersTemplates/_MediaParameters</para>
    /// </summary>
    [TemplateMapping("{5DF30DC0-E2FC-4921-B8F2-C54FAC1BD03E}", "InterfaceRenderingParameter")]
    public partial interface IMediaParameters : IRenderingParameterWrapper, Foundation.Theming.IParametersTemplateFixedHeight
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Media/ParametersTemplates/_MediaParameters</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{5DF30DC0-E2FC-4921-B8F2-C54FAC1BD03E}", typeof(Guid))]
    [TemplateMapping("{5DF30DC0-E2FC-4921-B8F2-C54FAC1BD03E}", "RenderingParameter")]
    internal partial class MediaParametersItem : CustomRenderingParameterWrapper, IMediaParameters
    {
        public MediaParametersItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }

        /// <summary>
        /// <para>Template: _MediaParameters</para>
        /// <para>Field: FixedHeight</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public virtual IBooleanFieldWrapper FixedHeight
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.BooleanFieldWrapper)GetField("Fixed height", "checkbox"); }
        }

        /// <summary>
        /// <para>Template: _MediaParameters</para>
        /// <para>Field: FixedHeight</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public bool FixedHeightValue
        {
            [DebuggerStepThrough]
            get { return this.FixedHeight.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Media/ParametersTemplates/_MediaParameters</para>
    /// <summary>
    public static class MediaParametersConstants
    {
        public static readonly ID TemplateID = new ID("{5DF30DC0-E2FC-4921-B8F2-C54FAC1BD03E}");
        public const string TemplateName = "_MediaParameters";

        public struct Fields
        {
            public struct FixedHeight
            {
                public static readonly ID ID = new ID("{B8965F9D-DDB4-4B8F-BF40-AFCF3C9AE09F}");
                public const string FieldName = "Fixed height";
            }
        }
    }
    
}
#endregion

#region _HasMedia (/sitecore/templates/Feature/Media/_HasMedia)
namespace Feature.Media
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _HasMedia</para>
    /// <para>ID: {a44e450e-ba3f-4faf-9c53-c63241cc34eb}</para>
    /// <para>Path: /sitecore/templates/Feature/Media/_HasMedia</para>
    /// </summary>
    [TemplateMapping("{A44E450E-BA3F-4FAF-9C53-C63241CC34EB}", "InterfaceMap")]
    public partial interface IHasMedia : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _HasMedia</para>
        /// <para>Field: MediaDescription</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("mediadescription")]
        IRichTextFieldWrapper MediaDescription { get; }

        /// <summary>
        /// <para>Template: _HasMedia</para>
        /// <para>Field: MediaDescription</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("mediadescription")]
        string MediaDescriptionValue { get; }

        /// <summary>
        /// <para>Template: _HasMedia</para>
        /// <para>Field: MediaThumbnail</para>
        /// <para>Data type: Image</para>
        /// </summary>
        ICustomImageFieldWrapper MediaThumbnail { get; }

        string MediaThumbnailValue { get; }

        /// <summary>
        /// <para>Template: _HasMedia</para>
        /// <para>Field: MediaTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mediatitle")]
        ITextFieldWrapper MediaTitle { get; }

        /// <summary>
        /// <para>Template: _HasMedia</para>
        /// <para>Field: MediaTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mediatitle")]
        string MediaTitleValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Media/_HasMedia</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{A44E450E-BA3F-4FAF-9C53-C63241CC34EB}", typeof(Guid))]
    [TemplateMapping("{A44E450E-BA3F-4FAF-9C53-C63241CC34EB}", "")]
    internal partial class HasMediaItem : CustomItemWrapper, IHasMedia
    {
        private Item _item = null;
        public HasMediaItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public HasMediaItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public HasMediaItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public HasMediaItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _HasMedia</para>
        /// <para>Field: MediaDescription</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("mediadescription")]
        public virtual IRichTextFieldWrapper MediaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("MediaDescription", "mediadescription"); }
        }

        /// <summary>
        /// <para>Template: _HasMedia</para>
        /// <para>Field: MediaDescription</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("mediadescription")]
        public string MediaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MediaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: _HasMedia</para>
        /// <para>Field: MediaThumbnail</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper MediaThumbnail
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("MediaThumbnail"); }
        }

        /// <summary>
        /// <para>Template: _HasMedia</para>
        /// <para>Field: MediaThumbnail</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string MediaThumbnailValue
        {
            [DebuggerStepThrough]
            get { return this.MediaThumbnail.Value; }
        }
        /// <summary>
        /// <para>Template: _HasMedia</para>
        /// <para>Field: MediaTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mediatitle")]
        public virtual ITextFieldWrapper MediaTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MediaTitle", "mediatitle"); }
        }

        /// <summary>
        /// <para>Template: _HasMedia</para>
        /// <para>Field: MediaTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mediatitle")]
        public string MediaTitleValue
        {
            [DebuggerStepThrough]
            get { return this.MediaTitle.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Media/_HasMedia</para>
    /// <summary>
    public static class HasMediaConstants
    {
        public static readonly ID TemplateID = new ID("{A44E450E-BA3F-4FAF-9C53-C63241CC34EB}");
        public const string TemplateName = "_HasMedia";

        public struct Fields
        {
            public struct MediaDescription
            {
                public static readonly ID ID = new ID("{302C9F8D-F703-4F76-A4AB-73D222648232}");
                public const string FieldName = "MediaDescription";
            }
            public struct MediaThumbnail
            {
                public static readonly ID ID = new ID("{4FF62B0A-D73B-4436-BEA2-023154F2FFC4}");
                public const string FieldName = "MediaThumbnail";
            }
            public struct MediaTitle
            {
                public static readonly ID ID = new ID("{63DDA48B-B0CB-45A7-9A1B-B26DDB41009B}");
                public const string FieldName = "MediaTitle";
            }
        }
    }
    
}
#endregion

#region _HasMediaImage (/sitecore/templates/Feature/Media/_HasMediaImage)
namespace Feature.Media
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _HasMediaImage</para>
    /// <para>ID: {fae0c913-1600-4eba-95a9-4d6fd7407e25}</para>
    /// <para>Path: /sitecore/templates/Feature/Media/_HasMediaImage</para>
    /// </summary>
    [TemplateMapping("{FAE0C913-1600-4EBA-95A9-4D6FD7407E25}", "InterfaceMap")]
    public partial interface IHasMediaImage : ICustomItemWrapper, Feature.Media.IHasMedia
    {
        /// <summary>
        /// <para>Template: _HasMediaImage</para>
        /// <para>Field: MediaImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        ICustomImageFieldWrapper MediaImage { get; }

        string MediaImageValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Media/_HasMediaImage</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{FAE0C913-1600-4EBA-95A9-4D6FD7407E25}", typeof(Guid))]
    [TemplateMapping("{FAE0C913-1600-4EBA-95A9-4D6FD7407E25}", "")]
    internal partial class HasMediaImageItem : CustomItemWrapper, IHasMediaImage
    {
        private Item _item = null;
        public HasMediaImageItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public HasMediaImageItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public HasMediaImageItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public HasMediaImageItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _HasMediaImage</para>
        /// <para>Field: MediaDescription</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("mediadescription")]
        public virtual IRichTextFieldWrapper MediaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("MediaDescription", "mediadescription"); }
        }

        /// <summary>
        /// <para>Template: _HasMediaImage</para>
        /// <para>Field: MediaDescription</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("mediadescription")]
        public string MediaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MediaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: _HasMediaImage</para>
        /// <para>Field: MediaImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper MediaImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("MediaImage"); }
        }

        /// <summary>
        /// <para>Template: _HasMediaImage</para>
        /// <para>Field: MediaImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string MediaImageValue
        {
            [DebuggerStepThrough]
            get { return this.MediaImage.Value; }
        }
        /// <summary>
        /// <para>Template: _HasMediaImage</para>
        /// <para>Field: MediaThumbnail</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper MediaThumbnail
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("MediaThumbnail"); }
        }

        /// <summary>
        /// <para>Template: _HasMediaImage</para>
        /// <para>Field: MediaThumbnail</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string MediaThumbnailValue
        {
            [DebuggerStepThrough]
            get { return this.MediaThumbnail.Value; }
        }
        /// <summary>
        /// <para>Template: _HasMediaImage</para>
        /// <para>Field: MediaTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mediatitle")]
        public virtual ITextFieldWrapper MediaTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MediaTitle", "mediatitle"); }
        }

        /// <summary>
        /// <para>Template: _HasMediaImage</para>
        /// <para>Field: MediaTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mediatitle")]
        public string MediaTitleValue
        {
            [DebuggerStepThrough]
            get { return this.MediaTitle.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Media/_HasMediaImage</para>
    /// <summary>
    public static class HasMediaImageConstants
    {
        public static readonly ID TemplateID = new ID("{FAE0C913-1600-4EBA-95A9-4D6FD7407E25}");
        public const string TemplateName = "_HasMediaImage";

        public struct Fields
        {
            public struct MediaDescription
            {
                public static readonly ID ID = new ID("{302C9F8D-F703-4F76-A4AB-73D222648232}");
                public const string FieldName = "MediaDescription";
            }
            public struct MediaImage
            {
                public static readonly ID ID = new ID("{9F51DEAD-AD6E-41C2-9759-7BE17EB474A4}");
                public const string FieldName = "MediaImage";
            }
            public struct MediaThumbnail
            {
                public static readonly ID ID = new ID("{4FF62B0A-D73B-4436-BEA2-023154F2FFC4}");
                public const string FieldName = "MediaThumbnail";
            }
            public struct MediaTitle
            {
                public static readonly ID ID = new ID("{63DDA48B-B0CB-45A7-9A1B-B26DDB41009B}");
                public const string FieldName = "MediaTitle";
            }
        }
    }
    
}
#endregion

#region _HasMediaSelector (/sitecore/templates/Feature/Media/_HasMediaSelector)
namespace Feature.Media
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _HasMediaSelector</para>
    /// <para>ID: {ae4635af-cfbf-4bf6-9b50-00be23a910c0}</para>
    /// <para>Path: /sitecore/templates/Feature/Media/_HasMediaSelector</para>
    /// </summary>
    [TemplateMapping("{AE4635AF-CFBF-4BF6-9B50-00BE23A910C0}", "InterfaceMap")]
    public partial interface IHasMediaSelector : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _HasMediaSelector</para>
        /// <para>Field: MediaSelector</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("mediaselector")]
        IListFieldWrapper MediaSelector { get; }

        /// <summary>
        /// <para>Template: _HasMediaSelector</para>
        /// <para>Field: MediaSelector</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("mediaselector")]
        IEnumerable<Guid> MediaSelectorValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Media/_HasMediaSelector</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{AE4635AF-CFBF-4BF6-9B50-00BE23A910C0}", typeof(Guid))]
    [TemplateMapping("{AE4635AF-CFBF-4BF6-9B50-00BE23A910C0}", "")]
    internal partial class HasMediaSelectorItem : CustomItemWrapper, IHasMediaSelector
    {
        private Item _item = null;
        public HasMediaSelectorItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public HasMediaSelectorItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public HasMediaSelectorItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public HasMediaSelectorItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _HasMediaSelector</para>
        /// <para>Field: MediaSelector</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("mediaselector")]
        public virtual IListFieldWrapper MediaSelector
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MediaSelector", "mediaselector"); }
        }

        /// <summary>
        /// <para>Template: _HasMediaSelector</para>
        /// <para>Field: MediaSelector</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("mediaselector")]
        public IEnumerable<Guid> MediaSelectorValue
        {
            [DebuggerStepThrough]
            get { return this.MediaSelector.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Media/_HasMediaSelector</para>
    /// <summary>
    public static class HasMediaSelectorConstants
    {
        public static readonly ID TemplateID = new ID("{AE4635AF-CFBF-4BF6-9B50-00BE23A910C0}");
        public const string TemplateName = "_HasMediaSelector";

        public struct Fields
        {
            public struct MediaSelector
            {
                public static readonly ID ID = new ID("{72EA8682-24D2-4BEB-951C-3E2164974105}");
                public const string FieldName = "MediaSelector";
            }
        }
    }
    
}
#endregion

#region _HasMediaVideo (/sitecore/templates/Feature/Media/_HasMediaVideo)
namespace Feature.Media
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _HasMediaVideo</para>
    /// <para>ID: {5a1b724b-b396-4c48-a833-655cd19018e1}</para>
    /// <para>Path: /sitecore/templates/Feature/Media/_HasMediaVideo</para>
    /// </summary>
    [TemplateMapping("{5A1B724B-B396-4C48-A833-655CD19018E1}", "InterfaceMap")]
    public partial interface IHasMediaVideo : ICustomItemWrapper, Feature.Media.IHasMedia
    {
        /// <summary>
        /// <para>Template: _HasMediaVideo</para>
        /// <para>Field: MediaVideoLink</para>
        /// <para>Data type: link</para>
        /// </summary>
        ICustomGeneralLinkFieldWrapper MediaVideoLink { get; }

        string MediaVideoLinkValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Media/_HasMediaVideo</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{5A1B724B-B396-4C48-A833-655CD19018E1}", typeof(Guid))]
    [TemplateMapping("{5A1B724B-B396-4C48-A833-655CD19018E1}", "")]
    internal partial class HasMediaVideoItem : CustomItemWrapper, IHasMediaVideo
    {
        private Item _item = null;
        public HasMediaVideoItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public HasMediaVideoItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public HasMediaVideoItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public HasMediaVideoItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _HasMediaVideo</para>
        /// <para>Field: MediaDescription</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("mediadescription")]
        public virtual IRichTextFieldWrapper MediaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("MediaDescription", "mediadescription"); }
        }

        /// <summary>
        /// <para>Template: _HasMediaVideo</para>
        /// <para>Field: MediaDescription</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("mediadescription")]
        public string MediaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MediaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: _HasMediaVideo</para>
        /// <para>Field: MediaThumbnail</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper MediaThumbnail
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("MediaThumbnail"); }
        }

        /// <summary>
        /// <para>Template: _HasMediaVideo</para>
        /// <para>Field: MediaThumbnail</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string MediaThumbnailValue
        {
            [DebuggerStepThrough]
            get { return this.MediaThumbnail.Value; }
        }
        /// <summary>
        /// <para>Template: _HasMediaVideo</para>
        /// <para>Field: MediaTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mediatitle")]
        public virtual ITextFieldWrapper MediaTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MediaTitle", "mediatitle"); }
        }

        /// <summary>
        /// <para>Template: _HasMediaVideo</para>
        /// <para>Field: MediaTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mediatitle")]
        public string MediaTitleValue
        {
            [DebuggerStepThrough]
            get { return this.MediaTitle.Value; }
        }
        /// <summary>
        /// <para>Template: _HasMediaVideo</para>
        /// <para>Field: MediaVideoLink</para>
        /// <para>Data type: link</para>
        /// </summary>
        public virtual ICustomGeneralLinkFieldWrapper MediaVideoLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("MediaVideoLink"); }
        }

        /// <summary>
        /// <para>Template: _HasMediaVideo</para>
        /// <para>Field: MediaVideoLink</para>
        /// <para>Data type: link</para>
        /// </summary>
        public string MediaVideoLinkValue
        {
            [DebuggerStepThrough]
            get { return this.MediaVideoLink.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Media/_HasMediaVideo</para>
    /// <summary>
    public static class HasMediaVideoConstants
    {
        public static readonly ID TemplateID = new ID("{5A1B724B-B396-4C48-A833-655CD19018E1}");
        public const string TemplateName = "_HasMediaVideo";

        public struct Fields
        {
            public struct MediaDescription
            {
                public static readonly ID ID = new ID("{302C9F8D-F703-4F76-A4AB-73D222648232}");
                public const string FieldName = "MediaDescription";
            }
            public struct MediaThumbnail
            {
                public static readonly ID ID = new ID("{4FF62B0A-D73B-4436-BEA2-023154F2FFC4}");
                public const string FieldName = "MediaThumbnail";
            }
            public struct MediaTitle
            {
                public static readonly ID ID = new ID("{63DDA48B-B0CB-45A7-9A1B-B26DDB41009B}");
                public const string FieldName = "MediaTitle";
            }
            public struct MediaVideoLink
            {
                public static readonly ID ID = new ID("{2628705D-9434-4448-978C-C3BF166FA1EB}");
                public const string FieldName = "MediaVideoLink";
            }
        }
    }
    
}
#endregion

#region _MediaSiteExtension (/sitecore/templates/Feature/Media/_MediaSiteExtension)
namespace Feature.Media
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _MediaSiteExtension</para>
    /// <para>ID: {d339e56b-6a8a-46bd-a7d3-c9725d50dd4a}</para>
    /// <para>Path: /sitecore/templates/Feature/Media/_MediaSiteExtension</para>
    /// </summary>
    [TemplateMapping("{D339E56B-6A8A-46BD-A7D3-C9725D50DD4A}", "InterfaceMap")]
    public partial interface IMediaSiteExtension : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _MediaSiteExtension</para>
        /// <para>Field: Mediafolder</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("mediafolder")]
        ILinkFieldWrapper Mediafolder { get; }

        /// <summary>
        /// <para>Template: _MediaSiteExtension</para>
        /// <para>Field: Mediafolder</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("mediafolder")]
        Guid MediafolderValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Media/_MediaSiteExtension</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{D339E56B-6A8A-46BD-A7D3-C9725D50DD4A}", typeof(Guid))]
    [TemplateMapping("{D339E56B-6A8A-46BD-A7D3-C9725D50DD4A}", "")]
    internal partial class MediaSiteExtensionItem : CustomItemWrapper, IMediaSiteExtension
    {
        private Item _item = null;
        public MediaSiteExtensionItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public MediaSiteExtensionItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public MediaSiteExtensionItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public MediaSiteExtensionItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _MediaSiteExtension</para>
        /// <para>Field: Mediafolder</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("mediafolder")]
        public virtual ILinkFieldWrapper Mediafolder
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Mediafolder", "mediafolder"); }
        }

        /// <summary>
        /// <para>Template: _MediaSiteExtension</para>
        /// <para>Field: Mediafolder</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("mediafolder")]
        public Guid MediafolderValue
        {
            [DebuggerStepThrough]
            get { return this.Mediafolder.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Media/_MediaSiteExtension</para>
    /// <summary>
    public static class MediaSiteExtensionConstants
    {
        public static readonly ID TemplateID = new ID("{D339E56B-6A8A-46BD-A7D3-C9725D50DD4A}");
        public const string TemplateName = "_MediaSiteExtension";

        public struct Fields
        {
            public struct Mediafolder
            {
                public static readonly ID ID = new ID("{E7A63BF6-5A06-498D-B6C1-C8F058ABE2B3}");
                public const string FieldName = "Mediafolder";
            }
        }
    }
    
}
#endregion

#region _Keyword (/sitecore/templates/Feature/Metadata/_Keyword)
namespace Feature.Metadata
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _Keyword</para>
    /// <para>ID: {409f883a-0dc8-431a-9508-7316b59b92be}</para>
    /// <para>Path: /sitecore/templates/Feature/Metadata/_Keyword</para>
    /// </summary>
    [TemplateMapping("{409F883A-0DC8-431A-9508-7316B59B92BE}", "InterfaceMap")]
    public partial interface IKeyword : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _Keyword</para>
        /// <para>Field: Keyword</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("keyword")]
        ITextFieldWrapper Keyword { get; }

        /// <summary>
        /// <para>Template: _Keyword</para>
        /// <para>Field: Keyword</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("keyword")]
        string KeywordValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Metadata/_Keyword</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{409F883A-0DC8-431A-9508-7316B59B92BE}", typeof(Guid))]
    [TemplateMapping("{409F883A-0DC8-431A-9508-7316B59B92BE}", "")]
    internal partial class KeywordItem : CustomItemWrapper, IKeyword
    {
        private Item _item = null;
        public KeywordItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public KeywordItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public KeywordItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public KeywordItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _Keyword</para>
        /// <para>Field: Keyword</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("keyword")]
        public virtual ITextFieldWrapper Keyword
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Keyword", "keyword"); }
        }

        /// <summary>
        /// <para>Template: _Keyword</para>
        /// <para>Field: Keyword</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("keyword")]
        public string KeywordValue
        {
            [DebuggerStepThrough]
            get { return this.Keyword.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Metadata/_Keyword</para>
    /// <summary>
    public static class KeywordConstants
    {
        public static readonly ID TemplateID = new ID("{409F883A-0DC8-431A-9508-7316B59B92BE}");
        public const string TemplateName = "_Keyword";

        public struct Fields
        {
            public struct Keyword
            {
                public static readonly ID ID = new ID("{7BDBBA5F-C7E6-45C2-82F5-010DED013588}");
                public const string FieldName = "Keyword";
            }
        }
    }
    
}
#endregion

#region _PageMetadata (/sitecore/templates/Feature/Metadata/_PageMetadata)
namespace Feature.Metadata
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _PageMetadata</para>
    /// <para>ID: {d88ccd80-d851-470d-af11-701ff23504e7}</para>
    /// <para>Path: /sitecore/templates/Feature/Metadata/_PageMetadata</para>
    /// </summary>
    [TemplateMapping("{D88CCD80-D851-470D-AF11-701FF23504E7}", "InterfaceMap")]
    public partial interface IPageMetadata : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        ITextFieldWrapper BrowserTitle { get; }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        string BrowserTitleValue { get; }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        IBooleanFieldWrapper CanIndex { get; }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        bool CanIndexValue { get; }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        ITextFieldWrapper CustomMetaData { get; }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        string CustomMetaDataValue { get; }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        ITextFieldWrapper MetaDescription { get; }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        string MetaDescriptionValue { get; }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        IListFieldWrapper MetaKeywords { get; }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        IEnumerable<Guid> MetaKeywordsValue { get; }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        IBooleanFieldWrapper SeoFollowLinks { get; }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        bool SeoFollowLinksValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Metadata/_PageMetadata</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{D88CCD80-D851-470D-AF11-701FF23504E7}", typeof(Guid))]
    [TemplateMapping("{D88CCD80-D851-470D-AF11-701FF23504E7}", "")]
    internal partial class PageMetadataItem : CustomItemWrapper, IPageMetadata
    {
        private Item _item = null;
        public PageMetadataItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public PageMetadataItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public PageMetadataItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public PageMetadataItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: _PageMetadata</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Metadata/_PageMetadata</para>
    /// <summary>
    public static class PageMetadataConstants
    {
        public static readonly ID TemplateID = new ID("{D88CCD80-D851-470D-AF11-701FF23504E7}");
        public const string TemplateName = "_PageMetadata";

        public struct Fields
        {
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
        }
    }
    
}
#endregion

#region _SiteMetadata (/sitecore/templates/Feature/Metadata/_SiteMetadata)
namespace Feature.Metadata
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _SiteMetadata</para>
    /// <para>ID: {cf38e914-9298-47cc-9205-210553e79f97}</para>
    /// <para>Path: /sitecore/templates/Feature/Metadata/_SiteMetadata</para>
    /// </summary>
    [TemplateMapping("{CF38E914-9298-47CC-9205-210553E79F97}", "InterfaceMap")]
    public partial interface ISiteMetadata : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _SiteMetadata</para>
        /// <para>Field: SiteBrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("sitebrowsertitle")]
        ITextFieldWrapper SiteBrowserTitle { get; }

        /// <summary>
        /// <para>Template: _SiteMetadata</para>
        /// <para>Field: SiteBrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("sitebrowsertitle")]
        string SiteBrowserTitleValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Metadata/_SiteMetadata</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{CF38E914-9298-47CC-9205-210553E79F97}", typeof(Guid))]
    [TemplateMapping("{CF38E914-9298-47CC-9205-210553E79F97}", "")]
    internal partial class SiteMetadataItem : CustomItemWrapper, ISiteMetadata
    {
        private Item _item = null;
        public SiteMetadataItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public SiteMetadataItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public SiteMetadataItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public SiteMetadataItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _SiteMetadata</para>
        /// <para>Field: SiteBrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("sitebrowsertitle")]
        public virtual ITextFieldWrapper SiteBrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("SiteBrowserTitle", "sitebrowsertitle"); }
        }

        /// <summary>
        /// <para>Template: _SiteMetadata</para>
        /// <para>Field: SiteBrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("sitebrowsertitle")]
        public string SiteBrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.SiteBrowserTitle.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Metadata/_SiteMetadata</para>
    /// <summary>
    public static class SiteMetadataConstants
    {
        public static readonly ID TemplateID = new ID("{CF38E914-9298-47CC-9205-210553E79F97}");
        public const string TemplateName = "_SiteMetadata";

        public struct Fields
        {
            public struct SiteBrowserTitle
            {
                public static readonly ID ID = new ID("{235AE392-97AC-4822-BE38-837DA3E7724E}");
                public const string FieldName = "SiteBrowserTitle";
            }
        }
    }
    
}
#endregion

#region _SiteConfiguration (/sitecore/templates/Feature/Multisite/_SiteConfiguration)
namespace Feature.Multisite
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _SiteConfiguration</para>
    /// <para>ID: {0fccfe4f-b087-498f-bd26-5cdffc522c9a}</para>
    /// <para>Path: /sitecore/templates/Feature/Multisite/_SiteConfiguration</para>
    /// </summary>
    [TemplateMapping("{0FCCFE4F-B087-498F-BD26-5CDFFC522C9A}", "InterfaceMap")]
    public partial interface ISiteConfiguration : ICustomItemWrapper, Foundation.Multisite.ISite
    {
        /// <summary>
        /// <para>Template: _SiteConfiguration</para>
        /// <para>Field: ShowInMenu</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinmenu")]
        IBooleanFieldWrapper ShowInMenu { get; }

        /// <summary>
        /// <para>Template: _SiteConfiguration</para>
        /// <para>Field: ShowInMenu</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinmenu")]
        bool ShowInMenuValue { get; }

        /// <summary>
        /// <para>Template: _SiteConfiguration</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        ITextFieldWrapper Title { get; }

        /// <summary>
        /// <para>Template: _SiteConfiguration</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        string TitleValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Multisite/_SiteConfiguration</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{0FCCFE4F-B087-498F-BD26-5CDFFC522C9A}", typeof(Guid))]
    [TemplateMapping("{0FCCFE4F-B087-498F-BD26-5CDFFC522C9A}", "")]
    internal partial class SiteConfigurationItem : CustomItemWrapper, ISiteConfiguration
    {
        private Item _item = null;
        public SiteConfigurationItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public SiteConfigurationItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public SiteConfigurationItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public SiteConfigurationItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _SiteConfiguration</para>
        /// <para>Field: ShowInMenu</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinmenu")]
        public virtual IBooleanFieldWrapper ShowInMenu
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInMenu", "showinmenu"); }
        }

        /// <summary>
        /// <para>Template: _SiteConfiguration</para>
        /// <para>Field: ShowInMenu</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinmenu")]
        public bool ShowInMenuValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInMenu.Value; }
        }
        /// <summary>
        /// <para>Template: _SiteConfiguration</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: _SiteConfiguration</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Multisite/_SiteConfiguration</para>
    /// <summary>
    public static class SiteConfigurationConstants
    {
        public static readonly ID TemplateID = new ID("{0FCCFE4F-B087-498F-BD26-5CDFFC522C9A}");
        public const string TemplateName = "_SiteConfiguration";

        public struct Fields
        {
            public struct ShowInMenu
            {
                public static readonly ID ID = new ID("{12537182-F35C-403F-AFB5-747D55C450B8}");
                public const string FieldName = "ShowInMenu";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{F07811D3-41E9-440A-9D81-310C1D78BED6}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region _Link (/sitecore/templates/Feature/Navigation/_Link)
namespace Feature.Navigation
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _Link</para>
    /// <para>ID: {a16b74e9-01b8-439c-b44e-42b3fb2ee14b}</para>
    /// <para>Path: /sitecore/templates/Feature/Navigation/_Link</para>
    /// </summary>
    [TemplateMapping("{A16B74E9-01B8-439C-B44E-42B3FB2EE14B}", "InterfaceMap")]
    public partial interface ILink : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _Link</para>
        /// <para>Field: Link</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("link")]
        ICustomGeneralLinkFieldWrapper Link { get; }

        /// <summary>
        /// <para>Template: _Link</para>
        /// <para>Field: Link</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("link")]
        string LinkValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Navigation/_Link</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{A16B74E9-01B8-439C-B44E-42B3FB2EE14B}", typeof(Guid))]
    [TemplateMapping("{A16B74E9-01B8-439C-B44E-42B3FB2EE14B}", "")]
    internal partial class LinkItem : CustomItemWrapper, ILink
    {
        private Item _item = null;
        public LinkItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public LinkItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public LinkItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public LinkItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _Link</para>
        /// <para>Field: Link</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("link")]
        public virtual ICustomGeneralLinkFieldWrapper Link
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("Link", "link"); }
        }

        /// <summary>
        /// <para>Template: _Link</para>
        /// <para>Field: Link</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("link")]
        public string LinkValue
        {
            [DebuggerStepThrough]
            get { return this.Link.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Navigation/_Link</para>
    /// <summary>
    public static class LinkConstants
    {
        public static readonly ID TemplateID = new ID("{A16B74E9-01B8-439C-B44E-42B3FB2EE14B}");
        public const string TemplateName = "_Link";

        public struct Fields
        {
            public struct Link
            {
                public static readonly ID ID = new ID("{FE71C30E-F07D-4052-8594-C3028CD76E1F}");
                public const string FieldName = "Link";
            }
        }
    }
    
}
#endregion

#region _LinkMenuItem (/sitecore/templates/Feature/Navigation/_LinkMenuItem)
namespace Feature.Navigation
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _LinkMenuItem</para>
    /// <para>ID: {18baf6b0-e0d6-4cce-9184-a4849343e7e4}</para>
    /// <para>Path: /sitecore/templates/Feature/Navigation/_LinkMenuItem</para>
    /// </summary>
    [TemplateMapping("{18BAF6B0-E0D6-4CCE-9184-A4849343E7E4}", "InterfaceMap")]
    public partial interface ILinkMenuItem : ICustomItemWrapper, Feature.Navigation.ILink
    {
        /// <summary>
        /// <para>Template: _LinkMenuItem</para>
        /// <para>Field: DividerBefore</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("dividerbefore")]
        IBooleanFieldWrapper DividerBefore { get; }

        /// <summary>
        /// <para>Template: _LinkMenuItem</para>
        /// <para>Field: DividerBefore</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("dividerbefore")]
        bool DividerBeforeValue { get; }

        /// <summary>
        /// <para>Template: _LinkMenuItem</para>
        /// <para>Field: Icon</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("icon")]
        ITextFieldWrapper Icon { get; }

        /// <summary>
        /// <para>Template: _LinkMenuItem</para>
        /// <para>Field: Icon</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("icon")]
        string IconValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Navigation/_LinkMenuItem</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{18BAF6B0-E0D6-4CCE-9184-A4849343E7E4}", typeof(Guid))]
    [TemplateMapping("{18BAF6B0-E0D6-4CCE-9184-A4849343E7E4}", "")]
    internal partial class LinkMenuItemItem : CustomItemWrapper, ILinkMenuItem
    {
        private Item _item = null;
        public LinkMenuItemItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public LinkMenuItemItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public LinkMenuItemItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public LinkMenuItemItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _LinkMenuItem</para>
        /// <para>Field: DividerBefore</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("dividerbefore")]
        public virtual IBooleanFieldWrapper DividerBefore
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("DividerBefore", "dividerbefore"); }
        }

        /// <summary>
        /// <para>Template: _LinkMenuItem</para>
        /// <para>Field: DividerBefore</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("dividerbefore")]
        public bool DividerBeforeValue
        {
            [DebuggerStepThrough]
            get { return this.DividerBefore.Value; }
        }
        /// <summary>
        /// <para>Template: _LinkMenuItem</para>
        /// <para>Field: Icon</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("icon")]
        public virtual ITextFieldWrapper Icon
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Icon", "icon"); }
        }

        /// <summary>
        /// <para>Template: _LinkMenuItem</para>
        /// <para>Field: Icon</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("icon")]
        public string IconValue
        {
            [DebuggerStepThrough]
            get { return this.Icon.Value; }
        }
        /// <summary>
        /// <para>Template: _LinkMenuItem</para>
        /// <para>Field: Link</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("link")]
        public virtual ICustomGeneralLinkFieldWrapper Link
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("Link", "link"); }
        }

        /// <summary>
        /// <para>Template: _LinkMenuItem</para>
        /// <para>Field: Link</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("link")]
        public string LinkValue
        {
            [DebuggerStepThrough]
            get { return this.Link.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Navigation/_LinkMenuItem</para>
    /// <summary>
    public static class LinkMenuItemConstants
    {
        public static readonly ID TemplateID = new ID("{18BAF6B0-E0D6-4CCE-9184-A4849343E7E4}");
        public const string TemplateName = "_LinkMenuItem";

        public struct Fields
        {
            public struct DividerBefore
            {
                public static readonly ID ID = new ID("{4231CD60-47C1-42AD-B838-0A6F8F1C4CFB}");
                public const string FieldName = "DividerBefore";
            }
            public struct Icon
            {
                public static readonly ID ID = new ID("{2C24649E-4460-4114-B026-886CFBE1A96D}");
                public const string FieldName = "Icon";
            }
            public struct Link
            {
                public static readonly ID ID = new ID("{FE71C30E-F07D-4052-8594-C3028CD76E1F}");
                public const string FieldName = "Link";
            }
        }
    }
    
}
#endregion

#region _Navigable (/sitecore/templates/Feature/Navigation/_Navigable)
namespace Feature.Navigation
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _Navigable</para>
    /// <para>ID: {a1cba309-d22b-46d5-80f8-2972c185363f}</para>
    /// <para>Path: /sitecore/templates/Feature/Navigation/_Navigable</para>
    /// </summary>
    [TemplateMapping("{A1CBA309-D22B-46D5-80F8-2972C185363F}", "InterfaceMap")]
    public partial interface INavigable : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _Navigable</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        ITextFieldWrapper NavigationTitle { get; }

        /// <summary>
        /// <para>Template: _Navigable</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        string NavigationTitleValue { get; }

        /// <summary>
        /// <para>Template: _Navigable</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        IBooleanFieldWrapper ShowChildren { get; }

        /// <summary>
        /// <para>Template: _Navigable</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        bool ShowChildrenValue { get; }

        /// <summary>
        /// <para>Template: _Navigable</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        IBooleanFieldWrapper ShowInNavigation { get; }

        /// <summary>
        /// <para>Template: _Navigable</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        bool ShowInNavigationValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Navigation/_Navigable</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{A1CBA309-D22B-46D5-80F8-2972C185363F}", typeof(Guid))]
    [TemplateMapping("{A1CBA309-D22B-46D5-80F8-2972C185363F}", "")]
    internal partial class NavigableItem : CustomItemWrapper, INavigable
    {
        private Item _item = null;
        public NavigableItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public NavigableItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public NavigableItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public NavigableItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _Navigable</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: _Navigable</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: _Navigable</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: _Navigable</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: _Navigable</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: _Navigable</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Navigation/_Navigable</para>
    /// <summary>
    public static class NavigableConstants
    {
        public static readonly ID TemplateID = new ID("{A1CBA309-D22B-46D5-80F8-2972C185363F}");
        public const string TemplateName = "_Navigable";

        public struct Fields
        {
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
        }
    }
    
}
#endregion

#region _NavigationRoot (/sitecore/templates/Feature/Navigation/_NavigationRoot)
namespace Feature.Navigation
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _NavigationRoot</para>
    /// <para>ID: {f9f4fc05-98d0-4c62-860f-f08ae7f0ee25}</para>
    /// <para>Path: /sitecore/templates/Feature/Navigation/_NavigationRoot</para>
    /// </summary>
    [TemplateMapping("{F9F4FC05-98D0-4C62-860F-F08AE7F0EE25}", "InterfaceMap")]
    public partial interface INavigationRoot : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Navigation/_NavigationRoot</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{F9F4FC05-98D0-4C62-860F-F08AE7F0EE25}", typeof(Guid))]
    [TemplateMapping("{F9F4FC05-98D0-4C62-860F-F08AE7F0EE25}", "")]
    internal partial class NavigationRootItem : CustomItemWrapper, INavigationRoot
    {
        private Item _item = null;
        public NavigationRootItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public NavigationRootItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public NavigationRootItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public NavigationRootItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Navigation/_NavigationRoot</para>
    /// <summary>
    public static class NavigationRootConstants
    {
        public static readonly ID TemplateID = new ID("{F9F4FC05-98D0-4C62-860F-F08AE7F0EE25}");
        public const string TemplateName = "_NavigationRoot";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region _NewsArticle (/sitecore/templates/Feature/News/_NewsArticle)
namespace Feature.News
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _NewsArticle</para>
    /// <para>ID: {2f75c8af-35fc-4a88-b585-7595203f442c}</para>
    /// <para>Path: /sitecore/templates/Feature/News/_NewsArticle</para>
    /// </summary>
    [TemplateMapping("{2F75C8AF-35FC-4A88-B585-7595203F442C}", "InterfaceMap")]
    public partial interface INewsArticle : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsBody</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("newsbody")]
        IRichTextFieldWrapper NewsBody { get; }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsBody</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("newsbody")]
        string NewsBodyValue { get; }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsDate</para>
        /// <para>Data type: Datetime</para>
        /// </summary>
        [IndexField("newsdate")]
        IDateTimeFieldWrapper NewsDate { get; }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsDate</para>
        /// <para>Data type: Datetime</para>
        /// </summary>
        [IndexField("newsdate")]
        DateTime NewsDateValue { get; }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        ICustomImageFieldWrapper NewsImage { get; }

        string NewsImageValue { get; }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsSummary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("newssummary")]
        IRichTextFieldWrapper NewsSummary { get; }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsSummary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("newssummary")]
        string NewsSummaryValue { get; }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("newstitle")]
        ITextFieldWrapper NewsTitle { get; }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("newstitle")]
        string NewsTitleValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/News/_NewsArticle</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{2F75C8AF-35FC-4A88-B585-7595203F442C}", typeof(Guid))]
    [TemplateMapping("{2F75C8AF-35FC-4A88-B585-7595203F442C}", "")]
    internal partial class NewsArticleItem : CustomItemWrapper, INewsArticle
    {
        private Item _item = null;
        public NewsArticleItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public NewsArticleItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public NewsArticleItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public NewsArticleItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsBody</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("newsbody")]
        public virtual IRichTextFieldWrapper NewsBody
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("NewsBody", "newsbody"); }
        }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsBody</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("newsbody")]
        public string NewsBodyValue
        {
            [DebuggerStepThrough]
            get { return this.NewsBody.Value; }
        }
        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsDate</para>
        /// <para>Data type: Datetime</para>
        /// </summary>
        [IndexField("newsdate")]
        public virtual IDateTimeFieldWrapper NewsDate
        {
            [DebuggerStepThrough]
            get { return GetField<DateTimeFieldWrapper>("NewsDate", "newsdate"); }
        }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsDate</para>
        /// <para>Data type: Datetime</para>
        /// </summary>
        [IndexField("newsdate")]
        public DateTime NewsDateValue
        {
            [DebuggerStepThrough]
            get { return this.NewsDate.Value; }
        }
        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper NewsImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("NewsImage"); }
        }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string NewsImageValue
        {
            [DebuggerStepThrough]
            get { return this.NewsImage.Value; }
        }
        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsSummary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("newssummary")]
        public virtual IRichTextFieldWrapper NewsSummary
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("NewsSummary", "newssummary"); }
        }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsSummary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("newssummary")]
        public string NewsSummaryValue
        {
            [DebuggerStepThrough]
            get { return this.NewsSummary.Value; }
        }
        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("newstitle")]
        public virtual ITextFieldWrapper NewsTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NewsTitle", "newstitle"); }
        }

        /// <summary>
        /// <para>Template: _NewsArticle</para>
        /// <para>Field: NewsTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("newstitle")]
        public string NewsTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NewsTitle.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/News/_NewsArticle</para>
    /// <summary>
    public static class NewsArticleConstants
    {
        public static readonly ID TemplateID = new ID("{2F75C8AF-35FC-4A88-B585-7595203F442C}");
        public const string TemplateName = "_NewsArticle";

        public struct Fields
        {
            public struct NewsBody
            {
                public static readonly ID ID = new ID("{801612C7-5E98-4E3C-80D2-A34D0EEBCBDA}");
                public const string FieldName = "NewsBody";
            }
            public struct NewsDate
            {
                public static readonly ID ID = new ID("{C464D2D7-3382-428A-BCDF-0963C60BA0E3}");
                public const string FieldName = "NewsDate";
            }
            public struct NewsImage
            {
                public static readonly ID ID = new ID("{3437EAAC-6EE8-460B-A33D-DA1F714B5A93}");
                public const string FieldName = "NewsImage";
            }
            public struct NewsSummary
            {
                public static readonly ID ID = new ID("{9D08271A-1672-44DD-B7EF-0A6EC34FCBA7}");
                public const string FieldName = "NewsSummary";
            }
            public struct NewsTitle
            {
                public static readonly ID ID = new ID("{BD9ECD4A-C0B0-4233-A3CD-D995519AC87B}");
                public const string FieldName = "NewsTitle";
            }
        }
    }
    
}
#endregion

#region _NewsFolder (/sitecore/templates/Feature/News/_NewsFolder)
namespace Feature.News
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _NewsFolder</para>
    /// <para>ID: {74889b26-061c-4d6a-8cdb-422665fc34ec}</para>
    /// <para>Path: /sitecore/templates/Feature/News/_NewsFolder</para>
    /// </summary>
    [TemplateMapping("{74889B26-061C-4D6A-8CDB-422665FC34EC}", "InterfaceMap")]
    public partial interface INewsFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/News/_NewsFolder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{74889B26-061C-4D6A-8CDB-422665FC34EC}", typeof(Guid))]
    [TemplateMapping("{74889B26-061C-4D6A-8CDB-422665FC34EC}", "")]
    internal partial class NewsFolderItem : CustomItemWrapper, INewsFolder
    {
        private Item _item = null;
        public NewsFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public NewsFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public NewsFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public NewsFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/News/_NewsFolder</para>
    /// <summary>
    public static class NewsFolderConstants
    {
        public static readonly ID TemplateID = new ID("{74889B26-061C-4D6A-8CDB-422665FC34EC}");
        public const string TemplateName = "_NewsFolder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region _HasPageContent (/sitecore/templates/Feature/PageContent/_HasPageContent)
namespace Feature.PageContent
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _HasPageContent</para>
    /// <para>ID: {af74a00b-8ca7-4c9a-a5c1-156a68590ee2}</para>
    /// <para>Path: /sitecore/templates/Feature/PageContent/_HasPageContent</para>
    /// </summary>
    [TemplateMapping("{AF74A00B-8CA7-4C9A-A5C1-156A68590EE2}", "InterfaceMap")]
    public partial interface IHasPageContent : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        IRichTextFieldWrapper Body { get; }

        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        string BodyValue { get; }

        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        ICustomImageFieldWrapper Image { get; }

        string ImageValue { get; }

        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        IRichTextFieldWrapper Summary { get; }

        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        string SummaryValue { get; }

        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        ITextFieldWrapper Title { get; }

        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        string TitleValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/PageContent/_HasPageContent</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{AF74A00B-8CA7-4C9A-A5C1-156A68590EE2}", typeof(Guid))]
    [TemplateMapping("{AF74A00B-8CA7-4C9A-A5C1-156A68590EE2}", "")]
    internal partial class HasPageContentItem : CustomItemWrapper, IHasPageContent
    {
        private Item _item = null;
        public HasPageContentItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public HasPageContentItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public HasPageContentItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public HasPageContentItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public virtual IRichTextFieldWrapper Body
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Body", "body"); }
        }

        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public string BodyValue
        {
            [DebuggerStepThrough]
            get { return this.Body.Value; }
        }
        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Image
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Image"); }
        }

        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string ImageValue
        {
            [DebuggerStepThrough]
            get { return this.Image.Value; }
        }
        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual IRichTextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: _HasPageContent</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/PageContent/_HasPageContent</para>
    /// <summary>
    public static class HasPageContentConstants
    {
        public static readonly ID TemplateID = new ID("{AF74A00B-8CA7-4C9A-A5C1-156A68590EE2}");
        public const string TemplateName = "_HasPageContent";

        public struct Fields
        {
            public struct Body
            {
                public static readonly ID ID = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
                public const string FieldName = "Body";
            }
            public struct Image
            {
                public static readonly ID ID = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
                public const string FieldName = "Image";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region _Employee (/sitecore/templates/Feature/Person/_Employee)
namespace Feature.Person
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _Employee</para>
    /// <para>ID: {745652ae-3298-48b1-9be1-99012d91f3ac}</para>
    /// <para>Path: /sitecore/templates/Feature/Person/_Employee</para>
    /// </summary>
    [TemplateMapping("{745652AE-3298-48B1-9BE1-99012D91F3AC}", "InterfaceMap")]
    public partial interface IEmployee : ICustomItemWrapper, Feature.Person.IPerson
    {
        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Biography</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("biography")]
        IRichTextFieldWrapper Biography { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Biography</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("biography")]
        string BiographyValue { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: BlogLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("bloglink")]
        ICustomGeneralLinkFieldWrapper BlogLink { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: BlogLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("bloglink")]
        string BlogLinkValue { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Email</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("email")]
        ITextFieldWrapper Email { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Email</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("email")]
        string EmailValue { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: FacebookLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("facebooklink")]
        ICustomGeneralLinkFieldWrapper FacebookLink { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: FacebookLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("facebooklink")]
        string FacebookLinkValue { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: LinkedInLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("linkedinlink")]
        ICustomGeneralLinkFieldWrapper LinkedInLink { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: LinkedInLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("linkedinlink")]
        string LinkedInLinkValue { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Mobile</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mobile")]
        ITextFieldWrapper Mobile { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Mobile</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mobile")]
        string MobileValue { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Telephone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("telephone")]
        ITextFieldWrapper Telephone { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Telephone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("telephone")]
        string TelephoneValue { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: TwitterLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterlink")]
        ICustomGeneralLinkFieldWrapper TwitterLink { get; }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: TwitterLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterlink")]
        string TwitterLinkValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Person/_Employee</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{745652AE-3298-48B1-9BE1-99012D91F3AC}", typeof(Guid))]
    [TemplateMapping("{745652AE-3298-48B1-9BE1-99012D91F3AC}", "")]
    internal partial class EmployeeItem : CustomItemWrapper, IEmployee
    {
        private Item _item = null;
        public EmployeeItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public EmployeeItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public EmployeeItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public EmployeeItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Biography</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("biography")]
        public virtual IRichTextFieldWrapper Biography
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Biography", "biography"); }
        }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Biography</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("biography")]
        public string BiographyValue
        {
            [DebuggerStepThrough]
            get { return this.Biography.Value; }
        }
        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: BlogLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("bloglink")]
        public virtual ICustomGeneralLinkFieldWrapper BlogLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("BlogLink", "bloglink"); }
        }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: BlogLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("bloglink")]
        public string BlogLinkValue
        {
            [DebuggerStepThrough]
            get { return this.BlogLink.Value; }
        }
        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Email</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("email")]
        public virtual ITextFieldWrapper Email
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Email", "email"); }
        }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Email</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("email")]
        public string EmailValue
        {
            [DebuggerStepThrough]
            get { return this.Email.Value; }
        }
        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: FacebookLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("facebooklink")]
        public virtual ICustomGeneralLinkFieldWrapper FacebookLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("FacebookLink", "facebooklink"); }
        }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: FacebookLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("facebooklink")]
        public string FacebookLinkValue
        {
            [DebuggerStepThrough]
            get { return this.FacebookLink.Value; }
        }
        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: LinkedInLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("linkedinlink")]
        public virtual ICustomGeneralLinkFieldWrapper LinkedInLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("LinkedInLink", "linkedinlink"); }
        }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: LinkedInLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("linkedinlink")]
        public string LinkedInLinkValue
        {
            [DebuggerStepThrough]
            get { return this.LinkedInLink.Value; }
        }
        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Mobile</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mobile")]
        public virtual ITextFieldWrapper Mobile
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Mobile", "mobile"); }
        }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Mobile</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mobile")]
        public string MobileValue
        {
            [DebuggerStepThrough]
            get { return this.Mobile.Value; }
        }
        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public virtual ITextFieldWrapper Name
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Name", "name"); }
        }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public string NameValue
        {
            [DebuggerStepThrough]
            get { return this.Name.Value; }
        }
        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Picture</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Picture
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Picture"); }
        }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Picture</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string PictureValue
        {
            [DebuggerStepThrough]
            get { return this.Picture.Value; }
        }
        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual ITextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Telephone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("telephone")]
        public virtual ITextFieldWrapper Telephone
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Telephone", "telephone"); }
        }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Telephone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("telephone")]
        public string TelephoneValue
        {
            [DebuggerStepThrough]
            get { return this.Telephone.Value; }
        }
        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: TwitterLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterlink")]
        public virtual ICustomGeneralLinkFieldWrapper TwitterLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("TwitterLink", "twitterlink"); }
        }

        /// <summary>
        /// <para>Template: _Employee</para>
        /// <para>Field: TwitterLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterlink")]
        public string TwitterLinkValue
        {
            [DebuggerStepThrough]
            get { return this.TwitterLink.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Person/_Employee</para>
    /// <summary>
    public static class EmployeeConstants
    {
        public static readonly ID TemplateID = new ID("{745652AE-3298-48B1-9BE1-99012D91F3AC}");
        public const string TemplateName = "_Employee";

        public struct Fields
        {
            public struct Biography
            {
                public static readonly ID ID = new ID("{0CC9785E-54FE-4FAE-93E4-D0D2AE75F339}");
                public const string FieldName = "Biography";
            }
            public struct BlogLink
            {
                public static readonly ID ID = new ID("{69A846D9-4C7F-435C-A8DC-87E2D7359CFA}");
                public const string FieldName = "BlogLink";
            }
            public struct Email
            {
                public static readonly ID ID = new ID("{5978B330-1D46-4065-8751-F74BF17D815E}");
                public const string FieldName = "Email";
            }
            public struct FacebookLink
            {
                public static readonly ID ID = new ID("{D31889C0-E34C-4904-A6F3-F3D92D314AA9}");
                public const string FieldName = "FacebookLink";
            }
            public struct LinkedInLink
            {
                public static readonly ID ID = new ID("{2B13DFAB-3450-45EF-93F4-BEAA6F544FA6}");
                public const string FieldName = "LinkedInLink";
            }
            public struct Mobile
            {
                public static readonly ID ID = new ID("{25B4CEE3-A61A-4DC3-BB52-775DD509DBB5}");
                public const string FieldName = "Mobile";
            }
            public struct Name
            {
                public static readonly ID ID = new ID("{26CD59AB-3639-488F-BAFD-58D2B217755A}");
                public const string FieldName = "Name";
            }
            public struct Picture
            {
                public static readonly ID ID = new ID("{C9BAF3EB-8CFA-4BF6-9B19-51D38DB5FC38}");
                public const string FieldName = "Picture";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{B897023C-15D2-49F3-8974-06FA5FB7AD00}");
                public const string FieldName = "Summary";
            }
            public struct Telephone
            {
                public static readonly ID ID = new ID("{8D0E8EE3-21C4-4AE2-A2F1-53D3F3EBE501}");
                public const string FieldName = "Telephone";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{76972FCD-4BB0-4255-864E-077745EFDF50}");
                public const string FieldName = "Title";
            }
            public struct TwitterLink
            {
                public static readonly ID ID = new ID("{6DE98EF7-1209-40A3-A63E-16DBEF015211}");
                public const string FieldName = "TwitterLink";
            }
        }
    }
    
}
#endregion

#region _Person (/sitecore/templates/Feature/Person/_Person)
namespace Feature.Person
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _Person</para>
    /// <para>ID: {7aca6ecf-1a80-4e35-97f5-dbaa8e3ec617}</para>
    /// <para>Path: /sitecore/templates/Feature/Person/_Person</para>
    /// </summary>
    [TemplateMapping("{7ACA6ECF-1A80-4E35-97F5-DBAA8E3EC617}", "InterfaceMap")]
    public partial interface IPerson : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        ITextFieldWrapper Name { get; }

        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        string NameValue { get; }

        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Picture</para>
        /// <para>Data type: Image</para>
        /// </summary>
        ICustomImageFieldWrapper Picture { get; }

        string PictureValue { get; }

        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        ITextFieldWrapper Summary { get; }

        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        string SummaryValue { get; }

        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        ITextFieldWrapper Title { get; }

        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        string TitleValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Person/_Person</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{7ACA6ECF-1A80-4E35-97F5-DBAA8E3EC617}", typeof(Guid))]
    [TemplateMapping("{7ACA6ECF-1A80-4E35-97F5-DBAA8E3EC617}", "")]
    internal partial class PersonItem : CustomItemWrapper, IPerson
    {
        private Item _item = null;
        public PersonItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public PersonItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public PersonItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public PersonItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public virtual ITextFieldWrapper Name
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Name", "name"); }
        }

        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public string NameValue
        {
            [DebuggerStepThrough]
            get { return this.Name.Value; }
        }
        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Picture</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Picture
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Picture"); }
        }

        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Picture</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string PictureValue
        {
            [DebuggerStepThrough]
            get { return this.Picture.Value; }
        }
        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual ITextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: _Person</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Person/_Person</para>
    /// <summary>
    public static class PersonConstants
    {
        public static readonly ID TemplateID = new ID("{7ACA6ECF-1A80-4E35-97F5-DBAA8E3EC617}");
        public const string TemplateName = "_Person";

        public struct Fields
        {
            public struct Name
            {
                public static readonly ID ID = new ID("{26CD59AB-3639-488F-BAFD-58D2B217755A}");
                public const string FieldName = "Name";
            }
            public struct Picture
            {
                public static readonly ID ID = new ID("{C9BAF3EB-8CFA-4BF6-9B19-51D38DB5FC38}");
                public const string FieldName = "Picture";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{B897023C-15D2-49F3-8974-06FA5FB7AD00}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{76972FCD-4BB0-4255-864E-077745EFDF50}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region _Quote (/sitecore/templates/Feature/Person/_Quote)
namespace Feature.Person
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _Quote</para>
    /// <para>ID: {755f1188-d385-4717-8681-ef45f2258575}</para>
    /// <para>Path: /sitecore/templates/Feature/Person/_Quote</para>
    /// </summary>
    [TemplateMapping("{755F1188-D385-4717-8681-EF45F2258575}", "InterfaceMap")]
    public partial interface IQuote : ICustomItemWrapper, Feature.Person.IPerson
    {
        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: CiteOrigin</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("cite_origin")]
        ITextFieldWrapper CiteOrigin { get; }

        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: CiteOrigin</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("cite_origin")]
        string CiteOriginValue { get; }

        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: Quote</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("quote")]
        ITextFieldWrapper Quote { get; }

        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: Quote</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("quote")]
        string QuoteValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Person/_Quote</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{755F1188-D385-4717-8681-EF45F2258575}", typeof(Guid))]
    [TemplateMapping("{755F1188-D385-4717-8681-EF45F2258575}", "")]
    internal partial class QuoteItem : CustomItemWrapper, IQuote
    {
        private Item _item = null;
        public QuoteItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public QuoteItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public QuoteItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public QuoteItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: CiteOrigin</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("cite_origin")]
        public virtual ITextFieldWrapper CiteOrigin
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Cite Origin", "cite_origin"); }
        }

        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: CiteOrigin</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("cite_origin")]
        public string CiteOriginValue
        {
            [DebuggerStepThrough]
            get { return this.CiteOrigin.Value; }
        }
        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public virtual ITextFieldWrapper Name
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Name", "name"); }
        }

        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public string NameValue
        {
            [DebuggerStepThrough]
            get { return this.Name.Value; }
        }
        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: Picture</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Picture
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Picture"); }
        }

        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: Picture</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string PictureValue
        {
            [DebuggerStepThrough]
            get { return this.Picture.Value; }
        }
        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: Quote</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("quote")]
        public virtual ITextFieldWrapper Quote
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Quote", "quote"); }
        }

        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: Quote</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("quote")]
        public string QuoteValue
        {
            [DebuggerStepThrough]
            get { return this.Quote.Value; }
        }
        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual ITextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: _Quote</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Person/_Quote</para>
    /// <summary>
    public static class QuoteConstants
    {
        public static readonly ID TemplateID = new ID("{755F1188-D385-4717-8681-EF45F2258575}");
        public const string TemplateName = "_Quote";

        public struct Fields
        {
            public struct CiteOrigin
            {
                public static readonly ID ID = new ID("{BF83983A-473F-4A49-BE8E-7D563AA5687E}");
                public const string FieldName = "Cite Origin";
            }
            public struct Name
            {
                public static readonly ID ID = new ID("{26CD59AB-3639-488F-BAFD-58D2B217755A}");
                public const string FieldName = "Name";
            }
            public struct Picture
            {
                public static readonly ID ID = new ID("{C9BAF3EB-8CFA-4BF6-9B19-51D38DB5FC38}");
                public const string FieldName = "Picture";
            }
            public struct Quote
            {
                public static readonly ID ID = new ID("{0DE53078-0DA4-40CC-BBCA-63AA96A0A1EF}");
                public const string FieldName = "Quote";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{B897023C-15D2-49F3-8974-06FA5FB7AD00}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{76972FCD-4BB0-4255-864E-077745EFDF50}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region _PagedSearchResultsParameters (/sitecore/templates/Feature/Search/_PagedSearchResultsParameters)
namespace Feature.Search
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    using Fortis.Model.RenderingParameters;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _PagedSearchResultsParameters</para>
    /// <para>ID: {d1d3e60f-e571-48d2-84cf-b053ee660c13}</para>
    /// <para>Path: /sitecore/templates/Feature/Search/_PagedSearchResultsParameters</para>
    /// </summary>
    [TemplateMapping("{D1D3E60F-E571-48D2-84CF-B053EE660C13}", "InterfaceRenderingParameter")]
    public partial interface IPagedSearchResultsParameters : IRenderingParameterWrapper
    {
        /// <summary>
        /// <para>Template: _PagedSearchResultsParameters</para>
        /// <para>Field: PagesToShow</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        ITextFieldWrapper PagesToShow { get; }

        string PagesToShowValue { get; }

        /// <summary>
        /// <para>Template: _PagedSearchResultsParameters</para>
        /// <para>Field: ResultsOnPage</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        ITextFieldWrapper ResultsOnPage { get; }

        string ResultsOnPageValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Search/_PagedSearchResultsParameters</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{D1D3E60F-E571-48D2-84CF-B053EE660C13}", typeof(Guid))]
    [TemplateMapping("{D1D3E60F-E571-48D2-84CF-B053EE660C13}", "RenderingParameter")]
    internal partial class PagedSearchResultsParametersItem : CustomRenderingParameterWrapper, IPagedSearchResultsParameters
    {
        public PagedSearchResultsParametersItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }

        /// <summary>
        /// <para>Template: _PagedSearchResultsParameters</para>
        /// <para>Field: PagesToShow</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        public virtual ITextFieldWrapper PagesToShow
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.TextFieldWrapper)GetField("PagesToShow", "single-line text"); }
        }

        /// <summary>
        /// <para>Template: _PagedSearchResultsParameters</para>
        /// <para>Field: PagesToShow</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        public string PagesToShowValue
        {
            [DebuggerStepThrough]
            get { return this.PagesToShow.Value; }
        }
        /// <summary>
        /// <para>Template: _PagedSearchResultsParameters</para>
        /// <para>Field: ResultsOnPage</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        public virtual ITextFieldWrapper ResultsOnPage
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.TextFieldWrapper)GetField("ResultsOnPage", "single-line text"); }
        }

        /// <summary>
        /// <para>Template: _PagedSearchResultsParameters</para>
        /// <para>Field: ResultsOnPage</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        public string ResultsOnPageValue
        {
            [DebuggerStepThrough]
            get { return this.ResultsOnPage.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Search/_PagedSearchResultsParameters</para>
    /// <summary>
    public static class PagedSearchResultsParametersConstants
    {
        public static readonly ID TemplateID = new ID("{D1D3E60F-E571-48D2-84CF-B053EE660C13}");
        public const string TemplateName = "_PagedSearchResultsParameters";

        public struct Fields
        {
            public struct PagesToShow
            {
                public static readonly ID ID = new ID("{D7DDE02F-B1F1-416D-91E0-7C3612EF4871}");
                public const string FieldName = "PagesToShow";
            }
            public struct ResultsOnPage
            {
                public static readonly ID ID = new ID("{FCC7E3B4-46AB-4A51-975F-A6B259B3D214}");
                public const string FieldName = "ResultsOnPage";
            }
        }
    }
    
}
#endregion

#region _SearchContext (/sitecore/templates/Feature/Search/_SearchContext)
namespace Feature.Search
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _SearchContext</para>
    /// <para>ID: {b524e8be-a099-4a63-be3f-dd4c42fd4185}</para>
    /// <para>Path: /sitecore/templates/Feature/Search/_SearchContext</para>
    /// </summary>
    [TemplateMapping("{B524E8BE-A099-4A63-BE3F-DD4C42FD4185}", "InterfaceMap")]
    public partial interface ISearchContext : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _SearchContext</para>
        /// <para>Field: SearchResultsPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        ITextFieldWrapper SearchResultsPage { get; }

        string SearchResultsPageValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Search/_SearchContext</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{B524E8BE-A099-4A63-BE3F-DD4C42FD4185}", typeof(Guid))]
    [TemplateMapping("{B524E8BE-A099-4A63-BE3F-DD4C42FD4185}", "")]
    internal partial class SearchContextItem : CustomItemWrapper, ISearchContext
    {
        private Item _item = null;
        public SearchContextItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public SearchContextItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public SearchContextItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public SearchContextItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _SearchContext</para>
        /// <para>Field: SearchResultsPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper SearchResultsPage
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Search Results Page"); }
        }

        /// <summary>
        /// <para>Template: _SearchContext</para>
        /// <para>Field: SearchResultsPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string SearchResultsPageValue
        {
            [DebuggerStepThrough]
            get { return this.SearchResultsPage.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Search/_SearchContext</para>
    /// <summary>
    public static class SearchContextConstants
    {
        public static readonly ID TemplateID = new ID("{B524E8BE-A099-4A63-BE3F-DD4C42FD4185}");
        public const string TemplateName = "_SearchContext";

        public struct Fields
        {
            public struct SearchResultsPage
            {
                public static readonly ID ID = new ID("{1C843E6A-02B9-4AA0-9FED-FDFDDC419AE3}");
                public const string FieldName = "Search Results Page";
            }
        }
    }
    
}
#endregion

#region _SearchResults (/sitecore/templates/Feature/Search/_SearchResults)
namespace Feature.Search
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _SearchResults</para>
    /// <para>ID: {14e452ca-064d-48a8-9ff2-2744d10437a1}</para>
    /// <para>Path: /sitecore/templates/Feature/Search/_SearchResults</para>
    /// </summary>
    [TemplateMapping("{14E452CA-064D-48A8-9FF2-2744D10437A1}", "InterfaceMap")]
    public partial interface ISearchResults : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _SearchResults</para>
        /// <para>Field: Root</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("root")]
        ILinkFieldWrapper Root { get; }

        /// <summary>
        /// <para>Template: _SearchResults</para>
        /// <para>Field: Root</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("root")]
        Guid RootValue { get; }

        /// <summary>
        /// <para>Template: _SearchResults</para>
        /// <para>Field: SearchBoxTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("searchboxtitle")]
        ITextFieldWrapper SearchBoxTitle { get; }

        /// <summary>
        /// <para>Template: _SearchResults</para>
        /// <para>Field: SearchBoxTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("searchboxtitle")]
        string SearchBoxTitleValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Search/_SearchResults</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{14E452CA-064D-48A8-9FF2-2744D10437A1}", typeof(Guid))]
    [TemplateMapping("{14E452CA-064D-48A8-9FF2-2744D10437A1}", "")]
    internal partial class SearchResultsItem : CustomItemWrapper, ISearchResults
    {
        private Item _item = null;
        public SearchResultsItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public SearchResultsItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public SearchResultsItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public SearchResultsItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _SearchResults</para>
        /// <para>Field: Root</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("root")]
        public virtual ILinkFieldWrapper Root
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Root", "root"); }
        }

        /// <summary>
        /// <para>Template: _SearchResults</para>
        /// <para>Field: Root</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("root")]
        public Guid RootValue
        {
            [DebuggerStepThrough]
            get { return this.Root.Value; }
        }
        /// <summary>
        /// <para>Template: _SearchResults</para>
        /// <para>Field: SearchBoxTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("searchboxtitle")]
        public virtual ITextFieldWrapper SearchBoxTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("SearchBoxTitle", "searchboxtitle"); }
        }

        /// <summary>
        /// <para>Template: _SearchResults</para>
        /// <para>Field: SearchBoxTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("searchboxtitle")]
        public string SearchBoxTitleValue
        {
            [DebuggerStepThrough]
            get { return this.SearchBoxTitle.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Search/_SearchResults</para>
    /// <summary>
    public static class SearchResultsConstants
    {
        public static readonly ID TemplateID = new ID("{14E452CA-064D-48A8-9FF2-2744D10437A1}");
        public const string TemplateName = "_SearchResults";

        public struct Fields
        {
            public struct Root
            {
                public static readonly ID ID = new ID("{CD904125-3AE5-4709-9E6D-71473C5D5007}");
                public const string FieldName = "Root";
            }
            public struct SearchBoxTitle
            {
                public static readonly ID ID = new ID("{80E30DD8-8021-45F5-9FE1-23D2702CC206}");
                public const string FieldName = "SearchBoxTitle";
            }
        }
    }
    
}
#endregion

#region _OpenGraph (/sitecore/templates/Feature/Social/_OpenGraph)
namespace Feature.Social
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _OpenGraph</para>
    /// <para>ID: {bdd24f35-05e8-4466-8798-7d3dd6a6c991}</para>
    /// <para>Path: /sitecore/templates/Feature/Social/_OpenGraph</para>
    /// </summary>
    [TemplateMapping("{BDD24F35-05E8-4466-8798-7D3DD6A6C991}", "InterfaceMap")]
    public partial interface IOpenGraph : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _OpenGraph</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        ITextFieldWrapper OpenGraphDescription { get; }

        /// <summary>
        /// <para>Template: _OpenGraph</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        string OpenGraphDescriptionValue { get; }

        /// <summary>
        /// <para>Template: _OpenGraph</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        ICustomImageFieldWrapper OpenGraphImage { get; }

        string OpenGraphImageValue { get; }

        /// <summary>
        /// <para>Template: _OpenGraph</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        ITextFieldWrapper OpenGraphTitle { get; }

        /// <summary>
        /// <para>Template: _OpenGraph</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        string OpenGraphTitleValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Social/_OpenGraph</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{BDD24F35-05E8-4466-8798-7D3DD6A6C991}", typeof(Guid))]
    [TemplateMapping("{BDD24F35-05E8-4466-8798-7D3DD6A6C991}", "")]
    internal partial class OpenGraphItem : CustomItemWrapper, IOpenGraph
    {
        private Item _item = null;
        public OpenGraphItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public OpenGraphItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public OpenGraphItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public OpenGraphItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _OpenGraph</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: _OpenGraph</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: _OpenGraph</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: _OpenGraph</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: _OpenGraph</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: _OpenGraph</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Social/_OpenGraph</para>
    /// <summary>
    public static class OpenGraphConstants
    {
        public static readonly ID TemplateID = new ID("{BDD24F35-05E8-4466-8798-7D3DD6A6C991}");
        public const string TemplateName = "_OpenGraph";

        public struct Fields
        {
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
        }
    }
    
}
#endregion

#region _TwitterFeed (/sitecore/templates/Feature/Social/_TwitterFeed)
namespace Feature.Social
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _TwitterFeed</para>
    /// <para>ID: {89d988bc-a9a7-43f5-a9fd-a05b0b164720}</para>
    /// <para>Path: /sitecore/templates/Feature/Social/_TwitterFeed</para>
    /// </summary>
    [TemplateMapping("{89D988BC-A9A7-43F5-A9FD-A05B0B164720}", "InterfaceMap")]
    public partial interface ITwitterFeed : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _TwitterFeed</para>
        /// <para>Field: FeedTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("feedtitle")]
        ITextFieldWrapper FeedTitle { get; }

        /// <summary>
        /// <para>Template: _TwitterFeed</para>
        /// <para>Field: FeedTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("feedtitle")]
        string FeedTitleValue { get; }

        /// <summary>
        /// <para>Template: _TwitterFeed</para>
        /// <para>Field: TwitterUrl</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterurl")]
        ICustomGeneralLinkFieldWrapper TwitterUrl { get; }

        /// <summary>
        /// <para>Template: _TwitterFeed</para>
        /// <para>Field: TwitterUrl</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterurl")]
        string TwitterUrlValue { get; }

        /// <summary>
        /// <para>Template: _TwitterFeed</para>
        /// <para>Field: WidgetId</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("widgetid")]
        ITextFieldWrapper WidgetId { get; }

        /// <summary>
        /// <para>Template: _TwitterFeed</para>
        /// <para>Field: WidgetId</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("widgetid")]
        string WidgetIdValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Social/_TwitterFeed</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{89D988BC-A9A7-43F5-A9FD-A05B0B164720}", typeof(Guid))]
    [TemplateMapping("{89D988BC-A9A7-43F5-A9FD-A05B0B164720}", "")]
    internal partial class TwitterFeedItem : CustomItemWrapper, ITwitterFeed
    {
        private Item _item = null;
        public TwitterFeedItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public TwitterFeedItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public TwitterFeedItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public TwitterFeedItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _TwitterFeed</para>
        /// <para>Field: FeedTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("feedtitle")]
        public virtual ITextFieldWrapper FeedTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("FeedTitle", "feedtitle"); }
        }

        /// <summary>
        /// <para>Template: _TwitterFeed</para>
        /// <para>Field: FeedTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("feedtitle")]
        public string FeedTitleValue
        {
            [DebuggerStepThrough]
            get { return this.FeedTitle.Value; }
        }
        /// <summary>
        /// <para>Template: _TwitterFeed</para>
        /// <para>Field: TwitterUrl</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterurl")]
        public virtual ICustomGeneralLinkFieldWrapper TwitterUrl
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("TwitterUrl", "twitterurl"); }
        }

        /// <summary>
        /// <para>Template: _TwitterFeed</para>
        /// <para>Field: TwitterUrl</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterurl")]
        public string TwitterUrlValue
        {
            [DebuggerStepThrough]
            get { return this.TwitterUrl.Value; }
        }
        /// <summary>
        /// <para>Template: _TwitterFeed</para>
        /// <para>Field: WidgetId</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("widgetid")]
        public virtual ITextFieldWrapper WidgetId
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("WidgetId", "widgetid"); }
        }

        /// <summary>
        /// <para>Template: _TwitterFeed</para>
        /// <para>Field: WidgetId</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("widgetid")]
        public string WidgetIdValue
        {
            [DebuggerStepThrough]
            get { return this.WidgetId.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Social/_TwitterFeed</para>
    /// <summary>
    public static class TwitterFeedConstants
    {
        public static readonly ID TemplateID = new ID("{89D988BC-A9A7-43F5-A9FD-A05B0B164720}");
        public const string TemplateName = "_TwitterFeed";

        public struct Fields
        {
            public struct FeedTitle
            {
                public static readonly ID ID = new ID("{099E4085-150C-4073-88D9-8B159D9A8B01}");
                public const string FieldName = "FeedTitle";
            }
            public struct TwitterUrl
            {
                public static readonly ID ID = new ID("{92EF8986-45E2-42DE-913F-B91FD960297A}");
                public const string FieldName = "TwitterUrl";
            }
            public struct WidgetId
            {
                public static readonly ID ID = new ID("{D1CF33B1-8B8A-4AAB-AA7E-2460566BEDED}");
                public const string FieldName = "WidgetId";
            }
        }
    }
    
}
#endregion

#region _TwitterFeedRenderingProperties (/sitecore/templates/Feature/Social/_TwitterFeedRenderingProperties)
namespace Feature.Social
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    using Fortis.Model.RenderingParameters;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _TwitterFeedRenderingProperties</para>
    /// <para>ID: {9eee8077-990f-4fde-95fb-c7b9819df913}</para>
    /// <para>Path: /sitecore/templates/Feature/Social/_TwitterFeedRenderingProperties</para>
    /// </summary>
    [TemplateMapping("{9EEE8077-990F-4FDE-95FB-C7B9819DF913}", "InterfaceRenderingParameter")]
    public partial interface ITwitterFeedRenderingProperties : IRenderingParameterWrapper, Foundation.Theming.IParametersTemplateHasBackground
    {
        /// <summary>
        /// <para>Template: _TwitterFeedRenderingProperties</para>
        /// <para>Field: TweetsToShow</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        ITextFieldWrapper TweetsToShow { get; }

        string TweetsToShowValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Social/_TwitterFeedRenderingProperties</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{9EEE8077-990F-4FDE-95FB-C7B9819DF913}", typeof(Guid))]
    [TemplateMapping("{9EEE8077-990F-4FDE-95FB-C7B9819DF913}", "RenderingParameter")]
    internal partial class TwitterFeedRenderingPropertiesItem : CustomRenderingParameterWrapper, ITwitterFeedRenderingProperties
    {
        public TwitterFeedRenderingPropertiesItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }

        /// <summary>
        /// <para>Template: _TwitterFeedRenderingProperties</para>
        /// <para>Field: Background</para>
        /// <para>Data type: Droplink</para>
        /// </summary>
        public virtual ILinkFieldWrapper Background
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Background", "droplink"); }
        }

        /// <summary>
        /// <para>Template: _TwitterFeedRenderingProperties</para>
        /// <para>Field: Background</para>
        /// <para>Data type: Droplink</para>
        /// </summary>
        public Guid BackgroundValue
        {
            [DebuggerStepThrough]
            get { return this.Background.Value; }
        }
        /// <summary>
        /// <para>Template: _TwitterFeedRenderingProperties</para>
        /// <para>Field: TweetsToShow</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        public virtual ITextFieldWrapper TweetsToShow
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.TextFieldWrapper)GetField("TweetsToShow", "single-line text"); }
        }

        /// <summary>
        /// <para>Template: _TwitterFeedRenderingProperties</para>
        /// <para>Field: TweetsToShow</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        public string TweetsToShowValue
        {
            [DebuggerStepThrough]
            get { return this.TweetsToShow.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Social/_TwitterFeedRenderingProperties</para>
    /// <summary>
    public static class TwitterFeedRenderingPropertiesConstants
    {
        public static readonly ID TemplateID = new ID("{9EEE8077-990F-4FDE-95FB-C7B9819DF913}");
        public const string TemplateName = "_TwitterFeedRenderingProperties";

        public struct Fields
        {
            public struct Background
            {
                public static readonly ID ID = new ID("{32439F83-C2FC-46E8-8981-5D1CDF1B2742}");
                public const string FieldName = "Background";
            }
            public struct TweetsToShow
            {
                public static readonly ID ID = new ID("{084D873D-194D-456B-A1D8-328C048E5582}");
                public const string FieldName = "TweetsToShow";
            }
        }
    }
    
}
#endregion

#region Icon (/sitecore/templates/Feature/Teasers/Icon)
namespace Feature.Teasers
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Icon</para>
    /// <para>ID: {e90d00b6-0be9-48e0-9c3f-047274024270}</para>
    /// <para>Path: /sitecore/templates/Feature/Teasers/Icon</para>
    /// </summary>
    [TemplateMapping("{E90D00B6-0BE9-48E0-9C3F-047274024270}", "InterfaceMap")]
    public partial interface IIcon : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: Icon</para>
        /// <para>Field: CssClass</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("cssclass")]
        ITextFieldWrapper CssClass { get; }

        /// <summary>
        /// <para>Template: Icon</para>
        /// <para>Field: CssClass</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("cssclass")]
        string CssClassValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Teasers/Icon</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{E90D00B6-0BE9-48E0-9C3F-047274024270}", typeof(Guid))]
    [TemplateMapping("{E90D00B6-0BE9-48E0-9C3F-047274024270}", "")]
    internal partial class IconItem : CustomItemWrapper, IIcon
    {
        private Item _item = null;
        public IconItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public IconItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public IconItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public IconItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Icon</para>
        /// <para>Field: CssClass</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("cssclass")]
        public virtual ITextFieldWrapper CssClass
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CssClass", "cssclass"); }
        }

        /// <summary>
        /// <para>Template: Icon</para>
        /// <para>Field: CssClass</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("cssclass")]
        public string CssClassValue
        {
            [DebuggerStepThrough]
            get { return this.CssClass.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Teasers/Icon</para>
    /// <summary>
    public static class IconConstants
    {
        public static readonly ID TemplateID = new ID("{E90D00B6-0BE9-48E0-9C3F-047274024270}");
        public const string TemplateName = "Icon";

        public struct Fields
        {
            public struct CssClass
            {
                public static readonly ID ID = new ID("{585F89D1-570C-4F66-A6EC-195A8DA654E1}");
                public const string FieldName = "CssClass";
            }
        }
    }
    
}
#endregion

#region _DynamicTeaser (/sitecore/templates/Feature/Teasers/_DynamicTeaser)
namespace Feature.Teasers
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _DynamicTeaser</para>
    /// <para>ID: {20a56d46-f5e3-4db8-8b96-081575363d44}</para>
    /// <para>Path: /sitecore/templates/Feature/Teasers/_DynamicTeaser</para>
    /// </summary>
    [TemplateMapping("{20A56D46-F5E3-4DB8-8B96-081575363D44}", "InterfaceMap")]
    public partial interface IDynamicTeaser : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _DynamicTeaser</para>
        /// <para>Field: Active</para>
        /// <para>Data type: Integer</para>
        /// </summary>
        [IndexField("active")]
        IIntegerFieldWrapper Active { get; }

        /// <summary>
        /// <para>Template: _DynamicTeaser</para>
        /// <para>Field: Active</para>
        /// <para>Data type: Integer</para>
        /// </summary>
        [IndexField("active")]
        long ActiveValue { get; }

        /// <summary>
        /// <para>Template: _DynamicTeaser</para>
        /// <para>Field: Count</para>
        /// <para>Data type: Integer</para>
        /// </summary>
        [IndexField("count")]
        IIntegerFieldWrapper Count { get; }

        /// <summary>
        /// <para>Template: _DynamicTeaser</para>
        /// <para>Field: Count</para>
        /// <para>Data type: Integer</para>
        /// </summary>
        [IndexField("count")]
        long CountValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Teasers/_DynamicTeaser</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{20A56D46-F5E3-4DB8-8B96-081575363D44}", typeof(Guid))]
    [TemplateMapping("{20A56D46-F5E3-4DB8-8B96-081575363D44}", "")]
    internal partial class DynamicTeaserItem : CustomItemWrapper, IDynamicTeaser
    {
        private Item _item = null;
        public DynamicTeaserItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public DynamicTeaserItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public DynamicTeaserItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public DynamicTeaserItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _DynamicTeaser</para>
        /// <para>Field: Active</para>
        /// <para>Data type: Integer</para>
        /// </summary>
        [IndexField("active")]
        public virtual IIntegerFieldWrapper Active
        {
            [DebuggerStepThrough]
            get { return GetField<IntegerFieldWrapper>("Active", "active"); }
        }

        /// <summary>
        /// <para>Template: _DynamicTeaser</para>
        /// <para>Field: Active</para>
        /// <para>Data type: Integer</para>
        /// </summary>
        [IndexField("active")]
        public long ActiveValue
        {
            [DebuggerStepThrough]
            get { return this.Active.Value; }
        }
        /// <summary>
        /// <para>Template: _DynamicTeaser</para>
        /// <para>Field: Count</para>
        /// <para>Data type: Integer</para>
        /// </summary>
        [IndexField("count")]
        public virtual IIntegerFieldWrapper Count
        {
            [DebuggerStepThrough]
            get { return GetField<IntegerFieldWrapper>("Count", "count"); }
        }

        /// <summary>
        /// <para>Template: _DynamicTeaser</para>
        /// <para>Field: Count</para>
        /// <para>Data type: Integer</para>
        /// </summary>
        [IndexField("count")]
        public long CountValue
        {
            [DebuggerStepThrough]
            get { return this.Count.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Teasers/_DynamicTeaser</para>
    /// <summary>
    public static class DynamicTeaserConstants
    {
        public static readonly ID TemplateID = new ID("{20A56D46-F5E3-4DB8-8B96-081575363D44}");
        public const string TemplateName = "_DynamicTeaser";

        public struct Fields
        {
            public struct Active
            {
                public static readonly ID ID = new ID("{9E942565-677F-491C-A0AC-6B930E37342A}");
                public const string FieldName = "Active";
            }
            public struct Count
            {
                public static readonly ID ID = new ID("{A33F9523-96C4-4E42-B6D7-1E861718D373}");
                public const string FieldName = "Count";
            }
        }
    }
    
}
#endregion

#region _Headline (/sitecore/templates/Feature/Teasers/_Headline)
namespace Feature.Teasers
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _Headline</para>
    /// <para>ID: {c80d124b-b9ac-432e-8c26-dbf3a7f18d20}</para>
    /// <para>Path: /sitecore/templates/Feature/Teasers/_Headline</para>
    /// </summary>
    [TemplateMapping("{C80D124B-B9AC-432E-8C26-DBF3A7F18D20}", "InterfaceMap")]
    public partial interface IHeadline : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _Headline</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        ILinkFieldWrapper TeaserIcon { get; }

        /// <summary>
        /// <para>Template: _Headline</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        Guid TeaserIconValue { get; }

        /// <summary>
        /// <para>Template: _Headline</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        ITextFieldWrapper TeaserTitle { get; }

        /// <summary>
        /// <para>Template: _Headline</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        string TeaserTitleValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Teasers/_Headline</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{C80D124B-B9AC-432E-8C26-DBF3A7F18D20}", typeof(Guid))]
    [TemplateMapping("{C80D124B-B9AC-432E-8C26-DBF3A7F18D20}", "")]
    internal partial class HeadlineItem : CustomItemWrapper, IHeadline
    {
        private Item _item = null;
        public HeadlineItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public HeadlineItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public HeadlineItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public HeadlineItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _Headline</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        public virtual ILinkFieldWrapper TeaserIcon
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Teaser Icon", "teaser_icon"); }
        }

        /// <summary>
        /// <para>Template: _Headline</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        public Guid TeaserIconValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserIcon.Value; }
        }
        /// <summary>
        /// <para>Template: _Headline</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        public virtual ITextFieldWrapper TeaserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("TeaserTitle", "teasertitle"); }
        }

        /// <summary>
        /// <para>Template: _Headline</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        public string TeaserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserTitle.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Teasers/_Headline</para>
    /// <summary>
    public static class HeadlineConstants
    {
        public static readonly ID TemplateID = new ID("{C80D124B-B9AC-432E-8C26-DBF3A7F18D20}");
        public const string TemplateName = "_Headline";

        public struct Fields
        {
            public struct TeaserIcon
            {
                public static readonly ID ID = new ID("{3AF50903-63A9-464B-A375-B94983624E7D}");
                public const string FieldName = "Teaser Icon";
            }
            public struct TeaserTitle
            {
                public static readonly ID ID = new ID("{4A59D072-5B41-4A79-A157-2B2CCAC10F2B}");
                public const string FieldName = "TeaserTitle";
            }
        }
    }
    
}
#endregion

#region _TeaserContent (/sitecore/templates/Feature/Teasers/_TeaserContent)
namespace Feature.Teasers
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _TeaserContent</para>
    /// <para>ID: {fec0e62a-01fd-40e5-88f3-e5229fe79527}</para>
    /// <para>Path: /sitecore/templates/Feature/Teasers/_TeaserContent</para>
    /// </summary>
    [TemplateMapping("{FEC0E62A-01FD-40E5-88F3-E5229FE79527}", "InterfaceMap")]
    public partial interface ITeaserContent : ICustomItemWrapper, Feature.Teasers.IHeadline
    {
        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserLabel</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teaser_label")]
        ITextFieldWrapper TeaserLabel { get; }

        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserLabel</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teaser_label")]
        string TeaserLabelValue { get; }

        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        ICustomImageFieldWrapper TeaserImage { get; }

        string TeaserImageValue { get; }

        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("teaserlink")]
        ICustomGeneralLinkFieldWrapper TeaserLink { get; }

        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("teaserlink")]
        string TeaserLinkValue { get; }

        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("teasersummary")]
        ITextFieldWrapper TeaserSummary { get; }

        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("teasersummary")]
        string TeaserSummaryValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Teasers/_TeaserContent</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{FEC0E62A-01FD-40E5-88F3-E5229FE79527}", typeof(Guid))]
    [TemplateMapping("{FEC0E62A-01FD-40E5-88F3-E5229FE79527}", "")]
    internal partial class TeaserContentItem : CustomItemWrapper, ITeaserContent
    {
        private Item _item = null;
        public TeaserContentItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public TeaserContentItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public TeaserContentItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public TeaserContentItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        public virtual ILinkFieldWrapper TeaserIcon
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Teaser Icon", "teaser_icon"); }
        }

        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        public Guid TeaserIconValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserIcon.Value; }
        }
        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserLabel</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teaser_label")]
        public virtual ITextFieldWrapper TeaserLabel
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Teaser Label", "teaser_label"); }
        }

        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserLabel</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teaser_label")]
        public string TeaserLabelValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserLabel.Value; }
        }
        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper TeaserImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("TeaserImage"); }
        }

        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string TeaserImageValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserImage.Value; }
        }
        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("teaserlink")]
        public virtual ICustomGeneralLinkFieldWrapper TeaserLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("TeaserLink", "teaserlink"); }
        }

        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("teaserlink")]
        public string TeaserLinkValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserLink.Value; }
        }
        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("teasersummary")]
        public virtual ITextFieldWrapper TeaserSummary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("TeaserSummary", "teasersummary"); }
        }

        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("teasersummary")]
        public string TeaserSummaryValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserSummary.Value; }
        }
        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        public virtual ITextFieldWrapper TeaserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("TeaserTitle", "teasertitle"); }
        }

        /// <summary>
        /// <para>Template: _TeaserContent</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        public string TeaserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserTitle.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Teasers/_TeaserContent</para>
    /// <summary>
    public static class TeaserContentConstants
    {
        public static readonly ID TemplateID = new ID("{FEC0E62A-01FD-40E5-88F3-E5229FE79527}");
        public const string TemplateName = "_TeaserContent";

        public struct Fields
        {
            public struct TeaserIcon
            {
                public static readonly ID ID = new ID("{3AF50903-63A9-464B-A375-B94983624E7D}");
                public const string FieldName = "Teaser Icon";
            }
            public struct TeaserLabel
            {
                public static readonly ID ID = new ID("{3F7E7E3A-4E8E-4639-B079-FC5AEFF172F5}");
                public const string FieldName = "Teaser Label";
            }
            public struct TeaserImage
            {
                public static readonly ID ID = new ID("{0F6B5546-E0AB-4487-81DE-640C1AA1B65B}");
                public const string FieldName = "TeaserImage";
            }
            public struct TeaserLink
            {
                public static readonly ID ID = new ID("{E8AB122C-6F54-4D4E-AEC6-F81ADDC558FC}");
                public const string FieldName = "TeaserLink";
            }
            public struct TeaserSummary
            {
                public static readonly ID ID = new ID("{13D97A52-7C4E-407C-960D-FADDE8A3C1B1}");
                public const string FieldName = "TeaserSummary";
            }
            public struct TeaserTitle
            {
                public static readonly ID ID = new ID("{4A59D072-5B41-4A79-A157-2B2CCAC10F2B}");
                public const string FieldName = "TeaserTitle";
            }
        }
    }
    
}
#endregion

#region _TeasersParameters (/sitecore/templates/Feature/Teasers/_TeasersParameters)
namespace Feature.Teasers
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    using Fortis.Model.RenderingParameters;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _TeasersParameters</para>
    /// <para>ID: {20748d57-4ef6-49a8-b7e6-13818795e3b5}</para>
    /// <para>Path: /sitecore/templates/Feature/Teasers/_TeasersParameters</para>
    /// </summary>
    [TemplateMapping("{20748D57-4EF6-49A8-B7E6-13818795E3B5}", "InterfaceRenderingParameter")]
    public partial interface ITeasersParameters : IRenderingParameterWrapper, Foundation.Theming.IParametersTemplateFixedHeight, Foundation.Theming.IParametersTemplateHasBackground
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Teasers/_TeasersParameters</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{20748D57-4EF6-49A8-B7E6-13818795E3B5}", typeof(Guid))]
    [TemplateMapping("{20748D57-4EF6-49A8-B7E6-13818795E3B5}", "RenderingParameter")]
    internal partial class TeasersParametersItem : CustomRenderingParameterWrapper, ITeasersParameters
    {
        public TeasersParametersItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }

        /// <summary>
        /// <para>Template: _TeasersParameters</para>
        /// <para>Field: Background</para>
        /// <para>Data type: Droplink</para>
        /// </summary>
        public virtual ILinkFieldWrapper Background
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Background", "droplink"); }
        }

        /// <summary>
        /// <para>Template: _TeasersParameters</para>
        /// <para>Field: Background</para>
        /// <para>Data type: Droplink</para>
        /// </summary>
        public Guid BackgroundValue
        {
            [DebuggerStepThrough]
            get { return this.Background.Value; }
        }
        /// <summary>
        /// <para>Template: _TeasersParameters</para>
        /// <para>Field: FixedHeight</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public virtual IBooleanFieldWrapper FixedHeight
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.BooleanFieldWrapper)GetField("Fixed height", "checkbox"); }
        }

        /// <summary>
        /// <para>Template: _TeasersParameters</para>
        /// <para>Field: FixedHeight</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public bool FixedHeightValue
        {
            [DebuggerStepThrough]
            get { return this.FixedHeight.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Teasers/_TeasersParameters</para>
    /// <summary>
    public static class TeasersParametersConstants
    {
        public static readonly ID TemplateID = new ID("{20748D57-4EF6-49A8-B7E6-13818795E3B5}");
        public const string TemplateName = "_TeasersParameters";

        public struct Fields
        {
            public struct Background
            {
                public static readonly ID ID = new ID("{32439F83-C2FC-46E8-8981-5D1CDF1B2742}");
                public const string FieldName = "Background";
            }
            public struct FixedHeight
            {
                public static readonly ID ID = new ID("{B8965F9D-DDB4-4B8F-BF40-AFCF3C9AE09F}");
                public const string FieldName = "Fixed height";
            }
        }
    }
    
}
#endregion

#region _TeaserVideoContent (/sitecore/templates/Feature/Teasers/_TeaserVideoContent)
namespace Feature.Teasers
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _TeaserVideoContent</para>
    /// <para>ID: {04075eb6-6d94-4bf2-9aeb-d29a89cdba00}</para>
    /// <para>Path: /sitecore/templates/Feature/Teasers/_TeaserVideoContent</para>
    /// </summary>
    [TemplateMapping("{04075EB6-6D94-4BF2-9AEB-D29A89CDBA00}", "InterfaceMap")]
    public partial interface ITeaserVideoContent : ICustomItemWrapper, Feature.Teasers.IHeadline, Feature.Teasers.ITeaserContent
    {
        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: VideoLink</para>
        /// <para>Data type: link</para>
        /// </summary>
        ICustomGeneralLinkFieldWrapper VideoLink { get; }

        string VideoLinkValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Feature/Teasers/_TeaserVideoContent</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{04075EB6-6D94-4BF2-9AEB-D29A89CDBA00}", typeof(Guid))]
    [TemplateMapping("{04075EB6-6D94-4BF2-9AEB-D29A89CDBA00}", "")]
    internal partial class TeaserVideoContentItem : CustomItemWrapper, ITeaserVideoContent
    {
        private Item _item = null;
        public TeaserVideoContentItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public TeaserVideoContentItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public TeaserVideoContentItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public TeaserVideoContentItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        public virtual ILinkFieldWrapper TeaserIcon
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Teaser Icon", "teaser_icon"); }
        }

        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        public Guid TeaserIconValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserIcon.Value; }
        }
        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: TeaserLabel</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teaser_label")]
        public virtual ITextFieldWrapper TeaserLabel
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Teaser Label", "teaser_label"); }
        }

        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: TeaserLabel</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teaser_label")]
        public string TeaserLabelValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserLabel.Value; }
        }
        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: TeaserImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper TeaserImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("TeaserImage"); }
        }

        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: TeaserImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string TeaserImageValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserImage.Value; }
        }
        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: TeaserLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("teaserlink")]
        public virtual ICustomGeneralLinkFieldWrapper TeaserLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("TeaserLink", "teaserlink"); }
        }

        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: TeaserLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("teaserlink")]
        public string TeaserLinkValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserLink.Value; }
        }
        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: TeaserSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("teasersummary")]
        public virtual ITextFieldWrapper TeaserSummary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("TeaserSummary", "teasersummary"); }
        }

        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: TeaserSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("teasersummary")]
        public string TeaserSummaryValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserSummary.Value; }
        }
        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        public virtual ITextFieldWrapper TeaserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("TeaserTitle", "teasertitle"); }
        }

        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        public string TeaserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: VideoLink</para>
        /// <para>Data type: link</para>
        /// </summary>
        public virtual ICustomGeneralLinkFieldWrapper VideoLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("VideoLink"); }
        }

        /// <summary>
        /// <para>Template: _TeaserVideoContent</para>
        /// <para>Field: VideoLink</para>
        /// <para>Data type: link</para>
        /// </summary>
        public string VideoLinkValue
        {
            [DebuggerStepThrough]
            get { return this.VideoLink.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Feature/Teasers/_TeaserVideoContent</para>
    /// <summary>
    public static class TeaserVideoContentConstants
    {
        public static readonly ID TemplateID = new ID("{04075EB6-6D94-4BF2-9AEB-D29A89CDBA00}");
        public const string TemplateName = "_TeaserVideoContent";

        public struct Fields
        {
            public struct TeaserIcon
            {
                public static readonly ID ID = new ID("{3AF50903-63A9-464B-A375-B94983624E7D}");
                public const string FieldName = "Teaser Icon";
            }
            public struct TeaserLabel
            {
                public static readonly ID ID = new ID("{3F7E7E3A-4E8E-4639-B079-FC5AEFF172F5}");
                public const string FieldName = "Teaser Label";
            }
            public struct TeaserImage
            {
                public static readonly ID ID = new ID("{0F6B5546-E0AB-4487-81DE-640C1AA1B65B}");
                public const string FieldName = "TeaserImage";
            }
            public struct TeaserLink
            {
                public static readonly ID ID = new ID("{E8AB122C-6F54-4D4E-AEC6-F81ADDC558FC}");
                public const string FieldName = "TeaserLink";
            }
            public struct TeaserSummary
            {
                public static readonly ID ID = new ID("{13D97A52-7C4E-407C-960D-FADDE8A3C1B1}");
                public const string FieldName = "TeaserSummary";
            }
            public struct TeaserTitle
            {
                public static readonly ID ID = new ID("{4A59D072-5B41-4A79-A157-2B2CCAC10F2B}");
                public const string FieldName = "TeaserTitle";
            }
            public struct VideoLink
            {
                public static readonly ID ID = new ID("{AC846A16-FD3F-4243-A21F-668A21010C44}");
                public const string FieldName = "VideoLink";
            }
        }
    }
    
}
#endregion

#region Theme Folder (/sitecore/templates/Foundation/Assets/Theme Folder)
namespace Foundation.Assets
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Theme Folder</para>
    /// <para>ID: {10059264-cd0b-47b9-8350-a31a90815921}</para>
    /// <para>Path: /sitecore/templates/Foundation/Assets/Theme Folder</para>
    /// </summary>
    [TemplateMapping("{10059264-CD0B-47B9-8350-A31A90815921}", "InterfaceMap")]
    public partial interface IThemeFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Assets/Theme Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{10059264-CD0B-47B9-8350-A31A90815921}", typeof(Guid))]
    [TemplateMapping("{10059264-CD0B-47B9-8350-A31A90815921}", "")]
    internal partial class ThemeFolderItem : CustomItemWrapper, IThemeFolder
    {
        private Item _item = null;
        public ThemeFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public ThemeFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public ThemeFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public ThemeFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Assets/Theme Folder</para>
    /// <summary>
    public static class ThemeFolderConstants
    {
        public static readonly ID TemplateID = new ID("{10059264-CD0B-47B9-8350-A31A90815921}");
        public const string TemplateName = "Theme Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Theme (/sitecore/templates/Foundation/Assets/Theme)
namespace Foundation.Assets
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Theme</para>
    /// <para>ID: {1c87ea50-cc18-48cc-86de-592e274d0c4f}</para>
    /// <para>Path: /sitecore/templates/Foundation/Assets/Theme</para>
    /// </summary>
    [TemplateMapping("{1C87EA50-CC18-48CC-86DE-592E274D0C4F}", "InterfaceMap")]
    public partial interface ITheme : ICustomItemWrapper, Foundation.Assets.IRenderingAssets
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Assets/Theme</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{1C87EA50-CC18-48CC-86DE-592E274D0C4F}", typeof(Guid))]
    [TemplateMapping("{1C87EA50-CC18-48CC-86DE-592E274D0C4F}", "")]
    internal partial class ThemeItem : CustomItemWrapper, ITheme
    {
        private Item _item = null;
        public ThemeItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public ThemeItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public ThemeItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public ThemeItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Theme</para>
        /// <para>Field: CssAssets</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("css_assets")]
        public virtual ITextFieldWrapper CssAssets
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Css assets", "css_assets"); }
        }

        /// <summary>
        /// <para>Template: Theme</para>
        /// <para>Field: CssAssets</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("css_assets")]
        public string CssAssetsValue
        {
            [DebuggerStepThrough]
            get { return this.CssAssets.Value; }
        }
        /// <summary>
        /// <para>Template: Theme</para>
        /// <para>Field: CssInline</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("css_inline")]
        public virtual ITextFieldWrapper CssInline
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Css inline", "css_inline"); }
        }

        /// <summary>
        /// <para>Template: Theme</para>
        /// <para>Field: CssInline</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("css_inline")]
        public string CssInlineValue
        {
            [DebuggerStepThrough]
            get { return this.CssInline.Value; }
        }
        /// <summary>
        /// <para>Template: Theme</para>
        /// <para>Field: JavaScriptAssets</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascript_assets")]
        public virtual ITextFieldWrapper JavaScriptAssets
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavaScript assets", "javascript_assets"); }
        }

        /// <summary>
        /// <para>Template: Theme</para>
        /// <para>Field: JavaScriptAssets</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascript_assets")]
        public string JavaScriptAssetsValue
        {
            [DebuggerStepThrough]
            get { return this.JavaScriptAssets.Value; }
        }
        /// <summary>
        /// <para>Template: Theme</para>
        /// <para>Field: JavaScriptInline</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascript_inline")]
        public virtual ITextFieldWrapper JavaScriptInline
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavaScript inline", "javascript_inline"); }
        }

        /// <summary>
        /// <para>Template: Theme</para>
        /// <para>Field: JavaScriptInline</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascript_inline")]
        public string JavaScriptInlineValue
        {
            [DebuggerStepThrough]
            get { return this.JavaScriptInline.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Assets/Theme</para>
    /// <summary>
    public static class ThemeConstants
    {
        public static readonly ID TemplateID = new ID("{1C87EA50-CC18-48CC-86DE-592E274D0C4F}");
        public const string TemplateName = "Theme";

        public struct Fields
        {
            public struct CssAssets
            {
                public static readonly ID ID = new ID("{4867D192-326A-4AA4-81EF-EA430E224AFF}");
                public const string FieldName = "Css assets";
            }
            public struct CssInline
            {
                public static readonly ID ID = new ID("{FD0DEC96-B220-4196-B544-68B11EEE727A}");
                public const string FieldName = "Css inline";
            }
            public struct JavaScriptAssets
            {
                public static readonly ID ID = new ID("{E514A1EB-DDBA-44F7-8528-82CA2280F778}");
                public const string FieldName = "JavaScript assets";
            }
            public struct JavaScriptInline
            {
                public static readonly ID ID = new ID("{11421560-0BCB-403A-B099-8595C34341FD}");
                public const string FieldName = "JavaScript inline";
            }
        }
    }
    
}
#endregion

#region _HasTheme (/sitecore/templates/Foundation/Assets/_HasTheme)
namespace Foundation.Assets
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _HasTheme</para>
    /// <para>ID: {5b6f8720-3a93-4da1-92a0-c3e85e01219a}</para>
    /// <para>Path: /sitecore/templates/Foundation/Assets/_HasTheme</para>
    /// </summary>
    [TemplateMapping("{5B6F8720-3A93-4DA1-92A0-C3E85E01219A}", "InterfaceMap")]
    public partial interface IHasTheme : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _HasTheme</para>
        /// <para>Field: Theme</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("theme")]
        ILinkFieldWrapper Theme { get; }

        /// <summary>
        /// <para>Template: _HasTheme</para>
        /// <para>Field: Theme</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("theme")]
        Guid ThemeValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Assets/_HasTheme</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{5B6F8720-3A93-4DA1-92A0-C3E85E01219A}", typeof(Guid))]
    [TemplateMapping("{5B6F8720-3A93-4DA1-92A0-C3E85E01219A}", "")]
    internal partial class HasThemeItem : CustomItemWrapper, IHasTheme
    {
        private Item _item = null;
        public HasThemeItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public HasThemeItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public HasThemeItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public HasThemeItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _HasTheme</para>
        /// <para>Field: Theme</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("theme")]
        public virtual ILinkFieldWrapper Theme
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Theme", "theme"); }
        }

        /// <summary>
        /// <para>Template: _HasTheme</para>
        /// <para>Field: Theme</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("theme")]
        public Guid ThemeValue
        {
            [DebuggerStepThrough]
            get { return this.Theme.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Assets/_HasTheme</para>
    /// <summary>
    public static class HasThemeConstants
    {
        public static readonly ID TemplateID = new ID("{5B6F8720-3A93-4DA1-92A0-C3E85E01219A}");
        public const string TemplateName = "_HasTheme";

        public struct Fields
        {
            public struct Theme
            {
                public static readonly ID ID = new ID("{53B5AF0A-265F-4E60-B2B2-4576CE0BECCF}");
                public const string FieldName = "Theme";
            }
        }
    }
    
}
#endregion

#region _PageAssets (/sitecore/templates/Foundation/Assets/_PageAssets)
namespace Foundation.Assets
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _PageAssets</para>
    /// <para>ID: {91962b60-25f6-428f-8d10-02aa1e49d6a5}</para>
    /// <para>Path: /sitecore/templates/Foundation/Assets/_PageAssets</para>
    /// </summary>
    [TemplateMapping("{91962B60-25F6-428F-8D10-02AA1E49D6A5}", "InterfaceMap")]
    public partial interface IPageAssets : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        ITextFieldWrapper CssCode { get; }

        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        string CssCodeValue { get; }

        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        IBooleanFieldWrapper InheritAssets { get; }

        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        bool InheritAssetsValue { get; }

        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        ITextFieldWrapper JavascriptCodeBottom { get; }

        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        string JavascriptCodeBottomValue { get; }

        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        ITextFieldWrapper JavascriptCodeTop { get; }

        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        string JavascriptCodeTopValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Assets/_PageAssets</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{91962B60-25F6-428F-8D10-02AA1E49D6A5}", typeof(Guid))]
    [TemplateMapping("{91962B60-25F6-428F-8D10-02AA1E49D6A5}", "")]
    internal partial class PageAssetsItem : CustomItemWrapper, IPageAssets
    {
        private Item _item = null;
        public PageAssetsItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public PageAssetsItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public PageAssetsItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public PageAssetsItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public virtual ITextFieldWrapper CssCode
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CssCode", "csscode"); }
        }

        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public string CssCodeValue
        {
            [DebuggerStepThrough]
            get { return this.CssCode.Value; }
        }
        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public virtual IBooleanFieldWrapper InheritAssets
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("InheritAssets", "inheritassets"); }
        }

        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public bool InheritAssetsValue
        {
            [DebuggerStepThrough]
            get { return this.InheritAssets.Value; }
        }
        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public virtual ITextFieldWrapper JavascriptCodeBottom
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeBottom", "javascriptcodebottom"); }
        }

        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public string JavascriptCodeBottomValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeBottom.Value; }
        }
        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public virtual ITextFieldWrapper JavascriptCodeTop
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeTop", "javascriptcodetop"); }
        }

        /// <summary>
        /// <para>Template: _PageAssets</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public string JavascriptCodeTopValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeTop.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Assets/_PageAssets</para>
    /// <summary>
    public static class PageAssetsConstants
    {
        public static readonly ID TemplateID = new ID("{91962B60-25F6-428F-8D10-02AA1E49D6A5}");
        public const string TemplateName = "_PageAssets";

        public struct Fields
        {
            public struct CssCode
            {
                public static readonly ID ID = new ID("{06A96EFC-F2E5-45C3-A7DC-4DDDFA366CC0}");
                public const string FieldName = "CssCode";
            }
            public struct InheritAssets
            {
                public static readonly ID ID = new ID("{F19E8A50-9950-4861-9E66-9598A1898E71}");
                public const string FieldName = "InheritAssets";
            }
            public struct JavascriptCodeBottom
            {
                public static readonly ID ID = new ID("{B3BA9EA9-D0A1-49DF-9F4B-28FA5D353DC8}");
                public const string FieldName = "JavascriptCodeBottom";
            }
            public struct JavascriptCodeTop
            {
                public static readonly ID ID = new ID("{D79D9DDD-2774-42F4-94C3-50C892F6E13D}");
                public const string FieldName = "JavascriptCodeTop";
            }
        }
    }
    
}
#endregion

#region _RenderingAssets (/sitecore/templates/Foundation/Assets/_RenderingAssets)
namespace Foundation.Assets
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _RenderingAssets</para>
    /// <para>ID: {7ceac341-b953-4c69-b907-ee44302bf6ae}</para>
    /// <para>Path: /sitecore/templates/Foundation/Assets/_RenderingAssets</para>
    /// </summary>
    [TemplateMapping("{7CEAC341-B953-4C69-B907-EE44302BF6AE}", "InterfaceMap")]
    public partial interface IRenderingAssets : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: CssAssets</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("css_assets")]
        ITextFieldWrapper CssAssets { get; }

        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: CssAssets</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("css_assets")]
        string CssAssetsValue { get; }

        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: CssInline</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("css_inline")]
        ITextFieldWrapper CssInline { get; }

        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: CssInline</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("css_inline")]
        string CssInlineValue { get; }

        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: JavaScriptAssets</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascript_assets")]
        ITextFieldWrapper JavaScriptAssets { get; }

        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: JavaScriptAssets</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascript_assets")]
        string JavaScriptAssetsValue { get; }

        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: JavaScriptInline</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascript_inline")]
        ITextFieldWrapper JavaScriptInline { get; }

        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: JavaScriptInline</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascript_inline")]
        string JavaScriptInlineValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Assets/_RenderingAssets</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{7CEAC341-B953-4C69-B907-EE44302BF6AE}", typeof(Guid))]
    [TemplateMapping("{7CEAC341-B953-4C69-B907-EE44302BF6AE}", "")]
    internal partial class RenderingAssetsItem : CustomItemWrapper, IRenderingAssets
    {
        private Item _item = null;
        public RenderingAssetsItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public RenderingAssetsItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public RenderingAssetsItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public RenderingAssetsItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: CssAssets</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("css_assets")]
        public virtual ITextFieldWrapper CssAssets
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Css assets", "css_assets"); }
        }

        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: CssAssets</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("css_assets")]
        public string CssAssetsValue
        {
            [DebuggerStepThrough]
            get { return this.CssAssets.Value; }
        }
        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: CssInline</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("css_inline")]
        public virtual ITextFieldWrapper CssInline
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Css inline", "css_inline"); }
        }

        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: CssInline</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("css_inline")]
        public string CssInlineValue
        {
            [DebuggerStepThrough]
            get { return this.CssInline.Value; }
        }
        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: JavaScriptAssets</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascript_assets")]
        public virtual ITextFieldWrapper JavaScriptAssets
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavaScript assets", "javascript_assets"); }
        }

        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: JavaScriptAssets</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascript_assets")]
        public string JavaScriptAssetsValue
        {
            [DebuggerStepThrough]
            get { return this.JavaScriptAssets.Value; }
        }
        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: JavaScriptInline</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascript_inline")]
        public virtual ITextFieldWrapper JavaScriptInline
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavaScript inline", "javascript_inline"); }
        }

        /// <summary>
        /// <para>Template: _RenderingAssets</para>
        /// <para>Field: JavaScriptInline</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascript_inline")]
        public string JavaScriptInlineValue
        {
            [DebuggerStepThrough]
            get { return this.JavaScriptInline.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Assets/_RenderingAssets</para>
    /// <summary>
    public static class RenderingAssetsConstants
    {
        public static readonly ID TemplateID = new ID("{7CEAC341-B953-4C69-B907-EE44302BF6AE}");
        public const string TemplateName = "_RenderingAssets";

        public struct Fields
        {
            public struct CssAssets
            {
                public static readonly ID ID = new ID("{4867D192-326A-4AA4-81EF-EA430E224AFF}");
                public const string FieldName = "Css assets";
            }
            public struct CssInline
            {
                public static readonly ID ID = new ID("{FD0DEC96-B220-4196-B544-68B11EEE727A}");
                public const string FieldName = "Css inline";
            }
            public struct JavaScriptAssets
            {
                public static readonly ID ID = new ID("{E514A1EB-DDBA-44F7-8528-82CA2280F778}");
                public const string FieldName = "JavaScript assets";
            }
            public struct JavaScriptInline
            {
                public static readonly ID ID = new ID("{11421560-0BCB-403A-B099-8595C34341FD}");
                public const string FieldName = "JavaScript inline";
            }
        }
    }
    
}
#endregion

#region DictionaryEntry (/sitecore/templates/Foundation/Dictionary/DictionaryEntry)
namespace Foundation.Dictionary
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: DictionaryEntry</para>
    /// <para>ID: {ec4dd3f2-590d-404b-9189-2a12679749cc}</para>
    /// <para>Path: /sitecore/templates/Foundation/Dictionary/DictionaryEntry</para>
    /// </summary>
    [TemplateMapping("{EC4DD3F2-590D-404B-9189-2A12679749CC}", "InterfaceMap")]
    public partial interface IDictionaryEntry : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: DictionaryEntry</para>
        /// <para>Field: Phrase</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("phrase")]
        ITextFieldWrapper Phrase { get; }

        /// <summary>
        /// <para>Template: DictionaryEntry</para>
        /// <para>Field: Phrase</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("phrase")]
        string PhraseValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Dictionary/DictionaryEntry</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{EC4DD3F2-590D-404B-9189-2A12679749CC}", typeof(Guid))]
    [TemplateMapping("{EC4DD3F2-590D-404B-9189-2A12679749CC}", "")]
    internal partial class DictionaryEntryItem : CustomItemWrapper, IDictionaryEntry
    {
        private Item _item = null;
        public DictionaryEntryItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public DictionaryEntryItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public DictionaryEntryItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public DictionaryEntryItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: DictionaryEntry</para>
        /// <para>Field: Phrase</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("phrase")]
        public virtual ITextFieldWrapper Phrase
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Phrase", "phrase"); }
        }

        /// <summary>
        /// <para>Template: DictionaryEntry</para>
        /// <para>Field: Phrase</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("phrase")]
        public string PhraseValue
        {
            [DebuggerStepThrough]
            get { return this.Phrase.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Dictionary/DictionaryEntry</para>
    /// <summary>
    public static class DictionaryEntryConstants
    {
        public static readonly ID TemplateID = new ID("{EC4DD3F2-590D-404B-9189-2A12679749CC}");
        public const string TemplateName = "DictionaryEntry";

        public struct Fields
        {
            public struct Phrase
            {
                public static readonly ID ID = new ID("{DDACDD55-5B08-405F-9E58-04F09AED640A}");
                public const string FieldName = "Phrase";
            }
        }
    }
    
}
#endregion

#region DictionaryFolder (/sitecore/templates/Foundation/Dictionary/DictionaryFolder)
namespace Foundation.Dictionary
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: DictionaryFolder</para>
    /// <para>ID: {98e4bdc6-9b43-4eb2-baa3-d4303c35852e}</para>
    /// <para>Path: /sitecore/templates/Foundation/Dictionary/DictionaryFolder</para>
    /// </summary>
    [TemplateMapping("{98E4BDC6-9B43-4EB2-BAA3-D4303C35852E}", "InterfaceMap")]
    public partial interface IDictionaryFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Dictionary/DictionaryFolder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{98E4BDC6-9B43-4EB2-BAA3-D4303C35852E}", typeof(Guid))]
    [TemplateMapping("{98E4BDC6-9B43-4EB2-BAA3-D4303C35852E}", "")]
    internal partial class DictionaryFolderItem : CustomItemWrapper, IDictionaryFolder
    {
        private Item _item = null;
        public DictionaryFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public DictionaryFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public DictionaryFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public DictionaryFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Dictionary/DictionaryFolder</para>
    /// <summary>
    public static class DictionaryFolderConstants
    {
        public static readonly ID TemplateID = new ID("{98E4BDC6-9B43-4EB2-BAA3-D4303C35852E}");
        public const string TemplateName = "DictionaryFolder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region _IndexedItem (/sitecore/templates/Foundation/Indexing/_IndexedItem)
namespace Foundation.Indexing
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _IndexedItem</para>
    /// <para>ID: {8fd6c8b6-a9a4-4322-947e-90ce3d94916d}</para>
    /// <para>Path: /sitecore/templates/Foundation/Indexing/_IndexedItem</para>
    /// </summary>
    [TemplateMapping("{8FD6C8B6-A9A4-4322-947E-90CE3D94916D}", "InterfaceMap")]
    public partial interface IIndexedItem : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: _IndexedItem</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        IBooleanFieldWrapper IncludeInSearchResults { get; }

        /// <summary>
        /// <para>Template: _IndexedItem</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        bool IncludeInSearchResultsValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Indexing/_IndexedItem</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{8FD6C8B6-A9A4-4322-947E-90CE3D94916D}", typeof(Guid))]
    [TemplateMapping("{8FD6C8B6-A9A4-4322-947E-90CE3D94916D}", "")]
    internal partial class IndexedItemItem : CustomItemWrapper, IIndexedItem
    {
        private Item _item = null;
        public IndexedItemItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public IndexedItemItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public IndexedItemItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public IndexedItemItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: _IndexedItem</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public virtual IBooleanFieldWrapper IncludeInSearchResults
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("IncludeInSearchResults", "includeinsearchresults"); }
        }

        /// <summary>
        /// <para>Template: _IndexedItem</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public bool IncludeInSearchResultsValue
        {
            [DebuggerStepThrough]
            get { return this.IncludeInSearchResults.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Indexing/_IndexedItem</para>
    /// <summary>
    public static class IndexedItemConstants
    {
        public static readonly ID TemplateID = new ID("{8FD6C8B6-A9A4-4322-947E-90CE3D94916D}");
        public const string TemplateName = "_IndexedItem";

        public struct Fields
        {
            public struct IncludeInSearchResults
            {
                public static readonly ID ID = new ID("{8D5C486E-A0E3-4DBE-9A4A-CDFF93594BDA}");
                public const string FieldName = "IncludeInSearchResults";
            }
        }
    }
    
}
#endregion

#region Local Datasource Folder (/sitecore/templates/Foundation/LocalDatasource/Local Datasource Folder)
namespace Foundation.LocalDatasource
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Local Datasource Folder</para>
    /// <para>ID: {fff5f245-ffc0-4022-a998-9b07aa5e761f}</para>
    /// <para>Path: /sitecore/templates/Foundation/LocalDatasource/Local Datasource Folder</para>
    /// </summary>
    [TemplateMapping("{FFF5F245-FFC0-4022-A998-9B07AA5E761F}", "InterfaceMap")]
    public partial interface ILocalDatasourceFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/LocalDatasource/Local Datasource Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{FFF5F245-FFC0-4022-A998-9B07AA5E761F}", typeof(Guid))]
    [TemplateMapping("{FFF5F245-FFC0-4022-A998-9B07AA5E761F}", "")]
    internal partial class LocalDatasourceFolderItem : CustomItemWrapper, ILocalDatasourceFolder
    {
        private Item _item = null;
        public LocalDatasourceFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public LocalDatasourceFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public LocalDatasourceFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public LocalDatasourceFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/LocalDatasource/Local Datasource Folder</para>
    /// <summary>
    public static class LocalDatasourceFolderConstants
    {
        public static readonly ID TemplateID = new ID("{FFF5F245-FFC0-4022-A998-9B07AA5E761F}");
        public const string TemplateName = "Local Datasource Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Datasource Configuration (/sitecore/templates/Foundation/Multisite/Datasource Configuration)
namespace Foundation.Multisite
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Datasource Configuration</para>
    /// <para>ID: {c82dc5ff-09ef-4403-96d3-3caf377b8c5b}</para>
    /// <para>Path: /sitecore/templates/Foundation/Multisite/Datasource Configuration</para>
    /// </summary>
    [TemplateMapping("{C82DC5FF-09EF-4403-96D3-3CAF377B8C5B}", "InterfaceMap")]
    public partial interface IDatasourceConfiguration : ICustomItemWrapper, Foundation.Multisite.ISiteSettings
    {
        /// <summary>
        /// <para>Template: Datasource Configuration</para>
        /// <para>Field: DatasourceLocation</para>
        /// <para>Data type: Datasource</para>
        /// </summary>
        ITextFieldWrapper DatasourceLocation { get; }

        string DatasourceLocationValue { get; }

        /// <summary>
        /// <para>Template: Datasource Configuration</para>
        /// <para>Field: DatasourceTemplate</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        ITextFieldWrapper DatasourceTemplate { get; }

        string DatasourceTemplateValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Multisite/Datasource Configuration</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{C82DC5FF-09EF-4403-96D3-3CAF377B8C5B}", typeof(Guid))]
    [TemplateMapping("{C82DC5FF-09EF-4403-96D3-3CAF377B8C5B}", "")]
    internal partial class DatasourceConfigurationItem : CustomItemWrapper, IDatasourceConfiguration
    {
        private Item _item = null;
        public DatasourceConfigurationItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public DatasourceConfigurationItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public DatasourceConfigurationItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public DatasourceConfigurationItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Datasource Configuration</para>
        /// <para>Field: DatasourceLocation</para>
        /// <para>Data type: Datasource</para>
        /// </summary>
        public virtual ITextFieldWrapper DatasourceLocation
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("DatasourceLocation"); }
        }

        /// <summary>
        /// <para>Template: Datasource Configuration</para>
        /// <para>Field: DatasourceLocation</para>
        /// <para>Data type: Datasource</para>
        /// </summary>
        public string DatasourceLocationValue
        {
            [DebuggerStepThrough]
            get { return this.DatasourceLocation.Value; }
        }
        /// <summary>
        /// <para>Template: Datasource Configuration</para>
        /// <para>Field: DatasourceTemplate</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper DatasourceTemplate
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("DatasourceTemplate"); }
        }

        /// <summary>
        /// <para>Template: Datasource Configuration</para>
        /// <para>Field: DatasourceTemplate</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string DatasourceTemplateValue
        {
            [DebuggerStepThrough]
            get { return this.DatasourceTemplate.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Multisite/Datasource Configuration</para>
    /// <summary>
    public static class DatasourceConfigurationConstants
    {
        public static readonly ID TemplateID = new ID("{C82DC5FF-09EF-4403-96D3-3CAF377B8C5B}");
        public const string TemplateName = "Datasource Configuration";

        public struct Fields
        {
            public struct DatasourceLocation
            {
                public static readonly ID ID = new ID("{5FE1CC43-F86C-459C-A379-CD75950D85AF}");
                public const string FieldName = "DatasourceLocation";
            }
            public struct DatasourceTemplate
            {
                public static readonly ID ID = new ID("{498DD5B6-7DAE-44A7-9213-1D32596AD14F}");
                public const string FieldName = "DatasourceTemplate";
            }
        }
    }
    
}
#endregion

#region Datasource Settings Folder (/sitecore/templates/Foundation/Multisite/Datasource Settings Folder)
namespace Foundation.Multisite
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Datasource Settings Folder</para>
    /// <para>ID: {7a98be60-9f59-4064-82c2-58da63562fa5}</para>
    /// <para>Path: /sitecore/templates/Foundation/Multisite/Datasource Settings Folder</para>
    /// </summary>
    [TemplateMapping("{7A98BE60-9F59-4064-82C2-58DA63562FA5}", "InterfaceMap")]
    public partial interface IDatasourceSettingsFolder : ICustomItemWrapper, Foundation.Multisite.ISiteSettings
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Multisite/Datasource Settings Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{7A98BE60-9F59-4064-82C2-58DA63562FA5}", typeof(Guid))]
    [TemplateMapping("{7A98BE60-9F59-4064-82C2-58DA63562FA5}", "")]
    internal partial class DatasourceSettingsFolderItem : CustomItemWrapper, IDatasourceSettingsFolder
    {
        private Item _item = null;
        public DatasourceSettingsFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public DatasourceSettingsFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public DatasourceSettingsFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public DatasourceSettingsFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Multisite/Datasource Settings Folder</para>
    /// <summary>
    public static class DatasourceSettingsFolderConstants
    {
        public static readonly ID TemplateID = new ID("{7A98BE60-9F59-4064-82C2-58DA63562FA5}");
        public const string TemplateName = "Datasource Settings Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Site Settings Root (/sitecore/templates/Foundation/Multisite/Site Settings Root)
namespace Foundation.Multisite
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Site Settings Root</para>
    /// <para>ID: {4c82b6dd-fe7c-4144-bcb3-f21b4080568f}</para>
    /// <para>Path: /sitecore/templates/Foundation/Multisite/Site Settings Root</para>
    /// </summary>
    [TemplateMapping("{4C82B6DD-FE7C-4144-BCB3-F21B4080568F}", "InterfaceMap")]
    public partial interface ISiteSettingsRoot : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Multisite/Site Settings Root</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{4C82B6DD-FE7C-4144-BCB3-F21B4080568F}", typeof(Guid))]
    [TemplateMapping("{4C82B6DD-FE7C-4144-BCB3-F21B4080568F}", "")]
    internal partial class SiteSettingsRootItem : CustomItemWrapper, ISiteSettingsRoot
    {
        private Item _item = null;
        public SiteSettingsRootItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public SiteSettingsRootItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public SiteSettingsRootItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public SiteSettingsRootItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Multisite/Site Settings Root</para>
    /// <summary>
    public static class SiteSettingsRootConstants
    {
        public static readonly ID TemplateID = new ID("{4C82B6DD-FE7C-4144-BCB3-F21B4080568F}");
        public const string TemplateName = "Site Settings Root";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region _Site (/sitecore/templates/Foundation/Multisite/_Site)
namespace Foundation.Multisite
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _Site</para>
    /// <para>ID: {bb85c5c2-9f87-48ce-8012-af67cf4f765d}</para>
    /// <para>Path: /sitecore/templates/Foundation/Multisite/_Site</para>
    /// </summary>
    [TemplateMapping("{BB85C5C2-9F87-48CE-8012-AF67CF4F765D}", "InterfaceMap")]
    public partial interface ISite : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Multisite/_Site</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{BB85C5C2-9F87-48CE-8012-AF67CF4F765D}", typeof(Guid))]
    [TemplateMapping("{BB85C5C2-9F87-48CE-8012-AF67CF4F765D}", "")]
    internal partial class SiteItem : CustomItemWrapper, ISite
    {
        private Item _item = null;
        public SiteItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public SiteItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public SiteItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public SiteItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Multisite/_Site</para>
    /// <summary>
    public static class SiteConstants
    {
        public static readonly ID TemplateID = new ID("{BB85C5C2-9F87-48CE-8012-AF67CF4F765D}");
        public const string TemplateName = "_Site";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region _SiteSettings (/sitecore/templates/Foundation/Multisite/_SiteSettings)
namespace Foundation.Multisite
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: _SiteSettings</para>
    /// <para>ID: {bccfebea-dccb-48fe-9570-6503829ec03f}</para>
    /// <para>Path: /sitecore/templates/Foundation/Multisite/_SiteSettings</para>
    /// </summary>
    [TemplateMapping("{BCCFEBEA-DCCB-48FE-9570-6503829EC03F}", "InterfaceMap")]
    public partial interface ISiteSettings : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Multisite/_SiteSettings</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{BCCFEBEA-DCCB-48FE-9570-6503829EC03F}", typeof(Guid))]
    [TemplateMapping("{BCCFEBEA-DCCB-48FE-9570-6503829EC03F}", "")]
    internal partial class SiteSettingsItem : CustomItemWrapper, ISiteSettings
    {
        private Item _item = null;
        public SiteSettingsItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public SiteSettingsItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public SiteSettingsItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public SiteSettingsItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Multisite/_SiteSettings</para>
    /// <summary>
    public static class SiteSettingsConstants
    {
        public static readonly ID TemplateID = new ID("{BCCFEBEA-DCCB-48FE-9570-6503829EC03F}");
        public const string TemplateName = "_SiteSettings";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region ParametersTemplate_HasDynamicPlaceholder (/sitecore/templates/Foundation/SitecoreExtensions/ParametersTemplate_HasDynamicPlaceholder)
namespace Foundation.SitecoreExtensions
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    using Fortis.Model.RenderingParameters;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: ParametersTemplate_HasDynamicPlaceholder</para>
    /// <para>ID: {8373e4e5-c79c-4123-9284-babd9601c565}</para>
    /// <para>Path: /sitecore/templates/Foundation/SitecoreExtensions/ParametersTemplate_HasDynamicPlaceholder</para>
    /// </summary>
    [TemplateMapping("{8373E4E5-C79C-4123-9284-BABD9601C565}", "InterfaceRenderingParameter")]
    public partial interface IParametersTemplateHasDynamicPlaceholder : IRenderingParameterWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/SitecoreExtensions/ParametersTemplate_HasDynamicPlaceholder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{8373E4E5-C79C-4123-9284-BABD9601C565}", typeof(Guid))]
    [TemplateMapping("{8373E4E5-C79C-4123-9284-BABD9601C565}", "RenderingParameter")]
    internal partial class ParametersTemplateHasDynamicPlaceholderItem : CustomRenderingParameterWrapper, IParametersTemplateHasDynamicPlaceholder
    {
        public ParametersTemplateHasDynamicPlaceholderItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/SitecoreExtensions/ParametersTemplate_HasDynamicPlaceholder</para>
    /// <summary>
    public static class ParametersTemplateHasDynamicPlaceholderConstants
    {
        public static readonly ID TemplateID = new ID("{8373E4E5-C79C-4123-9284-BABD9601C565}");
        public const string TemplateName = "ParametersTemplate_HasDynamicPlaceholder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region ParametersTemplate_QueryableDatasourceRendering (/sitecore/templates/Foundation/SitecoreExtensions/ParametersTemplate_QueryableDatasourceRendering)
namespace Foundation.SitecoreExtensions
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    using Fortis.Model.RenderingParameters;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: ParametersTemplate_QueryableDatasourceRendering</para>
    /// <para>ID: {4738312c-22b8-4e77-9b9c-86bcdcee6635}</para>
    /// <para>Path: /sitecore/templates/Foundation/SitecoreExtensions/ParametersTemplate_QueryableDatasourceRendering</para>
    /// </summary>
    [TemplateMapping("{4738312C-22B8-4E77-9B9C-86BCDCEE6635}", "InterfaceRenderingParameter")]
    public partial interface IParametersTemplateQueryableDatasourceRendering : IRenderingParameterWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/SitecoreExtensions/ParametersTemplate_QueryableDatasourceRendering</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{4738312C-22B8-4E77-9B9C-86BCDCEE6635}", typeof(Guid))]
    [TemplateMapping("{4738312C-22B8-4E77-9B9C-86BCDCEE6635}", "RenderingParameter")]
    internal partial class ParametersTemplateQueryableDatasourceRenderingItem : CustomRenderingParameterWrapper, IParametersTemplateQueryableDatasourceRendering
    {
        public ParametersTemplateQueryableDatasourceRenderingItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/SitecoreExtensions/ParametersTemplate_QueryableDatasourceRendering</para>
    /// <summary>
    public static class ParametersTemplateQueryableDatasourceRenderingConstants
    {
        public static readonly ID TemplateID = new ID("{4738312C-22B8-4E77-9B9C-86BCDCEE6635}");
        public const string TemplateName = "ParametersTemplate_QueryableDatasourceRendering";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region ParametersTemplate_FixedHeight (/sitecore/templates/Foundation/Theming/ParametersTemplate_FixedHeight)
namespace Foundation.Theming
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    using Fortis.Model.RenderingParameters;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: ParametersTemplate_FixedHeight</para>
    /// <para>ID: {329421cf-b99c-4e7a-af71-f7fa7dc42bf1}</para>
    /// <para>Path: /sitecore/templates/Foundation/Theming/ParametersTemplate_FixedHeight</para>
    /// </summary>
    [TemplateMapping("{329421CF-B99C-4E7A-AF71-F7FA7DC42BF1}", "InterfaceRenderingParameter")]
    public partial interface IParametersTemplateFixedHeight : IRenderingParameterWrapper
    {
        /// <summary>
        /// <para>Template: ParametersTemplate_FixedHeight</para>
        /// <para>Field: FixedHeight</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        IBooleanFieldWrapper FixedHeight { get; }

        bool FixedHeightValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Theming/ParametersTemplate_FixedHeight</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{329421CF-B99C-4E7A-AF71-F7FA7DC42BF1}", typeof(Guid))]
    [TemplateMapping("{329421CF-B99C-4E7A-AF71-F7FA7DC42BF1}", "RenderingParameter")]
    internal partial class ParametersTemplateFixedHeightItem : CustomRenderingParameterWrapper, IParametersTemplateFixedHeight
    {
        public ParametersTemplateFixedHeightItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_FixedHeight</para>
        /// <para>Field: FixedHeight</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public virtual IBooleanFieldWrapper FixedHeight
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.BooleanFieldWrapper)GetField("Fixed height", "checkbox"); }
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_FixedHeight</para>
        /// <para>Field: FixedHeight</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public bool FixedHeightValue
        {
            [DebuggerStepThrough]
            get { return this.FixedHeight.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Theming/ParametersTemplate_FixedHeight</para>
    /// <summary>
    public static class ParametersTemplateFixedHeightConstants
    {
        public static readonly ID TemplateID = new ID("{329421CF-B99C-4E7A-AF71-F7FA7DC42BF1}");
        public const string TemplateName = "ParametersTemplate_FixedHeight";

        public struct Fields
        {
            public struct FixedHeight
            {
                public static readonly ID ID = new ID("{B8965F9D-DDB4-4B8F-BF40-AFCF3C9AE09F}");
                public const string FieldName = "Fixed height";
            }
        }
    }
    
}
#endregion

#region ParametersTemplate_HasBackground (/sitecore/templates/Foundation/Theming/ParametersTemplate_HasBackground)
namespace Foundation.Theming
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    using Fortis.Model.RenderingParameters;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: ParametersTemplate_HasBackground</para>
    /// <para>ID: {a2a233a1-6701-48a9-b5f8-efeab74b655f}</para>
    /// <para>Path: /sitecore/templates/Foundation/Theming/ParametersTemplate_HasBackground</para>
    /// </summary>
    [TemplateMapping("{A2A233A1-6701-48A9-B5F8-EFEAB74B655F}", "InterfaceRenderingParameter")]
    public partial interface IParametersTemplateHasBackground : IRenderingParameterWrapper
    {
        /// <summary>
        /// <para>Template: ParametersTemplate_HasBackground</para>
        /// <para>Field: Background</para>
        /// <para>Data type: Droplink</para>
        /// </summary>
        ILinkFieldWrapper Background { get; }

        Guid BackgroundValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Theming/ParametersTemplate_HasBackground</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{A2A233A1-6701-48A9-B5F8-EFEAB74B655F}", typeof(Guid))]
    [TemplateMapping("{A2A233A1-6701-48A9-B5F8-EFEAB74B655F}", "RenderingParameter")]
    internal partial class ParametersTemplateHasBackgroundItem : CustomRenderingParameterWrapper, IParametersTemplateHasBackground
    {
        public ParametersTemplateHasBackgroundItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_HasBackground</para>
        /// <para>Field: Background</para>
        /// <para>Data type: Droplink</para>
        /// </summary>
        public virtual ILinkFieldWrapper Background
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Background", "droplink"); }
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_HasBackground</para>
        /// <para>Field: Background</para>
        /// <para>Data type: Droplink</para>
        /// </summary>
        public Guid BackgroundValue
        {
            [DebuggerStepThrough]
            get { return this.Background.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Theming/ParametersTemplate_HasBackground</para>
    /// <summary>
    public static class ParametersTemplateHasBackgroundConstants
    {
        public static readonly ID TemplateID = new ID("{A2A233A1-6701-48A9-B5F8-EFEAB74B655F}");
        public const string TemplateName = "ParametersTemplate_HasBackground";

        public struct Fields
        {
            public struct Background
            {
                public static readonly ID ID = new ID("{32439F83-C2FC-46E8-8981-5D1CDF1B2742}");
                public const string FieldName = "Background";
            }
        }
    }
    
}
#endregion

#region ParametersTemplate_HasContainer (/sitecore/templates/Foundation/Theming/ParametersTemplate_HasContainer)
namespace Foundation.Theming
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    using Fortis.Model.RenderingParameters;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: ParametersTemplate_HasContainer</para>
    /// <para>ID: {29299e73-6841-44c1-a65f-0889011e2eec}</para>
    /// <para>Path: /sitecore/templates/Foundation/Theming/ParametersTemplate_HasContainer</para>
    /// </summary>
    [TemplateMapping("{29299E73-6841-44C1-A65F-0889011E2EEC}", "InterfaceRenderingParameter")]
    public partial interface IParametersTemplateHasContainer : IRenderingParameterWrapper
    {
        /// <summary>
        /// <para>Template: ParametersTemplate_HasContainer</para>
        /// <para>Field: ContainerIsFluid</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        IBooleanFieldWrapper ContainerIsFluid { get; }

        bool ContainerIsFluidValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Theming/ParametersTemplate_HasContainer</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{29299E73-6841-44C1-A65F-0889011E2EEC}", typeof(Guid))]
    [TemplateMapping("{29299E73-6841-44C1-A65F-0889011E2EEC}", "RenderingParameter")]
    internal partial class ParametersTemplateHasContainerItem : CustomRenderingParameterWrapper, IParametersTemplateHasContainer
    {
        public ParametersTemplateHasContainerItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_HasContainer</para>
        /// <para>Field: ContainerIsFluid</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public virtual IBooleanFieldWrapper ContainerIsFluid
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.BooleanFieldWrapper)GetField("ContainerIsFluid", "checkbox"); }
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_HasContainer</para>
        /// <para>Field: ContainerIsFluid</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public bool ContainerIsFluidValue
        {
            [DebuggerStepThrough]
            get { return this.ContainerIsFluid.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Theming/ParametersTemplate_HasContainer</para>
    /// <summary>
    public static class ParametersTemplateHasContainerConstants
    {
        public static readonly ID TemplateID = new ID("{29299E73-6841-44C1-A65F-0889011E2EEC}");
        public const string TemplateName = "ParametersTemplate_HasContainer";

        public struct Fields
        {
            public struct ContainerIsFluid
            {
                public static readonly ID ID = new ID("{8F49D801-02B0-4DB7-90DB-5742D1662CF1}");
                public const string FieldName = "ContainerIsFluid";
            }
        }
    }
    
}
#endregion

#region ParametersTemplate_HasContainerWithBackground (/sitecore/templates/Foundation/Theming/ParametersTemplate_HasContainerWithBackground)
namespace Foundation.Theming
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    using Fortis.Model.RenderingParameters;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: ParametersTemplate_HasContainerWithBackground</para>
    /// <para>ID: {3ca3a190-897a-4ec9-8eb5-9de2c3636569}</para>
    /// <para>Path: /sitecore/templates/Foundation/Theming/ParametersTemplate_HasContainerWithBackground</para>
    /// </summary>
    [TemplateMapping("{3CA3A190-897A-4EC9-8EB5-9DE2C3636569}", "InterfaceRenderingParameter")]
    public partial interface IParametersTemplateHasContainerWithBackground : IRenderingParameterWrapper, Foundation.Theming.IParametersTemplateHasBackground, Foundation.Theming.IParametersTemplateHasContainer
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Theming/ParametersTemplate_HasContainerWithBackground</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{3CA3A190-897A-4EC9-8EB5-9DE2C3636569}", typeof(Guid))]
    [TemplateMapping("{3CA3A190-897A-4EC9-8EB5-9DE2C3636569}", "RenderingParameter")]
    internal partial class ParametersTemplateHasContainerWithBackgroundItem : CustomRenderingParameterWrapper, IParametersTemplateHasContainerWithBackground
    {
        public ParametersTemplateHasContainerWithBackgroundItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_HasContainerWithBackground</para>
        /// <para>Field: Background</para>
        /// <para>Data type: Droplink</para>
        /// </summary>
        public virtual ILinkFieldWrapper Background
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Background", "droplink"); }
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_HasContainerWithBackground</para>
        /// <para>Field: Background</para>
        /// <para>Data type: Droplink</para>
        /// </summary>
        public Guid BackgroundValue
        {
            [DebuggerStepThrough]
            get { return this.Background.Value; }
        }
        /// <summary>
        /// <para>Template: ParametersTemplate_HasContainerWithBackground</para>
        /// <para>Field: ContainerIsFluid</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public virtual IBooleanFieldWrapper ContainerIsFluid
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.BooleanFieldWrapper)GetField("ContainerIsFluid", "checkbox"); }
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_HasContainerWithBackground</para>
        /// <para>Field: ContainerIsFluid</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public bool ContainerIsFluidValue
        {
            [DebuggerStepThrough]
            get { return this.ContainerIsFluid.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Theming/ParametersTemplate_HasContainerWithBackground</para>
    /// <summary>
    public static class ParametersTemplateHasContainerWithBackgroundConstants
    {
        public static readonly ID TemplateID = new ID("{3CA3A190-897A-4EC9-8EB5-9DE2C3636569}");
        public const string TemplateName = "ParametersTemplate_HasContainerWithBackground";

        public struct Fields
        {
            public struct Background
            {
                public static readonly ID ID = new ID("{32439F83-C2FC-46E8-8981-5D1CDF1B2742}");
                public const string FieldName = "Background";
            }
            public struct ContainerIsFluid
            {
                public static readonly ID ID = new ID("{8F49D801-02B0-4DB7-90DB-5742D1662CF1}");
                public const string FieldName = "ContainerIsFluid";
            }
        }
    }
    
}
#endregion

#region Style (/sitecore/templates/Foundation/Theming/Style)
namespace Foundation.Theming
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Style</para>
    /// <para>ID: {c2ac5c42-a05c-4f51-854e-730c9bca06d1}</para>
    /// <para>Path: /sitecore/templates/Foundation/Theming/Style</para>
    /// </summary>
    [TemplateMapping("{C2AC5C42-A05C-4F51-854E-730C9BCA06D1}", "InterfaceMap")]
    public partial interface IStyle : ICustomItemWrapper
    {
        /// <summary>
        /// <para>Template: Style</para>
        /// <para>Field: Class</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("class")]
        ITextFieldWrapper Class { get; }

        /// <summary>
        /// <para>Template: Style</para>
        /// <para>Field: Class</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("class")]
        string ClassValue { get; }

    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Foundation/Theming/Style</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{C2AC5C42-A05C-4F51-854E-730C9BCA06D1}", typeof(Guid))]
    [TemplateMapping("{C2AC5C42-A05C-4F51-854E-730C9BCA06D1}", "")]
    internal partial class StyleItem : CustomItemWrapper, IStyle
    {
        private Item _item = null;
        public StyleItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public StyleItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public StyleItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public StyleItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Style</para>
        /// <para>Field: Class</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("class")]
        public virtual ITextFieldWrapper Class
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Class", "class"); }
        }

        /// <summary>
        /// <para>Template: Style</para>
        /// <para>Field: Class</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("class")]
        public string ClassValue
        {
            [DebuggerStepThrough]
            get { return this.Class.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Foundation/Theming/Style</para>
    /// <summary>
    public static class StyleConstants
    {
        public static readonly ID TemplateID = new ID("{C2AC5C42-A05C-4F51-854E-730C9BCA06D1}");
        public const string TemplateName = "Style";

        public struct Fields
        {
            public struct Class
            {
                public static readonly ID ID = new ID("{CF1E34B0-27E7-4861-BECD-C0BC58295F77}");
                public const string FieldName = "Class";
            }
        }
    }
    
}
#endregion

#region Demo Teaser (/sitecore/templates/Project/Common/Content Types/Demo Teaser)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Demo Teaser</para>
    /// <para>ID: {b4f6f114-e653-4a22-86c5-499e0bd99d9a}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Demo Teaser</para>
    /// </summary>
    [TemplateMapping("{B4F6F114-E653-4A22-86C5-499E0BD99D9A}", "InterfaceMap")]
    public partial interface IDemoTeaser : ICustomItemWrapper, Feature.Demo.IDemoContent
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Demo Teaser</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{B4F6F114-E653-4A22-86C5-499E0BD99D9A}", typeof(Guid))]
    [TemplateMapping("{B4F6F114-E653-4A22-86C5-499E0BD99D9A}", "")]
    internal partial class DemoTeaserItem : CustomItemWrapper, IDemoTeaser
    {
        private Item _item = null;
        public DemoTeaserItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public DemoTeaserItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public DemoTeaserItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public DemoTeaserItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Demo Teaser</para>
        /// <para>Field: HTMLContent</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("html_content")]
        public virtual ITextFieldWrapper HTMLContent
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("HTML Content", "html_content"); }
        }

        /// <summary>
        /// <para>Template: Demo Teaser</para>
        /// <para>Field: HTMLContent</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("html_content")]
        public string HTMLContentValue
        {
            [DebuggerStepThrough]
            get { return this.HTMLContent.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Demo Teaser</para>
    /// <summary>
    public static class DemoTeaserConstants
    {
        public static readonly ID TemplateID = new ID("{B4F6F114-E653-4A22-86C5-499E0BD99D9A}");
        public const string TemplateName = "Demo Teaser";

        public struct Fields
        {
            public struct HTMLContent
            {
                public static readonly ID ID = new ID("{0BC0AEDF-A6D0-4F74-933C-BD1779CD40B2}");
                public const string FieldName = "HTML Content";
            }
        }
    }
    
}
#endregion

#region Campaign Token (/sitecore/templates/Project/Common/Content Types/Demo Tokens/Campaign Token)
namespace Project.Common.ContentTypes.DemoTokens
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Campaign Token</para>
    /// <para>ID: {51b1726b-4290-4908-a2da-b169194ae80c}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Demo Tokens/Campaign Token</para>
    /// </summary>
    [TemplateMapping("{51B1726B-4290-4908-A2DA-B169194AE80C}", "InterfaceMap")]
    public partial interface ICampaignToken : ICustomItemWrapper, Feature.Demo.ICampaignToken, Feature.Demo.IToken
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Demo Tokens/Campaign Token</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{51B1726B-4290-4908-A2DA-B169194AE80C}", typeof(Guid))]
    [TemplateMapping("{51B1726B-4290-4908-A2DA-B169194AE80C}", "")]
    internal partial class CampaignTokenItem : CustomItemWrapper, ICampaignToken
    {
        private Item _item = null;
        public CampaignTokenItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public CampaignTokenItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public CampaignTokenItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public CampaignTokenItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Campaign Token</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("token_value")]
        public virtual ILinkFieldWrapper TokenValue
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Token Value", "token_value"); }
        }

        /// <summary>
        /// <para>Template: Campaign Token</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("token_value")]
        public Guid TokenValueValue
        {
            [DebuggerStepThrough]
            get { return this.TokenValue.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Demo Tokens/Campaign Token</para>
    /// <summary>
    public static class CampaignTokenConstants
    {
        public static readonly ID TemplateID = new ID("{51B1726B-4290-4908-A2DA-B169194AE80C}");
        public const string TemplateName = "Campaign Token";

        public struct Fields
        {
            public struct TokenValue
            {
                public static readonly ID ID = new ID("{3B485BD9-DEAE-4AAF-9C32-4106C4214162}");
                public const string FieldName = "Token Value";
            }
        }
    }
    
}
#endregion

#region Link Token (/sitecore/templates/Project/Common/Content Types/Demo Tokens/Link Token)
namespace Project.Common.ContentTypes.DemoTokens
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Link Token</para>
    /// <para>ID: {7defaa26-ed9d-4495-b5f0-0a7620403842}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Demo Tokens/Link Token</para>
    /// </summary>
    [TemplateMapping("{7DEFAA26-ED9D-4495-B5F0-0A7620403842}", "InterfaceMap")]
    public partial interface ILinkToken : ICustomItemWrapper, Feature.Demo.ILinkToken, Feature.Demo.IToken
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Demo Tokens/Link Token</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{7DEFAA26-ED9D-4495-B5F0-0A7620403842}", typeof(Guid))]
    [TemplateMapping("{7DEFAA26-ED9D-4495-B5F0-0A7620403842}", "")]
    internal partial class LinkTokenItem : CustomItemWrapper, ILinkToken
    {
        private Item _item = null;
        public LinkTokenItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public LinkTokenItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public LinkTokenItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public LinkTokenItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Link Token</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("token_value")]
        public virtual ICustomGeneralLinkFieldWrapper TokenValue
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("Token Value", "token_value"); }
        }

        /// <summary>
        /// <para>Template: Link Token</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("token_value")]
        public string TokenValueValue
        {
            [DebuggerStepThrough]
            get { return this.TokenValue.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Demo Tokens/Link Token</para>
    /// <summary>
    public static class LinkTokenConstants
    {
        public static readonly ID TemplateID = new ID("{7DEFAA26-ED9D-4495-B5F0-0A7620403842}");
        public const string TemplateName = "Link Token";

        public struct Fields
        {
            public struct TokenValue
            {
                public static readonly ID ID = new ID("{4A27A4AA-9201-4D1D-B612-F45DDA086C4C}");
                public const string FieldName = "Token Value";
            }
        }
    }
    
}
#endregion

#region Text Token (/sitecore/templates/Project/Common/Content Types/Demo Tokens/Text Token)
namespace Project.Common.ContentTypes.DemoTokens
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Text Token</para>
    /// <para>ID: {3f3cae5e-63d2-4f75-95d9-23eb01827aa9}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Demo Tokens/Text Token</para>
    /// </summary>
    [TemplateMapping("{3F3CAE5E-63D2-4F75-95D9-23EB01827AA9}", "InterfaceMap")]
    public partial interface ITextToken : ICustomItemWrapper, Feature.Demo.ITextToken, Feature.Demo.IToken
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Demo Tokens/Text Token</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{3F3CAE5E-63D2-4F75-95D9-23EB01827AA9}", typeof(Guid))]
    [TemplateMapping("{3F3CAE5E-63D2-4F75-95D9-23EB01827AA9}", "")]
    internal partial class TextTokenItem : CustomItemWrapper, ITextToken
    {
        private Item _item = null;
        public TextTokenItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public TextTokenItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public TextTokenItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public TextTokenItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Text Token</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("token_value")]
        public virtual ITextFieldWrapper TokenValue
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Token Value", "token_value"); }
        }

        /// <summary>
        /// <para>Template: Text Token</para>
        /// <para>Field: TokenValue</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("token_value")]
        public string TokenValueValue
        {
            [DebuggerStepThrough]
            get { return this.TokenValue.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Demo Tokens/Text Token</para>
    /// <summary>
    public static class TextTokenConstants
    {
        public static readonly ID TemplateID = new ID("{3F3CAE5E-63D2-4F75-95D9-23EB01827AA9}");
        public const string TemplateName = "Text Token";

        public struct Fields
        {
            public struct TokenValue
            {
                public static readonly ID ID = new ID("{7B9F4FE3-6285-4969-9784-B96D49973161}");
                public const string FieldName = "Token Value";
            }
        }
    }
    
}
#endregion

#region Employee Folder (/sitecore/templates/Project/Common/Content Types/Employee Folder)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Employee Folder</para>
    /// <para>ID: {f94f28f6-5b19-42f2-9164-1e21023e03ee}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Employee Folder</para>
    /// </summary>
    [TemplateMapping("{F94F28F6-5B19-42F2-9164-1E21023E03EE}", "InterfaceMap")]
    public partial interface IEmployeeFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Employee Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{F94F28F6-5B19-42F2-9164-1E21023E03EE}", typeof(Guid))]
    [TemplateMapping("{F94F28F6-5B19-42F2-9164-1E21023E03EE}", "")]
    internal partial class EmployeeFolderItem : CustomItemWrapper, IEmployeeFolder
    {
        private Item _item = null;
        public EmployeeFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public EmployeeFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public EmployeeFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public EmployeeFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Employee Folder</para>
    /// <summary>
    public static class EmployeeFolderConstants
    {
        public static readonly ID TemplateID = new ID("{F94F28F6-5B19-42F2-9164-1E21023E03EE}");
        public const string TemplateName = "Employee Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Employee (/sitecore/templates/Project/Common/Content Types/Employee)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Employee</para>
    /// <para>ID: {9671e92a-4ad3-46df-aff1-1542fd3d5bd9}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Employee</para>
    /// </summary>
    [TemplateMapping("{9671E92A-4AD3-46DF-AFF1-1542FD3D5BD9}", "InterfaceMap")]
    public partial interface IEmployee : ICustomItemWrapper, Feature.Person.IEmployee, Feature.Person.IPerson
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Employee</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{9671E92A-4AD3-46DF-AFF1-1542FD3D5BD9}", typeof(Guid))]
    [TemplateMapping("{9671E92A-4AD3-46DF-AFF1-1542FD3D5BD9}", "")]
    internal partial class EmployeeItem : CustomItemWrapper, IEmployee
    {
        private Item _item = null;
        public EmployeeItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public EmployeeItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public EmployeeItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public EmployeeItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Biography</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("biography")]
        public virtual IRichTextFieldWrapper Biography
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Biography", "biography"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Biography</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("biography")]
        public string BiographyValue
        {
            [DebuggerStepThrough]
            get { return this.Biography.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: BlogLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("bloglink")]
        public virtual ICustomGeneralLinkFieldWrapper BlogLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("BlogLink", "bloglink"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: BlogLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("bloglink")]
        public string BlogLinkValue
        {
            [DebuggerStepThrough]
            get { return this.BlogLink.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Email</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("email")]
        public virtual ITextFieldWrapper Email
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Email", "email"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Email</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("email")]
        public string EmailValue
        {
            [DebuggerStepThrough]
            get { return this.Email.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: FacebookLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("facebooklink")]
        public virtual ICustomGeneralLinkFieldWrapper FacebookLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("FacebookLink", "facebooklink"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: FacebookLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("facebooklink")]
        public string FacebookLinkValue
        {
            [DebuggerStepThrough]
            get { return this.FacebookLink.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: LinkedInLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("linkedinlink")]
        public virtual ICustomGeneralLinkFieldWrapper LinkedInLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("LinkedInLink", "linkedinlink"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: LinkedInLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("linkedinlink")]
        public string LinkedInLinkValue
        {
            [DebuggerStepThrough]
            get { return this.LinkedInLink.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Mobile</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mobile")]
        public virtual ITextFieldWrapper Mobile
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Mobile", "mobile"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Mobile</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mobile")]
        public string MobileValue
        {
            [DebuggerStepThrough]
            get { return this.Mobile.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public virtual ITextFieldWrapper Name
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Name", "name"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public string NameValue
        {
            [DebuggerStepThrough]
            get { return this.Name.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Picture</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Picture
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Picture"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Picture</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string PictureValue
        {
            [DebuggerStepThrough]
            get { return this.Picture.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual ITextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Telephone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("telephone")]
        public virtual ITextFieldWrapper Telephone
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Telephone", "telephone"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Telephone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("telephone")]
        public string TelephoneValue
        {
            [DebuggerStepThrough]
            get { return this.Telephone.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: TwitterLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterlink")]
        public virtual ICustomGeneralLinkFieldWrapper TwitterLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("TwitterLink", "twitterlink"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: TwitterLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterlink")]
        public string TwitterLinkValue
        {
            [DebuggerStepThrough]
            get { return this.TwitterLink.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Employee</para>
    /// <summary>
    public static class EmployeeConstants
    {
        public static readonly ID TemplateID = new ID("{9671E92A-4AD3-46DF-AFF1-1542FD3D5BD9}");
        public const string TemplateName = "Employee";

        public struct Fields
        {
            public struct Biography
            {
                public static readonly ID ID = new ID("{0CC9785E-54FE-4FAE-93E4-D0D2AE75F339}");
                public const string FieldName = "Biography";
            }
            public struct BlogLink
            {
                public static readonly ID ID = new ID("{69A846D9-4C7F-435C-A8DC-87E2D7359CFA}");
                public const string FieldName = "BlogLink";
            }
            public struct Email
            {
                public static readonly ID ID = new ID("{5978B330-1D46-4065-8751-F74BF17D815E}");
                public const string FieldName = "Email";
            }
            public struct FacebookLink
            {
                public static readonly ID ID = new ID("{D31889C0-E34C-4904-A6F3-F3D92D314AA9}");
                public const string FieldName = "FacebookLink";
            }
            public struct LinkedInLink
            {
                public static readonly ID ID = new ID("{2B13DFAB-3450-45EF-93F4-BEAA6F544FA6}");
                public const string FieldName = "LinkedInLink";
            }
            public struct Mobile
            {
                public static readonly ID ID = new ID("{25B4CEE3-A61A-4DC3-BB52-775DD509DBB5}");
                public const string FieldName = "Mobile";
            }
            public struct Name
            {
                public static readonly ID ID = new ID("{26CD59AB-3639-488F-BAFD-58D2B217755A}");
                public const string FieldName = "Name";
            }
            public struct Picture
            {
                public static readonly ID ID = new ID("{C9BAF3EB-8CFA-4BF6-9B19-51D38DB5FC38}");
                public const string FieldName = "Picture";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{B897023C-15D2-49F3-8974-06FA5FB7AD00}");
                public const string FieldName = "Summary";
            }
            public struct Telephone
            {
                public static readonly ID ID = new ID("{8D0E8EE3-21C4-4AE2-A2F1-53D3F3EBE501}");
                public const string FieldName = "Telephone";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{76972FCD-4BB0-4255-864E-077745EFDF50}");
                public const string FieldName = "Title";
            }
            public struct TwitterLink
            {
                public static readonly ID ID = new ID("{6DE98EF7-1209-40A3-A63E-16DBEF015211}");
                public const string FieldName = "TwitterLink";
            }
        }
    }
    
}
#endregion

#region FAQ Folder (/sitecore/templates/Project/Common/Content Types/FAQ Folder)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: FAQ Folder</para>
    /// <para>ID: {41da2d61-d85a-40f1-be69-ddd18dd1bc93}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/FAQ Folder</para>
    /// </summary>
    [TemplateMapping("{41DA2D61-D85A-40F1-BE69-DDD18DD1BC93}", "InterfaceMap")]
    public partial interface IFAQFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/FAQ Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{41DA2D61-D85A-40F1-BE69-DDD18DD1BC93}", typeof(Guid))]
    [TemplateMapping("{41DA2D61-D85A-40F1-BE69-DDD18DD1BC93}", "")]
    internal partial class FAQFolderItem : CustomItemWrapper, IFAQFolder
    {
        private Item _item = null;
        public FAQFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public FAQFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public FAQFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public FAQFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/FAQ Folder</para>
    /// <summary>
    public static class FAQFolderConstants
    {
        public static readonly ID TemplateID = new ID("{41DA2D61-D85A-40F1-BE69-DDD18DD1BC93}");
        public const string TemplateName = "FAQ Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region FAQ Group (/sitecore/templates/Project/Common/Content Types/FAQ Group)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: FAQ Group</para>
    /// <para>ID: {ba1eb1bd-e705-4be6-a432-06b7f1b2f2cc}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/FAQ Group</para>
    /// </summary>
    [TemplateMapping("{BA1EB1BD-E705-4BE6-A432-06B7F1B2F2CC}", "InterfaceMap")]
    public partial interface IFAQGroup : ICustomItemWrapper, Feature.FAQ.IFAQGroup
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/FAQ Group</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{BA1EB1BD-E705-4BE6-A432-06B7F1B2F2CC}", typeof(Guid))]
    [TemplateMapping("{BA1EB1BD-E705-4BE6-A432-06B7F1B2F2CC}", "")]
    internal partial class FAQGroupItem : CustomItemWrapper, IFAQGroup
    {
        private Item _item = null;
        public FAQGroupItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public FAQGroupItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public FAQGroupItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public FAQGroupItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: FAQ Group</para>
        /// <para>Field: GroupMember</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("group_member")]
        public virtual IListFieldWrapper GroupMember
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("Group Member", "group_member"); }
        }

        /// <summary>
        /// <para>Template: FAQ Group</para>
        /// <para>Field: GroupMember</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("group_member")]
        public IEnumerable<Guid> GroupMemberValue
        {
            [DebuggerStepThrough]
            get { return this.GroupMember.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/FAQ Group</para>
    /// <summary>
    public static class FAQGroupConstants
    {
        public static readonly ID TemplateID = new ID("{BA1EB1BD-E705-4BE6-A432-06B7F1B2F2CC}");
        public const string TemplateName = "FAQ Group";

        public struct Fields
        {
            public struct GroupMember
            {
                public static readonly ID ID = new ID("{631DA648-E2A5-4E3B-9733-C9C066C41EAE}");
                public const string FieldName = "Group Member";
            }
        }
    }
    
}
#endregion

#region FAQ (/sitecore/templates/Project/Common/Content Types/FAQ)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: FAQ</para>
    /// <para>ID: {bfdc1f27-3d2d-495f-89a3-0951f882420b}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/FAQ</para>
    /// </summary>
    [TemplateMapping("{BFDC1F27-3D2D-495F-89A3-0951F882420B}", "InterfaceMap")]
    public partial interface IFAQ : ICustomItemWrapper, Feature.FAQ.IFAQ
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/FAQ</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{BFDC1F27-3D2D-495F-89A3-0951F882420B}", typeof(Guid))]
    [TemplateMapping("{BFDC1F27-3D2D-495F-89A3-0951F882420B}", "")]
    internal partial class FAQItem : CustomItemWrapper, IFAQ
    {
        private Item _item = null;
        public FAQItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public FAQItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public FAQItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public FAQItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: FAQ</para>
        /// <para>Field: Answer</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("answer")]
        public virtual IRichTextFieldWrapper Answer
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Answer", "answer"); }
        }

        /// <summary>
        /// <para>Template: FAQ</para>
        /// <para>Field: Answer</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("answer")]
        public string AnswerValue
        {
            [DebuggerStepThrough]
            get { return this.Answer.Value; }
        }
        /// <summary>
        /// <para>Template: FAQ</para>
        /// <para>Field: Question</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("question")]
        public virtual ITextFieldWrapper Question
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Question", "question"); }
        }

        /// <summary>
        /// <para>Template: FAQ</para>
        /// <para>Field: Question</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("question")]
        public string QuestionValue
        {
            [DebuggerStepThrough]
            get { return this.Question.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/FAQ</para>
    /// <summary>
    public static class FAQConstants
    {
        public static readonly ID TemplateID = new ID("{BFDC1F27-3D2D-495F-89A3-0951F882420B}");
        public const string TemplateName = "FAQ";

        public struct Fields
        {
            public struct Answer
            {
                public static readonly ID ID = new ID("{57F39C75-51F0-4888-903E-724DFDCC8A38}");
                public const string FieldName = "Answer";
            }
            public struct Question
            {
                public static readonly ID ID = new ID("{9588B6D5-3E6A-4C16-BD37-98DA6F1DDE52}");
                public const string FieldName = "Question";
            }
        }
    }
    
}
#endregion

#region Global Folder (/sitecore/templates/Project/Common/Content Types/Global Folder)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Global Folder</para>
    /// <para>ID: {fd075cbc-572e-4d27-a09f-b780e8ff4741}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Global Folder</para>
    /// </summary>
    [TemplateMapping("{FD075CBC-572E-4D27-A09F-B780E8FF4741}", "InterfaceMap")]
    public partial interface IGlobalFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Global Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{FD075CBC-572E-4D27-A09F-B780E8FF4741}", typeof(Guid))]
    [TemplateMapping("{FD075CBC-572E-4D27-A09F-B780E8FF4741}", "")]
    internal partial class GlobalFolderItem : CustomItemWrapper, IGlobalFolder
    {
        private Item _item = null;
        public GlobalFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public GlobalFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public GlobalFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public GlobalFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Global Folder</para>
    /// <summary>
    public static class GlobalFolderConstants
    {
        public static readonly ID TemplateID = new ID("{FD075CBC-572E-4D27-A09F-B780E8FF4741}");
        public const string TemplateName = "Global Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Interest (/sitecore/templates/Project/Common/Content Types/Interest)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Interest</para>
    /// <para>ID: {4176bfc2-7814-4fa5-abcf-7fa0714bf05f}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Interest</para>
    /// </summary>
    [TemplateMapping("{4176BFC2-7814-4FA5-ABCF-7FA0714BF05F}", "InterfaceMap")]
    public partial interface IInterest : ICustomItemWrapper, Feature.Accounts.IInterest
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Interest</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{4176BFC2-7814-4FA5-ABCF-7FA0714BF05F}", typeof(Guid))]
    [TemplateMapping("{4176BFC2-7814-4FA5-ABCF-7FA0714BF05F}", "")]
    internal partial class InterestItem : CustomItemWrapper, IInterest
    {
        private Item _item = null;
        public InterestItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public InterestItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public InterestItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public InterestItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Interest</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Interest</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Interest</para>
    /// <summary>
    public static class InterestConstants
    {
        public static readonly ID TemplateID = new ID("{4176BFC2-7814-4FA5-ABCF-7FA0714BF05F}");
        public const string TemplateName = "Interest";

        public struct Fields
        {
            public struct Title
            {
                public static readonly ID ID = new ID("{1FBE5200-2C62-4A32-BA84-CFFE3CF665D3}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region Interests Folder (/sitecore/templates/Project/Common/Content Types/Interests Folder)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Interests Folder</para>
    /// <para>ID: {0db13819-7df3-4136-a4b9-0a22b1023ef7}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Interests Folder</para>
    /// </summary>
    [TemplateMapping("{0DB13819-7DF3-4136-A4B9-0A22B1023EF7}", "InterfaceMap")]
    public partial interface IInterestsFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Interests Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{0DB13819-7DF3-4136-A4B9-0A22B1023EF7}", typeof(Guid))]
    [TemplateMapping("{0DB13819-7DF3-4136-A4B9-0A22B1023EF7}", "")]
    internal partial class InterestsFolderItem : CustomItemWrapper, IInterestsFolder
    {
        private Item _item = null;
        public InterestsFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public InterestsFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public InterestsFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public InterestsFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Interests Folder</para>
    /// <summary>
    public static class InterestsFolderConstants
    {
        public static readonly ID TemplateID = new ID("{0DB13819-7DF3-4136-A4B9-0A22B1023EF7}");
        public const string TemplateName = "Interests Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Link Menu Item (/sitecore/templates/Project/Common/Content Types/Link Menu Item)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Link Menu Item</para>
    /// <para>ID: {390333c8-751b-4332-84a3-6360b969a19f}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Link Menu Item</para>
    /// </summary>
    [TemplateMapping("{390333C8-751B-4332-84A3-6360B969A19F}", "InterfaceMap")]
    public partial interface ILinkMenuItem : ICustomItemWrapper, Feature.Navigation.ILink, Feature.Navigation.ILinkMenuItem, Feature.Navigation.INavigable
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Link Menu Item</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{390333C8-751B-4332-84A3-6360B969A19F}", typeof(Guid))]
    [TemplateMapping("{390333C8-751B-4332-84A3-6360B969A19F}", "")]
    internal partial class LinkMenuItemItem : CustomItemWrapper, ILinkMenuItem
    {
        private Item _item = null;
        public LinkMenuItemItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public LinkMenuItemItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public LinkMenuItemItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public LinkMenuItemItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Link Menu Item</para>
        /// <para>Field: DividerBefore</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("dividerbefore")]
        public virtual IBooleanFieldWrapper DividerBefore
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("DividerBefore", "dividerbefore"); }
        }

        /// <summary>
        /// <para>Template: Link Menu Item</para>
        /// <para>Field: DividerBefore</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("dividerbefore")]
        public bool DividerBeforeValue
        {
            [DebuggerStepThrough]
            get { return this.DividerBefore.Value; }
        }
        /// <summary>
        /// <para>Template: Link Menu Item</para>
        /// <para>Field: Icon</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("icon")]
        public virtual ITextFieldWrapper Icon
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Icon", "icon"); }
        }

        /// <summary>
        /// <para>Template: Link Menu Item</para>
        /// <para>Field: Icon</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("icon")]
        public string IconValue
        {
            [DebuggerStepThrough]
            get { return this.Icon.Value; }
        }
        /// <summary>
        /// <para>Template: Link Menu Item</para>
        /// <para>Field: Link</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("link")]
        public virtual ICustomGeneralLinkFieldWrapper Link
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("Link", "link"); }
        }

        /// <summary>
        /// <para>Template: Link Menu Item</para>
        /// <para>Field: Link</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("link")]
        public string LinkValue
        {
            [DebuggerStepThrough]
            get { return this.Link.Value; }
        }
        /// <summary>
        /// <para>Template: Link Menu Item</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: Link Menu Item</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Link Menu Item</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: Link Menu Item</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: Link Menu Item</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: Link Menu Item</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Link Menu Item</para>
    /// <summary>
    public static class LinkMenuItemConstants
    {
        public static readonly ID TemplateID = new ID("{390333C8-751B-4332-84A3-6360B969A19F}");
        public const string TemplateName = "Link Menu Item";

        public struct Fields
        {
            public struct DividerBefore
            {
                public static readonly ID ID = new ID("{4231CD60-47C1-42AD-B838-0A6F8F1C4CFB}");
                public const string FieldName = "DividerBefore";
            }
            public struct Icon
            {
                public static readonly ID ID = new ID("{2C24649E-4460-4114-B026-886CFBE1A96D}");
                public const string FieldName = "Icon";
            }
            public struct Link
            {
                public static readonly ID ID = new ID("{FE71C30E-F07D-4052-8594-C3028CD76E1F}");
                public const string FieldName = "Link";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
        }
    }
    
}
#endregion

#region Link Menu (/sitecore/templates/Project/Common/Content Types/Link Menu)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Link Menu</para>
    /// <para>ID: {ac7394d5-2aa7-4fdb-a7d8-b1b87f9fa661}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Link Menu</para>
    /// </summary>
    [TemplateMapping("{AC7394D5-2AA7-4FDB-A7D8-B1B87F9FA661}", "InterfaceMap")]
    public partial interface ILinkMenu : ICustomItemWrapper, Feature.Navigation.INavigationRoot
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Link Menu</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{AC7394D5-2AA7-4FDB-A7D8-B1B87F9FA661}", typeof(Guid))]
    [TemplateMapping("{AC7394D5-2AA7-4FDB-A7D8-B1B87F9FA661}", "")]
    internal partial class LinkMenuItem : CustomItemWrapper, ILinkMenu
    {
        private Item _item = null;
        public LinkMenuItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public LinkMenuItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public LinkMenuItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public LinkMenuItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Link Menu</para>
    /// <summary>
    public static class LinkMenuConstants
    {
        public static readonly ID TemplateID = new ID("{AC7394D5-2AA7-4FDB-A7D8-B1B87F9FA661}");
        public const string TemplateName = "Link Menu";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Login Teaser (/sitecore/templates/Project/Common/Content Types/Login Teaser)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Login Teaser</para>
    /// <para>ID: {6e686b1c-1675-4263-af03-dce07827afdd}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Login Teaser</para>
    /// </summary>
    [TemplateMapping("{6E686B1C-1675-4263-AF03-DCE07827AFDD}", "InterfaceMap")]
    public partial interface ILoginTeaser : ICustomItemWrapper, Feature.Accounts.ILoginTeaser
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Login Teaser</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{6E686B1C-1675-4263-AF03-DCE07827AFDD}", typeof(Guid))]
    [TemplateMapping("{6E686B1C-1675-4263-AF03-DCE07827AFDD}", "")]
    internal partial class LoginTeaserItem : CustomItemWrapper, ILoginTeaser
    {
        private Item _item = null;
        public LoginTeaserItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public LoginTeaserItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public LoginTeaserItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public LoginTeaserItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Login Teaser</para>
        /// <para>Field: LoggedInSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("logged_in_summary")]
        public virtual ITextFieldWrapper LoggedInSummary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Logged In Summary", "logged_in_summary"); }
        }

        /// <summary>
        /// <para>Template: Login Teaser</para>
        /// <para>Field: LoggedInSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("logged_in_summary")]
        public string LoggedInSummaryValue
        {
            [DebuggerStepThrough]
            get { return this.LoggedInSummary.Value; }
        }
        /// <summary>
        /// <para>Template: Login Teaser</para>
        /// <para>Field: LoggedInTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("logged_in_title")]
        public virtual ITextFieldWrapper LoggedInTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Logged In Title", "logged_in_title"); }
        }

        /// <summary>
        /// <para>Template: Login Teaser</para>
        /// <para>Field: LoggedInTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("logged_in_title")]
        public string LoggedInTitleValue
        {
            [DebuggerStepThrough]
            get { return this.LoggedInTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Login Teaser</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual ITextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: Login Teaser</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: Login Teaser</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Login Teaser</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Login Teaser</para>
    /// <summary>
    public static class LoginTeaserConstants
    {
        public static readonly ID TemplateID = new ID("{6E686B1C-1675-4263-AF03-DCE07827AFDD}");
        public const string TemplateName = "Login Teaser";

        public struct Fields
        {
            public struct LoggedInSummary
            {
                public static readonly ID ID = new ID("{76183BC1-755C-428B-A35A-1425309990BE}");
                public const string FieldName = "Logged In Summary";
            }
            public struct LoggedInTitle
            {
                public static readonly ID ID = new ID("{39AABCF6-426C-4AD1-8B3D-A5135F219455}");
                public const string FieldName = "Logged In Title";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{FFAB401B-8D7C-4172-A82A-AE32B7D2C6C1}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{D9843186-ED10-47D8-8CC7-511AC670B6B4}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region Map Point (/sitecore/templates/Project/Common/Content Types/Map Point)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Map Point</para>
    /// <para>ID: {11c28d16-9b88-456e-a42b-d4b5a82867e3}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Map Point</para>
    /// </summary>
    [TemplateMapping("{11C28D16-9B88-456E-A42B-D4B5A82867E3}", "InterfaceMap")]
    public partial interface IMapPoint : ICustomItemWrapper, Feature.Maps.IMapPoint
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Map Point</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{11C28D16-9B88-456E-A42B-D4B5A82867E3}", typeof(Guid))]
    [TemplateMapping("{11C28D16-9B88-456E-A42B-D4B5A82867E3}", "")]
    internal partial class MapPointItem : CustomItemWrapper, IMapPoint
    {
        private Item _item = null;
        public MapPointItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public MapPointItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public MapPointItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public MapPointItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Map Point</para>
        /// <para>Field: MapPointAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("mappointaddress")]
        public virtual ITextFieldWrapper MapPointAddress
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MapPointAddress", "mappointaddress"); }
        }

        /// <summary>
        /// <para>Template: Map Point</para>
        /// <para>Field: MapPointAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("mappointaddress")]
        public string MapPointAddressValue
        {
            [DebuggerStepThrough]
            get { return this.MapPointAddress.Value; }
        }
        /// <summary>
        /// <para>Template: Map Point</para>
        /// <para>Field: MapPointLocation</para>
        /// <para>Data type: Map Field</para>
        /// </summary>
        public virtual ITextFieldWrapper MapPointLocation
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MapPointLocation"); }
        }

        /// <summary>
        /// <para>Template: Map Point</para>
        /// <para>Field: MapPointLocation</para>
        /// <para>Data type: Map Field</para>
        /// </summary>
        public string MapPointLocationValue
        {
            [DebuggerStepThrough]
            get { return this.MapPointLocation.Value; }
        }
        /// <summary>
        /// <para>Template: Map Point</para>
        /// <para>Field: MapPointName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mappointname")]
        public virtual ITextFieldWrapper MapPointName
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MapPointName", "mappointname"); }
        }

        /// <summary>
        /// <para>Template: Map Point</para>
        /// <para>Field: MapPointName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mappointname")]
        public string MapPointNameValue
        {
            [DebuggerStepThrough]
            get { return this.MapPointName.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Map Point</para>
    /// <summary>
    public static class MapPointConstants
    {
        public static readonly ID TemplateID = new ID("{11C28D16-9B88-456E-A42B-D4B5A82867E3}");
        public const string TemplateName = "Map Point";

        public struct Fields
        {
            public struct MapPointAddress
            {
                public static readonly ID ID = new ID("{0295C01D-214C-4C23-AFC2-3F0B4E88B643}");
                public const string FieldName = "MapPointAddress";
            }
            public struct MapPointLocation
            {
                public static readonly ID ID = new ID("{F686AC8E-1D33-45DB-8E1A-1B40CD491E7A}");
                public const string FieldName = "MapPointLocation";
            }
            public struct MapPointName
            {
                public static readonly ID ID = new ID("{F12C22BB-E57D-4FAB-96E1-1229E4E7FF0E}");
                public const string FieldName = "MapPointName";
            }
        }
    }
    
}
#endregion

#region Map Points Folder (/sitecore/templates/Project/Common/Content Types/Map Points Folder)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Map Points Folder</para>
    /// <para>ID: {067ec866-b3fb-485b-bb49-6151fb086e78}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Map Points Folder</para>
    /// </summary>
    [TemplateMapping("{067EC866-B3FB-485B-BB49-6151FB086E78}", "InterfaceMap")]
    public partial interface IMapPointsFolder : ICustomItemWrapper, Feature.Maps.IMapPointsFolder
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Map Points Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{067EC866-B3FB-485B-BB49-6151FB086E78}", typeof(Guid))]
    [TemplateMapping("{067EC866-B3FB-485B-BB49-6151FB086E78}", "")]
    internal partial class MapPointsFolderItem : CustomItemWrapper, IMapPointsFolder
    {
        private Item _item = null;
        public MapPointsFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public MapPointsFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public MapPointsFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public MapPointsFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Map Points Folder</para>
    /// <summary>
    public static class MapPointsFolderConstants
    {
        public static readonly ID TemplateID = new ID("{067EC866-B3FB-485B-BB49-6151FB086E78}");
        public const string TemplateName = "Map Points Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Carousel (/sitecore/templates/Project/Common/Content Types/Media/Carousel)
namespace Project.Common.ContentTypes.Media
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Carousel</para>
    /// <para>ID: {c18d3794-d126-4548-bfc8-89358de6e9c1}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Media/Carousel</para>
    /// </summary>
    [TemplateMapping("{C18D3794-D126-4548-BFC8-89358DE6E9C1}", "InterfaceMap")]
    public partial interface ICarousel : ICustomItemWrapper, Feature.Media.IHasMediaSelector
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Media/Carousel</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{C18D3794-D126-4548-BFC8-89358DE6E9C1}", typeof(Guid))]
    [TemplateMapping("{C18D3794-D126-4548-BFC8-89358DE6E9C1}", "")]
    internal partial class CarouselItem : CustomItemWrapper, ICarousel
    {
        private Item _item = null;
        public CarouselItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public CarouselItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public CarouselItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public CarouselItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Carousel</para>
        /// <para>Field: MediaSelector</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("mediaselector")]
        public virtual IListFieldWrapper MediaSelector
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MediaSelector", "mediaselector"); }
        }

        /// <summary>
        /// <para>Template: Carousel</para>
        /// <para>Field: MediaSelector</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("mediaselector")]
        public IEnumerable<Guid> MediaSelectorValue
        {
            [DebuggerStepThrough]
            get { return this.MediaSelector.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Media/Carousel</para>
    /// <summary>
    public static class CarouselConstants
    {
        public static readonly ID TemplateID = new ID("{C18D3794-D126-4548-BFC8-89358DE6E9C1}");
        public const string TemplateName = "Carousel";

        public struct Fields
        {
            public struct MediaSelector
            {
                public static readonly ID ID = new ID("{72EA8682-24D2-4BEB-951C-3E2164974105}");
                public const string FieldName = "MediaSelector";
            }
        }
    }
    
}
#endregion

#region Image (/sitecore/templates/Project/Common/Content Types/Media/Image)
namespace Project.Common.ContentTypes.Media
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Image</para>
    /// <para>ID: {f0369e1a-9030-4a05-a09c-ef09b664ed27}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Media/Image</para>
    /// </summary>
    [TemplateMapping("{F0369E1A-9030-4A05-A09C-EF09B664ED27}", "InterfaceMap")]
    public partial interface IImage : ICustomItemWrapper, Feature.Media.IHasMedia, Feature.Media.IHasMediaImage
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Media/Image</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{F0369E1A-9030-4A05-A09C-EF09B664ED27}", typeof(Guid))]
    [TemplateMapping("{F0369E1A-9030-4A05-A09C-EF09B664ED27}", "")]
    internal partial class ImageItem : CustomItemWrapper, IImage
    {
        private Item _item = null;
        public ImageItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public ImageItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public ImageItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public ImageItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Image</para>
        /// <para>Field: MediaDescription</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("mediadescription")]
        public virtual IRichTextFieldWrapper MediaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("MediaDescription", "mediadescription"); }
        }

        /// <summary>
        /// <para>Template: Image</para>
        /// <para>Field: MediaDescription</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("mediadescription")]
        public string MediaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MediaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Image</para>
        /// <para>Field: MediaImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper MediaImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("MediaImage"); }
        }

        /// <summary>
        /// <para>Template: Image</para>
        /// <para>Field: MediaImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string MediaImageValue
        {
            [DebuggerStepThrough]
            get { return this.MediaImage.Value; }
        }
        /// <summary>
        /// <para>Template: Image</para>
        /// <para>Field: MediaThumbnail</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper MediaThumbnail
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("MediaThumbnail"); }
        }

        /// <summary>
        /// <para>Template: Image</para>
        /// <para>Field: MediaThumbnail</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string MediaThumbnailValue
        {
            [DebuggerStepThrough]
            get { return this.MediaThumbnail.Value; }
        }
        /// <summary>
        /// <para>Template: Image</para>
        /// <para>Field: MediaTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mediatitle")]
        public virtual ITextFieldWrapper MediaTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MediaTitle", "mediatitle"); }
        }

        /// <summary>
        /// <para>Template: Image</para>
        /// <para>Field: MediaTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mediatitle")]
        public string MediaTitleValue
        {
            [DebuggerStepThrough]
            get { return this.MediaTitle.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Media/Image</para>
    /// <summary>
    public static class ImageConstants
    {
        public static readonly ID TemplateID = new ID("{F0369E1A-9030-4A05-A09C-EF09B664ED27}");
        public const string TemplateName = "Image";

        public struct Fields
        {
            public struct MediaDescription
            {
                public static readonly ID ID = new ID("{302C9F8D-F703-4F76-A4AB-73D222648232}");
                public const string FieldName = "MediaDescription";
            }
            public struct MediaImage
            {
                public static readonly ID ID = new ID("{9F51DEAD-AD6E-41C2-9759-7BE17EB474A4}");
                public const string FieldName = "MediaImage";
            }
            public struct MediaThumbnail
            {
                public static readonly ID ID = new ID("{4FF62B0A-D73B-4436-BEA2-023154F2FFC4}");
                public const string FieldName = "MediaThumbnail";
            }
            public struct MediaTitle
            {
                public static readonly ID ID = new ID("{63DDA48B-B0CB-45A7-9A1B-B26DDB41009B}");
                public const string FieldName = "MediaTitle";
            }
        }
    }
    
}
#endregion

#region Media Background Folder (/sitecore/templates/Project/Common/Content Types/Media/Media Background Folder)
namespace Project.Common.ContentTypes.Media
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Media Background Folder</para>
    /// <para>ID: {82a6f39c-53e1-4eca-8c27-69937cff3b47}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Media/Media Background Folder</para>
    /// </summary>
    [TemplateMapping("{82A6F39C-53E1-4ECA-8C27-69937CFF3B47}", "InterfaceMap")]
    public partial interface IMediaBackgroundFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Media/Media Background Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{82A6F39C-53E1-4ECA-8C27-69937CFF3B47}", typeof(Guid))]
    [TemplateMapping("{82A6F39C-53E1-4ECA-8C27-69937CFF3B47}", "")]
    internal partial class MediaBackgroundFolderItem : CustomItemWrapper, IMediaBackgroundFolder
    {
        private Item _item = null;
        public MediaBackgroundFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public MediaBackgroundFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public MediaBackgroundFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public MediaBackgroundFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Media/Media Background Folder</para>
    /// <summary>
    public static class MediaBackgroundFolderConstants
    {
        public static readonly ID TemplateID = new ID("{82A6F39C-53E1-4ECA-8C27-69937CFF3B47}");
        public const string TemplateName = "Media Background Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Media Background (/sitecore/templates/Project/Common/Content Types/Media/Media Background)
namespace Project.Common.ContentTypes.Media
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Media Background</para>
    /// <para>ID: {42a10c41-5186-4a1e-aa7e-54ea00199c3f}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Media/Media Background</para>
    /// </summary>
    [TemplateMapping("{42A10C41-5186-4A1E-AA7E-54EA00199C3F}", "InterfaceMap")]
    public partial interface IMediaBackground : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Media/Media Background</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{42A10C41-5186-4A1E-AA7E-54EA00199C3F}", typeof(Guid))]
    [TemplateMapping("{42A10C41-5186-4A1E-AA7E-54EA00199C3F}", "")]
    internal partial class MediaBackgroundItem : CustomItemWrapper, IMediaBackground
    {
        private Item _item = null;
        public MediaBackgroundItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public MediaBackgroundItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public MediaBackgroundItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public MediaBackgroundItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Media/Media Background</para>
    /// <summary>
    public static class MediaBackgroundConstants
    {
        public static readonly ID TemplateID = new ID("{42A10C41-5186-4A1E-AA7E-54EA00199C3F}");
        public const string TemplateName = "Media Background";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Media Folder (/sitecore/templates/Project/Common/Content Types/Media/Media Folder)
namespace Project.Common.ContentTypes.Media
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Media Folder</para>
    /// <para>ID: {920a1781-559f-4e1c-bb2e-6b9a2113fe6b}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Media/Media Folder</para>
    /// </summary>
    [TemplateMapping("{920A1781-559F-4E1C-BB2E-6B9A2113FE6B}", "InterfaceMap")]
    public partial interface IMediaFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Media/Media Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{920A1781-559F-4E1C-BB2E-6B9A2113FE6B}", typeof(Guid))]
    [TemplateMapping("{920A1781-559F-4E1C-BB2E-6B9A2113FE6B}", "")]
    internal partial class MediaFolderItem : CustomItemWrapper, IMediaFolder
    {
        private Item _item = null;
        public MediaFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public MediaFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public MediaFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public MediaFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Media/Media Folder</para>
    /// <summary>
    public static class MediaFolderConstants
    {
        public static readonly ID TemplateID = new ID("{920A1781-559F-4E1C-BB2E-6B9A2113FE6B}");
        public const string TemplateName = "Media Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Video (/sitecore/templates/Project/Common/Content Types/Media/Video)
namespace Project.Common.ContentTypes.Media
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Video</para>
    /// <para>ID: {f1c095e2-b3e0-46d0-b838-02a9e8b880d9}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Media/Video</para>
    /// </summary>
    [TemplateMapping("{F1C095E2-B3E0-46D0-B838-02A9E8B880D9}", "InterfaceMap")]
    public partial interface IVideo : ICustomItemWrapper, Feature.Media.IHasMedia, Feature.Media.IHasMediaVideo
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Media/Video</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{F1C095E2-B3E0-46D0-B838-02A9E8B880D9}", typeof(Guid))]
    [TemplateMapping("{F1C095E2-B3E0-46D0-B838-02A9E8B880D9}", "")]
    internal partial class VideoItem : CustomItemWrapper, IVideo
    {
        private Item _item = null;
        public VideoItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public VideoItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public VideoItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public VideoItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Video</para>
        /// <para>Field: MediaDescription</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("mediadescription")]
        public virtual IRichTextFieldWrapper MediaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("MediaDescription", "mediadescription"); }
        }

        /// <summary>
        /// <para>Template: Video</para>
        /// <para>Field: MediaDescription</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("mediadescription")]
        public string MediaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MediaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Video</para>
        /// <para>Field: MediaThumbnail</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper MediaThumbnail
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("MediaThumbnail"); }
        }

        /// <summary>
        /// <para>Template: Video</para>
        /// <para>Field: MediaThumbnail</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string MediaThumbnailValue
        {
            [DebuggerStepThrough]
            get { return this.MediaThumbnail.Value; }
        }
        /// <summary>
        /// <para>Template: Video</para>
        /// <para>Field: MediaTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mediatitle")]
        public virtual ITextFieldWrapper MediaTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MediaTitle", "mediatitle"); }
        }

        /// <summary>
        /// <para>Template: Video</para>
        /// <para>Field: MediaTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mediatitle")]
        public string MediaTitleValue
        {
            [DebuggerStepThrough]
            get { return this.MediaTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Video</para>
        /// <para>Field: MediaVideoLink</para>
        /// <para>Data type: link</para>
        /// </summary>
        public virtual ICustomGeneralLinkFieldWrapper MediaVideoLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("MediaVideoLink"); }
        }

        /// <summary>
        /// <para>Template: Video</para>
        /// <para>Field: MediaVideoLink</para>
        /// <para>Data type: link</para>
        /// </summary>
        public string MediaVideoLinkValue
        {
            [DebuggerStepThrough]
            get { return this.MediaVideoLink.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Media/Video</para>
    /// <summary>
    public static class VideoConstants
    {
        public static readonly ID TemplateID = new ID("{F1C095E2-B3E0-46D0-B838-02A9E8B880D9}");
        public const string TemplateName = "Video";

        public struct Fields
        {
            public struct MediaDescription
            {
                public static readonly ID ID = new ID("{302C9F8D-F703-4F76-A4AB-73D222648232}");
                public const string FieldName = "MediaDescription";
            }
            public struct MediaThumbnail
            {
                public static readonly ID ID = new ID("{4FF62B0A-D73B-4436-BEA2-023154F2FFC4}");
                public const string FieldName = "MediaThumbnail";
            }
            public struct MediaTitle
            {
                public static readonly ID ID = new ID("{63DDA48B-B0CB-45A7-9A1B-B26DDB41009B}");
                public const string FieldName = "MediaTitle";
            }
            public struct MediaVideoLink
            {
                public static readonly ID ID = new ID("{2628705D-9434-4448-978C-C3BF166FA1EB}");
                public const string FieldName = "MediaVideoLink";
            }
        }
    }
    
}
#endregion

#region MetaKeyword Folder (/sitecore/templates/Project/Common/Content Types/MetaKeyword Folder)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: MetaKeyword Folder</para>
    /// <para>ID: {cd047791-c29a-4596-aeee-db5e70421c1f}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/MetaKeyword Folder</para>
    /// </summary>
    [TemplateMapping("{CD047791-C29A-4596-AEEE-DB5E70421C1F}", "InterfaceMap")]
    public partial interface IMetaKeywordFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/MetaKeyword Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{CD047791-C29A-4596-AEEE-DB5E70421C1F}", typeof(Guid))]
    [TemplateMapping("{CD047791-C29A-4596-AEEE-DB5E70421C1F}", "")]
    internal partial class MetaKeywordFolderItem : CustomItemWrapper, IMetaKeywordFolder
    {
        private Item _item = null;
        public MetaKeywordFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public MetaKeywordFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public MetaKeywordFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public MetaKeywordFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/MetaKeyword Folder</para>
    /// <summary>
    public static class MetaKeywordFolderConstants
    {
        public static readonly ID TemplateID = new ID("{CD047791-C29A-4596-AEEE-DB5E70421C1F}");
        public const string TemplateName = "MetaKeyword Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region MetaKeyword (/sitecore/templates/Project/Common/Content Types/MetaKeyword)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: MetaKeyword</para>
    /// <para>ID: {18cdd4ce-cdbe-4bdc-9d5a-6249f7f0ec17}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/MetaKeyword</para>
    /// </summary>
    [TemplateMapping("{18CDD4CE-CDBE-4BDC-9D5A-6249F7F0EC17}", "InterfaceMap")]
    public partial interface IMetaKeyword : ICustomItemWrapper, Feature.Metadata.IKeyword
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/MetaKeyword</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{18CDD4CE-CDBE-4BDC-9D5A-6249F7F0EC17}", typeof(Guid))]
    [TemplateMapping("{18CDD4CE-CDBE-4BDC-9D5A-6249F7F0EC17}", "")]
    internal partial class MetaKeywordItem : CustomItemWrapper, IMetaKeyword
    {
        private Item _item = null;
        public MetaKeywordItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public MetaKeywordItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public MetaKeywordItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public MetaKeywordItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: MetaKeyword</para>
        /// <para>Field: Keyword</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("keyword")]
        public virtual ITextFieldWrapper Keyword
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Keyword", "keyword"); }
        }

        /// <summary>
        /// <para>Template: MetaKeyword</para>
        /// <para>Field: Keyword</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("keyword")]
        public string KeywordValue
        {
            [DebuggerStepThrough]
            get { return this.Keyword.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/MetaKeyword</para>
    /// <summary>
    public static class MetaKeywordConstants
    {
        public static readonly ID TemplateID = new ID("{18CDD4CE-CDBE-4BDC-9D5A-6249F7F0EC17}");
        public const string TemplateName = "MetaKeyword";

        public struct Fields
        {
            public struct Keyword
            {
                public static readonly ID ID = new ID("{7BDBBA5F-C7E6-45C2-82F5-010DED013588}");
                public const string FieldName = "Keyword";
            }
        }
    }
    
}
#endregion

#region Navigation Link (/sitecore/templates/Project/Common/Content Types/Navigation/Navigation Link)
namespace Project.Common.ContentTypes.Navigation
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Navigation Link</para>
    /// <para>ID: {8ff3d369-a508-4d2f-84a5-9b6c6bf5e537}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Navigation/Navigation Link</para>
    /// </summary>
    [TemplateMapping("{8FF3D369-A508-4D2F-84A5-9B6C6BF5E537}", "InterfaceMap")]
    public partial interface INavigationLink : ICustomItemWrapper, Feature.Navigation.ILink, Feature.Navigation.INavigable
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Navigation/Navigation Link</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{8FF3D369-A508-4D2F-84A5-9B6C6BF5E537}", typeof(Guid))]
    [TemplateMapping("{8FF3D369-A508-4D2F-84A5-9B6C6BF5E537}", "")]
    internal partial class NavigationLinkItem : CustomItemWrapper, INavigationLink
    {
        private Item _item = null;
        public NavigationLinkItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public NavigationLinkItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public NavigationLinkItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public NavigationLinkItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Navigation Link</para>
        /// <para>Field: Link</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("link")]
        public virtual ICustomGeneralLinkFieldWrapper Link
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("Link", "link"); }
        }

        /// <summary>
        /// <para>Template: Navigation Link</para>
        /// <para>Field: Link</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("link")]
        public string LinkValue
        {
            [DebuggerStepThrough]
            get { return this.Link.Value; }
        }
        /// <summary>
        /// <para>Template: Navigation Link</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: Navigation Link</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Navigation Link</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: Navigation Link</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: Navigation Link</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: Navigation Link</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Navigation/Navigation Link</para>
    /// <summary>
    public static class NavigationLinkConstants
    {
        public static readonly ID TemplateID = new ID("{8FF3D369-A508-4D2F-84A5-9B6C6BF5E537}");
        public const string TemplateName = "Navigation Link";

        public struct Fields
        {
            public struct Link
            {
                public static readonly ID ID = new ID("{FE71C30E-F07D-4052-8594-C3028CD76E1F}");
                public const string FieldName = "Link";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
        }
    }
    
}
#endregion

#region Registration Folder (/sitecore/templates/Project/Common/Content Types/Registration Folder)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Registration Folder</para>
    /// <para>ID: {689ba377-e538-49ed-9dfc-4dcc398ab9ac}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Registration Folder</para>
    /// </summary>
    [TemplateMapping("{689BA377-E538-49ED-9DFC-4DCC398AB9AC}", "InterfaceMap")]
    public partial interface IRegistrationFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Registration Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{689BA377-E538-49ED-9DFC-4DCC398AB9AC}", typeof(Guid))]
    [TemplateMapping("{689BA377-E538-49ED-9DFC-4DCC398AB9AC}", "")]
    internal partial class RegistrationFolderItem : CustomItemWrapper, IRegistrationFolder
    {
        private Item _item = null;
        public RegistrationFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public RegistrationFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public RegistrationFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public RegistrationFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Registration Folder</para>
    /// <summary>
    public static class RegistrationFolderConstants
    {
        public static readonly ID TemplateID = new ID("{689BA377-E538-49ED-9DFC-4DCC398AB9AC}");
        public const string TemplateName = "Registration Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Service Email (/sitecore/templates/Project/Common/Content Types/Service Email)
namespace Project.Common.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Service Email</para>
    /// <para>ID: {6db3ba22-5715-4529-a527-35b3af083ae4}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Service Email</para>
    /// </summary>
    [TemplateMapping("{6DB3BA22-5715-4529-A527-35B3AF083AE4}", "InterfaceMap")]
    public partial interface IServiceEmail : ICustomItemWrapper, Feature.Accounts.IMailTemplate
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Service Email</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{6DB3BA22-5715-4529-A527-35B3AF083AE4}", typeof(Guid))]
    [TemplateMapping("{6DB3BA22-5715-4529-A527-35B3AF083AE4}", "")]
    internal partial class ServiceEmailItem : CustomItemWrapper, IServiceEmail
    {
        private Item _item = null;
        public ServiceEmailItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public ServiceEmailItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public ServiceEmailItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public ServiceEmailItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Service Email</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public virtual IRichTextFieldWrapper Body
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Body", "body"); }
        }

        /// <summary>
        /// <para>Template: Service Email</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public string BodyValue
        {
            [DebuggerStepThrough]
            get { return this.Body.Value; }
        }
        /// <summary>
        /// <para>Template: Service Email</para>
        /// <para>Field: From</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("from")]
        public virtual ITextFieldWrapper From
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("From", "from"); }
        }

        /// <summary>
        /// <para>Template: Service Email</para>
        /// <para>Field: From</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("from")]
        public string FromValue
        {
            [DebuggerStepThrough]
            get { return this.From.Value; }
        }
        /// <summary>
        /// <para>Template: Service Email</para>
        /// <para>Field: Subject</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("subject")]
        public virtual ITextFieldWrapper Subject
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Subject", "subject"); }
        }

        /// <summary>
        /// <para>Template: Service Email</para>
        /// <para>Field: Subject</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("subject")]
        public string SubjectValue
        {
            [DebuggerStepThrough]
            get { return this.Subject.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Service Email</para>
    /// <summary>
    public static class ServiceEmailConstants
    {
        public static readonly ID TemplateID = new ID("{6DB3BA22-5715-4529-A527-35B3AF083AE4}");
        public const string TemplateName = "Service Email";

        public struct Fields
        {
            public struct Body
            {
                public static readonly ID ID = new ID("{1519CCAD-ED26-4F60-82CA-22079AF44D16}");
                public const string FieldName = "Body";
            }
            public struct From
            {
                public static readonly ID ID = new ID("{8605948C-60FB-46B8-8AAA-4C52561B53BC}");
                public const string FieldName = "From";
            }
            public struct Subject
            {
                public static readonly ID ID = new ID("{0F45DF05-546F-462D-97C0-BA4FB2B02564}");
                public const string FieldName = "Subject";
            }
        }
    }
    
}
#endregion

#region Social Feeds Folder (/sitecore/templates/Project/Common/Content Types/Social/Social Feeds Folder)
namespace Project.Common.ContentTypes.Social
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Social Feeds Folder</para>
    /// <para>ID: {4de2d9d9-0781-47ad-8f5d-52f2ad920d83}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Social/Social Feeds Folder</para>
    /// </summary>
    [TemplateMapping("{4DE2D9D9-0781-47AD-8F5D-52F2AD920D83}", "InterfaceMap")]
    public partial interface ISocialFeedsFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Social/Social Feeds Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{4DE2D9D9-0781-47AD-8F5D-52F2AD920D83}", typeof(Guid))]
    [TemplateMapping("{4DE2D9D9-0781-47AD-8F5D-52F2AD920D83}", "")]
    internal partial class SocialFeedsFolderItem : CustomItemWrapper, ISocialFeedsFolder
    {
        private Item _item = null;
        public SocialFeedsFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public SocialFeedsFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public SocialFeedsFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public SocialFeedsFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Social/Social Feeds Folder</para>
    /// <summary>
    public static class SocialFeedsFolderConstants
    {
        public static readonly ID TemplateID = new ID("{4DE2D9D9-0781-47AD-8F5D-52F2AD920D83}");
        public const string TemplateName = "Social Feeds Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Twitter Feed (/sitecore/templates/Project/Common/Content Types/Social/Twitter Feed)
namespace Project.Common.ContentTypes.Social
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Twitter Feed</para>
    /// <para>ID: {773a96f7-2752-4da2-a2f5-6119a21a24f3}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Social/Twitter Feed</para>
    /// </summary>
    [TemplateMapping("{773A96F7-2752-4DA2-A2F5-6119A21A24F3}", "InterfaceMap")]
    public partial interface ITwitterFeed : ICustomItemWrapper, Feature.Social.ITwitterFeed
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Social/Twitter Feed</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{773A96F7-2752-4DA2-A2F5-6119A21A24F3}", typeof(Guid))]
    [TemplateMapping("{773A96F7-2752-4DA2-A2F5-6119A21A24F3}", "")]
    internal partial class TwitterFeedItem : CustomItemWrapper, ITwitterFeed
    {
        private Item _item = null;
        public TwitterFeedItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public TwitterFeedItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public TwitterFeedItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public TwitterFeedItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Twitter Feed</para>
        /// <para>Field: FeedTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("feedtitle")]
        public virtual ITextFieldWrapper FeedTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("FeedTitle", "feedtitle"); }
        }

        /// <summary>
        /// <para>Template: Twitter Feed</para>
        /// <para>Field: FeedTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("feedtitle")]
        public string FeedTitleValue
        {
            [DebuggerStepThrough]
            get { return this.FeedTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Twitter Feed</para>
        /// <para>Field: TwitterUrl</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterurl")]
        public virtual ICustomGeneralLinkFieldWrapper TwitterUrl
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("TwitterUrl", "twitterurl"); }
        }

        /// <summary>
        /// <para>Template: Twitter Feed</para>
        /// <para>Field: TwitterUrl</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterurl")]
        public string TwitterUrlValue
        {
            [DebuggerStepThrough]
            get { return this.TwitterUrl.Value; }
        }
        /// <summary>
        /// <para>Template: Twitter Feed</para>
        /// <para>Field: WidgetId</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("widgetid")]
        public virtual ITextFieldWrapper WidgetId
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("WidgetId", "widgetid"); }
        }

        /// <summary>
        /// <para>Template: Twitter Feed</para>
        /// <para>Field: WidgetId</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("widgetid")]
        public string WidgetIdValue
        {
            [DebuggerStepThrough]
            get { return this.WidgetId.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Social/Twitter Feed</para>
    /// <summary>
    public static class TwitterFeedConstants
    {
        public static readonly ID TemplateID = new ID("{773A96F7-2752-4DA2-A2F5-6119A21A24F3}");
        public const string TemplateName = "Twitter Feed";

        public struct Fields
        {
            public struct FeedTitle
            {
                public static readonly ID ID = new ID("{099E4085-150C-4073-88D9-8B159D9A8B01}");
                public const string FieldName = "FeedTitle";
            }
            public struct TwitterUrl
            {
                public static readonly ID ID = new ID("{92EF8986-45E2-42DE-913F-B91FD960297A}");
                public const string FieldName = "TwitterUrl";
            }
            public struct WidgetId
            {
                public static readonly ID ID = new ID("{D1CF33B1-8B8A-4AAB-AA7E-2460566BEDED}");
                public const string FieldName = "WidgetId";
            }
        }
    }
    
}
#endregion

#region Dynamic Teaser (/sitecore/templates/Project/Common/Content Types/Teasers/Dynamic Teaser)
namespace Project.Common.ContentTypes.Teasers
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Dynamic Teaser</para>
    /// <para>ID: {f5f30cdc-9003-4015-84ec-c3a7e3e50d5e}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Teasers/Dynamic Teaser</para>
    /// </summary>
    [TemplateMapping("{F5F30CDC-9003-4015-84EC-C3A7E3E50D5E}", "InterfaceMap")]
    public partial interface IDynamicTeaser : ICustomItemWrapper, Feature.Teasers.IDynamicTeaser
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Dynamic Teaser</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{F5F30CDC-9003-4015-84EC-C3A7E3E50D5E}", typeof(Guid))]
    [TemplateMapping("{F5F30CDC-9003-4015-84EC-C3A7E3E50D5E}", "")]
    internal partial class DynamicTeaserItem : CustomItemWrapper, IDynamicTeaser
    {
        private Item _item = null;
        public DynamicTeaserItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public DynamicTeaserItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public DynamicTeaserItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public DynamicTeaserItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Dynamic Teaser</para>
        /// <para>Field: Active</para>
        /// <para>Data type: Integer</para>
        /// </summary>
        [IndexField("active")]
        public virtual IIntegerFieldWrapper Active
        {
            [DebuggerStepThrough]
            get { return GetField<IntegerFieldWrapper>("Active", "active"); }
        }

        /// <summary>
        /// <para>Template: Dynamic Teaser</para>
        /// <para>Field: Active</para>
        /// <para>Data type: Integer</para>
        /// </summary>
        [IndexField("active")]
        public long ActiveValue
        {
            [DebuggerStepThrough]
            get { return this.Active.Value; }
        }
        /// <summary>
        /// <para>Template: Dynamic Teaser</para>
        /// <para>Field: Count</para>
        /// <para>Data type: Integer</para>
        /// </summary>
        [IndexField("count")]
        public virtual IIntegerFieldWrapper Count
        {
            [DebuggerStepThrough]
            get { return GetField<IntegerFieldWrapper>("Count", "count"); }
        }

        /// <summary>
        /// <para>Template: Dynamic Teaser</para>
        /// <para>Field: Count</para>
        /// <para>Data type: Integer</para>
        /// </summary>
        [IndexField("count")]
        public long CountValue
        {
            [DebuggerStepThrough]
            get { return this.Count.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Dynamic Teaser</para>
    /// <summary>
    public static class DynamicTeaserConstants
    {
        public static readonly ID TemplateID = new ID("{F5F30CDC-9003-4015-84EC-C3A7E3E50D5E}");
        public const string TemplateName = "Dynamic Teaser";

        public struct Fields
        {
            public struct Active
            {
                public static readonly ID ID = new ID("{9E942565-677F-491C-A0AC-6B930E37342A}");
                public const string FieldName = "Active";
            }
            public struct Count
            {
                public static readonly ID ID = new ID("{A33F9523-96C4-4E42-B6D7-1E861718D373}");
                public const string FieldName = "Count";
            }
        }
    }
    
}
#endregion

#region Headline (/sitecore/templates/Project/Common/Content Types/Teasers/Headline)
namespace Project.Common.ContentTypes.Teasers
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Headline</para>
    /// <para>ID: {061574e1-59dd-4b62-9680-1c84efbe6773}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Teasers/Headline</para>
    /// </summary>
    [TemplateMapping("{061574E1-59DD-4B62-9680-1C84EFBE6773}", "InterfaceMap")]
    public partial interface IHeadline : ICustomItemWrapper, Feature.Teasers.IHeadline
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Headline</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{061574E1-59DD-4B62-9680-1C84EFBE6773}", typeof(Guid))]
    [TemplateMapping("{061574E1-59DD-4B62-9680-1C84EFBE6773}", "")]
    internal partial class HeadlineItem : CustomItemWrapper, IHeadline
    {
        private Item _item = null;
        public HeadlineItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public HeadlineItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public HeadlineItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public HeadlineItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Headline</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        public virtual ILinkFieldWrapper TeaserIcon
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Teaser Icon", "teaser_icon"); }
        }

        /// <summary>
        /// <para>Template: Headline</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        public Guid TeaserIconValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserIcon.Value; }
        }
        /// <summary>
        /// <para>Template: Headline</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        public virtual ITextFieldWrapper TeaserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("TeaserTitle", "teasertitle"); }
        }

        /// <summary>
        /// <para>Template: Headline</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        public string TeaserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserTitle.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Headline</para>
    /// <summary>
    public static class HeadlineConstants
    {
        public static readonly ID TemplateID = new ID("{061574E1-59DD-4B62-9680-1C84EFBE6773}");
        public const string TemplateName = "Headline";

        public struct Fields
        {
            public struct TeaserIcon
            {
                public static readonly ID ID = new ID("{3AF50903-63A9-464B-A375-B94983624E7D}");
                public const string FieldName = "Teaser Icon";
            }
            public struct TeaserTitle
            {
                public static readonly ID ID = new ID("{4A59D072-5B41-4A79-A157-2B2CCAC10F2B}");
                public const string FieldName = "TeaserTitle";
            }
        }
    }
    
}
#endregion

#region Quote Folder (/sitecore/templates/Project/Common/Content Types/Teasers/Quote Folder)
namespace Project.Common.ContentTypes.Teasers
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Quote Folder</para>
    /// <para>ID: {a8f1b162-041f-46bf-81eb-5213ae8bc579}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Teasers/Quote Folder</para>
    /// </summary>
    [TemplateMapping("{A8F1B162-041F-46BF-81EB-5213AE8BC579}", "InterfaceMap")]
    public partial interface IQuoteFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Quote Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{A8F1B162-041F-46BF-81EB-5213AE8BC579}", typeof(Guid))]
    [TemplateMapping("{A8F1B162-041F-46BF-81EB-5213AE8BC579}", "")]
    internal partial class QuoteFolderItem : CustomItemWrapper, IQuoteFolder
    {
        private Item _item = null;
        public QuoteFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public QuoteFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public QuoteFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public QuoteFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Quote Folder</para>
    /// <summary>
    public static class QuoteFolderConstants
    {
        public static readonly ID TemplateID = new ID("{A8F1B162-041F-46BF-81EB-5213AE8BC579}");
        public const string TemplateName = "Quote Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Quote (/sitecore/templates/Project/Common/Content Types/Teasers/Quote)
namespace Project.Common.ContentTypes.Teasers
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Quote</para>
    /// <para>ID: {40ad8a9b-c75c-428d-9e1a-51372b21f63e}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Teasers/Quote</para>
    /// </summary>
    [TemplateMapping("{40AD8A9B-C75C-428D-9E1A-51372B21F63E}", "InterfaceMap")]
    public partial interface IQuote : ICustomItemWrapper, Feature.Person.IPerson, Feature.Person.IQuote
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Quote</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{40AD8A9B-C75C-428D-9E1A-51372B21F63E}", typeof(Guid))]
    [TemplateMapping("{40AD8A9B-C75C-428D-9E1A-51372B21F63E}", "")]
    internal partial class QuoteItem : CustomItemWrapper, IQuote
    {
        private Item _item = null;
        public QuoteItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public QuoteItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public QuoteItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public QuoteItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Quote</para>
        /// <para>Field: CiteOrigin</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("cite_origin")]
        public virtual ITextFieldWrapper CiteOrigin
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Cite Origin", "cite_origin"); }
        }

        /// <summary>
        /// <para>Template: Quote</para>
        /// <para>Field: CiteOrigin</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("cite_origin")]
        public string CiteOriginValue
        {
            [DebuggerStepThrough]
            get { return this.CiteOrigin.Value; }
        }
        /// <summary>
        /// <para>Template: Quote</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public virtual ITextFieldWrapper Name
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Name", "name"); }
        }

        /// <summary>
        /// <para>Template: Quote</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public string NameValue
        {
            [DebuggerStepThrough]
            get { return this.Name.Value; }
        }
        /// <summary>
        /// <para>Template: Quote</para>
        /// <para>Field: Picture</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Picture
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Picture"); }
        }

        /// <summary>
        /// <para>Template: Quote</para>
        /// <para>Field: Picture</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string PictureValue
        {
            [DebuggerStepThrough]
            get { return this.Picture.Value; }
        }
        /// <summary>
        /// <para>Template: Quote</para>
        /// <para>Field: Quote</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("quote")]
        public virtual ITextFieldWrapper Quote
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Quote", "quote"); }
        }

        /// <summary>
        /// <para>Template: Quote</para>
        /// <para>Field: Quote</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("quote")]
        public string QuoteValue
        {
            [DebuggerStepThrough]
            get { return this.Quote.Value; }
        }
        /// <summary>
        /// <para>Template: Quote</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual ITextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: Quote</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: Quote</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Quote</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Quote</para>
    /// <summary>
    public static class QuoteConstants
    {
        public static readonly ID TemplateID = new ID("{40AD8A9B-C75C-428D-9E1A-51372B21F63E}");
        public const string TemplateName = "Quote";

        public struct Fields
        {
            public struct CiteOrigin
            {
                public static readonly ID ID = new ID("{BF83983A-473F-4A49-BE8E-7D563AA5687E}");
                public const string FieldName = "Cite Origin";
            }
            public struct Name
            {
                public static readonly ID ID = new ID("{26CD59AB-3639-488F-BAFD-58D2B217755A}");
                public const string FieldName = "Name";
            }
            public struct Picture
            {
                public static readonly ID ID = new ID("{C9BAF3EB-8CFA-4BF6-9B19-51D38DB5FC38}");
                public const string FieldName = "Picture";
            }
            public struct Quote
            {
                public static readonly ID ID = new ID("{0DE53078-0DA4-40CC-BBCA-63AA96A0A1EF}");
                public const string FieldName = "Quote";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{B897023C-15D2-49F3-8974-06FA5FB7AD00}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{76972FCD-4BB0-4255-864E-077745EFDF50}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region Teaser Folder (/sitecore/templates/Project/Common/Content Types/Teasers/Teaser Folder)
namespace Project.Common.ContentTypes.Teasers
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Teaser Folder</para>
    /// <para>ID: {29d4b405-39eb-487d-9d6b-3f8467ab167d}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Teasers/Teaser Folder</para>
    /// </summary>
    [TemplateMapping("{29D4B405-39EB-487D-9D6B-3F8467AB167D}", "InterfaceMap")]
    public partial interface ITeaserFolder : ICustomItemWrapper
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Teaser Folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{29D4B405-39EB-487D-9D6B-3F8467AB167D}", typeof(Guid))]
    [TemplateMapping("{29D4B405-39EB-487D-9D6B-3F8467AB167D}", "")]
    internal partial class TeaserFolderItem : CustomItemWrapper, ITeaserFolder
    {
        private Item _item = null;
        public TeaserFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public TeaserFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public TeaserFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public TeaserFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Teaser Folder</para>
    /// <summary>
    public static class TeaserFolderConstants
    {
        public static readonly ID TemplateID = new ID("{29D4B405-39EB-487D-9D6B-3F8467AB167D}");
        public const string TemplateName = "Teaser Folder";

        public struct Fields
        {
        }
    }
    
}
#endregion

#region Teaser (/sitecore/templates/Project/Common/Content Types/Teasers/Teaser)
namespace Project.Common.ContentTypes.Teasers
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Teaser</para>
    /// <para>ID: {c7d9d293-4ef8-4380-8e10-c4632e729f39}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Teasers/Teaser</para>
    /// </summary>
    [TemplateMapping("{C7D9D293-4EF8-4380-8E10-C4632E729F39}", "InterfaceMap")]
    public partial interface ITeaser : ICustomItemWrapper, Feature.Teasers.IHeadline, Feature.Teasers.ITeaserContent
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Teaser</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{C7D9D293-4EF8-4380-8E10-C4632E729F39}", typeof(Guid))]
    [TemplateMapping("{C7D9D293-4EF8-4380-8E10-C4632E729F39}", "")]
    internal partial class TeaserItem : CustomItemWrapper, ITeaser
    {
        private Item _item = null;
        public TeaserItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public TeaserItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public TeaserItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public TeaserItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Teaser</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        public virtual ILinkFieldWrapper TeaserIcon
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Teaser Icon", "teaser_icon"); }
        }

        /// <summary>
        /// <para>Template: Teaser</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        public Guid TeaserIconValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserIcon.Value; }
        }
        /// <summary>
        /// <para>Template: Teaser</para>
        /// <para>Field: TeaserLabel</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teaser_label")]
        public virtual ITextFieldWrapper TeaserLabel
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Teaser Label", "teaser_label"); }
        }

        /// <summary>
        /// <para>Template: Teaser</para>
        /// <para>Field: TeaserLabel</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teaser_label")]
        public string TeaserLabelValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserLabel.Value; }
        }
        /// <summary>
        /// <para>Template: Teaser</para>
        /// <para>Field: TeaserImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper TeaserImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("TeaserImage"); }
        }

        /// <summary>
        /// <para>Template: Teaser</para>
        /// <para>Field: TeaserImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string TeaserImageValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserImage.Value; }
        }
        /// <summary>
        /// <para>Template: Teaser</para>
        /// <para>Field: TeaserLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("teaserlink")]
        public virtual ICustomGeneralLinkFieldWrapper TeaserLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("TeaserLink", "teaserlink"); }
        }

        /// <summary>
        /// <para>Template: Teaser</para>
        /// <para>Field: TeaserLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("teaserlink")]
        public string TeaserLinkValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserLink.Value; }
        }
        /// <summary>
        /// <para>Template: Teaser</para>
        /// <para>Field: TeaserSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("teasersummary")]
        public virtual ITextFieldWrapper TeaserSummary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("TeaserSummary", "teasersummary"); }
        }

        /// <summary>
        /// <para>Template: Teaser</para>
        /// <para>Field: TeaserSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("teasersummary")]
        public string TeaserSummaryValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserSummary.Value; }
        }
        /// <summary>
        /// <para>Template: Teaser</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        public virtual ITextFieldWrapper TeaserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("TeaserTitle", "teasertitle"); }
        }

        /// <summary>
        /// <para>Template: Teaser</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        public string TeaserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserTitle.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Teaser</para>
    /// <summary>
    public static class TeaserConstants
    {
        public static readonly ID TemplateID = new ID("{C7D9D293-4EF8-4380-8E10-C4632E729F39}");
        public const string TemplateName = "Teaser";

        public struct Fields
        {
            public struct TeaserIcon
            {
                public static readonly ID ID = new ID("{3AF50903-63A9-464B-A375-B94983624E7D}");
                public const string FieldName = "Teaser Icon";
            }
            public struct TeaserLabel
            {
                public static readonly ID ID = new ID("{3F7E7E3A-4E8E-4639-B079-FC5AEFF172F5}");
                public const string FieldName = "Teaser Label";
            }
            public struct TeaserImage
            {
                public static readonly ID ID = new ID("{0F6B5546-E0AB-4487-81DE-640C1AA1B65B}");
                public const string FieldName = "TeaserImage";
            }
            public struct TeaserLink
            {
                public static readonly ID ID = new ID("{E8AB122C-6F54-4D4E-AEC6-F81ADDC558FC}");
                public const string FieldName = "TeaserLink";
            }
            public struct TeaserSummary
            {
                public static readonly ID ID = new ID("{13D97A52-7C4E-407C-960D-FADDE8A3C1B1}");
                public const string FieldName = "TeaserSummary";
            }
            public struct TeaserTitle
            {
                public static readonly ID ID = new ID("{4A59D072-5B41-4A79-A157-2B2CCAC10F2B}");
                public const string FieldName = "TeaserTitle";
            }
        }
    }
    
}
#endregion

#region Video Teaser (/sitecore/templates/Project/Common/Content Types/Teasers/Video Teaser)
namespace Project.Common.ContentTypes.Teasers
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Video Teaser</para>
    /// <para>ID: {ddbbf170-cfbd-439f-958c-a090bdf66d94}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Content Types/Teasers/Video Teaser</para>
    /// </summary>
    [TemplateMapping("{DDBBF170-CFBD-439F-958C-A090BDF66D94}", "InterfaceMap")]
    public partial interface IVideoTeaser : ICustomItemWrapper, Feature.Teasers.IHeadline, Feature.Teasers.ITeaserContent, Feature.Teasers.ITeaserVideoContent
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Video Teaser</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{DDBBF170-CFBD-439F-958C-A090BDF66D94}", typeof(Guid))]
    [TemplateMapping("{DDBBF170-CFBD-439F-958C-A090BDF66D94}", "")]
    internal partial class VideoTeaserItem : CustomItemWrapper, IVideoTeaser
    {
        private Item _item = null;
        public VideoTeaserItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public VideoTeaserItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public VideoTeaserItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public VideoTeaserItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        public virtual ILinkFieldWrapper TeaserIcon
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Teaser Icon", "teaser_icon"); }
        }

        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: TeaserIcon</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("teaser_icon")]
        public Guid TeaserIconValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserIcon.Value; }
        }
        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: TeaserLabel</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teaser_label")]
        public virtual ITextFieldWrapper TeaserLabel
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Teaser Label", "teaser_label"); }
        }

        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: TeaserLabel</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teaser_label")]
        public string TeaserLabelValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserLabel.Value; }
        }
        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: TeaserImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper TeaserImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("TeaserImage"); }
        }

        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: TeaserImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string TeaserImageValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserImage.Value; }
        }
        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: TeaserLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("teaserlink")]
        public virtual ICustomGeneralLinkFieldWrapper TeaserLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("TeaserLink", "teaserlink"); }
        }

        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: TeaserLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("teaserlink")]
        public string TeaserLinkValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserLink.Value; }
        }
        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: TeaserSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("teasersummary")]
        public virtual ITextFieldWrapper TeaserSummary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("TeaserSummary", "teasersummary"); }
        }

        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: TeaserSummary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("teasersummary")]
        public string TeaserSummaryValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserSummary.Value; }
        }
        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        public virtual ITextFieldWrapper TeaserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("TeaserTitle", "teasertitle"); }
        }

        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: TeaserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("teasertitle")]
        public string TeaserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.TeaserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: VideoLink</para>
        /// <para>Data type: link</para>
        /// </summary>
        public virtual ICustomGeneralLinkFieldWrapper VideoLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("VideoLink"); }
        }

        /// <summary>
        /// <para>Template: Video Teaser</para>
        /// <para>Field: VideoLink</para>
        /// <para>Data type: link</para>
        /// </summary>
        public string VideoLinkValue
        {
            [DebuggerStepThrough]
            get { return this.VideoLink.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Content Types/Teasers/Video Teaser</para>
    /// <summary>
    public static class VideoTeaserConstants
    {
        public static readonly ID TemplateID = new ID("{DDBBF170-CFBD-439F-958C-A090BDF66D94}");
        public const string TemplateName = "Video Teaser";

        public struct Fields
        {
            public struct TeaserIcon
            {
                public static readonly ID ID = new ID("{3AF50903-63A9-464B-A375-B94983624E7D}");
                public const string FieldName = "Teaser Icon";
            }
            public struct TeaserLabel
            {
                public static readonly ID ID = new ID("{3F7E7E3A-4E8E-4639-B079-FC5AEFF172F5}");
                public const string FieldName = "Teaser Label";
            }
            public struct TeaserImage
            {
                public static readonly ID ID = new ID("{0F6B5546-E0AB-4487-81DE-640C1AA1B65B}");
                public const string FieldName = "TeaserImage";
            }
            public struct TeaserLink
            {
                public static readonly ID ID = new ID("{E8AB122C-6F54-4D4E-AEC6-F81ADDC558FC}");
                public const string FieldName = "TeaserLink";
            }
            public struct TeaserSummary
            {
                public static readonly ID ID = new ID("{13D97A52-7C4E-407C-960D-FADDE8A3C1B1}");
                public const string FieldName = "TeaserSummary";
            }
            public struct TeaserTitle
            {
                public static readonly ID ID = new ID("{4A59D072-5B41-4A79-A157-2B2CCAC10F2B}");
                public const string FieldName = "TeaserTitle";
            }
            public struct VideoLink
            {
                public static readonly ID ID = new ID("{AC846A16-FD3F-4243-A21F-668A21010C44}");
                public const string FieldName = "VideoLink";
            }
        }
    }
    
}
#endregion

#region Demo Page (/sitecore/templates/Project/Common/Page Types/Demo Page)
namespace Project.Common.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Demo Page</para>
    /// <para>ID: {49c651ba-4004-40a9-9b0f-e95d0573f3ae}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Page Types/Demo Page</para>
    /// </summary>
    [TemplateMapping("{49C651BA-4004-40A9-9B0F-E95D0573F3AE}", "InterfaceMap")]
    public partial interface IDemoPage : ICustomItemWrapper, Feature.Demo.IDemoContent, Feature.Multisite.ISiteConfiguration, Foundation.Multisite.ISite
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Page Types/Demo Page</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{49C651BA-4004-40A9-9B0F-E95D0573F3AE}", typeof(Guid))]
    [TemplateMapping("{49C651BA-4004-40A9-9B0F-E95D0573F3AE}", "")]
    internal partial class DemoPageItem : CustomItemWrapper, IDemoPage
    {
        private Item _item = null;
        public DemoPageItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public DemoPageItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public DemoPageItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public DemoPageItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Demo Page</para>
        /// <para>Field: HTMLContent</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("html_content")]
        public virtual ITextFieldWrapper HTMLContent
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("HTML Content", "html_content"); }
        }

        /// <summary>
        /// <para>Template: Demo Page</para>
        /// <para>Field: HTMLContent</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("html_content")]
        public string HTMLContentValue
        {
            [DebuggerStepThrough]
            get { return this.HTMLContent.Value; }
        }
        /// <summary>
        /// <para>Template: Demo Page</para>
        /// <para>Field: ShowInMenu</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinmenu")]
        public virtual IBooleanFieldWrapper ShowInMenu
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInMenu", "showinmenu"); }
        }

        /// <summary>
        /// <para>Template: Demo Page</para>
        /// <para>Field: ShowInMenu</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinmenu")]
        public bool ShowInMenuValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInMenu.Value; }
        }
        /// <summary>
        /// <para>Template: Demo Page</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Demo Page</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Page Types/Demo Page</para>
    /// <summary>
    public static class DemoPageConstants
    {
        public static readonly ID TemplateID = new ID("{49C651BA-4004-40A9-9B0F-E95D0573F3AE}");
        public const string TemplateName = "Demo Page";

        public struct Fields
        {
            public struct HTMLContent
            {
                public static readonly ID ID = new ID("{0BC0AEDF-A6D0-4F74-933C-BD1779CD40B2}");
                public const string FieldName = "HTML Content";
            }
            public struct ShowInMenu
            {
                public static readonly ID ID = new ID("{12537182-F35C-403F-AFB5-747D55C450B8}");
                public const string FieldName = "ShowInMenu";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{F07811D3-41E9-440A-9D81-310C1D78BED6}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region ParametersTemplate_HasContainerWithDynamicPlaceholder (/sitecore/templates/Project/Common/Parameters/ParametersTemplate_HasContainerWithDynamicPlaceholder)
namespace Project.Common.Parameters
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    using Fortis.Model.RenderingParameters;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: ParametersTemplate_HasContainerWithDynamicPlaceholder</para>
    /// <para>ID: {4654d5f0-9b39-426a-992d-1d42e356fb0a}</para>
    /// <para>Path: /sitecore/templates/Project/Common/Parameters/ParametersTemplate_HasContainerWithDynamicPlaceholder</para>
    /// </summary>
    [TemplateMapping("{4654D5F0-9B39-426A-992D-1D42E356FB0A}", "InterfaceRenderingParameter")]
    public partial interface IParametersTemplateHasContainerWithDynamicPlaceholder : IRenderingParameterWrapper, Foundation.SitecoreExtensions.IParametersTemplateHasDynamicPlaceholder, Foundation.Theming.IParametersTemplateHasBackground, Foundation.Theming.IParametersTemplateHasContainer, Foundation.Theming.IParametersTemplateHasContainerWithBackground
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Common/Parameters/ParametersTemplate_HasContainerWithDynamicPlaceholder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{4654D5F0-9B39-426A-992D-1D42E356FB0A}", typeof(Guid))]
    [TemplateMapping("{4654D5F0-9B39-426A-992D-1D42E356FB0A}", "RenderingParameter")]
    internal partial class ParametersTemplateHasContainerWithDynamicPlaceholderItem : CustomRenderingParameterWrapper, IParametersTemplateHasContainerWithDynamicPlaceholder
    {
        public ParametersTemplateHasContainerWithDynamicPlaceholderItem(Dictionary<string, string> parameters, ISpawnProvider spawnProvider) : base(parameters, spawnProvider)
        {
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_HasContainerWithDynamicPlaceholder</para>
        /// <para>Field: Background</para>
        /// <para>Data type: Droplink</para>
        /// </summary>
        public virtual ILinkFieldWrapper Background
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.LinkFieldWrapper)GetField("Background", "droplink"); }
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_HasContainerWithDynamicPlaceholder</para>
        /// <para>Field: Background</para>
        /// <para>Data type: Droplink</para>
        /// </summary>
        public Guid BackgroundValue
        {
            [DebuggerStepThrough]
            get { return this.Background.Value; }
        }
        /// <summary>
        /// <para>Template: ParametersTemplate_HasContainerWithDynamicPlaceholder</para>
        /// <para>Field: ContainerIsFluid</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public virtual IBooleanFieldWrapper ContainerIsFluid
        {
            [DebuggerStepThrough]
            get { return (Fortis.Model.RenderingParameters.Fields.BooleanFieldWrapper)GetField("ContainerIsFluid", "checkbox"); }
        }

        /// <summary>
        /// <para>Template: ParametersTemplate_HasContainerWithDynamicPlaceholder</para>
        /// <para>Field: ContainerIsFluid</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        public bool ContainerIsFluidValue
        {
            [DebuggerStepThrough]
            get { return this.ContainerIsFluid.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Common/Parameters/ParametersTemplate_HasContainerWithDynamicPlaceholder</para>
    /// <summary>
    public static class ParametersTemplateHasContainerWithDynamicPlaceholderConstants
    {
        public static readonly ID TemplateID = new ID("{4654D5F0-9B39-426A-992D-1D42E356FB0A}");
        public const string TemplateName = "ParametersTemplate_HasContainerWithDynamicPlaceholder";

        public struct Fields
        {
            public struct Background
            {
                public static readonly ID ID = new ID("{32439F83-C2FC-46E8-8981-5D1CDF1B2742}");
                public const string FieldName = "Background";
            }
            public struct ContainerIsFluid
            {
                public static readonly ID ID = new ID("{8F49D801-02B0-4DB7-90DB-5742D1662CF1}");
                public const string FieldName = "ContainerIsFluid";
            }
        }
    }
    
}
#endregion

#region Site Root (/sitecore/templates/Project/Habitat/Content Types/Site Root)
namespace Project.Habitat.ContentTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Site Root</para>
    /// <para>ID: {0643d9d4-f30b-4b07-91d0-289cc324c9cf}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Content Types/Site Root</para>
    /// </summary>
    [TemplateMapping("{0643D9D4-F30B-4B07-91D0-289CC324C9CF}", "InterfaceMap")]
    public partial interface ISiteRoot : ICustomItemWrapper, Feature.Accounts.IAccountsSettings, Feature.Accounts.IProfileSettings, Feature.Demo.IProfilingSettings, Feature.Identity.IIdentity, Feature.Language.ILanguageSettings, Feature.Metadata.ISiteMetadata, Feature.Multisite.ISiteConfiguration, Feature.Search.ISearchContext, Foundation.Assets.IHasTheme, Foundation.Multisite.ISite
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Content Types/Site Root</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{0643D9D4-F30B-4B07-91D0-289CC324C9CF}", typeof(Guid))]
    [TemplateMapping("{0643D9D4-F30B-4B07-91D0-289CC324C9CF}", "")]
    internal partial class SiteRootItem : CustomItemWrapper, ISiteRoot
    {
        private Item _item = null;
        public SiteRootItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public SiteRootItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public SiteRootItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public SiteRootItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: AccountsDetailsPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper AccountsDetailsPage
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Accounts Details Page"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: AccountsDetailsPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string AccountsDetailsPageValue
        {
            [DebuggerStepThrough]
            get { return this.AccountsDetailsPage.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: AfterLoginPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper AfterLoginPage
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("After Login Page"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: AfterLoginPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string AfterLoginPageValue
        {
            [DebuggerStepThrough]
            get { return this.AfterLoginPage.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: Copyright</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("copyright")]
        public virtual IRichTextFieldWrapper Copyright
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Copyright", "copyright"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: Copyright</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("copyright")]
        public string CopyrightValue
        {
            [DebuggerStepThrough]
            get { return this.Copyright.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: ForgotPasswordMailTemplate</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper ForgotPasswordMailTemplate
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Forgot Password Mail Template"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: ForgotPasswordMailTemplate</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string ForgotPasswordMailTemplateValue
        {
            [DebuggerStepThrough]
            get { return this.ForgotPasswordMailTemplate.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: ForgotPasswordPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper ForgotPasswordPage
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Forgot Password Page"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: ForgotPasswordPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string ForgotPasswordPageValue
        {
            [DebuggerStepThrough]
            get { return this.ForgotPasswordPage.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: InterestsFolder</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("interests_folder")]
        public virtual ILinkFieldWrapper InterestsFolder
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Interests Folder", "interests_folder"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: InterestsFolder</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("interests_folder")]
        public Guid InterestsFolderValue
        {
            [DebuggerStepThrough]
            get { return this.InterestsFolder.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: LoginPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper LoginPage
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Login Page"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: LoginPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string LoginPageValue
        {
            [DebuggerStepThrough]
            get { return this.LoginPage.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: Logo</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Logo
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Logo"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: Logo</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string LogoValue
        {
            [DebuggerStepThrough]
            get { return this.Logo.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: LogoTagline</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("logo_tagline")]
        public virtual ITextFieldWrapper LogoTagline
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Logo Tagline", "logo_tagline"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: LogoTagline</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("logo_tagline")]
        public string LogoTaglineValue
        {
            [DebuggerStepThrough]
            get { return this.LogoTagline.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: OrganisationAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("organisationaddress")]
        public virtual ITextFieldWrapper OrganisationAddress
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OrganisationAddress", "organisationaddress"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: OrganisationAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("organisationaddress")]
        public string OrganisationAddressValue
        {
            [DebuggerStepThrough]
            get { return this.OrganisationAddress.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: OrganisationEmail</para>
        /// <para>Data type: link</para>
        /// </summary>
        public virtual ICustomGeneralLinkFieldWrapper OrganisationEmail
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("OrganisationEmail"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: OrganisationEmail</para>
        /// <para>Data type: link</para>
        /// </summary>
        public string OrganisationEmailValue
        {
            [DebuggerStepThrough]
            get { return this.OrganisationEmail.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: OrganisationName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("organisationname")]
        public virtual ITextFieldWrapper OrganisationName
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OrganisationName", "organisationname"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: OrganisationName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("organisationname")]
        public string OrganisationNameValue
        {
            [DebuggerStepThrough]
            get { return this.OrganisationName.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: OrganisationPhone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("organisationphone")]
        public virtual ITextFieldWrapper OrganisationPhone
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OrganisationPhone", "organisationphone"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: OrganisationPhone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("organisationphone")]
        public string OrganisationPhoneValue
        {
            [DebuggerStepThrough]
            get { return this.OrganisationPhone.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: RegisterOutcome</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("register_outcome")]
        public virtual ILinkFieldWrapper RegisterOutcome
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Register Outcome", "register_outcome"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: RegisterOutcome</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("register_outcome")]
        public Guid RegisterOutcomeValue
        {
            [DebuggerStepThrough]
            get { return this.RegisterOutcome.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: RegisterPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper RegisterPage
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Register Page"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: RegisterPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string RegisterPageValue
        {
            [DebuggerStepThrough]
            get { return this.RegisterPage.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: SearchResultsPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public virtual ITextFieldWrapper SearchResultsPage
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Search Results Page"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: SearchResultsPage</para>
        /// <para>Data type: Internal Link</para>
        /// </summary>
        public string SearchResultsPageValue
        {
            [DebuggerStepThrough]
            get { return this.SearchResultsPage.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: ShowInMenu</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinmenu")]
        public virtual IBooleanFieldWrapper ShowInMenu
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInMenu", "showinmenu"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: ShowInMenu</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinmenu")]
        public bool ShowInMenuValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInMenu.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: SiteBrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("sitebrowsertitle")]
        public virtual ITextFieldWrapper SiteBrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("SiteBrowserTitle", "sitebrowsertitle"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: SiteBrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("sitebrowsertitle")]
        public string SiteBrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.SiteBrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: SiteProfiles</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("siteprofiles")]
        public virtual IListFieldWrapper SiteProfiles
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("SiteProfiles", "siteprofiles"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: SiteProfiles</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("siteprofiles")]
        public IEnumerable<Guid> SiteProfilesValue
        {
            [DebuggerStepThrough]
            get { return this.SiteProfiles.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: SupportedLanguages</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("supportedlanguages")]
        public virtual IListFieldWrapper SupportedLanguages
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("SupportedLanguages", "supportedlanguages"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: SupportedLanguages</para>
        /// <para>Data type: Multilist</para>
        /// </summary>
        [IndexField("supportedlanguages")]
        public IEnumerable<Guid> SupportedLanguagesValue
        {
            [DebuggerStepThrough]
            get { return this.SupportedLanguages.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: Theme</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("theme")]
        public virtual ILinkFieldWrapper Theme
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Theme", "theme"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: Theme</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("theme")]
        public Guid ThemeValue
        {
            [DebuggerStepThrough]
            get { return this.Theme.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: UserProfile</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("user_profile")]
        public virtual ILinkFieldWrapper UserProfile
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("User Profile", "user_profile"); }
        }

        /// <summary>
        /// <para>Template: Site Root</para>
        /// <para>Field: UserProfile</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("user_profile")]
        public Guid UserProfileValue
        {
            [DebuggerStepThrough]
            get { return this.UserProfile.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Content Types/Site Root</para>
    /// <summary>
    public static class SiteRootConstants
    {
        public static readonly ID TemplateID = new ID("{0643D9D4-F30B-4B07-91D0-289CC324C9CF}");
        public const string TemplateName = "Site Root";

        public struct Fields
        {
            public struct AccountsDetailsPage
            {
                public static readonly ID ID = new ID("{ED71D374-8C33-4561-991D-77482AE01330}");
                public const string FieldName = "Accounts Details Page";
            }
            public struct AfterLoginPage
            {
                public static readonly ID ID = new ID("{B128E2B3-3865-4F1C-A147-5F248676D3F5}");
                public const string FieldName = "After Login Page";
            }
            public struct Copyright
            {
                public static readonly ID ID = new ID("{02115632-FE1E-4B3D-9AD4-A4DDF1F782F0}");
                public const string FieldName = "Copyright";
            }
            public struct ForgotPasswordMailTemplate
            {
                public static readonly ID ID = new ID("{365254C4-1C1C-493A-9710-671574717898}");
                public const string FieldName = "Forgot Password Mail Template";
            }
            public struct ForgotPasswordPage
            {
                public static readonly ID ID = new ID("{F3CD2BB8-472B-4DF0-87C0-A13098E391CA}");
                public const string FieldName = "Forgot Password Page";
            }
            public struct InterestsFolder
            {
                public static readonly ID ID = new ID("{021AA3F7-206F-4ACC-9538-F6D7FE86B168}");
                public const string FieldName = "Interests Folder";
            }
            public struct LoginPage
            {
                public static readonly ID ID = new ID("{60745023-FFD5-400E-8F80-4BCA9F2ABB29}");
                public const string FieldName = "Login Page";
            }
            public struct Logo
            {
                public static readonly ID ID = new ID("{E748D808-64C1-4DEC-9718-F35CF9689E4B}");
                public const string FieldName = "Logo";
            }
            public struct LogoTagline
            {
                public static readonly ID ID = new ID("{31D027BB-FAB5-4E1A-A66D-9F5B0FD4F005}");
                public const string FieldName = "Logo Tagline";
            }
            public struct OrganisationAddress
            {
                public static readonly ID ID = new ID("{A24DF48F-C8A3-4163-966C-8C24BD8760B2}");
                public const string FieldName = "OrganisationAddress";
            }
            public struct OrganisationEmail
            {
                public static readonly ID ID = new ID("{9C428556-5D7B-46AC-B0BB-B06A4F4C9591}");
                public const string FieldName = "OrganisationEmail";
            }
            public struct OrganisationName
            {
                public static readonly ID ID = new ID("{EFD4980A-030C-497C-8880-40B6030AC28B}");
                public const string FieldName = "OrganisationName";
            }
            public struct OrganisationPhone
            {
                public static readonly ID ID = new ID("{005ED83C-2D2F-4D07-A7A9-EB64D873DE46}");
                public const string FieldName = "OrganisationPhone";
            }
            public struct RegisterOutcome
            {
                public static readonly ID ID = new ID("{835FA523-D28A-46A2-A589-6AA4A5BF0846}");
                public const string FieldName = "Register Outcome";
            }
            public struct RegisterPage
            {
                public static readonly ID ID = new ID("{71962360-10D8-4B98-BB8D-57660CE11127}");
                public const string FieldName = "Register Page";
            }
            public struct SearchResultsPage
            {
                public static readonly ID ID = new ID("{1C843E6A-02B9-4AA0-9FED-FDFDDC419AE3}");
                public const string FieldName = "Search Results Page";
            }
            public struct ShowInMenu
            {
                public static readonly ID ID = new ID("{12537182-F35C-403F-AFB5-747D55C450B8}");
                public const string FieldName = "ShowInMenu";
            }
            public struct SiteBrowserTitle
            {
                public static readonly ID ID = new ID("{235AE392-97AC-4822-BE38-837DA3E7724E}");
                public const string FieldName = "SiteBrowserTitle";
            }
            public struct SiteProfiles
            {
                public static readonly ID ID = new ID("{2A84ECA4-68BB-4451-B4AC-98EA71A5A3DC}");
                public const string FieldName = "SiteProfiles";
            }
            public struct SupportedLanguages
            {
                public static readonly ID ID = new ID("{5F115B6D-6052-4C7E-B442-AE923A7E9BD2}");
                public const string FieldName = "SupportedLanguages";
            }
            public struct Theme
            {
                public static readonly ID ID = new ID("{53B5AF0A-265F-4E60-B2B2-4576CE0BECCF}");
                public const string FieldName = "Theme";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{F07811D3-41E9-440A-9D81-310C1D78BED6}");
                public const string FieldName = "Title";
            }
            public struct UserProfile
            {
                public static readonly ID ID = new ID("{378B7D87-5775-4EB6-86B7-282D5359B1C6}");
                public const string FieldName = "User Profile";
            }
        }
    }
    
}
#endregion

#region Article (/sitecore/templates/Project/Habitat/Page Types/Article)
namespace Project.Habitat.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Article</para>
    /// <para>ID: {94a8c8e9-690b-4e65-98e7-f95800222767}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Page Types/Article</para>
    /// </summary>
    [TemplateMapping("{94A8C8E9-690B-4E65-98E7-F95800222767}", "InterfaceMap")]
    public partial interface IArticle : ICustomItemWrapper, Feature.Metadata.IPageMetadata, Feature.Navigation.INavigable, Feature.PageContent.IHasPageContent, Feature.Social.IOpenGraph, Foundation.Assets.IPageAssets, Foundation.Indexing.IIndexedItem
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Article</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{94A8C8E9-690B-4E65-98E7-F95800222767}", typeof(Guid))]
    [TemplateMapping("{94A8C8E9-690B-4E65-98E7-F95800222767}", "")]
    internal partial class ArticleItem : CustomItemWrapper, IArticle
    {
        private Item _item = null;
        public ArticleItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public ArticleItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public ArticleItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public ArticleItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public virtual IRichTextFieldWrapper Body
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Body", "body"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public string BodyValue
        {
            [DebuggerStepThrough]
            get { return this.Body.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public virtual ITextFieldWrapper CssCode
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CssCode", "csscode"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public string CssCodeValue
        {
            [DebuggerStepThrough]
            get { return this.CssCode.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Image
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Image"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string ImageValue
        {
            [DebuggerStepThrough]
            get { return this.Image.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public virtual IBooleanFieldWrapper IncludeInSearchResults
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("IncludeInSearchResults", "includeinsearchresults"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public bool IncludeInSearchResultsValue
        {
            [DebuggerStepThrough]
            get { return this.IncludeInSearchResults.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public virtual IBooleanFieldWrapper InheritAssets
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("InheritAssets", "inheritassets"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public bool InheritAssetsValue
        {
            [DebuggerStepThrough]
            get { return this.InheritAssets.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public virtual ITextFieldWrapper JavascriptCodeBottom
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeBottom", "javascriptcodebottom"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public string JavascriptCodeBottomValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeBottom.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public virtual ITextFieldWrapper JavascriptCodeTop
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeTop", "javascriptcodetop"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public string JavascriptCodeTopValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeTop.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual IRichTextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Article</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Article</para>
    /// <summary>
    public static class ArticleConstants
    {
        public static readonly ID TemplateID = new ID("{94A8C8E9-690B-4E65-98E7-F95800222767}");
        public const string TemplateName = "Article";

        public struct Fields
        {
            public struct Body
            {
                public static readonly ID ID = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
                public const string FieldName = "Body";
            }
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CssCode
            {
                public static readonly ID ID = new ID("{06A96EFC-F2E5-45C3-A7DC-4DDDFA366CC0}");
                public const string FieldName = "CssCode";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct Image
            {
                public static readonly ID ID = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
                public const string FieldName = "Image";
            }
            public struct IncludeInSearchResults
            {
                public static readonly ID ID = new ID("{8D5C486E-A0E3-4DBE-9A4A-CDFF93594BDA}");
                public const string FieldName = "IncludeInSearchResults";
            }
            public struct InheritAssets
            {
                public static readonly ID ID = new ID("{F19E8A50-9950-4861-9E66-9598A1898E71}");
                public const string FieldName = "InheritAssets";
            }
            public struct JavascriptCodeBottom
            {
                public static readonly ID ID = new ID("{B3BA9EA9-D0A1-49DF-9F4B-28FA5D353DC8}");
                public const string FieldName = "JavascriptCodeBottom";
            }
            public struct JavascriptCodeTop
            {
                public static readonly ID ID = new ID("{D79D9DDD-2774-42F4-94C3-50C892F6E13D}");
                public const string FieldName = "JavascriptCodeTop";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region Edit Profile Page (/sitecore/templates/Project/Habitat/Page Types/Edit Profile Page)
namespace Project.Habitat.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Edit Profile Page</para>
    /// <para>ID: {867f774a-195e-49d3-8e40-01f18410bb02}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Page Types/Edit Profile Page</para>
    /// </summary>
    [TemplateMapping("{867F774A-195E-49D3-8E40-01F18410BB02}", "InterfaceMap")]
    public partial interface IEditProfilePage : ICustomItemWrapper, Feature.Metadata.IPageMetadata, Feature.Navigation.INavigable, Feature.PageContent.IHasPageContent, Feature.Social.IOpenGraph, Foundation.Indexing.IIndexedItem
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Edit Profile Page</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{867F774A-195E-49D3-8E40-01F18410BB02}", typeof(Guid))]
    [TemplateMapping("{867F774A-195E-49D3-8E40-01F18410BB02}", "")]
    internal partial class EditProfilePageItem : CustomItemWrapper, IEditProfilePage
    {
        private Item _item = null;
        public EditProfilePageItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public EditProfilePageItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public EditProfilePageItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public EditProfilePageItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public virtual IRichTextFieldWrapper Body
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Body", "body"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public string BodyValue
        {
            [DebuggerStepThrough]
            get { return this.Body.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Image
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Image"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string ImageValue
        {
            [DebuggerStepThrough]
            get { return this.Image.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public virtual IBooleanFieldWrapper IncludeInSearchResults
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("IncludeInSearchResults", "includeinsearchresults"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public bool IncludeInSearchResultsValue
        {
            [DebuggerStepThrough]
            get { return this.IncludeInSearchResults.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual IRichTextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Edit Profile Page</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Edit Profile Page</para>
    /// <summary>
    public static class EditProfilePageConstants
    {
        public static readonly ID TemplateID = new ID("{867F774A-195E-49D3-8E40-01F18410BB02}");
        public const string TemplateName = "Edit Profile Page";

        public struct Fields
        {
            public struct Body
            {
                public static readonly ID ID = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
                public const string FieldName = "Body";
            }
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct Image
            {
                public static readonly ID ID = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
                public const string FieldName = "Image";
            }
            public struct IncludeInSearchResults
            {
                public static readonly ID ID = new ID("{8D5C486E-A0E3-4DBE-9A4A-CDFF93594BDA}");
                public const string FieldName = "IncludeInSearchResults";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region Employee (/sitecore/templates/Project/Habitat/Page Types/Employee)
namespace Project.Habitat.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Employee</para>
    /// <para>ID: {467c2144-4454-4518-b1de-e31b4cbbff33}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Page Types/Employee</para>
    /// </summary>
    [TemplateMapping("{467C2144-4454-4518-B1DE-E31B4CBBFF33}", "InterfaceMap")]
    public partial interface IEmployee : ICustomItemWrapper, Feature.Metadata.IPageMetadata, Feature.Navigation.INavigable, Feature.Person.IEmployee, Feature.Person.IPerson, Feature.Social.IOpenGraph, Foundation.Assets.IPageAssets, Foundation.Indexing.IIndexedItem
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Employee</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{467C2144-4454-4518-B1DE-E31B4CBBFF33}", typeof(Guid))]
    [TemplateMapping("{467C2144-4454-4518-B1DE-E31B4CBBFF33}", "")]
    internal partial class EmployeeItem : CustomItemWrapper, IEmployee
    {
        private Item _item = null;
        public EmployeeItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public EmployeeItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public EmployeeItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public EmployeeItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Biography</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("biography")]
        public virtual IRichTextFieldWrapper Biography
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Biography", "biography"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Biography</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("biography")]
        public string BiographyValue
        {
            [DebuggerStepThrough]
            get { return this.Biography.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: BlogLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("bloglink")]
        public virtual ICustomGeneralLinkFieldWrapper BlogLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("BlogLink", "bloglink"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: BlogLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("bloglink")]
        public string BlogLinkValue
        {
            [DebuggerStepThrough]
            get { return this.BlogLink.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public virtual ITextFieldWrapper CssCode
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CssCode", "csscode"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public string CssCodeValue
        {
            [DebuggerStepThrough]
            get { return this.CssCode.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Email</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("email")]
        public virtual ITextFieldWrapper Email
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Email", "email"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Email</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("email")]
        public string EmailValue
        {
            [DebuggerStepThrough]
            get { return this.Email.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: FacebookLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("facebooklink")]
        public virtual ICustomGeneralLinkFieldWrapper FacebookLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("FacebookLink", "facebooklink"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: FacebookLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("facebooklink")]
        public string FacebookLinkValue
        {
            [DebuggerStepThrough]
            get { return this.FacebookLink.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public virtual IBooleanFieldWrapper IncludeInSearchResults
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("IncludeInSearchResults", "includeinsearchresults"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public bool IncludeInSearchResultsValue
        {
            [DebuggerStepThrough]
            get { return this.IncludeInSearchResults.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public virtual IBooleanFieldWrapper InheritAssets
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("InheritAssets", "inheritassets"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public bool InheritAssetsValue
        {
            [DebuggerStepThrough]
            get { return this.InheritAssets.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public virtual ITextFieldWrapper JavascriptCodeBottom
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeBottom", "javascriptcodebottom"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public string JavascriptCodeBottomValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeBottom.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public virtual ITextFieldWrapper JavascriptCodeTop
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeTop", "javascriptcodetop"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public string JavascriptCodeTopValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeTop.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: LinkedInLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("linkedinlink")]
        public virtual ICustomGeneralLinkFieldWrapper LinkedInLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("LinkedInLink", "linkedinlink"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: LinkedInLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("linkedinlink")]
        public string LinkedInLinkValue
        {
            [DebuggerStepThrough]
            get { return this.LinkedInLink.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Mobile</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mobile")]
        public virtual ITextFieldWrapper Mobile
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Mobile", "mobile"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Mobile</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mobile")]
        public string MobileValue
        {
            [DebuggerStepThrough]
            get { return this.Mobile.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public virtual ITextFieldWrapper Name
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Name", "name"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Name</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("name")]
        public string NameValue
        {
            [DebuggerStepThrough]
            get { return this.Name.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Picture</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Picture
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Picture"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Picture</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string PictureValue
        {
            [DebuggerStepThrough]
            get { return this.Picture.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual ITextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Telephone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("telephone")]
        public virtual ITextFieldWrapper Telephone
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Telephone", "telephone"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Telephone</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("telephone")]
        public string TelephoneValue
        {
            [DebuggerStepThrough]
            get { return this.Telephone.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: TwitterLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterlink")]
        public virtual ICustomGeneralLinkFieldWrapper TwitterLink
        {
            [DebuggerStepThrough]
            get { return GetField<CustomGeneralLinkFieldWrapper>("TwitterLink", "twitterlink"); }
        }

        /// <summary>
        /// <para>Template: Employee</para>
        /// <para>Field: TwitterLink</para>
        /// <para>Data type: General Link</para>
        /// </summary>
        [IndexField("twitterlink")]
        public string TwitterLinkValue
        {
            [DebuggerStepThrough]
            get { return this.TwitterLink.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Employee</para>
    /// <summary>
    public static class EmployeeConstants
    {
        public static readonly ID TemplateID = new ID("{467C2144-4454-4518-B1DE-E31B4CBBFF33}");
        public const string TemplateName = "Employee";

        public struct Fields
        {
            public struct Biography
            {
                public static readonly ID ID = new ID("{0CC9785E-54FE-4FAE-93E4-D0D2AE75F339}");
                public const string FieldName = "Biography";
            }
            public struct BlogLink
            {
                public static readonly ID ID = new ID("{69A846D9-4C7F-435C-A8DC-87E2D7359CFA}");
                public const string FieldName = "BlogLink";
            }
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CssCode
            {
                public static readonly ID ID = new ID("{06A96EFC-F2E5-45C3-A7DC-4DDDFA366CC0}");
                public const string FieldName = "CssCode";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct Email
            {
                public static readonly ID ID = new ID("{5978B330-1D46-4065-8751-F74BF17D815E}");
                public const string FieldName = "Email";
            }
            public struct FacebookLink
            {
                public static readonly ID ID = new ID("{D31889C0-E34C-4904-A6F3-F3D92D314AA9}");
                public const string FieldName = "FacebookLink";
            }
            public struct IncludeInSearchResults
            {
                public static readonly ID ID = new ID("{8D5C486E-A0E3-4DBE-9A4A-CDFF93594BDA}");
                public const string FieldName = "IncludeInSearchResults";
            }
            public struct InheritAssets
            {
                public static readonly ID ID = new ID("{F19E8A50-9950-4861-9E66-9598A1898E71}");
                public const string FieldName = "InheritAssets";
            }
            public struct JavascriptCodeBottom
            {
                public static readonly ID ID = new ID("{B3BA9EA9-D0A1-49DF-9F4B-28FA5D353DC8}");
                public const string FieldName = "JavascriptCodeBottom";
            }
            public struct JavascriptCodeTop
            {
                public static readonly ID ID = new ID("{D79D9DDD-2774-42F4-94C3-50C892F6E13D}");
                public const string FieldName = "JavascriptCodeTop";
            }
            public struct LinkedInLink
            {
                public static readonly ID ID = new ID("{2B13DFAB-3450-45EF-93F4-BEAA6F544FA6}");
                public const string FieldName = "LinkedInLink";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct Mobile
            {
                public static readonly ID ID = new ID("{25B4CEE3-A61A-4DC3-BB52-775DD509DBB5}");
                public const string FieldName = "Mobile";
            }
            public struct Name
            {
                public static readonly ID ID = new ID("{26CD59AB-3639-488F-BAFD-58D2B217755A}");
                public const string FieldName = "Name";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
            public struct Picture
            {
                public static readonly ID ID = new ID("{C9BAF3EB-8CFA-4BF6-9B19-51D38DB5FC38}");
                public const string FieldName = "Picture";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{B897023C-15D2-49F3-8974-06FA5FB7AD00}");
                public const string FieldName = "Summary";
            }
            public struct Telephone
            {
                public static readonly ID ID = new ID("{8D0E8EE3-21C4-4AE2-A2F1-53D3F3EBE501}");
                public const string FieldName = "Telephone";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{76972FCD-4BB0-4255-864E-077745EFDF50}");
                public const string FieldName = "Title";
            }
            public struct TwitterLink
            {
                public static readonly ID ID = new ID("{6DE98EF7-1209-40A3-A63E-16DBEF015211}");
                public const string FieldName = "TwitterLink";
            }
        }
    }
    
}
#endregion

#region Employees folder (/sitecore/templates/Project/Habitat/Page Types/Employees folder)
namespace Project.Habitat.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Employees folder</para>
    /// <para>ID: {51e2ff7f-6fb3-4470-91c8-d2ad97bf1eae}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Page Types/Employees folder</para>
    /// </summary>
    [TemplateMapping("{51E2FF7F-6FB3-4470-91C8-D2AD97BF1EAE}", "InterfaceMap")]
    public partial interface IEmployeesFolder : ICustomItemWrapper, Feature.Metadata.IPageMetadata, Feature.Navigation.INavigable, Feature.PageContent.IHasPageContent, Feature.Social.IOpenGraph, Foundation.Assets.IPageAssets, Foundation.Indexing.IIndexedItem, Project.Habitat.PageTypes.IArticle
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Employees folder</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{51E2FF7F-6FB3-4470-91C8-D2AD97BF1EAE}", typeof(Guid))]
    [TemplateMapping("{51E2FF7F-6FB3-4470-91C8-D2AD97BF1EAE}", "")]
    internal partial class EmployeesFolderItem : CustomItemWrapper, IEmployeesFolder
    {
        private Item _item = null;
        public EmployeesFolderItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public EmployeesFolderItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public EmployeesFolderItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public EmployeesFolderItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public virtual IRichTextFieldWrapper Body
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Body", "body"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public string BodyValue
        {
            [DebuggerStepThrough]
            get { return this.Body.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public virtual ITextFieldWrapper CssCode
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CssCode", "csscode"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public string CssCodeValue
        {
            [DebuggerStepThrough]
            get { return this.CssCode.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Image
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Image"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string ImageValue
        {
            [DebuggerStepThrough]
            get { return this.Image.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public virtual IBooleanFieldWrapper IncludeInSearchResults
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("IncludeInSearchResults", "includeinsearchresults"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public bool IncludeInSearchResultsValue
        {
            [DebuggerStepThrough]
            get { return this.IncludeInSearchResults.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public virtual IBooleanFieldWrapper InheritAssets
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("InheritAssets", "inheritassets"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public bool InheritAssetsValue
        {
            [DebuggerStepThrough]
            get { return this.InheritAssets.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public virtual ITextFieldWrapper JavascriptCodeBottom
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeBottom", "javascriptcodebottom"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public string JavascriptCodeBottomValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeBottom.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public virtual ITextFieldWrapper JavascriptCodeTop
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeTop", "javascriptcodetop"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public string JavascriptCodeTopValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeTop.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual IRichTextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Employees folder</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Employees folder</para>
    /// <summary>
    public static class EmployeesFolderConstants
    {
        public static readonly ID TemplateID = new ID("{51E2FF7F-6FB3-4470-91C8-D2AD97BF1EAE}");
        public const string TemplateName = "Employees folder";

        public struct Fields
        {
            public struct Body
            {
                public static readonly ID ID = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
                public const string FieldName = "Body";
            }
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CssCode
            {
                public static readonly ID ID = new ID("{06A96EFC-F2E5-45C3-A7DC-4DDDFA366CC0}");
                public const string FieldName = "CssCode";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct Image
            {
                public static readonly ID ID = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
                public const string FieldName = "Image";
            }
            public struct IncludeInSearchResults
            {
                public static readonly ID ID = new ID("{8D5C486E-A0E3-4DBE-9A4A-CDFF93594BDA}");
                public const string FieldName = "IncludeInSearchResults";
            }
            public struct InheritAssets
            {
                public static readonly ID ID = new ID("{F19E8A50-9950-4861-9E66-9598A1898E71}");
                public const string FieldName = "InheritAssets";
            }
            public struct JavascriptCodeBottom
            {
                public static readonly ID ID = new ID("{B3BA9EA9-D0A1-49DF-9F4B-28FA5D353DC8}");
                public const string FieldName = "JavascriptCodeBottom";
            }
            public struct JavascriptCodeTop
            {
                public static readonly ID ID = new ID("{D79D9DDD-2774-42F4-94C3-50C892F6E13D}");
                public const string FieldName = "JavascriptCodeTop";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region Forgot Password Page (/sitecore/templates/Project/Habitat/Page Types/Forgot Password Page)
namespace Project.Habitat.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Forgot Password Page</para>
    /// <para>ID: {8707a0b7-4a7d-44e4-abd6-a1ccb21049cf}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Page Types/Forgot Password Page</para>
    /// </summary>
    [TemplateMapping("{8707A0B7-4A7D-44E4-ABD6-A1CCB21049CF}", "InterfaceMap")]
    public partial interface IForgotPasswordPage : ICustomItemWrapper, Feature.Metadata.IPageMetadata, Feature.Navigation.INavigable, Feature.PageContent.IHasPageContent, Feature.Social.IOpenGraph, Foundation.Indexing.IIndexedItem
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Forgot Password Page</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{8707A0B7-4A7D-44E4-ABD6-A1CCB21049CF}", typeof(Guid))]
    [TemplateMapping("{8707A0B7-4A7D-44E4-ABD6-A1CCB21049CF}", "")]
    internal partial class ForgotPasswordPageItem : CustomItemWrapper, IForgotPasswordPage
    {
        private Item _item = null;
        public ForgotPasswordPageItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public ForgotPasswordPageItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public ForgotPasswordPageItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public ForgotPasswordPageItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public virtual IRichTextFieldWrapper Body
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Body", "body"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public string BodyValue
        {
            [DebuggerStepThrough]
            get { return this.Body.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Image
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Image"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string ImageValue
        {
            [DebuggerStepThrough]
            get { return this.Image.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public virtual IBooleanFieldWrapper IncludeInSearchResults
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("IncludeInSearchResults", "includeinsearchresults"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public bool IncludeInSearchResultsValue
        {
            [DebuggerStepThrough]
            get { return this.IncludeInSearchResults.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual IRichTextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Forgot Password Page</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Forgot Password Page</para>
    /// <summary>
    public static class ForgotPasswordPageConstants
    {
        public static readonly ID TemplateID = new ID("{8707A0B7-4A7D-44E4-ABD6-A1CCB21049CF}");
        public const string TemplateName = "Forgot Password Page";

        public struct Fields
        {
            public struct Body
            {
                public static readonly ID ID = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
                public const string FieldName = "Body";
            }
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct Image
            {
                public static readonly ID ID = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
                public const string FieldName = "Image";
            }
            public struct IncludeInSearchResults
            {
                public static readonly ID ID = new ID("{8D5C486E-A0E3-4DBE-9A4A-CDFF93594BDA}");
                public const string FieldName = "IncludeInSearchResults";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region Home (/sitecore/templates/Project/Habitat/Page Types/Home)
namespace Project.Habitat.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Home</para>
    /// <para>ID: {4a8822cc-b418-4452-ab0f-8bb6df2f2114}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Page Types/Home</para>
    /// </summary>
    [TemplateMapping("{4A8822CC-B418-4452-AB0F-8BB6DF2F2114}", "InterfaceMap")]
    public partial interface IHome : ICustomItemWrapper, Feature.Metadata.IPageMetadata, Feature.Navigation.INavigable, Feature.Navigation.INavigationRoot, Feature.Social.IOpenGraph
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Home</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{4A8822CC-B418-4452-AB0F-8BB6DF2F2114}", typeof(Guid))]
    [TemplateMapping("{4A8822CC-B418-4452-AB0F-8BB6DF2F2114}", "")]
    internal partial class HomeItem : CustomItemWrapper, IHome
    {
        private Item _item = null;
        public HomeItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public HomeItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public HomeItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public HomeItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: Home</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Home</para>
    /// <summary>
    public static class HomeConstants
    {
        public static readonly ID TemplateID = new ID("{4A8822CC-B418-4452-AB0F-8BB6DF2F2114}");
        public const string TemplateName = "Home";

        public struct Fields
        {
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
        }
    }
    
}
#endregion

#region Login Page (/sitecore/templates/Project/Habitat/Page Types/Login Page)
namespace Project.Habitat.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Login Page</para>
    /// <para>ID: {ecc4e901-9c5f-4043-b11e-cfa868d1bb73}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Page Types/Login Page</para>
    /// </summary>
    [TemplateMapping("{ECC4E901-9C5F-4043-B11E-CFA868D1BB73}", "InterfaceMap")]
    public partial interface ILoginPage : ICustomItemWrapper, Feature.Metadata.IPageMetadata, Feature.Navigation.INavigable, Feature.PageContent.IHasPageContent, Feature.Social.IOpenGraph, Foundation.Indexing.IIndexedItem
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Login Page</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{ECC4E901-9C5F-4043-B11E-CFA868D1BB73}", typeof(Guid))]
    [TemplateMapping("{ECC4E901-9C5F-4043-B11E-CFA868D1BB73}", "")]
    internal partial class LoginPageItem : CustomItemWrapper, ILoginPage
    {
        private Item _item = null;
        public LoginPageItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public LoginPageItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public LoginPageItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public LoginPageItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public virtual IRichTextFieldWrapper Body
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Body", "body"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public string BodyValue
        {
            [DebuggerStepThrough]
            get { return this.Body.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Image
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Image"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string ImageValue
        {
            [DebuggerStepThrough]
            get { return this.Image.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public virtual IBooleanFieldWrapper IncludeInSearchResults
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("IncludeInSearchResults", "includeinsearchresults"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public bool IncludeInSearchResultsValue
        {
            [DebuggerStepThrough]
            get { return this.IncludeInSearchResults.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual IRichTextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Login Page</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Login Page</para>
    /// <summary>
    public static class LoginPageConstants
    {
        public static readonly ID TemplateID = new ID("{ECC4E901-9C5F-4043-B11E-CFA868D1BB73}");
        public const string TemplateName = "Login Page";

        public struct Fields
        {
            public struct Body
            {
                public static readonly ID ID = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
                public const string FieldName = "Body";
            }
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct Image
            {
                public static readonly ID ID = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
                public const string FieldName = "Image";
            }
            public struct IncludeInSearchResults
            {
                public static readonly ID ID = new ID("{8D5C486E-A0E3-4DBE-9A4A-CDFF93594BDA}");
                public const string FieldName = "IncludeInSearchResults";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region Map Page (/sitecore/templates/Project/Habitat/Page Types/Map Page)
namespace Project.Habitat.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Map Page</para>
    /// <para>ID: {ee9e5bdb-7d71-48f7-b461-42bf9c2052ec}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Page Types/Map Page</para>
    /// </summary>
    [TemplateMapping("{EE9E5BDB-7D71-48F7-B461-42BF9C2052EC}", "InterfaceMap")]
    public partial interface IMapPage : ICustomItemWrapper, Feature.Maps.IMapPoint, Feature.Metadata.IPageMetadata, Feature.Navigation.INavigable, Feature.PageContent.IHasPageContent, Feature.Social.IOpenGraph, Foundation.Assets.IPageAssets, Foundation.Indexing.IIndexedItem
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Map Page</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{EE9E5BDB-7D71-48F7-B461-42BF9C2052EC}", typeof(Guid))]
    [TemplateMapping("{EE9E5BDB-7D71-48F7-B461-42BF9C2052EC}", "")]
    internal partial class MapPageItem : CustomItemWrapper, IMapPage
    {
        private Item _item = null;
        public MapPageItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public MapPageItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public MapPageItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public MapPageItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public virtual IRichTextFieldWrapper Body
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Body", "body"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public string BodyValue
        {
            [DebuggerStepThrough]
            get { return this.Body.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public virtual ITextFieldWrapper CssCode
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CssCode", "csscode"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public string CssCodeValue
        {
            [DebuggerStepThrough]
            get { return this.CssCode.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Image
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Image"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string ImageValue
        {
            [DebuggerStepThrough]
            get { return this.Image.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public virtual IBooleanFieldWrapper IncludeInSearchResults
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("IncludeInSearchResults", "includeinsearchresults"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public bool IncludeInSearchResultsValue
        {
            [DebuggerStepThrough]
            get { return this.IncludeInSearchResults.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public virtual IBooleanFieldWrapper InheritAssets
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("InheritAssets", "inheritassets"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public bool InheritAssetsValue
        {
            [DebuggerStepThrough]
            get { return this.InheritAssets.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public virtual ITextFieldWrapper JavascriptCodeBottom
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeBottom", "javascriptcodebottom"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public string JavascriptCodeBottomValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeBottom.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public virtual ITextFieldWrapper JavascriptCodeTop
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeTop", "javascriptcodetop"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public string JavascriptCodeTopValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeTop.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: MapPointAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("mappointaddress")]
        public virtual ITextFieldWrapper MapPointAddress
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MapPointAddress", "mappointaddress"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: MapPointAddress</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("mappointaddress")]
        public string MapPointAddressValue
        {
            [DebuggerStepThrough]
            get { return this.MapPointAddress.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: MapPointLocation</para>
        /// <para>Data type: Map Field</para>
        /// </summary>
        public virtual ITextFieldWrapper MapPointLocation
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MapPointLocation"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: MapPointLocation</para>
        /// <para>Data type: Map Field</para>
        /// </summary>
        public string MapPointLocationValue
        {
            [DebuggerStepThrough]
            get { return this.MapPointLocation.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: MapPointName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mappointname")]
        public virtual ITextFieldWrapper MapPointName
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MapPointName", "mappointname"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: MapPointName</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("mappointname")]
        public string MapPointNameValue
        {
            [DebuggerStepThrough]
            get { return this.MapPointName.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual IRichTextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Map Page</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Map Page</para>
    /// <summary>
    public static class MapPageConstants
    {
        public static readonly ID TemplateID = new ID("{EE9E5BDB-7D71-48F7-B461-42BF9C2052EC}");
        public const string TemplateName = "Map Page";

        public struct Fields
        {
            public struct Body
            {
                public static readonly ID ID = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
                public const string FieldName = "Body";
            }
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CssCode
            {
                public static readonly ID ID = new ID("{06A96EFC-F2E5-45C3-A7DC-4DDDFA366CC0}");
                public const string FieldName = "CssCode";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct Image
            {
                public static readonly ID ID = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
                public const string FieldName = "Image";
            }
            public struct IncludeInSearchResults
            {
                public static readonly ID ID = new ID("{8D5C486E-A0E3-4DBE-9A4A-CDFF93594BDA}");
                public const string FieldName = "IncludeInSearchResults";
            }
            public struct InheritAssets
            {
                public static readonly ID ID = new ID("{F19E8A50-9950-4861-9E66-9598A1898E71}");
                public const string FieldName = "InheritAssets";
            }
            public struct JavascriptCodeBottom
            {
                public static readonly ID ID = new ID("{B3BA9EA9-D0A1-49DF-9F4B-28FA5D353DC8}");
                public const string FieldName = "JavascriptCodeBottom";
            }
            public struct JavascriptCodeTop
            {
                public static readonly ID ID = new ID("{D79D9DDD-2774-42F4-94C3-50C892F6E13D}");
                public const string FieldName = "JavascriptCodeTop";
            }
            public struct MapPointAddress
            {
                public static readonly ID ID = new ID("{0295C01D-214C-4C23-AFC2-3F0B4E88B643}");
                public const string FieldName = "MapPointAddress";
            }
            public struct MapPointLocation
            {
                public static readonly ID ID = new ID("{F686AC8E-1D33-45DB-8E1A-1B40CD491E7A}");
                public const string FieldName = "MapPointLocation";
            }
            public struct MapPointName
            {
                public static readonly ID ID = new ID("{F12C22BB-E57D-4FAB-96E1-1229E4E7FF0E}");
                public const string FieldName = "MapPointName";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region News Article (/sitecore/templates/Project/Habitat/Page Types/News Article)
namespace Project.Habitat.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: News Article</para>
    /// <para>ID: {b69277ad-e917-4b9f-9136-a12e0a3e462f}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Page Types/News Article</para>
    /// </summary>
    [TemplateMapping("{B69277AD-E917-4B9F-9136-A12E0A3E462F}", "InterfaceMap")]
    public partial interface INewsArticle : ICustomItemWrapper, Feature.Metadata.IPageMetadata, Feature.News.INewsArticle, Feature.Social.IOpenGraph, Foundation.Assets.IPageAssets, Foundation.Indexing.IIndexedItem
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/News Article</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{B69277AD-E917-4B9F-9136-A12E0A3E462F}", typeof(Guid))]
    [TemplateMapping("{B69277AD-E917-4B9F-9136-A12E0A3E462F}", "")]
    internal partial class NewsArticleItem : CustomItemWrapper, INewsArticle
    {
        private Item _item = null;
        public NewsArticleItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public NewsArticleItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public NewsArticleItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public NewsArticleItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public virtual ITextFieldWrapper CssCode
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CssCode", "csscode"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public string CssCodeValue
        {
            [DebuggerStepThrough]
            get { return this.CssCode.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public virtual IBooleanFieldWrapper IncludeInSearchResults
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("IncludeInSearchResults", "includeinsearchresults"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public bool IncludeInSearchResultsValue
        {
            [DebuggerStepThrough]
            get { return this.IncludeInSearchResults.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public virtual IBooleanFieldWrapper InheritAssets
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("InheritAssets", "inheritassets"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public bool InheritAssetsValue
        {
            [DebuggerStepThrough]
            get { return this.InheritAssets.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public virtual ITextFieldWrapper JavascriptCodeBottom
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeBottom", "javascriptcodebottom"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public string JavascriptCodeBottomValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeBottom.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public virtual ITextFieldWrapper JavascriptCodeTop
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeTop", "javascriptcodetop"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public string JavascriptCodeTopValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeTop.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: NewsBody</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("newsbody")]
        public virtual IRichTextFieldWrapper NewsBody
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("NewsBody", "newsbody"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: NewsBody</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("newsbody")]
        public string NewsBodyValue
        {
            [DebuggerStepThrough]
            get { return this.NewsBody.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: NewsDate</para>
        /// <para>Data type: Datetime</para>
        /// </summary>
        [IndexField("newsdate")]
        public virtual IDateTimeFieldWrapper NewsDate
        {
            [DebuggerStepThrough]
            get { return GetField<DateTimeFieldWrapper>("NewsDate", "newsdate"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: NewsDate</para>
        /// <para>Data type: Datetime</para>
        /// </summary>
        [IndexField("newsdate")]
        public DateTime NewsDateValue
        {
            [DebuggerStepThrough]
            get { return this.NewsDate.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: NewsImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper NewsImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("NewsImage"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: NewsImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string NewsImageValue
        {
            [DebuggerStepThrough]
            get { return this.NewsImage.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: NewsSummary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("newssummary")]
        public virtual IRichTextFieldWrapper NewsSummary
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("NewsSummary", "newssummary"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: NewsSummary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("newssummary")]
        public string NewsSummaryValue
        {
            [DebuggerStepThrough]
            get { return this.NewsSummary.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: NewsTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("newstitle")]
        public virtual ITextFieldWrapper NewsTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NewsTitle", "newstitle"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: NewsTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("newstitle")]
        public string NewsTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NewsTitle.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: News Article</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/News Article</para>
    /// <summary>
    public static class NewsArticleConstants
    {
        public static readonly ID TemplateID = new ID("{B69277AD-E917-4B9F-9136-A12E0A3E462F}");
        public const string TemplateName = "News Article";

        public struct Fields
        {
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CssCode
            {
                public static readonly ID ID = new ID("{06A96EFC-F2E5-45C3-A7DC-4DDDFA366CC0}");
                public const string FieldName = "CssCode";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct IncludeInSearchResults
            {
                public static readonly ID ID = new ID("{8D5C486E-A0E3-4DBE-9A4A-CDFF93594BDA}");
                public const string FieldName = "IncludeInSearchResults";
            }
            public struct InheritAssets
            {
                public static readonly ID ID = new ID("{F19E8A50-9950-4861-9E66-9598A1898E71}");
                public const string FieldName = "InheritAssets";
            }
            public struct JavascriptCodeBottom
            {
                public static readonly ID ID = new ID("{B3BA9EA9-D0A1-49DF-9F4B-28FA5D353DC8}");
                public const string FieldName = "JavascriptCodeBottom";
            }
            public struct JavascriptCodeTop
            {
                public static readonly ID ID = new ID("{D79D9DDD-2774-42F4-94C3-50C892F6E13D}");
                public const string FieldName = "JavascriptCodeTop";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct NewsBody
            {
                public static readonly ID ID = new ID("{801612C7-5E98-4E3C-80D2-A34D0EEBCBDA}");
                public const string FieldName = "NewsBody";
            }
            public struct NewsDate
            {
                public static readonly ID ID = new ID("{C464D2D7-3382-428A-BCDF-0963C60BA0E3}");
                public const string FieldName = "NewsDate";
            }
            public struct NewsImage
            {
                public static readonly ID ID = new ID("{3437EAAC-6EE8-460B-A33D-DA1F714B5A93}");
                public const string FieldName = "NewsImage";
            }
            public struct NewsSummary
            {
                public static readonly ID ID = new ID("{9D08271A-1672-44DD-B7EF-0A6EC34FCBA7}");
                public const string FieldName = "NewsSummary";
            }
            public struct NewsTitle
            {
                public static readonly ID ID = new ID("{BD9ECD4A-C0B0-4233-A3CD-D995519AC87B}");
                public const string FieldName = "NewsTitle";
            }
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
        }
    }
    
}
#endregion

#region News List (/sitecore/templates/Project/Habitat/Page Types/News List)
namespace Project.Habitat.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: News List</para>
    /// <para>ID: {a99866e5-08e7-44d8-8a52-f8e26bcd3714}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Page Types/News List</para>
    /// </summary>
    [TemplateMapping("{A99866E5-08E7-44D8-8A52-F8E26BCD3714}", "InterfaceMap")]
    public partial interface INewsList : ICustomItemWrapper, Feature.Metadata.IPageMetadata, Feature.Navigation.INavigable, Feature.News.INewsFolder, Feature.PageContent.IHasPageContent, Feature.Social.IOpenGraph, Foundation.Assets.IPageAssets
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/News List</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{A99866E5-08E7-44D8-8A52-F8E26BCD3714}", typeof(Guid))]
    [TemplateMapping("{A99866E5-08E7-44D8-8A52-F8E26BCD3714}", "")]
    internal partial class NewsListItem : CustomItemWrapper, INewsList
    {
        private Item _item = null;
        public NewsListItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public NewsListItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public NewsListItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public NewsListItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public virtual IRichTextFieldWrapper Body
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Body", "body"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public string BodyValue
        {
            [DebuggerStepThrough]
            get { return this.Body.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public virtual ITextFieldWrapper CssCode
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CssCode", "csscode"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public string CssCodeValue
        {
            [DebuggerStepThrough]
            get { return this.CssCode.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Image
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Image"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string ImageValue
        {
            [DebuggerStepThrough]
            get { return this.Image.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public virtual IBooleanFieldWrapper InheritAssets
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("InheritAssets", "inheritassets"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public bool InheritAssetsValue
        {
            [DebuggerStepThrough]
            get { return this.InheritAssets.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public virtual ITextFieldWrapper JavascriptCodeBottom
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeBottom", "javascriptcodebottom"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public string JavascriptCodeBottomValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeBottom.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public virtual ITextFieldWrapper JavascriptCodeTop
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeTop", "javascriptcodetop"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public string JavascriptCodeTopValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeTop.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual IRichTextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: News List</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/News List</para>
    /// <summary>
    public static class NewsListConstants
    {
        public static readonly ID TemplateID = new ID("{A99866E5-08E7-44D8-8A52-F8E26BCD3714}");
        public const string TemplateName = "News List";

        public struct Fields
        {
            public struct Body
            {
                public static readonly ID ID = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
                public const string FieldName = "Body";
            }
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CssCode
            {
                public static readonly ID ID = new ID("{06A96EFC-F2E5-45C3-A7DC-4DDDFA366CC0}");
                public const string FieldName = "CssCode";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct Image
            {
                public static readonly ID ID = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
                public const string FieldName = "Image";
            }
            public struct InheritAssets
            {
                public static readonly ID ID = new ID("{F19E8A50-9950-4861-9E66-9598A1898E71}");
                public const string FieldName = "InheritAssets";
            }
            public struct JavascriptCodeBottom
            {
                public static readonly ID ID = new ID("{B3BA9EA9-D0A1-49DF-9F4B-28FA5D353DC8}");
                public const string FieldName = "JavascriptCodeBottom";
            }
            public struct JavascriptCodeTop
            {
                public static readonly ID ID = new ID("{D79D9DDD-2774-42F4-94C3-50C892F6E13D}");
                public const string FieldName = "JavascriptCodeTop";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region Register Page (/sitecore/templates/Project/Habitat/Page Types/Register Page)
namespace Project.Habitat.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Register Page</para>
    /// <para>ID: {6ef8f8a0-c567-495b-9e00-8775a268a486}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Page Types/Register Page</para>
    /// </summary>
    [TemplateMapping("{6EF8F8A0-C567-495B-9E00-8775A268A486}", "InterfaceMap")]
    public partial interface IRegisterPage : ICustomItemWrapper, Feature.Metadata.IPageMetadata, Feature.Navigation.INavigable, Feature.PageContent.IHasPageContent, Feature.Social.IOpenGraph, Foundation.Indexing.IIndexedItem
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Register Page</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{6EF8F8A0-C567-495B-9E00-8775A268A486}", typeof(Guid))]
    [TemplateMapping("{6EF8F8A0-C567-495B-9E00-8775A268A486}", "")]
    internal partial class RegisterPageItem : CustomItemWrapper, IRegisterPage
    {
        private Item _item = null;
        public RegisterPageItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public RegisterPageItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public RegisterPageItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public RegisterPageItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public virtual IRichTextFieldWrapper Body
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Body", "body"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public string BodyValue
        {
            [DebuggerStepThrough]
            get { return this.Body.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Image
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Image"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string ImageValue
        {
            [DebuggerStepThrough]
            get { return this.Image.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public virtual IBooleanFieldWrapper IncludeInSearchResults
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("IncludeInSearchResults", "includeinsearchresults"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public bool IncludeInSearchResultsValue
        {
            [DebuggerStepThrough]
            get { return this.IncludeInSearchResults.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual IRichTextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Register Page</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Register Page</para>
    /// <summary>
    public static class RegisterPageConstants
    {
        public static readonly ID TemplateID = new ID("{6EF8F8A0-C567-495B-9E00-8775A268A486}");
        public const string TemplateName = "Register Page";

        public struct Fields
        {
            public struct Body
            {
                public static readonly ID ID = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
                public const string FieldName = "Body";
            }
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct Image
            {
                public static readonly ID ID = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
                public const string FieldName = "Image";
            }
            public struct IncludeInSearchResults
            {
                public static readonly ID ID = new ID("{8D5C486E-A0E3-4DBE-9A4A-CDFF93594BDA}");
                public const string FieldName = "IncludeInSearchResults";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region Search Results (/sitecore/templates/Project/Habitat/Page Types/Search Results)
namespace Project.Habitat.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Search Results</para>
    /// <para>ID: {92168572-385b-45f0-b40f-3d987ad20e5c}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Page Types/Search Results</para>
    /// </summary>
    [TemplateMapping("{92168572-385B-45F0-B40F-3D987AD20E5C}", "InterfaceMap")]
    public partial interface ISearchResults : ICustomItemWrapper, Feature.Metadata.IPageMetadata, Feature.Navigation.INavigable, Feature.PageContent.IHasPageContent, Feature.Search.ISearchResults, Feature.Social.IOpenGraph, Foundation.Assets.IPageAssets
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Search Results</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{92168572-385B-45F0-B40F-3D987AD20E5C}", typeof(Guid))]
    [TemplateMapping("{92168572-385B-45F0-B40F-3D987AD20E5C}", "")]
    internal partial class SearchResultsItem : CustomItemWrapper, ISearchResults
    {
        private Item _item = null;
        public SearchResultsItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public SearchResultsItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public SearchResultsItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public SearchResultsItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public virtual IRichTextFieldWrapper Body
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Body", "body"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public string BodyValue
        {
            [DebuggerStepThrough]
            get { return this.Body.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public virtual ITextFieldWrapper CssCode
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CssCode", "csscode"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public string CssCodeValue
        {
            [DebuggerStepThrough]
            get { return this.CssCode.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Image
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Image"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string ImageValue
        {
            [DebuggerStepThrough]
            get { return this.Image.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public virtual IBooleanFieldWrapper InheritAssets
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("InheritAssets", "inheritassets"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public bool InheritAssetsValue
        {
            [DebuggerStepThrough]
            get { return this.InheritAssets.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public virtual ITextFieldWrapper JavascriptCodeBottom
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeBottom", "javascriptcodebottom"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public string JavascriptCodeBottomValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeBottom.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public virtual ITextFieldWrapper JavascriptCodeTop
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeTop", "javascriptcodetop"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public string JavascriptCodeTopValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeTop.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: Root</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("root")]
        public virtual ILinkFieldWrapper Root
        {
            [DebuggerStepThrough]
            get { return GetField<LinkFieldWrapper>("Root", "root"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: Root</para>
        /// <para>Data type: Droptree</para>
        /// </summary>
        [IndexField("root")]
        public Guid RootValue
        {
            [DebuggerStepThrough]
            get { return this.Root.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: SearchBoxTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("searchboxtitle")]
        public virtual ITextFieldWrapper SearchBoxTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("SearchBoxTitle", "searchboxtitle"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: SearchBoxTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("searchboxtitle")]
        public string SearchBoxTitleValue
        {
            [DebuggerStepThrough]
            get { return this.SearchBoxTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual IRichTextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Search Results</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Search Results</para>
    /// <summary>
    public static class SearchResultsConstants
    {
        public static readonly ID TemplateID = new ID("{92168572-385B-45F0-B40F-3D987AD20E5C}");
        public const string TemplateName = "Search Results";

        public struct Fields
        {
            public struct Body
            {
                public static readonly ID ID = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
                public const string FieldName = "Body";
            }
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CssCode
            {
                public static readonly ID ID = new ID("{06A96EFC-F2E5-45C3-A7DC-4DDDFA366CC0}");
                public const string FieldName = "CssCode";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct Image
            {
                public static readonly ID ID = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
                public const string FieldName = "Image";
            }
            public struct InheritAssets
            {
                public static readonly ID ID = new ID("{F19E8A50-9950-4861-9E66-9598A1898E71}");
                public const string FieldName = "InheritAssets";
            }
            public struct JavascriptCodeBottom
            {
                public static readonly ID ID = new ID("{B3BA9EA9-D0A1-49DF-9F4B-28FA5D353DC8}");
                public const string FieldName = "JavascriptCodeBottom";
            }
            public struct JavascriptCodeTop
            {
                public static readonly ID ID = new ID("{D79D9DDD-2774-42F4-94C3-50C892F6E13D}");
                public const string FieldName = "JavascriptCodeTop";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
            public struct Root
            {
                public static readonly ID ID = new ID("{CD904125-3AE5-4709-9E6D-71473C5D5007}");
                public const string FieldName = "Root";
            }
            public struct SearchBoxTitle
            {
                public static readonly ID ID = new ID("{80E30DD8-8021-45F5-9FE1-23D2702CC206}");
                public const string FieldName = "SearchBoxTitle";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

#region Section (/sitecore/templates/Project/Habitat/Page Types/Section)
namespace Project.Habitat.PageTypes
{
    using Fortis.Model;
    using Fortis.Model.Fields;
    using Fortis.Providers;
    using CustomWrappers;
    /// <summary>
    /// <para>Template interface</para>
    /// <para>Template: Section</para>
    /// <para>ID: {8ee208f9-a6a6-41e2-88a0-c188737a178c}</para>
    /// <para>Path: /sitecore/templates/Project/Habitat/Page Types/Section</para>
    /// </summary>
    [TemplateMapping("{8EE208F9-A6A6-41E2-88A0-C188737A178C}", "InterfaceMap")]
    public partial interface ISection : ICustomItemWrapper, Feature.Metadata.IPageMetadata, Feature.Navigation.INavigable, Feature.PageContent.IHasPageContent, Feature.Social.IOpenGraph, Foundation.Assets.IPageAssets, Foundation.Indexing.IIndexedItem
    {
    }

    /// <summary>
    /// <para>Template class</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Section</para>
    /// </summary>
    [PredefinedQuery("TemplateId", ComparisonType.Equal, "{8EE208F9-A6A6-41E2-88A0-C188737A178C}", typeof(Guid))]
    [TemplateMapping("{8EE208F9-A6A6-41E2-88A0-C188737A178C}", "")]
    internal partial class SectionItem : CustomItemWrapper, ISection
    {
        private Item _item = null;
        public SectionItem(ISpawnProvider spawnProvider) : base(null, spawnProvider) { }
        public SectionItem(Guid id, ISpawnProvider spawnProvider) : base(id, spawnProvider) { }
        public SectionItem(Guid id, Dictionary<string, object> lazyFields, ISpawnProvider spawnProvider) : base(id, lazyFields, spawnProvider) { }
        public SectionItem(Item item, ISpawnProvider spawnProvider) : base(item, spawnProvider)
        {
            _item = item;
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public virtual IRichTextFieldWrapper Body
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Body", "body"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: Body</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("body")]
        public string BodyValue
        {
            [DebuggerStepThrough]
            get { return this.Body.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public virtual ITextFieldWrapper BrowserTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("BrowserTitle", "browsertitle"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: BrowserTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("browsertitle")]
        public string BrowserTitleValue
        {
            [DebuggerStepThrough]
            get { return this.BrowserTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public virtual IBooleanFieldWrapper CanIndex
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("CanIndex", "canindex"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: CanIndex</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("canindex")]
        public bool CanIndexValue
        {
            [DebuggerStepThrough]
            get { return this.CanIndex.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public virtual ITextFieldWrapper CssCode
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CssCode", "csscode"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: CssCode</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("csscode")]
        public string CssCodeValue
        {
            [DebuggerStepThrough]
            get { return this.CssCode.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public virtual ITextFieldWrapper CustomMetaData
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("CustomMetaData", "custommetadata"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: CustomMetaData</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("custommetadata")]
        public string CustomMetaDataValue
        {
            [DebuggerStepThrough]
            get { return this.CustomMetaData.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper Image
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("Image"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: Image</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string ImageValue
        {
            [DebuggerStepThrough]
            get { return this.Image.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public virtual IBooleanFieldWrapper IncludeInSearchResults
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("IncludeInSearchResults", "includeinsearchresults"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: IncludeInSearchResults</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("includeinsearchresults")]
        public bool IncludeInSearchResultsValue
        {
            [DebuggerStepThrough]
            get { return this.IncludeInSearchResults.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public virtual IBooleanFieldWrapper InheritAssets
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("InheritAssets", "inheritassets"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: InheritAssets</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("inheritassets")]
        public bool InheritAssetsValue
        {
            [DebuggerStepThrough]
            get { return this.InheritAssets.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public virtual ITextFieldWrapper JavascriptCodeBottom
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeBottom", "javascriptcodebottom"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: JavascriptCodeBottom</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodebottom")]
        public string JavascriptCodeBottomValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeBottom.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public virtual ITextFieldWrapper JavascriptCodeTop
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("JavascriptCodeTop", "javascriptcodetop"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: JavascriptCodeTop</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("javascriptcodetop")]
        public string JavascriptCodeTopValue
        {
            [DebuggerStepThrough]
            get { return this.JavascriptCodeTop.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public virtual ITextFieldWrapper MetaDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("MetaDescription", "metadescription"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: MetaDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("metadescription")]
        public string MetaDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.MetaDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public virtual IListFieldWrapper MetaKeywords
        {
            [DebuggerStepThrough]
            get { return GetField<ListFieldWrapper>("MetaKeywords", "metakeywords"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: MetaKeywords</para>
        /// <para>Data type: Treelist</para>
        /// </summary>
        [IndexField("metakeywords")]
        public IEnumerable<Guid> MetaKeywordsValue
        {
            [DebuggerStepThrough]
            get { return this.MetaKeywords.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public virtual ITextFieldWrapper NavigationTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("NavigationTitle", "navigationtitle"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: NavigationTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("navigationtitle")]
        public string NavigationTitleValue
        {
            [DebuggerStepThrough]
            get { return this.NavigationTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public virtual ITextFieldWrapper OpenGraphDescription
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphDescription", "opengraphdescription"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: OpenGraphDescription</para>
        /// <para>Data type: Multi-Line Text</para>
        /// </summary>
        [IndexField("opengraphdescription")]
        public string OpenGraphDescriptionValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphDescription.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public virtual ICustomImageFieldWrapper OpenGraphImage
        {
            [DebuggerStepThrough]
            get { return GetField<CustomImageFieldWrapper>("OpenGraphImage"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: OpenGraphImage</para>
        /// <para>Data type: Image</para>
        /// </summary>
        public string OpenGraphImageValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphImage.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public virtual ITextFieldWrapper OpenGraphTitle
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("OpenGraphTitle", "opengraphtitle"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: OpenGraphTitle</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("opengraphtitle")]
        public string OpenGraphTitleValue
        {
            [DebuggerStepThrough]
            get { return this.OpenGraphTitle.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public virtual IBooleanFieldWrapper SeoFollowLinks
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("SeoFollowLinks", "seofollowlinks"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: SeoFollowLinks</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("seofollowlinks")]
        public bool SeoFollowLinksValue
        {
            [DebuggerStepThrough]
            get { return this.SeoFollowLinks.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public virtual IBooleanFieldWrapper ShowChildren
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowChildren", "showchildren"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: ShowChildren</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showchildren")]
        public bool ShowChildrenValue
        {
            [DebuggerStepThrough]
            get { return this.ShowChildren.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public virtual IBooleanFieldWrapper ShowInNavigation
        {
            [DebuggerStepThrough]
            get { return GetField<BooleanFieldWrapper>("ShowInNavigation", "showinnavigation"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: ShowInNavigation</para>
        /// <para>Data type: Checkbox</para>
        /// </summary>
        [IndexField("showinnavigation")]
        public bool ShowInNavigationValue
        {
            [DebuggerStepThrough]
            get { return this.ShowInNavigation.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public virtual IRichTextFieldWrapper Summary
        {
            [DebuggerStepThrough]
            get { return GetField<RichTextFieldWrapper>("Summary", "summary"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: Summary</para>
        /// <para>Data type: Rich Text</para>
        /// </summary>
        [IndexField("summary")]
        public string SummaryValue
        {
            [DebuggerStepThrough]
            get { return this.Summary.Value; }
        }
        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public virtual ITextFieldWrapper Title
        {
            [DebuggerStepThrough]
            get { return GetField<TextFieldWrapper>("Title", "title"); }
        }

        /// <summary>
        /// <para>Template: Section</para>
        /// <para>Field: Title</para>
        /// <para>Data type: Single-Line Text</para>
        /// </summary>
        [IndexField("title")]
        public string TitleValue
        {
            [DebuggerStepThrough]
            get { return this.Title.Value; }
        }
	
    }

    /// <summary>
    /// <para>Constants class for accessing template ID and field ID and names.</para>
    /// <para>/sitecore/templates/Project/Habitat/Page Types/Section</para>
    /// <summary>
    public static class SectionConstants
    {
        public static readonly ID TemplateID = new ID("{8EE208F9-A6A6-41E2-88A0-C188737A178C}");
        public const string TemplateName = "Section";

        public struct Fields
        {
            public struct Body
            {
                public static readonly ID ID = new ID("{D74F396D-5C5E-4916-BD0A-BFD58B6B1967}");
                public const string FieldName = "Body";
            }
            public struct BrowserTitle
            {
                public static readonly ID ID = new ID("{CA0479CE-0BFE-4522-83DE-BA688B380A78}");
                public const string FieldName = "BrowserTitle";
            }
            public struct CanIndex
            {
                public static readonly ID ID = new ID("{683D7237-206A-488F-9DEE-4A4E41FB161D}");
                public const string FieldName = "CanIndex";
            }
            public struct CssCode
            {
                public static readonly ID ID = new ID("{06A96EFC-F2E5-45C3-A7DC-4DDDFA366CC0}");
                public const string FieldName = "CssCode";
            }
            public struct CustomMetaData
            {
                public static readonly ID ID = new ID("{167ABA77-5172-42AF-9F9E-00299113839E}");
                public const string FieldName = "CustomMetaData";
            }
            public struct Image
            {
                public static readonly ID ID = new ID("{9492E0BB-9DF9-46E7-8188-EC795C4ADE44}");
                public const string FieldName = "Image";
            }
            public struct IncludeInSearchResults
            {
                public static readonly ID ID = new ID("{8D5C486E-A0E3-4DBE-9A4A-CDFF93594BDA}");
                public const string FieldName = "IncludeInSearchResults";
            }
            public struct InheritAssets
            {
                public static readonly ID ID = new ID("{F19E8A50-9950-4861-9E66-9598A1898E71}");
                public const string FieldName = "InheritAssets";
            }
            public struct JavascriptCodeBottom
            {
                public static readonly ID ID = new ID("{B3BA9EA9-D0A1-49DF-9F4B-28FA5D353DC8}");
                public const string FieldName = "JavascriptCodeBottom";
            }
            public struct JavascriptCodeTop
            {
                public static readonly ID ID = new ID("{D79D9DDD-2774-42F4-94C3-50C892F6E13D}");
                public const string FieldName = "JavascriptCodeTop";
            }
            public struct MetaDescription
            {
                public static readonly ID ID = new ID("{BB7A38C0-323C-4F81-8EB9-288ABF7C4638}");
                public const string FieldName = "MetaDescription";
            }
            public struct MetaKeywords
            {
                public static readonly ID ID = new ID("{4B16F930-73C9-4643-BB1B-00F06E60A073}");
                public const string FieldName = "MetaKeywords";
            }
            public struct NavigationTitle
            {
                public static readonly ID ID = new ID("{1B483E91-D8C4-4D19-BA03-462074B55936}");
                public const string FieldName = "NavigationTitle";
            }
            public struct OpenGraphDescription
            {
                public static readonly ID ID = new ID("{A12D5346-87EE-484D-83C5-F1E8E1B99666}");
                public const string FieldName = "OpenGraphDescription";
            }
            public struct OpenGraphImage
            {
                public static readonly ID ID = new ID("{11F41661-E5FE-44E7-B8DA-7CFF2D39B4B2}");
                public const string FieldName = "OpenGraphImage";
            }
            public struct OpenGraphTitle
            {
                public static readonly ID ID = new ID("{0EE2F208-1FEE-42FC-8051-6696D49A92BF}");
                public const string FieldName = "OpenGraphTitle";
            }
            public struct SeoFollowLinks
            {
                public static readonly ID ID = new ID("{0DCA829C-9FCE-41F5-9990-C6182FEFE905}");
                public const string FieldName = "SeoFollowLinks";
            }
            public struct ShowChildren
            {
                public static readonly ID ID = new ID("{68016087-AA00-45D6-922A-678475C50D4A}");
                public const string FieldName = "ShowChildren";
            }
            public struct ShowInNavigation
            {
                public static readonly ID ID = new ID("{5585A30D-B115-4753-93CE-422C3455DEB2}");
                public const string FieldName = "ShowInNavigation";
            }
            public struct Summary
            {
                public static readonly ID ID = new ID("{AC3FD4DB-8266-476D-9635-67814D91E901}");
                public const string FieldName = "Summary";
            }
            public struct Title
            {
                public static readonly ID ID = new ID("{C30A013F-3CC8-4961-9837-1C483277084A}");
                public const string FieldName = "Title";
            }
        }
    }
    
}
#endregion

}
