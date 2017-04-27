﻿namespace Sitecore.Foundation.Indexing.Models
{
    using System.Collections.Generic;
    using Sitecore.ContentSearch;
    using Sitecore.ContentSearch.SearchTypes;
    using Fortis.Foundation.CodeGen.Templates.Foundation.Indexing;

    public class IndexedItem : SearchResultItem
    {
        [IndexField(Constants.IndexFields.HasPresentation)]
        public bool HasPresentation { get; set; }

        [IndexField(IndexedItemConstants.Fields.IncludeInSearchResults.FieldName)]
        public bool ShowInSearchResults { get; set; }

        [IndexField(Constants.IndexFields.AllTemplates)]
        public List<string> AllTemplates { get; set; }

        [IndexField(Constants.IndexFields.HasSearchResultFormatter)]
        public bool HasSearchResultFormatter { get; set; }

        [IndexField(Constants.IndexFields.IsLatestVersion)]
        public bool IsLatestVersion { get; set; }
    }
}