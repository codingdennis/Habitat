﻿namespace Sitecore.Feature.Accounts.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using FluentAssertions;
    using Sitecore;
    using Sitecore.Collections;
    using Sitecore.Data;
    using Sitecore.FakeDb;
    using Sitecore.FakeDb.Sites;
    using Sitecore.Feature.Accounts.Services;
    using Sitecore.Feature.Accounts.Tests.Extensions;
    using Sitecore.Foundation.Testing.Attributes;
    using Sitecore.Sites;
    using Xunit;
    using Fortis.Foundation.CodeGen.Templates.Feature.Accounts;

    public class ProfileSettingsServiceTests
    {
        [Theory, AutoDbData]
        public void GetUserDefaultProfileShoulReturnProfileItem(Db db, ID profileId, ID interestFolderId, ProfileSettingsService profileSettingsService, IEnumerable<string> interests)
        {
            var coreDb = new Db("core");
            var siteContext = this.BuildSiteContext(db, coreDb, profileId, interestFolderId, interests);

            using (new SiteContextSwitcher(siteContext))
                using (coreDb)
                {
                    var item = profileSettingsService.GetUserDefaultProfile();
                    item.Should().NotBeNull();
                    item.ID.Should().Be(profileId);
                }
        }

        [Theory, AutoDbData]
        public void GetUserDefaultProfileShoulReturnListOfInterests(Db db, ID profileId, ID interestFolderId, ProfileSettingsService profileSettingsService, IEnumerable<string> interests)
        {
            var coreDb = new Db("core");
            var siteContext = this.BuildSiteContext(db, coreDb, profileId, interestFolderId, interests);

            using (new SiteContextSwitcher(siteContext))
                using (coreDb)
                {
                    var interestsResult = profileSettingsService.GetInterests();
                    interestsResult.Should().BeEquivalentTo(interests);
                }
        }

        private SiteContext BuildSiteContext(Db db, Db coreDb, ID profileId, ID interestFolder, IEnumerable<string> interests)
        {
            var interestItem = new DbItem("InterestsFolder", interestFolder);
            interests.Select(i => new DbItem(i) {TemplateID = InterestItemConstants.TemplateID, Fields = {new DbField("Title", InterestItemConstants.Fields.Title.ID) {Value = i}}})
                .ToList().ForEach(x => interestItem.Add(x));

            db.Add(new DbItem("siteroot")
            {
                TemplateID = ProfileSettingsItemConstants.TemplateID,
                Fields =
                {
                    new DbField("UserProfile", ProfileSettingsItemConstants.Fields.UserProfile.ID)
                    {
                        Value = profileId.ToString()
                    },
                    new DbField("InterestsFolder", ProfileSettingsItemConstants.Fields.InterestsFolder.ID)
                    {
                        Value = interestFolder.ToString()
                    }
                },
                Children =
                {
                    interestItem
                }
            });

            coreDb.Add(new DbItem("UserProfile", profileId));

            var fakeSite = new FakeSiteContext(new StringDictionary
            {
                {
                    "rootPath", "/sitecore/content/siteroot"
                },
                {
                    "database", "master"
                }
            }) as SiteContext;

            Context.Item = db.GetItem(interestFolder);
            return fakeSite;
        }

    }
}