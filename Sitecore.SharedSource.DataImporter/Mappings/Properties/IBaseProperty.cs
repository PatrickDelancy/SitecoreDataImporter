using Sitecore.Data.Items;
using Sitecore.SharedSource.DataImporter.Providers;

namespace Sitecore.SharedSource.DataImporter.Mappings.Properties {
	public interface IBaseProperty {

		#region Methods

        void FillField(BaseDataMap map, ref Item newItem, Item importRow);

		#endregion Methods
	}
}
