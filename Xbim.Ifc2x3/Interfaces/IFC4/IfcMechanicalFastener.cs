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
namespace Xbim.Ifc2x3.SharedComponentElements
{
	public partial class @IfcMechanicalFastener : IIfcMechanicalFastener
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcMechanicalFastener.NominalDiameter 
		{ 
			get
			{
				if (!NominalDiameter.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(NominalDiameter.Value);
			} 
			set
			{
				
			}
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcMechanicalFastener.NominalLength 
		{ 
			get
			{
				if (!NominalLength.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(NominalLength.Value);
			} 
			set
			{
				
			}
		}
		Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum? IIfcMechanicalFastener.PredefinedType 
		{ 
			get
			{
				//## Handle return of PredefinedType for which no match was found
			    return null;
			    //##
			} 
			set
			{
				
			}
		}
	//## Custom code
	//##
	}
}