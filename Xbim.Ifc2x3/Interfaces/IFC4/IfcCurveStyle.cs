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
namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcCurveStyle : IIfcCurveStyle
	{
		IIfcCurveFontOrScaledCurveFontSelect IIfcCurveStyle.CurveFont 
		{ 
			get
			{
				if (CurveFont == null) return null;
				var ifcpredefinedcurvefont = CurveFont as IfcPreDefinedCurveFont;
				if (ifcpredefinedcurvefont != null) 
					return ifcpredefinedcurvefont;
				var ifccurvestylefont = CurveFont as IfcCurveStyleFont;
				if (ifccurvestylefont != null) 
					return ifccurvestylefont;
				var ifccurvestylefontandscaling = CurveFont as IfcCurveStyleFontAndScaling;
				if (ifccurvestylefontandscaling != null) 
					return ifccurvestylefontandscaling;
				return null;
			} 
			set
			{
				
			}
		}
		IIfcSizeSelect IIfcCurveStyle.CurveWidth 
		{ 
			get
			{
				if (CurveWidth == null) return null;
				if (CurveWidth is MeasureResource.IfcRatioMeasure) 
					return new Ifc4.MeasureResource.IfcRatioMeasure((double)(MeasureResource.IfcRatioMeasure)CurveWidth);
				if (CurveWidth is MeasureResource.IfcLengthMeasure) 
					return new Ifc4.MeasureResource.IfcLengthMeasure((double)(MeasureResource.IfcLengthMeasure)CurveWidth);
				if (CurveWidth is MeasureResource.IfcDescriptiveMeasure) 
					return new Ifc4.MeasureResource.IfcDescriptiveMeasure((string)(MeasureResource.IfcDescriptiveMeasure)CurveWidth);
				if (CurveWidth is MeasureResource.IfcPositiveLengthMeasure) 
					return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)(MeasureResource.IfcPositiveLengthMeasure)CurveWidth);
				if (CurveWidth is MeasureResource.IfcNormalisedRatioMeasure) 
					return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)(MeasureResource.IfcNormalisedRatioMeasure)CurveWidth);
				if (CurveWidth is MeasureResource.IfcPositiveRatioMeasure) 
					return new Ifc4.MeasureResource.IfcPositiveRatioMeasure((double)(MeasureResource.IfcPositiveRatioMeasure)CurveWidth);
				return null;
			} 
			set
			{
				
			}
		}
		IIfcColour IIfcCurveStyle.CurveColour 
		{ 
			get
			{
				if (CurveColour == null) return null;
				var ifccolourspecification = CurveColour as PresentationResource.IfcColourSpecification;
				if (ifccolourspecification != null) 
					return ifccolourspecification;
				var ifcpredefinedcolour = CurveColour as PresentationResource.IfcPreDefinedColour;
				if (ifcpredefinedcolour != null) 
					return ifcpredefinedcolour;
				return null;
			} 
			set
			{
				
			}
		}
		Ifc4.MeasureResource.IfcBoolean? IIfcCurveStyle.ModelOrDraughting 
		{ 
			get
			{
				//## Handle return of ModelOrDraughting for which no match was found
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