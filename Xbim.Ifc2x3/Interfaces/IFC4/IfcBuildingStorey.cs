// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcBuildingStorey : IIfcBuildingStorey
	{
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcBuildingStorey.Elevation 
		{ 
			get
			{
				if (!Elevation.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(Elevation.Value);
			} 
			set
			{
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcSpatialElement.LongName 
		{ 
			get
			{
				//## Handle return of LongName for which no match was found
                return !Name.HasValue ? null : new Ifc4.MeasureResource.IfcLabel(Name.Value);
				//##
			} 
			set
			{
				
			}
		}
		IEnumerable<IIfcRelContainedInSpatialStructure> IIfcSpatialElement.ContainsElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelContainedInSpatialStructure>(e => (e.RelatingStructure as IfcBuildingStorey) == this, "RelatingStructure", this);
			} 
		}
		IEnumerable<IIfcRelServicesBuildings> IIfcSpatialElement.ServicedBySystems 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelServicesBuildings>(e => e.RelatedBuildings != null &&  e.RelatedBuildings.Contains(this), "RelatedBuildings", this);
			} 
		}
		IEnumerable<IIfcRelReferencedInSpatialStructure> IIfcSpatialElement.ReferencesElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelReferencedInSpatialStructure>(e => (e.RelatingStructure as IfcBuildingStorey) == this, "RelatingStructure", this);
			} 
		}
	//## Custom code
	//##
	}
}