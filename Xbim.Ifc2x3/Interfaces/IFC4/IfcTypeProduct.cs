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
namespace Xbim.Ifc2x3.Kernel
{
	public partial class @IfcTypeProduct : IIfcTypeProduct
	{
		IEnumerable<IIfcRepresentationMap> IIfcTypeProduct.RepresentationMaps 
		{ 
			get
			{
				foreach (var member in RepresentationMaps)
				{
					yield return member as IIfcRepresentationMap;
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcTypeProduct.Tag 
		{ 
			get
			{
				if (!Tag.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Tag.Value);
			} 
			set
			{
				
			}
		}
		IEnumerable<IIfcRelAssignsToProduct> IIfcTypeProduct.ReferencedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssignsToProduct>(e => (e.RelatingProduct as IfcTypeProduct) == this, "RelatingProduct", this);
			} 
		}
	//## Custom code
	//##
	}
}