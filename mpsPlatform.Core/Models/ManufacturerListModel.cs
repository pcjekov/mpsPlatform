namespace mpsPlatform.Core.Models
{
	public class ManufacturerListModel
	{
		public IEnumerable<ManufacturerModel> Manufacturers { get; set; } 
			= Enumerable.Empty<ManufacturerModel>();
	}
}
