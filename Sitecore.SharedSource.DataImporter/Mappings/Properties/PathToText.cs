﻿using Sitecore.Data.Items;
using Sitecore.Data.Fields;
using Sitecore.SharedSource.DataImporter.Providers;

namespace Sitecore.SharedSource.DataImporter.Mappings.Properties
{
	public class PathToText : BaseMapping, IBaseProperty {

		#region Properties

		#endregion Properties

		#region Constructor

		//constructor
		public PathToText(Item i) : base(i) {

		}

		#endregion Constructor

		#region Methods

		//fills it's own field
        public void FillField(BaseDataMap map, ref Item newItem, Item importRow)
        {
            Field f = newItem.Fields[NewItemField];
            if(f != null)
                f.Value = importRow.Paths.FullPath;
		}

		#endregion Methods
	}
}
