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
namespace Xbim.Ifc2x3.ProfileResource
{
	public partial class @IfcIShapeProfileDef : IIfcIShapeProfileDef
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcIShapeProfileDef.OverallWidth 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)OverallWidth);
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcIShapeProfileDef.OverallDepth 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)OverallDepth);
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcIShapeProfileDef.WebThickness 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)WebThickness);
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcIShapeProfileDef.FlangeThickness 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)FlangeThickness);
			} 
		}
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcIShapeProfileDef.FilletRadius 
		{ 
			get
			{
				if (FilletRadius == null) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure((double)FilletRadius);
			} 
		}
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcIShapeProfileDef.FlangeEdgeRadius 
		{ 
			get
			{
				//## Handle return of FlangeEdgeRadius for which no match was found
				//TODO: Handle return of FlangeEdgeRadius for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Ifc4.MeasureResource.IfcPlaneAngleMeasure? IIfcIShapeProfileDef.FlangeSlope 
		{ 
			get
			{
				//## Handle return of FlangeSlope for which no match was found
				//TODO: Handle return of FlangeSlope for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
	}
}