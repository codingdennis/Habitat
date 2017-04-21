namespace Sitecore.Feature.Maps.Models
{
    using Fortis.Foundation.CodeGen.Templates.Feature.Maps;
    public class MapPoint
    {
        public MapPoint()
        {
        }

        public MapPoint(Data.Items.Item item)
        {
            this.Name = item[MapPointConstants.Fields.MapPointName.ID];
            this.Address = item[MapPointConstants.Fields.MapPointAddress.ID];
            this.Location = item[MapPointConstants.Fields.MapPointLocation.ID];
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
    }
}