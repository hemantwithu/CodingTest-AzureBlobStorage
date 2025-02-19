
namespace AzureBlobApi.Models
{
    public class Property
    {
        public string PropertyId { get; set; }
        public string PropertyName { get; set; }
        public List<Space> Spaces { get; set; }
        public List<string> Features { get; set; }
        public List<string> Highlights { get; set; }
        public List<TransportationModel> Transportation { get; set; }
    }

    public class Space
    {
        public string SpaceId { get; set; }
        public string SpaceName { get; set; }
        public List<RentRollModel> RentRoll { get; set; }
    }
    public class TransportationModel
    {
        public string Type { get; set; }
        public string Line { get; set; }
        public string Distance { get; set; }
    }

    public class RentRollModel
    {
        public string Month { get; set; }
        public int Rent { get; set; }
    }
}